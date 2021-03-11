using OPM.DBHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace OPM.OPMEnginee
{
    class PO : IPO
    {
        private string _idPO;
        private string _idContract;
        private string _numberPO;
        private string _dateCreatedPO;
        private float _numbefOfDevice;
        private string _durationConfirmPO;
        private string _defaultActiveDatePO;
        private string _deadlinePO;
        private float _totalValuePO;

        public string IDPO
        {
            set { _idPO = value; }
            get { return _idPO; }
        }
        public string IDContract
        {
            set { _idContract = value; }
            get { return _idContract; }
        }
        public string PONumber
        {
            set { _numberPO = value; }
            get { return _numberPO; }
        }
        public float NumberOfDevice
        {
            set { _numbefOfDevice = value; }
            get { return _numbefOfDevice; }
        }
        public string DateCreatedPO
        {
            set { _dateCreatedPO = value; }
            get { return _dateCreatedPO; }
        }
        public string DurationConfirmPO
        {
            set { _durationConfirmPO = value; }
            get { return _durationConfirmPO; }
        }
        public string DefaultActiveDatePO
        {
            set { _defaultActiveDatePO = value; }
            get { return _defaultActiveDatePO; }
        }

        public string DeadLinePO
        {
            set { _deadlinePO = value; }
            get { return _deadlinePO; }
        }

        public float TotalValuePO
        {
            set { _totalValuePO = value; }
            get { return _totalValuePO; }
        }

        public int GetAllPOs(ref List<IPO> lstPOs)
        {
            throw new NotImplementedException();
        }

        public int GetDetailPO(string strQueryOne)
        {
            string strQuery = "select * from PO where id=" + "/'" + strQueryOne + "/'";
            PO newPO = new PO();
            DataSet ds = new DataSet();
            int ret = OPMDBHandler.fQuerryData(strQuery, ref ds);
            if (0 != ds.Tables.Count)
            {
                newPO.IDPO = (string)ds.Tables[0].Rows[0].ItemArray[0];
            }
            else
            {
                return 0;
            }
            return 1;
        }

        public int InsertListPO(IPO po, string strInsertQuery)
        {
            throw new NotImplementedException();
        }

        public int InsertNewPO(PO po)
        {
            string strInsertPONew = "insert into PO values (";
            strInsertPONew += "'";
            strInsertPONew += po.IDPO;
            strInsertPONew += "','";
            strInsertPONew += po.IDContract;
            strInsertPONew += "','";
            strInsertPONew += po.PONumber;
            strInsertPONew += "','";
            strInsertPONew += po.NumberOfDevice.ToString();
            strInsertPONew += "','";
            strInsertPONew += po.DateCreatedPO;
            strInsertPONew += "','";

            strInsertPONew += "','";

            strInsertPONew += po.DurationConfirmPO;
            strInsertPONew += "','";
            strInsertPONew += po.DefaultActiveDatePO;
            strInsertPONew += "','";
            strInsertPONew += po.DeadLinePO;
            strInsertPONew += "','";

            strInsertPONew += "','";

            strInsertPONew += "','";

            strInsertPONew += "','";

            strInsertPONew += po.TotalValuePO;
            strInsertPONew += "')";
            int ret = OPMDBHandler.fInsertData(strInsertPONew);
            if (0 == ret)
            {
                return ret;
            }
            return 1;
        }
    }
}
