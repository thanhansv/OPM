using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using WordOffice = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace OPM.WordHandler
{
    class OpmWordHandler
    {
        private string _nameWordfile;
        public OpmWordHandler()
        {
        }
        ~OpmWordHandler()
        { }

        public string FileName
        {
            set { _nameWordfile = value; }
            get { return _nameWordfile; }
        }
        public static void FindAndReplace(WordOffice.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }
        public static void CreateWordDocument(object filename, object SaveAs, string strName, string strFirstname, string strBirthday, string strDate)
        {
            WordOffice.Application wordApp = new WordOffice.Application();
            object missing = Missing.Value;
            WordOffice.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace
                FindAndReplace(wordApp, "<name>", strName);
                FindAndReplace(wordApp, "<firstname>", strFirstname);
                //this.FindAndReplace(wordApp, "<birthday>", dateTimePicker1.Value.ToShortDateString());
                FindAndReplace(wordApp, "<birthday>", strBirthday);
                //this.FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
                FindAndReplace(wordApp, "<date>", strDate);
            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Created!");
        }

        public static void Create_BLTU_Contract(object filename, object SaveAs, string strPOnumber, string strIdContract, string strSigndate, string strPOdate)
        {
            WordOffice.Application wordApp = new WordOffice.Application();
            object missing = Missing.Value;
            WordOffice.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace
                FindAndReplace(wordApp, "<tempPO>", strPOnumber);
                FindAndReplace(wordApp, "<temp_IdContract>", strIdContract);
                //this.FindAndReplace(wordApp, "<birthday>", dateTimePicker1.Value.ToShortDateString());
                FindAndReplace(wordApp, "<tmp_signdate>", strSigndate);
                //this.FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
                FindAndReplace(wordApp, "<date_po>", strPOdate);
            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Created!");
        }
        public static void Create_BLTH_PO(object filename, object SaveAs,string strPOnumber)
        { }
        public static void Create_BLTU_PO(object filename, object SaveAs,string strPOnumber, string strIdContract, string strContractName, string strSigneddateContract, string strPOSigneddate, string strPOValueNotVAT, string strPOValueTU, string strSiteB, string strActiveDatePO)
        {
            WordOffice.Application wordApp = new WordOffice.Application();
            object missing = Missing.Value;
            WordOffice.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace
                FindAndReplace(wordApp, "<PO_Name>", strPOnumber);
                FindAndReplace(wordApp, "<Contract_ID>", strIdContract);
                FindAndReplace(wordApp, "<Contract_Name>", strContractName);
                FindAndReplace(wordApp, "<Signed_DateContract>", strSigneddateContract);
                FindAndReplace(wordApp, "<Signed_DatePO>", strPOSigneddate);
                FindAndReplace(wordApp, "<Total_Value>", strPOValueNotVAT);
                FindAndReplace(wordApp, "<Value_Tamung>", strPOValueTU);
                FindAndReplace(wordApp, "<Site_B>", strSiteB);
                FindAndReplace(wordApp, "<Active_Date>", strActiveDatePO);
            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Created!");
        }
        public static void Create_DNTU_PO(object filename, object SaveAs)
        { }
        public static void Create_NTKTHH(object filename, object SaveAs)
        { }
        public static void PrintDocument(object filename)
        {
            WordOffice.Application wordApp = new WordOffice.Application();
            object missing = Missing.Value;
            WordOffice.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                myWordDoc.Application.ActivePrinter = "PCL6 V4 Driver for Universal Print";
                myWordDoc.PrintOut();
            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Created!");
        }

        public static void PrintDocumentA(object filename)
        {
            return;
        }

        public static void  CreateBLTH_Contract(object filename, object SaveAs, string strContractCode, string strContractName, string strSigneddate,string tbxSiteB,string txbGaranteeValue,string txbGaranteeActiveDate)
        {
            WordOffice.Application wordApp = new WordOffice.Application();
            object missing = Missing.Value;
            WordOffice.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace
                FindAndReplace(wordApp, "<Contract_Code>", strContractCode);
                FindAndReplace(wordApp, "<Contract_Name>", strContractName);
                FindAndReplace(wordApp, "<Signed_Date>", strSigneddate);
                FindAndReplace(wordApp, "<Site_B>", tbxSiteB);
                FindAndReplace(wordApp, "<Grt_Val>", txbGaranteeValue);
                FindAndReplace(wordApp, "<Grt_Act_Date>", txbGaranteeActiveDate);

            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Bảo Lãnh Thực Hiện Hợp Đồng Đã Được Tạo");
        }


    }
}
