﻿using OPM.DBHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace OPM.OPMEnginee
{
    class SiteInfo : ISiteInfo
    {
        private string _id;
        private string _type;
        private string _headquaterInfo;
        private string _address;
        private string _phonenumber;
        private string _tin;
        private string _account;
        private string _representative;
        private string _landlineSiteA;
        private string _faxSiteA;

        public SiteInfo()
        {
        }

        public SiteInfo(string id, string type, string headquaterInfo, string address, string phonenumber, string tin, string account, string representative, string landlineSiteA, string faxSiteA)
        {
            Id = id;
            Type = type;
            HeadquaterInfo = headquaterInfo;
            Address = address;
            Phonenumber = phonenumber;
            Tin = tin;
            Account = account;
            Representative = representative;
            LandlineSiteA = landlineSiteA;
            FaxSiteA = faxSiteA;
        }

        public string Id { get => _id; set => _id = value; }
        public string Type { get => _type; set => _type = value; }
        public string HeadquaterInfo { get => _headquaterInfo; set => _headquaterInfo = value; }
        public string Address { get => _address; set => _address = value; }
        public string Phonenumber { get => _phonenumber; set => _phonenumber = value; }
        public string Tin { get => _tin; set => _tin = value; }
        public string Account { get => _account; set => _account = value; }
        public string Representative { get => _representative; set => _representative = value; }
        public string LandlineSiteA { get => _landlineSiteA; set => _landlineSiteA = value; }
        public string FaxSiteA { get => _faxSiteA; set => _faxSiteA = value; }

        public int GetSiteInfo(string idSiteInfo, ISiteInfo siteInfo)
        {
            throw new NotImplementedException();
        }


        public int GetSiteInfoObject(string idContract, ref SiteInfo siteInfo)
        {
            string strQueryOne = "SELECT DISTINCT * FROM Contract INNER JOIN Site_Info ON Site_Info.id COLLATE SQL_Latin1_General_CP1_CI_AS = Contract.id_siteB WHERE Contract.id =" + "'" + idContract + "'";
            DataSet ds = new DataSet();
            int ret = OPMDBHandler.fQuerryData(strQueryOne, ref ds);
            if (0 != ds.Tables.Count)
            {
                siteInfo.Id = (string)ds.Tables[0].Rows[0].ItemArray[16];
                siteInfo.Type = (string)ds.Tables[0].Rows[0].ItemArray[16];
                siteInfo.HeadquaterInfo = (string)ds.Tables[0].Rows[0].ItemArray[16];
                siteInfo.Address = (string)ds.Tables[0].Rows[0].ItemArray[17];
                siteInfo.Phonenumber = (string)ds.Tables[0].Rows[0].ItemArray[18];
                siteInfo.Tin = (string)ds.Tables[0].Rows[0].ItemArray[19];
                siteInfo.Account = (string)ds.Tables[0].Rows[0].ItemArray[20];
                siteInfo.Representative = (string)ds.Tables[0].Rows[0].ItemArray[21];
                siteInfo.LandlineSiteA = (string)ds.Tables[0].Rows[0].ItemArray[22];
                siteInfo.FaxSiteA = (string)ds.Tables[0].Rows[0].ItemArray[23];
            }
            else
            {
                return 0;
            }
            return 1;
        }
    }
}
