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
        private string _nameContract;
        private string _codeAccounting;
        private string _dateSigned;
        private string _paymentMethod;
        private string _typeContract;
        private string _durationContract;
        private string _valueContract;
        private string _activeDateContract;
        private string _durationGuranteePO;
        private string _phuluc;
        private string _vbGuranteeDoc;
        private string _siteA;
        private string _siteB;
        public ContractObj()
        {
            _phuluc = String.Empty;
            _vbGuranteeDoc = String.Empty;
        }
        ~ContractObj()
        {

        }
        public string IdContract
        {
            set { _idContract = value; }
            get { return _idContract; }
        }
        public string NameContract
        {
            set { _nameContract = value; }
            get { return _nameContract; }
        }
        public string ValueContract
        {
            set { _valueContract = value; }
            get { return _valueContract; }
        }
        public string CodeAccounting
        {
            set { _codeAccounting = value; }
            get { return _codeAccounting; }
        }

        public string ActiveDateContract
        {
            set { _activeDateContract = value; }
            get { return _activeDateContract; }
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

        public string Phuluc
        {
            set { _phuluc = value; }
            get { return _phuluc; }
        }

        public string SiteA
        {
            set { _siteA = value; }
            get { return _siteA; }
        }

        public string SiteB
        {
            set { _siteB = value; }
            get { return _siteB; }
        }

        public List<IContract> GetAllContract()
        {
            throw new NotImplementedException();
        }

        public int GetDetailContract(string strIdContract)
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
                return 0;
            }
            return 1;
        }

        public int InsertNewContract(ContractObj newContract)
        {
            string strInsertContractNew = "insert into Contract values (";
            strInsertContractNew += "'";
            strInsertContractNew += newContract.IdContract;
            strInsertContractNew += "','";
            strInsertContractNew += newContract.NameContract;
            strInsertContractNew += "','";
            strInsertContractNew += newContract.CodeAccounting;
            strInsertContractNew += "','";
            strInsertContractNew += newContract.DateSigned;
            strInsertContractNew += "','";
            strInsertContractNew += newContract.TypeContract;
            strInsertContractNew += "','";
            strInsertContractNew += newContract.DurationContract;
            strInsertContractNew += "','";
            strInsertContractNew += newContract.ActiveDateContract;
            strInsertContractNew += "','";
            strInsertContractNew += newContract.ValueContract;
            strInsertContractNew += "','";
            strInsertContractNew += newContract.DurationGuranteePO;
            strInsertContractNew += "','";
            strInsertContractNew += newContract.SiteA;
            strInsertContractNew += "','";
            strInsertContractNew += newContract.SiteB;
            strInsertContractNew += "','";
            strInsertContractNew += newContract.Phuluc;
            strInsertContractNew += "','";
            strInsertContractNew += newContract.VbGuranteeDoc;
            strInsertContractNew += "')";
            int ret = OPMDBHandler.fInsertData(strInsertContractNew);
            if(0==ret)
            {
                return ret;
            }
            return 1;

        }

        public int UpdateExistedContract(ContractObj newContract)
        {
            return 1;
        }
        public int InsertNewContract(IContract contract)
        {
            throw new NotImplementedException();
        }

    }
}
