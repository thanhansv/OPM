using OPM.OPMEnginee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OPM.GUI
{
    public partial class UsrPanelCatalog : UserControl
    {
        private string selectednode;

        public event AddControlFlowHandler DisplayControlFlow;

        public UsrPanelCatalog()
        {
            InitializeComponent();
        }

        private void lvCatalog_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                TreeNode selectedNode = tvCatalog.GetNodeAt(e.X, e.Y);
                //MessageBox.Show("You clicked on node: " + selectedNode.Text);
                /*Check Type of Note*/
                /*Display the Context Menu*/
                this.selectednode = selectedNode.Text;
                ctxRightMouse.Show();


            }
        }
        private void tsmRefresh_MouseClick(object sender, EventArgs e)
        {
            if(null != DisplayControlFlow)
            {
                DisplayControlFlow();
            }
            string strTemp = TypeOfSelectedNode(this.selectednode);
            if ("PO" == strTemp)
            {
                MessageBox.Show("Refresh PO");
            }    
            MessageBox.Show("Refresh");
            /*Reload lại Treeview*/
        }
        private void tsmCreateNew_MouseClick(object sender, EventArgs e)
        {
            MessageBox.Show("Create New");
            /*Create New base on the clicked Item*/
        }
        private void tsmDelete_MouseClick(object sender, EventArgs e)
        {
            MessageBox.Show("Delete");
            /*Delete base on the clicked Item*/
        }
        public void tsmEdit_MouseClick(object sender, EventArgs e)
        {
            //TreeNode selectedNode = tvCatalog.GetNodeAt(e., e.Y);
            //MessageBox.Show("You clicked on node: " + selectedNode.Text);
            /*Edit base on the clicked Item*/

            string strTemp = TypeOfSelectedNode(this.selectednode);
            IContract contract = new ContractObj();
            contract = contract.GetDetailContract(strTemp);
            if(null == contract)
            {
                //GUI.OPM2.flowLayoutPanelContent.Controls.Add(Contract_Info);
                //GUI.Contract_Info contract_Info = new GUI.Contract_Info();
                //flowLayoutPanelContent.Controls.Add(contract_Info);
                //ContractInfoChildForm c = new ContractInfoChildForm();
                //OPMDASHBOARDA.OpenChidForm(c);


            }    
            else
            {
                
            }    
            /*Reload lại Treeview*/

        }
        private string TypeOfSelectedNode(string strSelectedNode)
        {
            return "PO";
        }
    }
}
