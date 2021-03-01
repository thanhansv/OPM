using OPM.OPMEnginee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OPM.GUI
{
	public partial class Contract_Info : UserControl
	{
        public event AddResponseCatalog AddCatalog;


        public Contract_Info()
		{
			InitializeComponent();
		}

        private void btEdit_Click(object sender, EventArgs e)
        {
            return;
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            return;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            /*Save The Edited Contract Info */
            ContractObj newContract = new ContractObj();
            newContract.IdContract = tbContract.Text;
            newContract.NameContract = tbBidName.Text;
            newContract.CodeAccounting = tbAccountingCode.Text;
            newContract.DateSigned = tbxDateSigned.Text;
            newContract.TypeContract = txbTypeContract.Text;
            newContract.DurationContract = tbxDurationContract.Text;
            newContract.ActiveDateContract = tbActiveDate.Text;
            newContract.ValueContract = tbxValueContract.Text;
            newContract.DurationGuranteePO = tbxDurationPO.Text;
            newContract.SiteA = tbxSiteA.Text;
            newContract.SiteB = tbxSiteB.Text;

            int ret = newContract.InsertNewContract(newContract);
            if(0==ret)
            {
                MessageBox.Show(ConstantVar.CreateNewContractFail);
            }else
            {
                UsrPanelCatalog a = new UsrPanelCatalog();
                a.ChangeNode();
                
            }    
            return;
            

        }

        private void Contract_Info_AddCatalog(string strAddedCatalog)
        {
            throw new NotImplementedException();
        }

        private void btDesSiteB_Click(object sender, EventArgs e)
        {
            /*Display SiteB Info*/
            return;
        }

        private void btDescSiteA_Click(object sender, EventArgs e)
        {
            /*Display SiteA Info*/
            return;
        }
    }
}
