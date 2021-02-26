using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using OPM.DBHandler;

namespace OPM.OPMEnginee
{
    class ContractObj :IContract
    {
        private string _idContract;
        private string _dateSigned;
        private string _paymentMethod;
        private string _typeContract;
        private string _durationContract;
        private string _durationGuranteePO;
        private string _phuluc;
        private string _vbGuranteeDoc;
        public ContractObj()
        { 
        }
        ~ContractObj()
        {

        }
        public string IdContract
        {
            set { _idContract = value; }
            get { return _idContract; }
        }
        public string DateSigned
        {
            set { _dateSigned = value; }
            get { return _dateSigned; }
        }
        public string PaymentMethod
        {
            set { _paymentMethod = value; }
            get { return _paymentMethod; }
        }
        public string TypeContract
        {
            set { _typeContract = value; }
            get { return _typeContract; }
        }

        public string DurationContract
        {
            set { _durationContract = value; }
            get { return _durationContract; }
        }

        public string DurationGuranteePO
        {
            set { _durationGuranteePO = value; }
            get { return _durationGuranteePO; }
        }

        public string VbGuranteeDoc
        {
            set { _vbGuranteeDoc = value; }
            get { return _vbGuranteeDoc; }
        }

        public List<IContract> GetAllContract()
        {
            throw new NotImplementedException();
        }

        public IContract GetDetailContract(string strIdContract)
        {
            string strQueryOne = "select * from Contract where id=" + "/'" + strIdContract + "/'";
            ContractObj contract = new ContractObj();
            DataSet ds = new DataSet();
            int ret = OPMDBHandler.fQuerryData(strQueryOne, ref ds);
            if (0 != ds.Tables.Count)
            {
                    contract.IdContract = (string)ds.Tables[0].Rows[0].ItemArray[0];
            }
            else
            {
                return null;
            }
            return contract;
        }

        public int InsertNewContract(IContract contract)
        {
            throw new NotImplementedException();
        }
    }
}
