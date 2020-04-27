using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace ERP
{
    public partial class frmItems : DevExpress.XtraEditors.XtraForm
    {
        private readonly SqlConnection con = new SqlConnection();
        private readonly SqlCommand cmd = new SqlCommand();
        private readonly Presentation.CLS_STORE store = new Presentation.CLS_STORE();
        private readonly Presentation.CLS_ITEMS ITEMS = new Presentation.CLS_ITEMS();
        private readonly Presentation.CLS_Currencies currency = new Presentation.CLS_Currencies();
        DataLayer.DataLayer DL = new DataLayer.DataLayer();

        public frmItems()
        {
            InitializeComponent();
           // System.Diagnostics.Process process = new System.Diagnostics.Process();
           // process.StartInfo.FileName = "net start \"Sql Server (SQLEXPRESS)\"";
           // process.Start();
        }

        private void txtItemUnitsCount_EditValueChanged(object sender, EventArgs e)
        {
            dgvUnits.Rows.Clear();
            for (int i = 0; i < int.Parse(txtItemUnitsCount.Text); i++)
            {
                dgvUnits.Rows.Add();
            }
            viewUnit();
        }

        private void viewUnit()
        {
            try
            {
                DataTable dt;
                dt = ITEMS.Get_Units();
                for (int i = 0; i < dgvUnits.Rows.Count; i++)
                {
                    ((DataGridViewComboBoxCell)dgvUnits.Rows[i].Cells[0]).Items.Clear();
                    //for (int j = 0; j < cmbUnitName.Items.Count; j++)
                    // while (dr.Read())
                    {
                        ((DataGridViewComboBoxCell)dgvUnits.Rows[i].Cells[0]).DataSource = dt;
                        ((DataGridViewComboBoxCell)dgvUnits.Rows[i].Cells[0]).ValueMember = "UnitName";
                        ((DataGridViewComboBoxCell)dgvUnits.Rows[i].Cells[0]).DisplayMember = "UnitName";//Items.Add(dr["UnitName"]);
                    }
                }
            }
            catch (Exception r) { MessageBox.Show(r.Message, "المجموعة الرقمية للنظم والتقنية 1.0"); }
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storesDataSet.Get_Currencies' table. You can move, or remove it, as needed.
            this.get_CurrenciesTableAdapter.Fill(this.storesDataSet.Get_Currencies);
            cmbCurrency.Properties.DisplayMember = "name";
            cmbCurrency.Properties.ValueMember = "Id";
           // cmbCurrency.Properties.DataSource = currency.Get_Currencies();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text==""|| cmbCurrency.EditValue==null|| dgvUnits.Rows.Count<1|| txtItemName.Text == "" || txtSalePrice.Text == "")
            {
                DL.ShowMessageBox("تأكد من تعبئة جميع الحقول");
            }
            else
            {
                if (MessageBox.Show("هل ترغب بإضافة الصنف", "المجموعة الرقمية للنظم والتقنية", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DataTable dt = new DataTable();
                    dt = ITEMS.VerifyProductName(txtItemName.Text);
                    if (dt.Rows.Count <= 0)
                    {
                        try
                        {
                            int s = 0; // Input Validation
                            for (int i = 0; i < dgvUnits.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvUnits.Columns.Count - 1; j++)//التحقق من الوحدات الفارغة وقيمها
                                {
                                    if (dgvUnits[j, i].Value == null)
                                    {
                                        s = 1;
                                        break;
                                    }
                                }
                                if (s == 0)
                                {
                                    for (int j = i + 1; j < dgvUnits.Rows.Count; j++) // التحقق من تكرار الوحدات او قيم الوحدات
                                    {
                                        if (dgvUnits[0, i].Value.ToString() == dgvUnits[0, j].Value.ToString() || dgvUnits[1, i].Value.ToString() == dgvUnits[1, j].Value.ToString())
                                        {
                                            s = 2;
                                            break;
                                        }
                                    }
                                }
                            }
                            if (s == 1)
                            {
                                MessageBox.Show("تأكد من تعبئة جميع الحقول", "المجموعة الرقمية للنظم والتقنية 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else if (s == 2)
                            {
                                MessageBox.Show("تأكد من تعبئة الوحدات بشكل صحيح", "المجموعة الرقمية للنظم والتقنية 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            //

                            // save salePrice to minimum unit price
                            decimal PQty = decimal.Parse(dgvUnits[1, 0].Value.ToString());
                            for (int q = 0 + 1; q < dgvUnits.Rows.Count - 1; q++)
                            {
                                PQty *= decimal.Parse(dgvUnits[1, q].Value.ToString());
                            }
                            decimal minimumUnitPrice = decimal.Parse(txtSalePrice.Text) / PQty;
                            //////////////////
                            // Get initialQty if there is any
                            double iQty = 0;

                            for (int q = 0; q < dgvUnits.Rows.Count; q++)
                            {
                                if (dgvUnits[2, q].Value != null)
                                {
                                    double qty = 1;
                                    for (int x = q; x >= 0; x--)
                                    {
                                        qty *= double.Parse(dgvUnits[1, x].Value.ToString());
                                    }
                                    iQty += double.Parse(dgvUnits[2, q].Value.ToString()) * qty;
                                }
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
                                ITEMS.Add_Item(txtItemName.Text, txtItemDetails.Text, minimumUnitPrice, txtItemPosition.Text, cmbCurrency.EditValue.ToString(),txtBarcode.Text, DAL);
                                string MaxItemID = ITEMS.Get_Max_ItemID(DAL);
                                int IsMain = 1;
                                for (int i = 0; i < dgvUnits.Rows.Count; i++)
                                {
                                    //
                                    decimal Qty = decimal.Parse(dgvUnits[1, i].Value.ToString());
                                    for (int q = i - 1; q >= 0; q--)
                                    {
                                        Qty *= decimal.Parse(dgvUnits[1, q].Value.ToString());
                                    }

                                    //
                                    string UnitID = ITEMS.GET_UNIT_ID(dgvUnits[0, i].Value.ToString(), DAL).Rows[0][0].ToString();
                                    ITEMS.Add_ItemUnit(MaxItemID, UnitID, Qty.ToString(), IsMain, DAL);
                                    IsMain = 0;
                                }

                                // Get NewPrice of the min Unit
                                string unitQty = ITEMS.Get_QtyOfItemUnit(int.Parse(MaxItemID), dgvUnits.Rows[dgvUnits.Rows.Count - 1].Cells[0].Value.ToString(), DAL);
                                decimal newPrice = decimal.Parse(txtPurchasePrice.Text) / decimal.Parse(unitQty);

                                if (iQty > 0)
                                    store.Add_ItemToStore(int.Parse(MaxItemID), iQty, newPrice, DAL);

                                //////////////////
                                transaction.Commit(); con.Close();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                DL.ShowMessageBox("عذراً .. فشلت العملية \n " + ex.Message);
                            }
                            //  MessageBox.Show("تمـت الإضافه بنجــاح", "المجموعة الرقمية للنظم والتقنية 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //View();
                            //SelectItemId();
                            txtItemDetails.Text = "";
                            txtItemName.Text = "";
                            GenerateBarcode();
                            txtItemName.Focus();
                        }
                        catch (Exception r) { DL.ShowMessageBox(r.Message, "المجموعة الرقمية للنظم والتقنية 1.0"); }
                    }
                    else
                    {
                        DL.ShowMessageBox("عـذراً هذا الصنف موجود مسبقاً في المخزن");
                        txtItemName.Focus();
                    }
                }
            }
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            if (txtUnitName.Text == "")
            {
                MessageBox.Show("تأكد من تعبئة الحقول الفارغة", "ألمجموعة الرقمية للنظم والتقنية", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable dt = new DataTable();
                dt = ITEMS.GET_UNIT_ID(txtUnitName.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("عـذراً هذه الوحدة موجودة مسبقاً", "المجموعة الرقمية للنظم والتقنية 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUnitName.Focus();
                }
                else
                {
                    ITEMS.Add_Unit(txtUnitName.Text);
                    MessageBox.Show("تمت الإضافة بنجاح", "ألمجموعة الرقمية للنظم والتقنية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //
                    txtUnitName.Text = "";
                    viewUnit();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnBarcodeGenerate_Click(object sender, EventArgs e)
        {
            GenerateBarcode(); // 你好
        }

        private void GenerateBarcode()
        {
            string barCode = DateTime.Now.Ticks.ToString();
            txtBarcode.Text = barCode;
            try
            {
                Zen.Barcode.Code128BarcodeDraw brCode =
                Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                imgBarcode.Image = brCode.Draw(barCode, 60);
            }
            catch (Exception)
            {

            }
        }
    }
}