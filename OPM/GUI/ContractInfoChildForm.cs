using System;
using System.Windows.Forms;
using OPM.WordHandler;
using OPM.OPMEnginee;
using OPM.EmailHandler;
using System.IO;

namespace OPM.GUI
{
    

    public partial class ContractInfoChildForm : Form
    {
        /*Delegate For Request Dashboard Update Catalog Admin*/
        public delegate void UpdateCatalogDelegate(string value);
        public UpdateCatalogDelegate UpdateCatalogPanel;
        public UpdateCatalogDelegate OpenPurchaseOrderInforGUI;

        /*Delegate For Request Dashboard Open PO Form*/
        public delegate void RequestDashBoardOpenChildForm(string strIDContract, string strKHMS);
        public RequestDashBoardOpenChildForm RequestDashBoardOpenPOForm;

        /*Delegate For Request Dashboard Open Description Form*/
        public delegate void RequestDashBoardOpenDescriptionForm(string siteId, DescriptionSiteForm.SetIdSite setIdSite);
        public RequestDashBoardOpenDescriptionForm requestDashBoardOpendescriptionForm;

        /*Object Contract for Contract form*/
        private ContractObj newContract = new ContractObj();

        public ContractInfoChildForm()
        {
            InitializeComponent();
        }
        void SetIdSiteA(string value)
        {
            tbxSiteA.Text = value;
        }
        void SetIdSiteB(string value)
        {
            tbxSiteB.Text = value;
        }
        public void State(bool state)
        {
            txbKHMS.ReadOnly = state;
            tbContract.ReadOnly = state;
            tbBidName.ReadOnly = state;
            tbAccountingCode.ReadOnly = state;
            tbxDurationContract.ReadOnly = state;
            txbTypeContract.ReadOnly = state;
            tbxValueContract.ReadOnly = state;
            tbxDurationPO.ReadOnly = state;
            txbGaranteeValue.ReadOnly = state;
            txbGaranteeActiveDate.ReadOnly = state;
            tbxSiteA.ReadOnly = state;
            tbxSiteB.ReadOnly = state;
        }

        public void SetValueItemForm(string idContract)
        {
            //Add New Comment+ Edit From local
            //Add New Comment Level2+ Edit From Local Lan 2+Change Local Lan 2
            ContractObj contract = new ContractObj();
            contract.GetDisplayContract(idContract, ref contract);
            this.txbKHMS.Text = contract.KHMS;
            this.tbContract.Text = contract.IdContract;
            this.tbBidName.Text = contract.NameContract;
            this.tbAccountingCode.Text = contract.CodeAccounting;
            dateTimePickerDateSignedPO.Value= (contract.DateSigned==null)?DateTime.Now:DateTime.ParseExact(contract.DateSigned,"mm-dd-yyyy",null);
            dateTimePickerDurationDateContract.Value = dateTimePickerDateSignedPO.Value.AddDays(Convert.ToInt32(contract.DurationContract));
            this.txbTypeContract.Text = contract.TypeContract;
            this.tbxDurationContract.Text = contract.DurationContract;
            dateTimePickerActiveDateContract.Value = (contract.ActiveDateContract == null) ? DateTime.Now : DateTime.ParseExact(contract.ActiveDateContract, "mm-dd-yyyy", null);
            this.tbxValueContract.Text = contract.ValueContract;
            this.tbxDurationPO.Text = contract.DurationGuranteePO;
            this.tbxSiteA.Text = contract.SiteA;
            this.tbxSiteB.Text = contract.SiteB;
            this.ExpirationDate.Value = (contract.ExperationDate == null) ? DateTime.Now : DateTime.ParseExact(contract.ExperationDate, "mm-dd-yyyy", null);
            State(true);

            return;
        }

        private IContract contract = new ContractObj();
        private void IdSiteA_Click(object sender, EventArgs e)
        {
            requestDashBoardOpendescriptionForm(tbxSiteA.Text.ToString(),SetIdSiteA);
            return;
        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            string strContract = "Contract_" + tbContract.Text.ToString();
            //OpenPurchaseOrderInforGUI(temp);
            /*Request DashBoard Open PO Form*/
            RequestDashBoardOpenPOForm(strContract, txbKHMS.Text);
            return;
        }

