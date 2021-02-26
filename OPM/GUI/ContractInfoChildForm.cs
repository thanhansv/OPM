using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using OPM.OPMEnginee;

namespace OPM.GUI
{
    public partial class ContractInfoChildForm : Form
    {
        public ContractInfoChildForm()
        {
            InitializeComponent();
            
        }
        private IContract contract = new ContractObj();
        private void button1_Click(object sender, EventArgs e)
        {
            contract = contract.GetDetailContract(txbIDContract.Text);
        }
    }
}
