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
            dateTimePickerActiveDateContract.Enabled = !state;
            dateTimePickerDateSignedPO.Enabled = !state;
        }

        public void SetValueItemForm(string idContract)
        {
            Contract contract = new Contract(idContract);
            txbKHMS.Text = contract.KHMS;
            tbContract.Text = contract.Id;
            tbBidName.Text = contract.Namecontract;
            tbAccountingCode.Text = contract.Codeaccouting;
            dateTimePickerDateSignedPO.Value= contract.Datesigned;
            dateTimePickerDurationDateContract.Value = dateTimePickerDateSignedPO.Value.AddDays(Convert.ToInt32(contract.Durationcontract));
            txbTypeContract.Text = contract.Typecontract;
            tbxDurationContract.Text = contract.Durationcontract.ToString();
            dateTimePickerActiveDateContract.Value = contract.Activedate;
            tbxValueContract.Text = contract.Valuecontract.ToString();
            tbxDurationPO.Text = contract.Durationpo.ToString();
            tbxSiteA.Text = contract.Id_siteA;
            tbxSiteB.Text = contract.Id_siteB;
            ExpirationDate.Value = contract.ExperationDate;
            txbGaranteeActiveDate.Text = (contract.ExperationDate - contract.Activedate).TotalDays.ToString();
            txbGaranteeValue.Text = contract.Blvalue.ToString();
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

        private void ContractInfoChildForm_Load(object sender, EventArgs e)
        {
            this.txbKHMS.Text = "Mua sắm tập trung thiết bị đầu cuối ONT loại (2FE/GE+Wifi singleband) tương thích hệ thống gpon cho nhu cầu năm 2020";
            this.tbContract.Text = "111-2020/CUVT-ANSV/DTRR-KHMS";
            this.tbBidName.Text = "Mua sắm thiết bị đầu cuối ONT loại (2FE/GE+Wifi singleband)";
            this.tbAccountingCode.Text = "12345678";
            dateTimePickerDateSignedPO.Value = DateTime.Now;
            dateTimePickerDurationDateContract.Value = dateTimePickerDateSignedPO.Value;
            this.txbTypeContract.Text = "Theo đơn giá cố định";
            this.tbxDurationContract.Text = "0";
            dateTimePickerActiveDateContract.Value = dateTimePickerDateSignedPO.Value;
            this.tbxValueContract.Text = "0";
            this.tbxDurationPO.Text = "0";
            this.tbxSiteA.Text = "TTCUVT-TPHCM";
            this.tbxSiteB.Text = "ANSV";
            txbGaranteeActiveDate.Text = "0";
            this.ExpirationDate.Value = dateTimePickerActiveDateContract.Value;
            ExpirationDate.Enabled = false;
            dateTimePickerDurationDateContract.Enabled = false;

        }
    }
}
