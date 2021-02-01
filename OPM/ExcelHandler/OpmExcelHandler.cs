using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using WordOffice = Microsoft.Office.Interop.Word;
using ExcelOffice = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Data;

namespace OPM.ExcelHandler
{
    class OpmExcelHandler
    {
        private string _strFileName;

        public string FileName
        {
            set { _strFileName = value; }
            get { return _strFileName; }
        }
        public OpmExcelHandler()
        { }
        ~OpmExcelHandler()
        { }

        public void fReadExcelFile(string fname, object oExcelDataSet)
        {

            ExcelOffice.Application xlApp = new ExcelOffice.Application();
            ExcelOffice.Workbook xlWorkbook = xlApp.Workbooks.Open(fname);
            int numSheets = xlWorkbook.Sheets.Count;
            ExcelOffice._Worksheet xlWorksheet = (ExcelOffice._Worksheet)xlWorkbook.Sheets[1];
            ExcelOffice.Range xlRange = xlWorksheet.UsedRange;
            string xName = xlWorksheet.Name.ToString();

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            //cleanup  
            GC.Collect();
            GC.WaitForPendingFinalizers();
            //rule of thumb for releasing com objects:  
            //  never use two dots, all COM objects must be referenced and released individually  
            //  ex: [somthing].[something].[something] is bad  

            //release com objects to fully kill excel process from running in the background  
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release  
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release  
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }
        public int fWriteExcelfile(string strFilename)
        {
            return 0;
        }
    }
}
