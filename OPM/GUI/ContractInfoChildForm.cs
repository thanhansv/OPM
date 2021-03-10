using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OPM.WordHandler;

using OPM.OPMEnginee;
using OPM.EmailHandler;

namespace OPM.GUI
{
    

    public partial class ContractInfoChildForm : Form
    {
        public delegate void UpdateCatalogDelegate(string value);
        public UpdateCatalogDelegate UpdateCatalogPanel;
        public UpdateCatalogDelegate OpenPurchaseOrderInforGUI;

        public ContractInfoChildForm()
        {
            InitializeComponent();
            
        }

        public void SetValueItemForm()
        {
            this.tbContract.Text = "AAAAA";
            return;
        }
        private IContract contract = new ContractObj();
        private void button1_Click(object sender, EventArgs e)
        {
            int ret = contract.GetDetailContract(tbContract.Text);
        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            OpenPurchaseOrderInforGUI(tbContract.Text);
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int ret = 0;
            /*Save The Edited Contract Info */
            ContractObj newContract = new ContractObj();
            newContract.IdContract = tbContract.Text;
            newContract.NameContract = tbBidName.Text;
            newContract.CodeAccounting = tbAccountingCode.Text;
            newContract.DateSigned = tbxDateSigned.Text;
            newContract.TypeContract = txbTypeContract.Text;
            newContract.DurationContract = tbxDurationContract.Text;
            newContract.ActiveDateContract = tbActiveDate.Text;
            newContract.ValueContract = tbxValueContract.Text;
            newContract.DurationGuranteePO = tbxDurationPO.Text;
            newContract.SiteA = tbxSiteA.Text;
            newContract.SiteB = tbxSiteB.Text;
            ret = newContract.GetDetailContract(tbContract.Text);
            if(0==ret)
            {
                ret = newContract.InsertNewContract(newContract);
                if (0 == ret)
                {
                    MessageBox.Show(ConstantVar.CreateNewContractFail);
                }
                else
                {
                    UpdateCatalogPanel(tbContract.Text);
                }

                /*Create Bao Lanh Thuc Hien Hop Dong*/
                string filename = @"F:\LP\MSTT_Template.docx";
                string strBLHPName = @"F:\LP\MSTT.docx";
                OpmWordHandler.CreateBLTH_Contract(filename, strBLHPName, tbContract.Text, tbBidName.Text, tbxDateSigned.Text);

                /*Send Email To DF*/
                OPMEmailHandler.fSendEmail("Mail From DoanTD Gmail");
            }
            else
            {
                ret = newContract.UpdateExistedContract(newContract);
                if (0 == ret)
                {
                    MessageBox.Show(ConstantVar.CreateNewContractFail);
                }
            }
            
            return;
        }
    }
}
