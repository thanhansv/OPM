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
        public OPMDASHBOARDA()
        {
            InitializeComponent();
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
            OpenChidForm(new ContractInfoChildForm());
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

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TreeNode selectedNode = treeView1.GetNodeAt(e.X, e.Y);
                MessageBox.Show("You clicked on node: " + selectedNode.Text);
            }
        }
    }
}
