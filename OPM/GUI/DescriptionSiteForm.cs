using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OPM.DBHandler;
using OPM.OPMEnginee;
namespace OPM.GUI
{
    public partial class DescriptionSiteForm : Form
    {
        public delegate void UpdateCatalogDelegate(string value);
        public UpdateCatalogDelegate UpdateCatalogPanel;

        public delegate void RequestDashBoardOpenDescriptionForm(string siteId);
        public RequestDashBoardOpenDescriptionForm requestDashBoardOpendescriptionForm;

        //Truyền giá trị của Id_Site về Form Contract
        public delegate void SetIdSite(string idSite);
        public SetIdSite setIdSite;


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
            //Cập nhật hoặc thêm mới Site_Info
            int ret = InsertOrUpdate(txbID.Text.Trim());
            if (ret == 0) MessageBox.Show("update ko thành công");
            else
            {
                state(true);
                setIdSite(txbID.Text.Trim());
            }
        }
        //Kiểm tra sự tồn tại của siteInfo.Id
        bool Exist(string id)
        {
            try
            {
                string query = string.Format("SELECT * FROM dbo.Site_Info WHERE id = '{0}'", id);
                DataTable table = DataProvider.ExecuteQuery(query);
                return table.Rows.Count > 0;
            }
            catch
            {

            }
            return false;
        }
        //Cập nhật hoặc thêm mới Site_Info
        int InsertOrUpdate(string id)
        {
            int ret = 0;
            if (id == null)
                MessageBox.Show("Id chưa khởi tạo!");
            else
            {
                if (Exist(id))
                {
                    string query = string.Format("UPDATE dbo.Site_Info SET headquater_info = '{1}', address= N'{2}', phonenumber = N'{3}', tin= '{4}', account = '{5}',representative = N'{6}' WHERE id = '{0}'", txbID.Text, txbhead.Text, txbAddress.Text, txbPhone.Text, txbFax.Text, txbAccount.Text, txbRepresen.Text);
                    try
                    {
                        ret = DataProvider.ExecuteNonQuery(query);
                        MessageBox.Show(string.Format("Cập nhật thành công Site_Info {0} !", id));
                    }
                    catch
                    {
                        ret = 0;
                    }
                }
                else
                {
                    string query = string.Format(@"INSERT INTO dbo.Site_Info(id, headquater_info, address, phonenumber, tin, account, representative) VALUES(N'{0}','{1}',N'{2}',N'{3}','{4}','{5}',N'{6}')", id, txbhead.Text, txbAddress.Text, txbPhone.Text, txbFax.Text, txbAccount.Text, txbRepresen.Text);
                    try
                    {
                        ret = DataProvider.ExecuteNonQuery(query);
                        MessageBox.Show(string.Format("Tạo mới thành công Site_Info {0} !", id));
                    }
                    catch
                    {
                        ret = 0;
                    }
                }
            }
            return ret;
        }
    }
}
