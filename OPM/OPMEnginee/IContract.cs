﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OPM.OPMEnginee
{
    interface IContract
    {
        //public List<ContractMdl> GetAllContract();
        public int InsertNewContract(ContractObj contract);
        public int GetDetailContract(string strIdContract);
        public List<IContract> GetAllContract();
        public int UpdateExistedContract(ContractObj newContract);

    }
}
