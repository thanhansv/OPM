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
using System.IO;

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
            OpenPurchaseOrderInforGUI("Contract_"+tbContract.Text.ToString());
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
            newContract.DateSigned = dateTimePickerDateSignedPO.Value.ToString("yyyy-MM-dd");
            newContract.TypeContract = txbTypeContract.Text;
            newContract.DurationContract = tbxDurationContract.Text;
            newContract.ActiveDateContract = dateTimePickerActiveDateContract.Value.ToString("yyyy-MM-dd");
            newContract.ValueContract = tbxValueContract.Text;
            newContract.DurationGuranteePO = tbxDurationPO.Text;
            newContract.SiteA = tbxSiteA.Text;
            newContract.SiteB = tbxSiteB.Text;
            
            ret = newContract.GetDetailContract(tbContract.Text);
            if(0==ret)
            {
                /*Create Folder Contract on F Disk*/
                string strContractDirectory = "F:\\OPM\\" + tbContract.Text;
                strContractDirectory = strContractDirectory.Replace('/','_');
                strContractDirectory = strContractDirectory.Replace('-', '_');
                if (!Directory.Exists(strContractDirectory))
                {

                    Directory.CreateDirectory(strContractDirectory);
                    MessageBox.Show("Folder have been created!!!");
                }

                else
                {
                    MessageBox.Show("Folder already exist!!!");

                }
                ret = newContract.InsertNewContract(newContract);
                if (0 == ret)
                {
                    MessageBox.Show(ConstantVar.CreateNewContractFail);
                }
                else
                {
                    UpdateCatalogPanel(tbContract.Text);
                    /*Create Bao Lanh Thuc Hien Hop Dong*/
                    this.Cursor = Cursors.WaitCursor;

                    string filename = @"F:\LP\MSTT_Template.docx";
                    string strBLHPName = strContractDirectory + "\\Bao_Lanh_Hop_Dong.docx";

                    OpmWordHandler.CreateBLTH_Contract(filename, strBLHPName, tbContract.Text, tbBidName.Text, tbxDateSigned.Text, tbxSiteB.Text, txbGaranteeValue.Text, txbGaranteeActiveDate.Text);
                    this.Cursor = Cursors.Default;
                    /*Send Email To DF*/
                    OPMEmailHandler.fSendEmail("Mail From DoanTD Gmail", strBLHPName);
                }
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
