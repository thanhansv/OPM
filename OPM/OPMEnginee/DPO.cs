using OPM.DBHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace OPM.OPMEnginee
{
    class DPO
    {
        string idPO;
        string province;
        int times=0;
        int quantity = 0;
        DateTime dateDelivery = DateTime.Now;

        public string IdPO { get => idPO; set => idPO = value; }
        public string Province { get => province; set => province = value; }
        public int Times { get => times; set => times = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public DateTime DateDelivery { get => dateDelivery; set => dateDelivery = value; }

        public DPO() { }
        public DPO(string idPO, string province, int times, int quantity, DateTime dateDelivery)
        {
            IdPO = idPO;
            Province = province;
            Times = times;
            Quantity = quantity;
            DateDelivery = dateDelivery;
        }
        public static void Delete(string idPO, string province, int times)
        {
            string query = string.Format("DELETE FROM dbo.DPO WHERE IdPO = '{0}' AND Province = N'{1}' AND Times = {2}", idPO, province, times);
            OPMDBHandler.ExecuteNonQuery(query);
        }
        public static void Delete(string idPO, int times)
        {
            string query = string.Format("DELETE FROM dbo.DPO WHERE IdPO = '{0}' AND Times = {2}", idPO, times);
            OPMDBHandler.ExecuteNonQuery(query);
        }
        public static void Delete(string idPO)
        {
            string query = string.Format("DELETE FROM dbo.DPO WHERE IdPO = '{0}'", idPO);
            OPMDBHandler.ExecuteNonQuery(query);
        }

        public void Delete()
        {
            string query = string.Format("DELETE FROM dbo.DPO WHERE IdPO = '{0}' AND Province = N'{1}' AND Times = {2}", idPO, province, times);
            OPMDBHandler.ExecuteNonQuery(query);
        }
        public static void ResetQuantityByIdPO(string idPO)
        {
            string query = string.Format("UPDATE dbo.DPO SET quantity = 0 WHERE idPO = '{0}'", idPO);
            OPMDBHandler.ExecuteNonQuery(query);
        }
        public static void ResetQuantityByIdPOAndTimes(string idPO, int times)
        {
            string query = string.Format("UPDATE dbo.DPO SET quantity = 0 WHERE idPO = '{0}' And times = {1}", idPO,times);
            OPMDBHandler.ExecuteNonQuery(query);
        }
        public static List<DPO> GetListByProvince(string province)
        {
            List<DPO> list = new List<DPO>();
            string query = string.Format("SELECT * FROM dbo.DPO Where province = '{0}' Order By IdPO, Times", province);
            DataTable dataTable = OPMDBHandler.ExecuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                DPO dpo = new DPO(item);
                list.Add(dpo);
            }
            return list;
        }
        public static List<DPO> GetListByIdPO(string idPO)
        {
            List<DPO> list = new List<DPO>();
            string query = string.Format("SELECT * FROM dbo.DPO Where IdPO = '{0}' Order By Times, Province", idPO);
            DataTable dataTable = OPMDBHandler.ExecuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                DPO dpo = new DPO(item);
                list.Add(dpo);
            }
            return list;
        }
        public static List<DPO> GetListByIdPOAndTimes(string idPO, int times)
        {
            List<DPO> list = new List<DPO>();
            string query = string.Format("SELECT * FROM dbo.DPO Where IdPO = '{0}' AND Times = {1} Order By Province", idPO,times);
            DataTable dataTable = OPMDBHandler.ExecuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                DPO dpo = new DPO(item);
                list.Add(dpo);
            }
            return list;
        }
        public static void InsertOrUpdateList(List<DPO> dPOs)
        {
            foreach (DPO dPO in dPOs)
            {
                if (dPO.Exist()) dPO.Update();
                else dPO.Insert();
            }
        }
        public static void InsertOrUpdateTable(DataTable table)
        {
            foreach (DataRow item in table.Rows)
            {
                DPO dPO = new DPO(item);
                if (dPO.Exist()) dPO.Update();
                else dPO.Insert();
            }
        }
        public void Update()
        {
            string query = string.Format("SET DATEFORMAT DMY UPDATE dbo.DPO SET quantity = {3}, dateDelivery = '{4}' WHERE idPO = '{0}' AND province = N'{1}' AND times = {2})", idPO, province, times, quantity, dateDelivery.ToString("d", CultureInfo.CreateSpecificCulture("en-NZ")));
            OPMDBHandler.ExecuteNonQuery(query);
        }
        public void Insert()
        {
            string query = string.Format(@"SET DATEFORMAT DMY INSERT INTO dbo.DPO(idPO,province,times,quantity,dateDelivery) VALUES('{0}',N'{1}',{2},{3},'{4}')", idPO, province, times, quantity, dateDelivery.ToString("d", CultureInfo.CreateSpecificCulture("en-NZ")));
            OPMDBHandler.ExecuteNonQuery(query);
        }
        public DPO(DataRow row)
        {
            IdPO = row["IdPO"].ToString();
            Province = row["Province"].ToString();
            Times = (int)row["Times"];
            Quantity = (row["Quantity"] == null || row["Quantity"] == DBNull.Value) ? 0 : (int)row["Quantity"];
            DateDelivery = (row["DateDelivery"] == null || row["DateDelivery"] == DBNull.Value) ? DateTime.Now : (DateTime)row["DateDelivery"];
        }
        public DPO(string idPO, string province, int times)
        {
            IdPO = idPO;
            Province = province;
            Times = times;
            string query = string.Format("SELECT * FROM dbo.Contract WHERE IdPO = '{0}' AND Province = N'{1}' AND Times = {2}", idPO,province,times);
            try
            {
                DataTable table = OPMDBHandler.ExecuteQuery(query);
                if (table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];
                    Quantity = (row["Quantity"] == null || row["Quantity"] == DBNull.Value) ? 0 : (int)row["Quantity"];
                    DateDelivery = (row["DateDelivery"] == null || row["DateDelivery"] == DBNull.Value) ? DateTime.Now : (DateTime)row["DateDelivery"];
                }
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu từ bảng dbo.DPO!");
            }
        }
        public bool Exist()
        {
            string query = string.Format("SELECT * FROM dbo.DPO WHERE IdPO = '{0}' AND Province = N'{1}' AND Times = {2}", idPO, province, times);
            DataTable table = OPMDBHandler.ExecuteQuery(query);
            return table.Rows.Count > 0;
        }
    }
}
