using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OPM.OPMEnginee;

namespace OPM.GUI
{
    public partial class OPMDASHBOARDA : Form
    {
        
        private TreeNode selectedNode;

        public OPMDASHBOARDA()
        {
            InitializeComponent();
            TreeNode node = null;
            InitCatalogAdmin(node, null);
        }

        private int LoadCatalogAdmin()
        {
            List<CatalogAdmin> lstCatalogAdmins = new List<CatalogAdmin>();
            int ret = CatalogAdmin.GetFamilyNodes(ref lstCatalogAdmins);

            treeView1.Nodes.Clear();

            foreach(CatalogAdmin catalogAdmin in lstCatalogAdmins)
            {
                TreeNode a = treeView1.Nodes.Add(catalogAdmin.CatalogParent);
                
                AddChildTreeNode(ref a, catalogAdmin.GetListChildNode());

            }    
            return 1;
        }

        private int InitCatalogAdmin(TreeNode parentNode, string parent)
        {
            DataSet ds = new DataSet();
            int ret = CatalogAdmin.GetCatalogNodes(ref ds, parent);
            if(0 == ret)
            {
                return 0;
            }

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                TreeNode node = new TreeNode();
                node.Text = dr["ctlname"].ToString();
                node.Name = dr["ctlID"].ToString();
                string strChildID = dr["ctlID"].ToString();
                if(null == parentNode|| null==parent)
                {
                    InitCatalogAdmin(node, strChildID);
                    treeView1.Nodes.Add(node);
                }
                else
                {
                    InitCatalogAdmin(node, strChildID);
                    parentNode.Nodes.Add(node);

                }    
            }
            return 1;
        }
        public  void UpdateTreeView(string strNewNode)
        {
            treeView1.Nodes[0].Nodes[0].Nodes.Add(strNewNode);
        }
        private Form activeForm = null;
        private  void OpenChidForm(Form childForm)
        {
            if (null != activeForm)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panContent.Controls.Add(childForm);
            panContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        public void treeView1_DoubleClick(object sender, EventArgs e)
        {
            /*OK Important for Communication*/

            /*Check What Label Checked and it's parent Checked*/
            MessageBox.Show(treeView1.SelectedNode.Name.ToString());

            string strNodeID = treeView1.SelectedNode.Name.ToString();
            if (null != treeView1.SelectedNode.Parent)
            {
                string strParentNodeID = treeView1.SelectedNode.Parent.Name.ToString();
                MessageBox.Show(treeView1.SelectedNode.Parent.Text);
            }    
            else
            {
                MessageBox.Show("No Parent Node");
            }
            string[] temp = strNodeID.Split('_');
            temp[0] += "_";
            /*Get Detail Infor On Database*/
            switch (temp[0])
            {
                case ConstantVar.ContractType:
                    /*Display Gui Contract*/
                    ContractInfoChildForm contractInfoChildForm = new ContractInfoChildForm();
                    contractInfoChildForm.UpdateCatalogPanel = new ContractInfoChildForm.UpdateCatalogDelegate(GetCatalogvalue);
                    contractInfoChildForm.OpenPurchaseOrderInforGUI = new ContractInfoChildForm.UpdateCatalogDelegate(OpenSequenceChildForm);
                    contractInfoChildForm.SetValueItemForm();
                    OpenChidForm(contractInfoChildForm);
                    break;
                case ConstantVar.POType:
                    /*Display PO */
                    PurchaseOderInfor purchaseOderInfor  = new PurchaseOderInfor();
                    purchaseOderInfor.UpdateCatalogPanel = new PurchaseOderInfor.UpdateCatalogDelegate(GetCatalogvalue);
                    
                    //contractInfoChildForm.SetValueItemForm();
                    OpenChidForm(purchaseOderInfor);
                    break;
                case ConstantVar.DPType:
                    /*Display DP */
                    DeliverPartInforDetail deliverPartInforDetail = new DeliverPartInforDetail();
                    deliverPartInforDetail.UpdateCatalogPanel = new DeliverPartInforDetail.UpdateCatalogDelegate(GetCatalogvalue);
                    OpenChidForm(deliverPartInforDetail);
                    break;
                case ConstantVar.NTKTType:
                    /*Display NTKT */
                    NTKTInfor nTKTInfor = new NTKTInfor();
                    nTKTInfor.UpdateCatalogPanel = new NTKTInfor.UpdateCatalogDelegate(GetCatalogvalue);
                    OpenChidForm(nTKTInfor);
                    break;
                case ConstantVar.PLType:
                    /*Display PL */
                    PackageListInfor packageListInfor = new PackageListInfor();
                    packageListInfor.UpdateCatalogPanel = new PackageListInfor.UpdateCatalogDelegate(GetCatalogvalue);
                    OpenChidForm(packageListInfor);
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
        }

        private void contextMenuStrip_Click(object sender, EventArgs e)
        {
            OpenChidForm(new ContractInfoChildForm());
        }

        private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "toolStripMenuRefresh")
            {

                ContractInfoChildForm contractInfoChildForm = new ContractInfoChildForm();
                contractInfoChildForm.UpdateCatalogPanel = new ContractInfoChildForm.UpdateCatalogDelegate(GetCatalogvalue);
                //contractInfoChildForm.OpenPurchaseOrderInforGUI = new ContractInfoChildForm.UpdateCatalogDelegate(OpenSequenceChildForm);

                OpenChidForm(contractInfoChildForm);
            }
            else if(e.ClickedItem.Name == "toolStripMenuNew")
            {
                //Do Something
                OpenChidForm(new NewItem());
            }
            else if (e.ClickedItem.Name == "toolStripMenuEdit")
            {
                //Do Something
                TreeNode a = treeView1.Nodes[0];
                List<string> MyList4 = new List<string>();
                MyList4.Add("Free");
                MyList4.Add("Education");

                AddChildTreeNode(ref a, MyList4);

            }
            else
            {
                //Do Something
                MessageBox.Show("Wanna Delete this Node?");

            }


        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                selectedNode = treeView1.GetNodeAt(e.X, e.Y);
                //MessageBox.Show("You clicked on node: " + selectedNode.Name.ToString());

            }
            if(e.Button == MouseButtons.Right)
            {
                if(treeView1.SelectedNode.Name.Contains("Year"))
                {
                    return;

                }else if(treeView1.SelectedNode.Name.Contains("PO_Year"))
                {
                    return;
                }
                else if (treeView1.SelectedNode.Name.Contains("NTKT"))
                {
                    return;
                }
                else if (treeView1.SelectedNode.Name.Contains("DP_PO_Year"))
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        private void AddChildTreeNode(ref TreeNode treeParentNode, List<string> treeChildNodes)
        {
            foreach(string childNode in treeChildNodes)
            {

                TreeNode treeChildNode = new System.Windows.Forms.TreeNode(childNode);
                treeParentNode.Nodes.Add(childNode);
            } 
            return;
        }

        private void AfterLabelEdited()
        {
            return;
        }

        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            /*Check What Lalel was Editted*/
            /*Update On DataBase*/
            return;
        }

