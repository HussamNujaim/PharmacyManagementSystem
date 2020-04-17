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
    public partial class frmDeposition : DevExpress.XtraEditors.XtraForm
    {
        Presentation.CLS_Accounts acc = new Presentation.CLS_Accounts();
        Presentation.CLS_Bounds bound = new Presentation.CLS_Bounds();
        Presentation.CLS_Cashbook cash = new Presentation.CLS_Cashbook();

        string UserName;
        List<CurrencyInfo> currencies = new List<CurrencyInfo>();
        public frmDeposition()
        {
            InitializeComponent();
        }

        private void frmDeposition_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storesDataSet.Get_Cashbooks' table. You can move, or remove it, as needed.
            this.get_CashbooksTableAdapter.Fill(this.storesDataSet.Get_Cashbooks);
            // TODO: This line of code loads data into the 'storesDataSet.Get_PrimaryAccounts' table. You can move, or remove it, as needed.
            this.get_PrimaryAccountsTableAdapter.Fill(this.storesDataSet.Get_PrimaryAccounts);
            string id = bound.Get_Max_BoundId("سند قبض");
            int boundId = 1;
            if (id != null)
            {
                if (id != "")
                {
                    boundId = (int.Parse(id) + 1);
                }
            }
            txtId.Text = boundId.ToString();
            try
            {
                currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Yemen));
                currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.USD));
                currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.SaudiArabia));
                cboCurrency.DataSource = currencies;
            }
            catch { }


        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lookUpEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPalance_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dtp_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbCurrency_Properties_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmbSecondaryAcc.Properties.DataSource = acc.Get_SecondaryAccounts(cmbPrimaryAcc.EditValue.ToString());
                cmbSecondaryAcc.Properties.DisplayMember = "اسم الحساب";
                cmbSecondaryAcc.Properties.ValueMember = "رقم الحساب";
                cmbSecondaryAcc.EditValue = null;
            }
            catch { }
        }

        private void txtArabicPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ToWord toWord = new ToWord(Convert.ToDecimal(txtArabicPrice.Text), currencies[Convert.ToInt32(cboCurrency.SelectedValue)]);

                txtArabic.Text = toWord.ConvertToArabic();
            }
            catch
            {

            }
        }

        private void cmbCashbook_EditValueChanged(object sender, EventArgs e)
        {
           // cboCurrency.SelectedIndex = cmbCashbook.SelectedIndex;
            try
            {
                ToWord toWord = new ToWord(Convert.ToDecimal(txtPalance.Text), currencies[Convert.ToInt32(cboCurrency.SelectedValue)]);

                txtArabicWord.Text = toWord.ConvertToArabic();
            }
            catch
            {

            }
        }
    }
}