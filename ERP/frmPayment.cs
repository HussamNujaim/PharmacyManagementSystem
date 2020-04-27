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
using System.Data.SqlClient;
using System.Configuration;

namespace ERP
{
    public partial class frmPayment : DevExpress.XtraEditors.XtraForm
    {
        Presentation.CLS_Accounts acc = new Presentation.CLS_Accounts();
        Presentation.CLS_Bounds bound = new Presentation.CLS_Bounds();
        Presentation.CLS_Cashbook cash = new Presentation.CLS_Cashbook();
        DataLayer.DataLayer DAL = new DataLayer.DataLayer();

        string UserName="Admin";
        List<CurrencyInfo> currencies = new List<CurrencyInfo>();
        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storesDataSet.Get_Cashbooks' table. You can move, or remove it, as needed.
            this.get_CashbooksTableAdapter.Fill(this.storesDataSet.Get_Cashbooks);
            // TODO: This line of code loads data into the 'storesDataSet.Get_PrimaryAccounts' table. You can move, or remove it, as needed.
            this.get_PrimaryAccountsTableAdapter.Fill(this.storesDataSet.Get_PrimaryAccounts);
            txtId.Text = GetMaxId();
            try
            {
                currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Yemen));
                currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.USD));
                currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.SaudiArabia));
                cboCurrency.DataSource = currencies;
            }
            catch { }


        }

        private string GetMaxId()
        {
            string id = bound.Get_Max_BoundPaymentId("سند صرف");
            int boundId = 1;
            if (id != null)
            {
                if (id != "")
                {
                    boundId = (int.Parse(id) + 1);
                }
            }
           return boundId.ToString();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lookUpEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbDetails.Text != "" && cmbPrimaryAcc.ItemIndex >= 0 && cmbSecondaryAcc.ItemIndex >= 0 && txtPalance.Text != "")
            {
                //
                DataTable dtCash = cash.Get_Cashbook(int.Parse(cmbCashbook.EditValue.ToString()));
                DataTable dtAcc = acc.Get_SecondaryAccount(cmbSecondaryAcc.EditValue.ToString());
                if (dtCash.Rows[0][4].ToString() != dtAcc.Rows[0][6].ToString())
                {
                    DAL.ShowMessageBox("عذراً .. لايمكن سحب المبلغ من هذا الصندوق, بسبب اختلاف العملة", "Error");
                    return;
                }
                //
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ERP.Properties.Settings.ERP"].ConnectionString;
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    DataLayer.DataLayer DAL = new DataLayer.DataLayer(transaction, con);
                    string boundId = (int.Parse(bound.Get_Max_BoundPaymentId("سند صرف", DAL)) + 1).ToString();
                    bound.Add_BoundPayment(boundId.ToString(), "سند صرف", cmbSecondaryAcc.EditValue.ToString(), decimal.Parse(txtPalance.Text), cmbDetails.Text, dtp.EditValue.ToString(), "", UserName, int.Parse(cmbCashbook.EditValue.ToString()), DAL);
                    //////////////// Account
                    DataTable dt = acc.Get_SecondaryAccount(cmbSecondaryAcc.EditValue.ToString(), DAL);
                    decimal palance = decimal.Parse(dt.Rows[0][4].ToString()) - decimal.Parse(dt.Rows[0][3].ToString());
                    decimal dain = 0;
                    decimal madin = decimal.Parse(txtPalance.Text);
                    palance = palance + madin - dain;
                    //add AccReport
                    acc.Add_AccountsReport(cmbSecondaryAcc.EditValue.ToString(), "سند صرف", int.Parse(boundId), dtp.EditValue.ToString(), cmbDetails.Text, dain, madin, palance, DAL);
                    // Edit Accounts Table
                    acc.Edit_SecondaryAccount(dt.Rows[0][0].ToString(), decimal.Parse(dt.Rows[0][3].ToString()) + dain, decimal.Parse(dt.Rows[0][4].ToString()) + madin, DAL);

                    /////////////// Cashbook
                    DataTable cashbook = cash.Get_Cashbook(int.Parse(cmbCashbook.EditValue.ToString()), DAL); // get cashbook .
                    int cashbookId = int.Parse(cashbook.Rows[0][0].ToString());
                    decimal cashPalance = decimal.Parse(cashbook.Rows[0][3].ToString());
                    cashPalance = cashPalance - decimal.Parse(txtPalance.Text);
                    //
                    cash.Add_CashbookReport(cashbookId, "سند صرف", int.Parse(boundId), dtp.EditValue.ToString(),
                        cmbSecondaryAcc.Text + " : " + cmbDetails.Text, decimal.Parse(txtPalance.Text), 0, DAL);
                    cash.Edit_Cashbook(cashbookId, cashPalance, DAL);
                    //////////////////////////Receiver 
                    //    acc.Add_ReceiversReport("", "سند قبض", int.Parse(txtBoundId.Text), dtp.Value.ToShortDateString(), "من: " + cmbSecondaryAcc.Text, 0, decimal.Parse(txtPalance.Text), DAL);

                    transaction.Commit(); con.Close();
                    cmbDetails.SelectedItem = null;
                    cmbPrimaryAcc.EditValue = null;
                    cmbSecondaryAcc.EditValue = null;

                    txtLastPalance.Text = "";
                    txtPalance.Text = "";
                    txtArabicWord.Text = "";
                    cmbSecondaryAcc.Properties.DataSource = null;
                    txtId.Text = GetMaxId();
                    cmbPrimaryAcc.Focus();

                    MessageBox.Show("تمت الإضافة بنجاح", "المجموعة الرقمية للنظم والتقنية");

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("عذراً .. فشلت العملية \n " + ex.Message, "المجموعة الرقمية للنظم والتقنية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPalance_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ToWord toWord = new ToWord(Convert.ToDecimal(txtPalance.Text), currencies[Convert.ToInt32(cboCurrency.SelectedValue)]);
                txtArabicWord.Text = toWord.ConvertToArabic();
            }
            catch
            {

            }
        }

        private void dtp_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbPrimaryAcc_Properties_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbPrimaryAcc.EditValue != null)
                {
                    cmbSecondaryAcc.Properties.DataSource = acc.Get_SecondaryAccounts(cmbPrimaryAcc.EditValue.ToString());
                    cmbSecondaryAcc.Properties.DisplayMember = "name";
                    cmbSecondaryAcc.Properties.ValueMember = "Id";
                    cmbSecondaryAcc.EditValue = null;
                }
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
            cboCurrency.SelectedIndex = cmbCashbook.ItemIndex;
            try
            {
                ToWord toWord = new ToWord(Convert.ToDecimal(txtPalance.Text), currencies[Convert.ToInt32(cboCurrency.SelectedValue)]);

                txtArabicWord.Text = toWord.ConvertToArabic();
            }
            catch
            {

            }
        }

        private void cmbPrimaryAcc_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbSecondaryAcc_EditValueChanged(object sender, EventArgs e)
        {
            txtLastPalance.Text = "";
            try
            {
                if (cmbSecondaryAcc.EditValue != null)
                {
                    string date = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;

                    decimal Dain = decimal.Parse(acc.Get_Sum_AccDain(cmbSecondaryAcc.EditValue.ToString(), date));
                    decimal Madin = decimal.Parse(acc.Get_Sum_AccMadin(cmbSecondaryAcc.EditValue.ToString(), date));
                    decimal accPalacne = Madin - Dain;

                    if (accPalacne < 0)
                    {
                        txtLastPalance.Text = "له : " + DAL.Split((-1 * accPalacne).ToString());
                    }
                    else if (accPalacne > 0)
                    {
                        txtLastPalance.Text = "عليه : " + DAL.Split(accPalacne.ToString());
                    }
                    else
                        txtLastPalance.Text = "0 ";
                }
            }
            catch { }
        }
    }
}