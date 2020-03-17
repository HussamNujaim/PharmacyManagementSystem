using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ERP
{
    public partial class frmCurrency : DevExpress.XtraEditors.XtraForm
    {
        DataLayer.DataLayer DL=new DataLayer.DataLayer();
        Presentation.CLS_Currencies currency=new Presentation.CLS_Currencies();

        public frmCurrency()
        {
            InitializeComponent();
        }

        private void chkbxAdd_Click(object sender, EventArgs e)
        {
            try
            {
                chkbxAdd.Checked = true;
                btnAdd.Enabled = true;
                chkbtnEdit.Checked = false;
                btnEdit.Enabled = false;
            }
            catch { }
        }

        private void chkbtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                chkbxAdd.Checked = false;
                btnAdd.Enabled = false;
                chkbtnEdit.Checked = true;
                btnEdit.Enabled = true;
            }
            catch { }
        }

        private void chkbxAdd_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbxAdd.Checked)
            {
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                lPresentationEdit.Visible = false;
            }
        }

        private void chkbtnEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbtnEdit.Checked)
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = true;
                lPresentationEdit.Visible = true;
            }
        }

        private void frmCurrency_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storesDataSet.Get_Currencies' table. You can move, or remove it, as needed.
            this.get_CurrenciesTableAdapter.Fill(this.storesDataSet.Get_Currencies);
          //  dgv.DataSource = currency.Get_Currencies();
        }

        private void chkbxIsMain_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbxIsMain.Checked)
            {
                lPresentationExchangeRate.Enabled = false;
                txtExchangeRate.Enabled = false;
            }
            else
            {
                lPresentationExchangeRate.Enabled = true;
                txtExchangeRate.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool succeeded = false;
            if (txtName.Text != "" && txtSymbol.Text != "")
            {
                if (chkbxIsMain.Checked)
                {

                    currency.AddCurrency(txtName.Text, 1, 1);
                    succeeded = true;
                }
                else
                {
                    if (txtExchangeRate.Text != "")
                    {
                        currency.AddCurrency(txtName.Text, 0, decimal.Parse(txtExchangeRate.Text));
                        succeeded = true;
                    }
                    else
                    {
                        DL.ShowMessageBox("قم بتعبئة جميع الحقول المطلوبة");
                    }
                }
            }
            else 
            {
                DL.ShowMessageBox("قم بتعبئة جميع الحقول المطلوبة");
            }
            if(succeeded)
            {
                this.get_CurrenciesTableAdapter.Fill(this.storesDataSet.Get_Currencies);
                //dgv.RefreshDataSource();
                txtExchangeRate.Text = "";
                txtName.Text = "";
                txtSymbol.Text = "";
                chkbxIsMain.Checked = false;
                txtName.Focus();
            }
        }
    }
}