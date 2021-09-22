using OPM.DBHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace OPM.OPMEnginee
{
    public partial class NTKTRequest
    {
        private string id;
        private string id_po;
        private int numberofdevice;
        private DateTime deliver_date_expected;
        private string email_request_status;
        private DateTime create_date;

        public string Id { get => id; set => id = value; }
        public string Id_po { get => id_po; set => id_po = value; }
        public int Numberofdevice { get => numberofdevice; set => numberofdevice = value; }
        public DateTime Deliver_date_expected { get => deliver_date_expected; set => deliver_date_expected = value; }
        public string Email_request_status { get => email_request_status; set => email_request_status = value; }
        public DateTime Create_date { get => create_date; set => create_date = value; }
        public NTKTRequest(string id, string id_po, int numberofdevice, DateTime deliver_date_expected, string email_request_status, DateTime create_date)
        {
            Id = id;
            Id_po = id_po;
            Numberofdevice = numberofdevice;
            Deliver_date_expected = deliver_date_expected;
            Email_request_status = email_request_status;
            Create_date = create_date;
        }
        public NTKTRequest(DataRow row)
        {
            Id = row["id"].ToString();
            Id_po = row["id_po"].ToString();
            Numberofdevice = (row["numberofdevice"]==null|| row["numberofdevice"]==DBNull.Value)?0:(int)row["numberofdevice"];
            Deliver_date_expected = (row["deliver_date_expected"]==null|| row["deliver_date_expected"]==DBNull.Value)?DateTime.Now:(DateTime)row["deliver_date_expected"];
            Email_request_status = row["email_request_status"].ToString();
            Create_date = (row["create_date"] == null || row["create_date"] == DBNull.Value) ? DateTime.Now : (DateTime)row["create_date"];
        }
        public NTKTRequest(string id)
        {
            string query = string.Format("SELECT * FROM dbo.NTKT WHERE id = '{0}'", id);
            DataTable table = OPMDBHandler.ExecuteQuery(query);
            if(table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                Id = id;
                Id_po = row["id_po"].ToString();
                Numberofdevice = (row["numberofdevice"] == null || row["numberofdevice"] == DBNull.Value) ? 0 : (int)row["numberofdevice"];
                Deliver_date_expected = (row["deliver_date_expected"] == null || row["deliver_date_expected"] == DBNull.Value) ? DateTime.Now : (DateTime)row["deliver_date_expected"];
                Email_request_status = row["email_request_status"].ToString();
                Create_date = (row["create_date"] == null || row["create_date"] == DBNull.Value) ? DateTime.Now : (DateTime)row["create_date"];
            }
        }
        public NTKTRequest() { }
        public bool Exist()
        {
            string query = string.Format("SELECT * FROM dbo.NTKT WHERE id = '{0}'", id);
            DataTable table = OPMDBHandler.ExecuteQuery(query);
            return table.Rows.Count > 0;
        }
        public static bool Exist(string id)
        {
            string query = string.Format("SELECT * FROM dbo.NTKT WHERE id = '{0}'", id);
            DataTable table = OPMDBHandler.ExecuteQuery(query);
            return table.Rows.Count > 0;
        }
        public void InsertOrUpdate()
        {
            if (id == null)
                MessageBox.Show("Id chưa khởi tạo!");
            else
            {
                if (Exist(id))
                {
                    string query = string.Format("SET DATEFORMAT DMY UPDATE dbo.NTKT SET deliver_date_expected = '{1}', create_date = '{2}' Where id = '{0}'",id, deliver_date_expected.ToString("d", CultureInfo.CreateSpecificCulture("en-NZ")), create_date.ToString("d", CultureInfo.CreateSpecificCulture("en-NZ")));
                    OPMDBHandler.ExecuteNonQuery(query);
                    MessageBox.Show(string.Format("Cập nhật thành công Yêu cầu NTKT {0} của PO {1}!", id, id_po));
                }
                else
                {
                    string query = string.Format(@"SET DATEFORMAT DMY INSERT INTO dbo.NTKT(id, id_po, deliver_date_expected,create_date) VALUES('{0}','{1}','{2}','{3}') INSERT INTO dbo.CatalogAdmin (ctlID, ctlname, ctlparent, haveparent) VALUES ('NTKT_{0}', 'YCNTKT{0}', 'PO_{1}', 1)", id, id_po, deliver_date_expected.ToString("d", CultureInfo.CreateSpecificCulture("en-NZ")), create_date.ToString("d", CultureInfo.CreateSpecificCulture("en-NZ")));
                    OPMDBHandler.ExecuteNonQuery(query);
                    MessageBox.Show(string.Format("Tạo mới thành công Yêu cầu NTKT {0} của PO {1}!", id, id_po));
                }
            }
        }
    }
}
