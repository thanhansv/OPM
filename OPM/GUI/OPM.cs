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
using System.Data.SqlClient;

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

            /*OK for Sending Email*/
            //OPMEmailHandler.fSendEmail("AAAAA");

            //String strconnection = @"Data Source=JOHAN-LAPTOP\SQLOPM; Initial Catalog = OpmDB; User ID = sa; Password=Pa$$w0rd";
            //String strconnection = @"Server=10.2.8.96,1433; Database = OpmDB; User ID = sa; Password=Pa$$w0rd";
            //String strconnection = @"Data Source = 127.0.0.1,1433; Initial Catalog = OpmDB; User ID = sa; Password = Pa$$w0rd";
            
            //String OK_1
            String strconnection1 = @"Data Source=DOANTD; Initial Catalog = OpmDB; User ID = sa; Password=Pa$$w0rd";

            String strconnection2 = @"Data Source=MSI\PHANTOM_OPM; Initial Catalog = OpmDB; User ID = sa; Password=Pa$$w0rd";
            SqlConnection con = new SqlConnection(strconnection2);
            con.Open();

            string querry = @"INSERT INTO Site_Info(id, type, headquater_info, address, phonenumber, tin, account, representative) VALUES('TTCUVT-TPDN', '', '125 Hai Ba Trung, TP.HCM', '12/1 Nguyen Thi Minh Khai, TP.HCM', '02835282338', '0300954529', '0071001103921', 'Mr Ho Minh Kiet')";
            using (SqlCommand insertCommand = con.CreateCommand())
            {
                insertCommand.CommandText = querry;
                var row = insertCommand.ExecuteNonQuery();
            }    
            con.Close();
            con.Dispose();
            //con = null;
         } 
    }
}

