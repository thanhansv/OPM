using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OPM.GUI
{
    public delegate void AddControlFlowHandler();
    public partial class OPM2 : Form
    {
        public OPM2()
        {
            InitializeComponent();
        } 

        private void OPM2_Load(object sender, EventArgs e)
        {
            GUI.UsrCtltabHeader usrCtltabHeader = new GUI.UsrCtltabHeader();
            this.flowLayoutPanelHeader.Controls.Add(usrCtltabHeader);
            usrCtltabHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));

            GUI.UsrPanelCatalog usrPanelCatalog = new UsrPanelCatalog();
            this.flowLayoutPanelCatalog.Controls.Add(usrPanelCatalog);
            usrPanelCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            usrPanelCatalog.DisplayControlFlow += UsrPanelCatalog_DisplayControlFlow;

            GUI.Contract_Info contract_Info = new Contract_Info();
            this.flowLayoutPanelContent.Controls.Add(contract_Info);

            contract_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
        }

        private void UsrPanelCatalog_DisplayControlFlow()
        {
            GUI.Contract_Info contract_Info = new Contract_Info();
            this.flowLayoutPanelContent.Controls.Clear();
            this.flowLayoutPanelContent.Controls.Add(contract_Info);
            contract_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));

        }

        public void FlowAddControl(object sender)
        {
            //this.flowLayoutPanelHeader.Controls.Add(sender);
        }
    }
}
