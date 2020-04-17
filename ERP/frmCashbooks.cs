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
    public partial class frmCashbooks : DevExpress.XtraEditors.XtraForm
    {
        Presentation.CLS_Cashbook cash = new Presentation.CLS_Cashbook();
        public frmCashbooks()
        {
            InitializeComponent();
            dgv.DataSource = cash.Get_Cashbooks();
        }

        private void chkbxIsMain_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && cmbCurrency.EditValue != null)
            {
                decimal initBalance = 0;
                if (txtInitialBalance.Text != "")
                {
                    initBalance = decimal.Parse(txtInitialBalance.Text);
                }
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ERP.Properties.Settings.ERP"].ConnectionString;
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    int isMain = 0;
                    if (chkbxIsMain.Checked)
                        isMain = 1;
                    DataLayer.DataLayer DAL = new DataLayer.DataLayer(transaction, con);
                    cash.Add_Cashbook(txtName.Text, txtDetails.Text, int.Parse(cmbCurrency.EditValue.ToString()), initBalance,isMain, DAL);
                    //
                    DataTable dt = cash.Get_Cashbooks(DAL);
                    int cashbookId = int.Parse(dt.Rows[dt.Rows.Count - 1][0].ToString());
                    decimal cashPalance = initBalance;
                    //
                    cash.Add_CashbookReport(cashbookId, "رصيد افتتاحي", 0, DateTime.Now.ToShortDateString(),
                        "رصيد اول الفترة", 0, cashPalance, DAL);
                    //
                    dgv.DataSource = null;
                    dgv.DataSource = cash.Get_Cashbooks(DAL);
                    txtName.Text = "";
                    txtDetails.Text = "";
                    txtInitialBalance.Text = "";
                    transaction.Commit(); con.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("عذراً .. فشلت العملية \n " + ex.Message, "المجموعة الرقمية للنظم والتقنية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmCashbooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storesDataSet.Get_Currencies' table. You can move, or remove it, as needed.
            this.get_CurrenciesTableAdapter.Fill(this.storesDataSet.Get_Currencies);

        }
    }
}