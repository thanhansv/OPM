﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OPM.OPMEnginee
{
    interface ICases
    {
        public int InsertListCases(ICases cases, string strInsertQuery);
        public int GetDetailCases(ref ICases cases, string strQueryOne);
        public int GetAllContract(ref List<ICases> lstCase);
    }
}