        private void btnCreateGarantee_Click(object sender, EventArgs e)
        {
            if (Contract.Exist(tbContract.Text))
            {
                Contract contract = new Contract(tbContract.Text);
                contract.CreatContractGuarantee();
            }
            else MessageBox.Show("Chưa có hợp đồng {0}",tbContract.Text);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Contract contract = new Contract();
            contract.KHMS = txbKHMS.Text;
            contract.Id = tbContract.Text;
            contract.Namecontract = tbBidName.Text;
            contract.Codeaccouting = tbAccountingCode.Text;
            contract.Typecontract = txbTypeContract.Text;
            contract.Valuecontract = double.Parse(tbxValueContract.Text);
            contract.Blvalue = int.Parse(txbGaranteeValue.Text);
            //Vbgurantee = textBoxVbGuarantee.Text,
            contract.Id_siteA = tbxSiteA.Text;
            contract.Id_siteB = tbxSiteB.Text;
            //Phuluc = textBoxPhuLuc.Text,
            contract.Datesigned = dateTimePickerDateSignedPO.Value;
            contract.Activedate = dateTimePickerActiveDateContract.Value;
            contract.ExperationDate = ExpirationDate.Value;
            contract.Durationcontract = int.Parse(tbxDurationContract.Text);
            contract.Durationpo = int.Parse(tbxDurationPO.Text);
            
            contract.InsertOrUpdate();
            //int ret = 0;
            ///*Save The Edited Contract Info */
            ////ContractObj newContract = new ContractObj();
            //newContract.KHMS = txbKHMS.Text;
            //newContract.IdContract = tbContract.Text;
            //newContract.NameContract = tbBidName.Text;
            //newContract.CodeAccounting = tbAccountingCode.Text;
            //newContract.DateSigned = dateTimePickerDateSignedPO.Value.ToString("yyyy-MM-dd");
            //newContract.TypeContract = txbTypeContract.Text;
            //newContract.DurationContract = tbxDurationContract.Text;
            //dateTimePickerDurationDateContract.Value = dateTimePickerDateSignedPO.Value.AddDays(Convert.ToInt32(tbxDurationContract.Text));
            //newContract.ActiveDateContract = dateTimePickerActiveDateContract.Value.ToString("yyyy-MM-dd");
            //newContract.ValueContract = tbxValueContract.Text;
            //newContract.DurationGuranteePO = tbxDurationPO.Text;
            //newContract.SiteA = tbxSiteA.Text;
            //newContract.SiteB = tbxSiteB.Text;
            //newContract.ExperationDate = ExpirationDate.Value.ToString("yyyy-MM-dd");
            //ret = newContract.GetDetailContract(tbContract.Text);
            //if(0==ret)
            //{
            //    /*Create Folder Contract on F Disk*/
            //    string strContractDirectory = "E:\\OPM\\" + tbContract.Text;
            //    strContractDirectory = strContractDirectory.Replace('/','_');
            //    strContractDirectory = strContractDirectory.Replace('-', '_');
            //    if (!Directory.Exists(strContractDirectory))
            //    {

            //        Directory.CreateDirectory(strContractDirectory);
            //        MessageBox.Show("Folder Contract have been created!!!");
            //    }

            //    else
            //    {
            //        MessageBox.Show("Folder already exist!!!");

            //    }
            //    //Tạo mới hợp đồng

            //    //ret = newContract.InsertNewContract(newContract);
            //    if (0 == ret)
            //    {
            //        MessageBox.Show(ConstantVar.CreateNewContractFail);
            //    }
            //    else
            //    {
            //        UpdateCatalogPanel(tbContract.Text);
            //        /*Create Bao Lanh Thuc Hien Hop Dong*/
            //        this.Cursor = Cursors.WaitCursor;
            //        string filename = @"E:\LP\MSTT_Template.docx";
            //        string strBLHPName = strContractDirectory + "\\Bao_Lanh_Hop_Dong.docx";
            //        OpmWordHandler.CreateBLTH_Contract(filename, strBLHPName, tbContract.Text, tbBidName.Text, dateTimePickerDateSignedPO.Value.ToString(), tbxSiteB.Text, txbGaranteeValue.Text, txbGaranteeActiveDate.Text);
            //        /*Send Email To DF*/
            //        OPMEmailHandler.fSendEmail("Mail From DoanTD Gmail", strBLHPName);
            //        this.Cursor = Cursors.Default;
            //    }
            //}
            //else
            //{
            //    ret = newContract.UpdateExistedContract(newContract);

            //    if (0 == ret)
            //    {
            //        MessageBox.Show(ConstantVar.CreateNewContractFail);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Update Success");
            //        State(true);
            //    }
            //}
            UpdateCatalogPanel(tbContract.Text);
            return;
        }

        private static bool isNumber(string val)
        {
            if (val != "")
            {
                return System.Text.RegularExpressions.Regex.IsMatch(val, "[^0-9]");
            }
              else return true;
        }

        private void tbxDurationContract_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (isNumber(tbxDurationContract.Text) != true && (tbxDurationContract.Text) !=null)
            {
                dateTimePickerDurationDateContract.Value= dateTimePickerDateSignedPO.Value.AddDays(Convert.ToInt32(tbxDurationContract.Text));
            } else
            {
                MessageBox.Show("only allow input numbers");
                tbxDurationContract.Text = "";
            }
        }

        private void IdSiteB_Click(object sender, EventArgs e)
        {
            requestDashBoardOpendescriptionForm(tbxSiteB.Text.ToString(),SetIdSiteB);
            return;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (isNumber(txbGaranteeActiveDate.Text) != true)
            {
                ExpirationDate.Value = dateTimePickerActiveDateContract.Value.AddDays(Convert.ToInt32(txbGaranteeActiveDate.Text));
            }
            else
            {
                MessageBox.Show("only allow input numbers");
                txbGaranteeActiveDate.Text = "";
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            State(false);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Contract.Delete(tbContract.Text);
            UpdateCatalogPanel(tbContract.Text);
        }
    }
}
