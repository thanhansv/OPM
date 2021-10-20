﻿using OPM.OPMEnginee;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace OPM.GUI
{
    public partial class OPMDASHBOARDA : Form
    {
        private int tempStatus=0;
        //tempStatus = x = 
        //0: đang ở Form tạo mới hợp đồng
        //1: đang ở Form chỉnh sửa hợp đồng
        //2:
        //3: Đang ở Form tạo mới PO
        //4: Đang ở Form chỉnh sửa PO
        Contract_Thanh contract = new Contract_Thanh();
        PO_Thanh po=new PO_Thanh();
        Goods_Thanh goods=new Goods_Thanh();
        Site_Info info=new Site_Info();
        NTKT_Thanh ntkt = new NTKT_Thanh();
        public Contract_Thanh Contract 
        { 
            get => contract;
            set
            {
                contract = value;
                po.IdContract = value.Id;
            }
        }
        public PO_Thanh PO { get => po; set => po = value; }
        public Goods_Thanh Goods
        {
            get => goods;
            set
            {
                goods = value;
                contract.ContractValue = value.PriceUnit * value.Quantity;
            }
        }
        public Site_Info Info { get => info; set => info = value; }
        public NTKT_Thanh Ntkt { get => ntkt; set => ntkt = value; }
        public int TempStatus { get => tempStatus; set => tempStatus = value; }

        public OPMDASHBOARDA()
        {
            InitializeComponent();
        }
        private void OPMDASHBOARDA_Load(object sender, EventArgs e)
        {
            OpenContractForm();
        }
        public void InitCatalogByNodeName(string nodeName)
        {
            treeViewOPM.Nodes.Clear();
            DataTable table = CatalogAdmin.Table();
            if (!CatalogAdmin.Exist(nodeName))
            {
                DataRow row = table.NewRow();
                row["ctlId"] = nodeName;
                string[] temp = nodeName.Split('_', 2);
                switch (temp[0])
                {
                    case "Contract":
                        row["ctlName"] = temp[1];
                        break;
                    case "PO":
                        row["ctlName"] = po.POName;
                        row["ctlParent"] = "Contract_"+contract.Id;
                        break;
                    case "DP":
                        break;
                    case "NTKT":
                        row["ctlName"] = "NTKT"+ntkt.Number.ToString();
                        row["ctlParent"] = "PO_" + po.Id;
                        break;
                    case "PL":
                        break;
                    default:
                        MessageBox.Show(string.Format("Không tìm thấy đường dẫn đến nút {0} trên TreeView", nodeName));
                        return;
                }
                table.Rows.Add(row);
            }
            InitCatalogAdmin(null, null, table);
            List<string> list = CatalogAdmin.PathToContractNodeFromCurrentNode(nodeName,table);
            list.Reverse();
            treeViewOPM.SelectedNode = treeViewOPM.Nodes[list[0]];
            treeViewOPM.SelectedNode.Expand();
            treeViewOPM.SelectedNode.ForeColor = Color.Blue;
            for (int i = 1; i <= list.Count - 1; i++)
            {
                treeViewOPM.SelectedNode = treeViewOPM.SelectedNode.Nodes[list[i]];
                treeViewOPM.SelectedNode.Expand();
                treeViewOPM.SelectedNode.ForeColor = Color.Blue;
            }
        }
        private void InitCatalogAdmin(TreeNode parentNode, string parent, DataTable table)
        {
            DataRow[] ds = table.Select(string.Format(@"ctlparent is null"), "ctlname");
            if (parent!=null) ds = table.Select(string.Format(@"ctlparent = '{0}'", parent), "ctlname");
            if (ds.Length < 1) return;
            foreach (DataRow dr in ds)
            {
                TreeNode node = new TreeNode
                {
                    Text = dr["ctlname"].ToString(),
                    Name = dr["ctlID"].ToString()
                };
                string strChildID = dr["ctlID"].ToString();
                if (null == parentNode || null == parent)
                {
                    InitCatalogAdmin(node, strChildID, table);
                    treeViewOPM.Nodes.Add(node);
                }
                else
                {
                    InitCatalogAdmin(node, strChildID, table);
                    parentNode.Nodes.Add(node);
                }
            }
        }
        public void SetNameOfSelectNode(string nameOfNode)
        {
            treeViewOPM.SelectedNode.Text = nameOfNode;
        }
        public void SetIdSiteA(string vl)
        {
            contract.IdSiteA = vl;
        }
        public void SetIdSiteB(string vl)
        {
            contract.IdSiteB = vl;
        }
        public void treeViewOPM_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string strNodeID = treeViewOPM.SelectedNode.Name.ToString();
                //if (null != treeViewOPM.SelectedNode.Parent)
                //{
                //    string strParentNodeID = treeViewOPM.SelectedNode.Parent.Name.ToString();
                //}
                string[] temp = strNodeID.Split('_', 2);
                /*Get Detail Infor On Database*/
                switch (temp[0])
                {
                    case "Contract":
                        tempStatus = 1;//Đang ở Form chỉnh sửa hợp đồng
                        contract = new Contract_Thanh(temp[1]);

                        goods = new Goods_Thanh(temp[1]);
                        OpenContractForm();
                        break;
                    case "PO":
                        tempStatus = 4;//Đang ở Form PO có sẵn
                        po = new PO_Thanh(temp[1]);
                        contract = new Contract_Thanh(po.IdContract);
                        goods = new Goods_Thanh(po.IdContract);
                        OpenPOForm();
                        break;
                    case "DP":
                        /*Display DP */
                        DeliverPartInforDetail deliverPartInforDetail = new DeliverPartInforDetail();
                        deliverPartInforDetail.UpdateCatalogPanel = new DeliverPartInforDetail.UpdateCatalogDelegate(InitCatalogByNodeName);
                        OpenChildForm(deliverPartInforDetail);
                        break;
                    case "NTKT":
                        ntkt = new NTKT_Thanh(temp[1]);
                        po = new PO_Thanh(ntkt.Id_po);
                        contract = new Contract_Thanh(po.IdContract);
                        goods = new Goods_Thanh(po.IdContract);
                        OpenNTKTForm();
                        break;
                    case "PL":
                        /*Display PL */
                        PackageListInfor packageListInfor = new PackageListInfor();
                        packageListInfor.UpdateCatalogPanel = new PackageListInfor.UpdateCatalogDelegate(InitCatalogByNodeName);
                        OpenChildForm(packageListInfor);
                        break;
                    default:
                        MessageBox.Show("Invalid grade");
                        break;
                }
            }
            catch (Exception)
            {

            }
        }
        private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "toolStripMenuNewContract")
            {
                tempStatus = 0;//Đang ở Form tạo mới Hợp đồng
                Contract = new Contract_Thanh();
                OpenContractForm();
            }
            else if (e.ClickedItem.Name == "toolStripMenuNew")
            {
                //Do Something
                PurchaseOderInfor purchaseOderInfor = new PurchaseOderInfor();
                OpenChildForm(purchaseOderInfor);
            }
            else if (e.ClickedItem.Name == "toolStripMenuEdit")
            {
                //Do Something
            }
            else
            {
                //Do Something

            }
        }
        public void OpenSiteAForm(string idSite)
        {
            SiteForm siteForm = new SiteForm
            {
                setStringValue = new SiteForm.SetStringValue(SetIdSiteA),
                IdSite = idSite
            };
            OpenChildForm(siteForm);
        }
        public void OpenSiteBForm(string idSite)
        {
            SiteForm siteForm = new SiteForm
            {
                setStringValue = new SiteForm.SetStringValue(SetIdSiteB),
                IdSite = idSite
            };
            OpenChildForm(siteForm);
        }

        public void OpenGoodsForm()
        {
            GoodsForm goodsForm = new GoodsForm();
            Text = string.Format("Hợp đồng số {0}: Bảng hàng hoá", contract.Id);
            OpenChildForm(goodsForm);
        }
        public void OpenContractForm()
        {
            ContractInfoChildForm contractInfoChildForm = new ContractInfoChildForm();
            Text = string.Format("Hợp đồng số {0}", contract.Id);
            InitCatalogByNodeName("Contract_" + contract.Id);
            OpenChildForm(contractInfoChildForm);
        }
        public void OpenPOForm()
        {
            PurchaseOderInfor purchaseOderInfor = new PurchaseOderInfor();
            Text = string.Format("Hợp đồng số {0} - {1}", contract.Id, po.POName);
            if (tempStatus == 3) po = new PO_Thanh();
            po.IdContract = contract.Id;
            InitCatalogByNodeName("PO_" + po.Id);
            OpenChildForm(purchaseOderInfor);
        }
        public void OpenNTKTForm()
        {
            NTKTInfor nTKTInfor = new NTKTInfor();
            Text = string.Format(@"Hợp đồng số {2} - {1} - Đợt NTKT{0}", ntkt.Number, po.POName,contract.Id);
            ntkt.Id_po = po.Id;
            InitCatalogByNodeName("NTKT_" + ntkt.Id);
            OpenChildForm(nTKTInfor);
        }
        public void OpenDpForm(string idPO, string idContract, String PONumber)
        {
            DeliverPartInforDetail deliverPartInforDetail = new DeliverPartInforDetail();
            PO po = new PO();
            //int retPo = PO.GetObjectPO(idPO, ref po);
            ContractObj contractObj = new ContractObj();
            int retContract = ContractObj.GetObjectContract(idContract, ref contractObj);
            deliverPartInforDetail.setIdPO(idPO);
            deliverPartInforDetail.setIdcontract(idContract);
            deliverPartInforDetail.setKHMS(contractObj.KHMS);
            deliverPartInforDetail.setPoname(PONumber);
            OpenChildForm(deliverPartInforDetail);
            return;
        }
        void OpenChildForm(Form childForm)
        {
            ClearPanel();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panContent.Controls.Add(childForm);
            panContent.Tag = childForm;
            childForm.Tag = this;
            childForm.Show();
        }
        public void ClearPanel()
        {
            foreach (Control item in panContent.Controls)
            {
                item.Dispose();
            }
        }
    }
}
