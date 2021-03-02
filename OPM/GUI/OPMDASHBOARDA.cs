using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OPM.GUI
{
    public partial class OPMDASHBOARDA : Form
    {
        
        private TreeNode selectedNode;

        public OPMDASHBOARDA()
        {
            InitializeComponent();
            /*Load The TreeView Content*/
            treeView1.Nodes[0].Nodes[0].Nodes.Add("DoanTD");
            /*Load The TreeView Content*/
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
            /*OK Important for Comunicate*/
            ContractInfoChildForm contractInfoChildForm = new ContractInfoChildForm();
            contractInfoChildForm.UpdateCatalogPanel = new ContractInfoChildForm.UpdateCatalogDelegate(GetCatalogvalue);
            OpenChidForm(contractInfoChildForm);
        }

        private void contextMenuStrip_Click(object sender, EventArgs e)
        {
            OpenChidForm(new ContractInfoChildForm());
        }

        private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "toolStripMenuRefresh")
            {
                OpenChidForm(new ContractInfoChildForm());
            }
            else if(e.ClickedItem.Name == "toolStripMenuNew")
            {
                //Do Something
                OpenChidForm(new NewItem());
            }
            else if (e.ClickedItem.Name == "toolStripMenuEdit")
            {
                //Do Something
                //treeView1.Nodes[1].Nodes.Add("DoanTD");
                //treeView1.Nodes[0].Nodes.Add("DoanTD");
                //treeView1.Nodes[0].Nodes[0].Nodes.Add("DoanTD");
                TreeNode a = treeView1.Nodes[0];
                List<string> MyList4 = new List<string>();
                MyList4.Add("Free");
                MyList4.Add("Education");

                AddChildTreeNode(ref a, MyList4);

            }
            else
            {
                //Do Something
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
                if(selectedNode.Name.Contains("Year"))
                {
                    return;

                }else if(selectedNode.Name.Contains("PO_Year"))
                {
                    return;
                }
                else if (selectedNode.Name.Contains("NTKT"))
                {
                    return;
                }
                else if (selectedNode.Name.Contains("DP_PO_Year"))
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
            treeView1.Nodes[0].Nodes.Add(strvalue);
            return;
        }

    }
}
