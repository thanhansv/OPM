using System;
using System.Collections.Generic;
using System.Text;

namespace OPM.OPMEnginee
{
    interface IPO
    {
        public int InsertListPO(IPO po, string strInsertQuery);
        public int GetDetailPO(ref IPO po, string strQueryOne);
        public int GetAllPOs(ref List<IPO> lstPOs);
    }
}