        private void OPMDASHBOARDA_Load(object sender, EventArgs e)
        {
            GUI.UsrCtltabHeader usrCtltabHeader = new GUI.UsrCtltabHeader();
            this.panHeader.Controls.Add(usrCtltabHeader);
            usrCtltabHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));

        }
        /*OK Important for Comunicate*/
        public void GetCatalogvalue(string strvalue)
        {
            System.Windows.Forms.TreeNode newTreeNode= new TreeNode(strvalue);

            treeView1.Nodes.Add(strvalue);
            return;
        }

        public void UpdateCatalogNodes(TreeNode parentNode, string strNewnode)
        {
            TreeNode newTreeNode = new TreeNode(strNewnode);
            if(!parentNode.Nodes.Contains(newTreeNode))
            {
                parentNode.Nodes.Add(newTreeNode);
            }    
            return;
        }

        public void OpenSequenceChildForm(string strParentInfo)
        {
            if(strParentInfo.Contains(ConstantVar.ContractType))
            {
                PurchaseOderInfor purchaseOderInfor = new PurchaseOderInfor();
                purchaseOderInfor.UpdateCatalogPanel = new PurchaseOderInfor.UpdateCatalogDelegate(GetCatalogvalue);

                //contractInfoChildForm.SetValueItemForm();
                OpenChidForm(purchaseOderInfor);
            }    
        }

    }
}
