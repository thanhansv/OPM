﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OPM.OPMEnginee
{
    interface IListNTKT
    {
        public int InsertListNTKT(IListNTKT lstNTKT, string strInsertQuery);
        public int GetDetailListNTKT(ref IListNTKT lstNTKT, string strQueryOne);
        public int GetAllListNTKT(ref List<IListNTKT> lstNTKTs);
    }
}
