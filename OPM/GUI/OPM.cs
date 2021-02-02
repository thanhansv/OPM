using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPM.EmailHandler;
using OPM.ExcelHandler;
using OPM.WordHandler;
using xExcel=Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.IO;
using OPM.Enginee;
using System.Drawing.Printing;
using Microsoft.Win32;
using System.Windows;
using System.Diagnostics;
using System.Threading;
using RawPrint;
using xWord = Microsoft.Office.Interop.Word;
using System.Reflection;
using OPM.EmailHandler;

namespace OPM
{
    public partial class OPM : Form
    {
        public OPM()
        {
            InitializeComponent();
            OPMEmailHandler oPMEmailHandler = new OPMEmailHandler();
            //See if any printers are installed  
            if (PrinterSettings.InstalledPrinters.Count <= 0)
            {
                MessageBox.Show("Printer not found!");
                return;
            }

            //Get all available printers and add them to the combo box  
            List<string> printersList = new List<string>();
            foreach (String printer in PrinterSettings.InstalledPrinters)
            {
                printersList.Add(printer.ToString());
            }

        }



        private void treeViewA_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeNode selectedNode = treeViewA.GetNodeAt(e.X, e.Y);
                MessageBox.Show("You clicked on node: " + selectedNode.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //OpmWordHandler _wordhandle = new OpmWordHandler();
            //_wordhandle.FileName="DoanTD";
            //_wordhandle.fCreate_BLTU_Contract(@"F:\07. Digital Tranfrom\Tài liệu quy trình\Template\Contract\Bảo Lãnh Tạm Ứng.docx", @"F:\07. Digital Tranfrom\Tài liệu quy trình\OPM_Doc\Contract\Bảo Lãnh Tạm Ứng.docx", "PO1", "SSDCDCMS-050121-1113-19", "29/10/1989", "22/01/1989");
            //OpmExcelHandler _excelhandler = new OpmExcelHandler();
            //_excelhandler.FileName = "";
            //LogHelper.Writelog("AAAAAAAAAAAAAAAAAAAAAAAAAAAA");

            //string Filepath = @"E:\Cetificate\AAA.pdf";
            //string Filename = "AAA.pdf";
            //string PrinterName = "PCL6 V4 Driver for Universal Print";
            //IPrinter printer = new Printer();
            //printer.PrintRawFile(PrinterName, Filepath, Filename);

            /*OK for Printer*/
            //OpmWordHandler _opmWordHandler = new OpmWordHandler();
            //_opmWordHandler.fPrintDocument(@"E:\Cetificate\AAA.doc");

            OPMEmailHandler.fSendEmail("AAAAA");



        }
    }
}

