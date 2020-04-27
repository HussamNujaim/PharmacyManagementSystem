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
    public partial class frmStores : DevExpress.XtraEditors.XtraForm
    {
        Presentation.CLS_STORE store = new Presentation.CLS_STORE();
        public frmStores()
        {
            InitializeComponent();
            dgv.DataSource = store.Get_Stores();
        }

        private void chkbxIsMain_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
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
                    store.Add_Store(txtName.Text, txtLocation.Text, txtDetails.Text,isMain, DAL);
                    //
                    dgv.DataSource = null;
                    dgv.DataSource = store.Get_Stores(DAL);
                    txtName.Text = "";
                    txtLocation.Text = "";
                    txtDetails.Text = "";
                    chkbxIsMain.Checked = false;
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