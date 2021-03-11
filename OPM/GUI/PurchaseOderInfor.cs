using OPM.EmailHandler;
using OPM.OPMEnginee;
using OPM.WordHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace OPM.GUI
{
    public partial class PurchaseOderInfor : Form
    {
        public delegate void UpdateCatalogDelegate(string value);
        public UpdateCatalogDelegate UpdateCatalogPanel;

        public PurchaseOderInfor()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*Check PO in DB*/
            int ret = 0;
            /*Save The Edited Contract Info */
            PO newPO = new PO();
            newPO.IDContract = txbIDContract.Text ;
            newPO.IDPO = txbPOCode.Text;
            newPO.PONumber = txbPOName.Text;
            newPO.DateCreatedPO = TimePickerDateCreatedPO.Value.ToString("yyyy-MM-dd");
            newPO.DurationConfirmPO = TimePickerDateConfirmPO.Value.ToString("yyyy-MM-dd");
            newPO.DefaultActiveDatePO = TimepickerDefaultActive.Value.ToString("yyyy-MM-dd");
            newPO.DeadLinePO = TimePickerDeadLinePO.Value.ToString("yyyy-MM-dd");
            newPO.TotalValuePO = float.Parse(txbValuePO.Text);


            ret = newPO.GetDetailPO(txbPOCode.Text);
            if (0 == ret)
            {
                /*Create Folder Contract on F Disk*/
                string strContractDirectory = txbIDContract.Text.Replace('/', '_');
                strContractDirectory = strContractDirectory.Replace('-', '_');

                string strPODirectory = "F:\\OPM\\" + strContractDirectory + "\\" + txbPOName.Text;

                if (!Directory.Exists(strPODirectory))
                {

                    Directory.CreateDirectory(strPODirectory);
                    MessageBox.Show("Folder have been created!!!");
                }

                else
                {
                    MessageBox.Show("Folder already exist!!!");

                }
                ret = newPO.InsertNewPO(newPO);
                if (0 == ret)
                {
                    MessageBox.Show(ConstantVar.CreateNewPOFail);
                }
                else
                {
                    //UpdateCatalogPanel(txbIDContract.Text, txbPOName.Text);
                }

                /*Create Bao Lanh Thuc Hien Hop Dong*/
                //string filename = @"F:\LP\MSTT_Template.docx";
                //string strBLHPName = strContractDirectory + "\\Bao_Lanh_Hop_Dong.docx";

                //OpmWordHandler.CreateBLTH_Contract(filename, strBLHPName, tbContract.Text, tbBidName.Text, tbxDateSigned.Text, tbxSiteB.Text, txbGaranteeValue.Text, txbGaranteeActiveDate.Text);

                /*Send Email To DF*/
                //OPMEmailHandler.fSendEmail("Mail From DoanTD Gmail", strBLHPName);

                //UpdateCatalogPanel(txbPOCode.Text);
            }
        }

        public void SetTxbIDContract(string strIDContract)
        {
            this.txbIDContract.Text = strIDContract;
        }
    }
}
