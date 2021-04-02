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
    public partial class DescriptionSiteForm : Form
    {
        public delegate void UpdateCatalogDelegate(string value);
        public UpdateCatalogDelegate UpdateCatalogPanel;

        public delegate void RequestDashBoardOpenDescriptionForm(string siteId);
        public RequestDashBoardOpenDescriptionForm requestDashBoardOpendescriptionForm;

       
        private void SetDefaultValues()
        {
            txbID.Clear();
            txbhead.Clear();
            txbAddress.Clear();
            txbPhone.Clear();
            txbFax.Clear();
            txbRepresen.Clear();
            txbAccount.Clear();
        }
        public void setId(string value)
        {
            txbID.Text = value;
            return;
        }
        public void setHeadquater(string value)
        {
            txbhead.Text = value;
            return;
        }
        public void setAddress(string value)
        {
            txbAddress.Text = value;
            return;
        }
        public void setPhone(string value)
        {
            txbPhone.Text = value;
            return;
        }
        public void setFax(string value)
        {
            txbFax.Text = value;
            return;

        }
        public void setAccount(string value)
        {
            txbAccount.Text = value;
            return;

        }
        public void setRepresentative(string value)
        {
            txbRepresen.Text = value;
            return;

        }
        public void state(bool state)
        {
            txbID.ReadOnly = state;
            txbhead.ReadOnly = state;
            txbAddress.ReadOnly = state;
            txbPhone.ReadOnly = state;
            txbFax.ReadOnly = state;
            txbRepresen.ReadOnly = state;
            txbAccount.ReadOnly = state;
        }
        public DescriptionSiteForm()
        {
            InitializeComponent();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionSiteForm_Load(object sender, EventArgs e)
        {
            state(true);
        }

        private void edit_Click(object sender, EventArgs e)
        {
            state(false);
        }

        private void save_Click(object sender, EventArgs e)
        {
            SiteInfo siteInfo = new SiteInfo();
            siteInfo.Id = txbID.Text;
            siteInfo.HeadquaterInfo= txbhead.Text;
            siteInfo.Address = txbAddress.Text;
            siteInfo.Account = txbAccount.Text;
            siteInfo.Phonenumber = txbPhone.Text;
            siteInfo.Tin = txbFax.Text;
            siteInfo.Representative = txbRepresen.Text;
            int ret= siteInfo.UpdateExistedSite(siteInfo);
            if (ret == 0) MessageBox.Show("update ko thành công");
            else
            {
                MessageBox.Show("update thành công");
                state(false);
            }
        }
    }
}
