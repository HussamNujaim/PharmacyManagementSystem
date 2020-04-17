namespace ERP
{
    partial class frmAccounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccounts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtAddDebit = new DevExpress.XtraEditors.TextEdit();
            this.txtAddCredit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmbAddCurrency = new DevExpress.XtraEditors.LookUpEdit();
            this.getCurrenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetCurrencies = new ERP.StoresDataSet();
            this.cmbAddPrimaryAccount = new DevExpress.XtraEditors.LookUpEdit();
            this.getPrimaryAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddAccDetails = new DevExpress.XtraEditors.TextEdit();
            this.txtAddAccName = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.txtEditDebit = new DevExpress.XtraEditors.TextEdit();
            this.txtEditCredit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.cmbEditCurrency = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.cmbEditPrimaryAcc = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtEditAccId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtEditAccDetails = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtEditAccName = new DevExpress.XtraEditors.TextEdit();
            this.get_CurrenciesTableAdapter = new ERP.StoresDataSetTableAdapters.Get_CurrenciesTableAdapter();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.cmbSearchPrimaryAcc = new DevExpress.XtraEditors.LookUpEdit();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.get_PrimaryAccountsTableAdapter = new ERP.StoresDataSetTableAdapters.Get_PrimaryAccountsTableAdapter();
            this.getPrimaryAccountsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddDebit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddCredit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAddCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCurrenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetCurrencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAddPrimaryAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPrimaryAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddAccDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddAccName.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditDebit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditCredit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEditCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEditPrimaryAcc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditAccId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditAccDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditAccName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSearchPrimaryAcc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPrimaryAccountsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "ERP.Properties.Settings.ERP";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "Get_SecondaryAccounts";
            queryParameter1.Name = "@fatherAccount";
            queryParameter1.Type = typeof(int);
            queryParameter1.ValueInfo = "0";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "Get_SecondaryAccounts";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgv);
            this.panelControl1.Location = new System.Drawing.Point(417, 64);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(526, 393);
            this.panelControl1.TabIndex = 3;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.SystemColors.Control;
            this.dgv.Location = new System.Drawing.Point(2, 2);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(522, 389);
            this.dgv.StandardTab = true;
            this.dgv.TabIndex = 2;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.xtraTabControl1.Appearance.Options.UseFont = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(-1, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(412, 455);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 11F);
            this.xtraTabPage1.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(406, 408);
            this.xtraTabPage1.Text = "إضافة حساب جديد";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.cmbAddCurrency);
            this.groupControl1.Controls.Add(this.cmbAddPrimaryAccount);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtAddAccDetails);
            this.groupControl1.Controls.Add(this.txtAddAccName);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(406, 408);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.txtAddDebit);
            this.groupControl3.Controls.Add(this.txtAddCredit);
            this.groupControl3.Controls.Add(this.labelControl8);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Location = new System.Drawing.Point(5, 189);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(393, 104);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "رصيد افتتاحي";
            // 
            // txtAddDebit
            // 
            this.txtAddDebit.Location = new System.Drawing.Point(16, 63);
            this.txtAddDebit.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddDebit.Name = "txtAddDebit";
            this.txtAddDebit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAddDebit.Properties.Appearance.Options.UseFont = true;
            this.txtAddDebit.Size = new System.Drawing.Size(265, 26);
            this.txtAddDebit.TabIndex = 1;
            // 
            // txtAddCredit
            // 
            this.txtAddCredit.Location = new System.Drawing.Point(16, 29);
            this.txtAddCredit.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddCredit.Name = "txtAddCredit";
            this.txtAddCredit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAddCredit.Properties.Appearance.Options.UseFont = true;
            this.txtAddCredit.Size = new System.Drawing.Size(265, 26);
            this.txtAddCredit.TabIndex = 0;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(289, 66);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(27, 19);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "دائن";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(289, 32);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(33, 19);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "مدين";
            // 
            // cmbAddCurrency
            // 
            this.cmbAddCurrency.Location = new System.Drawing.Point(21, 146);
            this.cmbAddCurrency.Name = "cmbAddCurrency";
            this.cmbAddCurrency.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbAddCurrency.Properties.Appearance.Options.UseFont = true;
            this.cmbAddCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAddCurrency.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 25, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbAddCurrency.Properties.DataSource = this.getCurrenciesBindingSource;
            this.cmbAddCurrency.Properties.DisplayMember = "name";
            this.cmbAddCurrency.Properties.NullText = "";
            this.cmbAddCurrency.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbAddCurrency.Properties.ShowFooter = false;
            this.cmbAddCurrency.Properties.ShowHeader = false;
            this.cmbAddCurrency.Properties.ShowLines = false;
            this.cmbAddCurrency.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbAddCurrency.Properties.ValueMember = "Id";
            this.cmbAddCurrency.Size = new System.Drawing.Size(265, 26);
            this.cmbAddCurrency.TabIndex = 4;
            // 
            // getCurrenciesBindingSource
            // 
            this.getCurrenciesBindingSource.DataMember = "Get_Currencies";
            this.getCurrenciesBindingSource.DataSource = this.GetCurrencies;
            // 
            // GetCurrencies
            // 
            this.GetCurrencies.DataSetName = "GetCurrencies";
            this.GetCurrencies.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbAddPrimaryAccount
            // 
            this.cmbAddPrimaryAccount.Location = new System.Drawing.Point(21, 46);
            this.cmbAddPrimaryAccount.Name = "cmbAddPrimaryAccount";
            this.cmbAddPrimaryAccount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbAddPrimaryAccount.Properties.Appearance.Options.UseFont = true;
            this.cmbAddPrimaryAccount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAddPrimaryAccount.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 25, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbAddPrimaryAccount.Properties.DataSource = this.getPrimaryAccountsBindingSource1;
            this.cmbAddPrimaryAccount.Properties.DisplayMember = "name";
            this.cmbAddPrimaryAccount.Properties.NullText = "";
            this.cmbAddPrimaryAccount.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbAddPrimaryAccount.Properties.ShowFooter = false;
            this.cmbAddPrimaryAccount.Properties.ShowHeader = false;
            this.cmbAddPrimaryAccount.Properties.ShowLines = false;
            this.cmbAddPrimaryAccount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbAddPrimaryAccount.Properties.ValueMember = "Id";
            this.cmbAddPrimaryAccount.Size = new System.Drawing.Size(265, 26);
            this.cmbAddPrimaryAccount.TabIndex = 0;
            // 
            // getPrimaryAccountsBindingSource
            // 
            this.getPrimaryAccountsBindingSource.DataMember = "Get_PrimaryAccounts";
            this.getPrimaryAccountsBindingSource.DataSource = this.GetCurrencies;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(304, 149);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 19);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "العملة";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(304, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 19);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "تفاصيل";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(304, 82);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(91, 19);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "اسم الحساب";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(21, 310);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(265, 46);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(304, 49);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "نوع الحساب";
            // 
            // txtAddAccDetails
            // 
            this.txtAddAccDetails.Location = new System.Drawing.Point(21, 113);
            this.txtAddAccDetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddAccDetails.Name = "txtAddAccDetails";
            this.txtAddAccDetails.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAddAccDetails.Properties.Appearance.Options.UseFont = true;
            this.txtAddAccDetails.Size = new System.Drawing.Size(265, 26);
            this.txtAddAccDetails.TabIndex = 3;
            // 
            // txtAddAccName
            // 
            this.txtAddAccName.Location = new System.Drawing.Point(21, 79);
            this.txtAddAccName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddAccName.Name = "txtAddAccName";
            this.txtAddAccName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAddAccName.Properties.Appearance.Options.UseFont = true;
            this.txtAddAccName.Size = new System.Drawing.Size(265, 26);
            this.txtAddAccName.TabIndex = 1;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 11F);
            this.xtraTabPage2.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage2.Controls.Add(this.groupControl2);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(406, 408);
            this.xtraTabPage2.Text = "تعديل حساب ";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Controls.Add(this.cmbEditCurrency);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.cmbEditPrimaryAcc);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.btnEdit);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txtEditAccId);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.txtEditAccDetails);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.txtEditAccName);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(406, 408);
            this.groupControl2.TabIndex = 9;
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.txtEditDebit);
            this.groupControl4.Controls.Add(this.txtEditCredit);
            this.groupControl4.Controls.Add(this.labelControl12);
            this.groupControl4.Controls.Add(this.labelControl13);
            this.groupControl4.Location = new System.Drawing.Point(8, 205);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(393, 104);
            this.groupControl4.TabIndex = 5;
            this.groupControl4.Text = "رصيد افتتاحي (جديد)";
            // 
            // txtEditDebit
            // 
            this.txtEditDebit.Location = new System.Drawing.Point(16, 63);
            this.txtEditDebit.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditDebit.Name = "txtEditDebit";
            this.txtEditDebit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtEditDebit.Properties.Appearance.Options.UseFont = true;
            this.txtEditDebit.Size = new System.Drawing.Size(265, 26);
            this.txtEditDebit.TabIndex = 1;
            // 
            // txtEditCredit
            // 
            this.txtEditCredit.Location = new System.Drawing.Point(16, 29);
            this.txtEditCredit.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditCredit.Name = "txtEditCredit";
            this.txtEditCredit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtEditCredit.Properties.Appearance.Options.UseFont = true;
            this.txtEditCredit.Size = new System.Drawing.Size(265, 26);
            this.txtEditCredit.TabIndex = 0;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(289, 66);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(27, 19);
            this.labelControl12.TabIndex = 12;
            this.labelControl12.Text = "دائن";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(289, 32);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(33, 19);
            this.labelControl13.TabIndex = 12;
            this.labelControl13.Text = "مدين";
            // 
            // cmbEditCurrency
            // 
            this.cmbEditCurrency.Location = new System.Drawing.Point(9, 164);
            this.cmbEditCurrency.Name = "cmbEditCurrency";
            this.cmbEditCurrency.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbEditCurrency.Properties.Appearance.Options.UseFont = true;
            this.cmbEditCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEditCurrency.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 25, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbEditCurrency.Properties.DataSource = this.getCurrenciesBindingSource;
            this.cmbEditCurrency.Properties.DisplayMember = "name";
            this.cmbEditCurrency.Properties.NullText = "";
            this.cmbEditCurrency.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbEditCurrency.Properties.ShowFooter = false;
            this.cmbEditCurrency.Properties.ShowHeader = false;
            this.cmbEditCurrency.Properties.ShowLines = false;
            this.cmbEditCurrency.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbEditCurrency.Properties.ValueMember = "Id";
            this.cmbEditCurrency.Size = new System.Drawing.Size(230, 26);
            this.cmbEditCurrency.TabIndex = 4;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(257, 167);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(92, 19);
            this.labelControl11.TabIndex = 16;
            this.labelControl11.Text = "العملة (جديد)";
            // 
            // cmbEditPrimaryAcc
            // 
            this.cmbEditPrimaryAcc.Location = new System.Drawing.Point(9, 64);
            this.cmbEditPrimaryAcc.Name = "cmbEditPrimaryAcc";
            this.cmbEditPrimaryAcc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbEditPrimaryAcc.Properties.Appearance.Options.UseFont = true;
            this.cmbEditPrimaryAcc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEditPrimaryAcc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 25, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbEditPrimaryAcc.Properties.DataSource = this.getPrimaryAccountsBindingSource1;
            this.cmbEditPrimaryAcc.Properties.DisplayMember = "name";
            this.cmbEditPrimaryAcc.Properties.NullText = "";
            this.cmbEditPrimaryAcc.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbEditPrimaryAcc.Properties.ShowFooter = false;
            this.cmbEditPrimaryAcc.Properties.ShowHeader = false;
            this.cmbEditPrimaryAcc.Properties.ShowLines = false;
            this.cmbEditPrimaryAcc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbEditPrimaryAcc.Properties.ValueMember = "Id";
            this.cmbEditPrimaryAcc.Size = new System.Drawing.Size(230, 26);
            this.cmbEditPrimaryAcc.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(257, 67);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(131, 19);
            this.labelControl9.TabIndex = 14;
            this.labelControl9.Text = "نوع الحساب (جديد)";
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(110, 338);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(148, 46);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "تعديل";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(301, 34);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(84, 19);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "رقم الحساب";
            // 
            // txtEditAccId
            // 
            this.txtEditAccId.Location = new System.Drawing.Point(9, 31);
            this.txtEditAccId.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditAccId.Name = "txtEditAccId";
            this.txtEditAccId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtEditAccId.Properties.Appearance.Options.UseFont = true;
            this.txtEditAccId.Properties.ReadOnly = true;
            this.txtEditAccId.Size = new System.Drawing.Size(284, 26);
            this.txtEditAccId.TabIndex = 0;
            this.txtEditAccId.TabStop = false;
            this.txtEditAccId.EditValueChanged += new System.EventHandler(this.txtEditID_EditValueChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(257, 134);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(108, 19);
            this.labelControl10.TabIndex = 1;
            this.labelControl10.Text = "التفاصيل (جديد)";
            // 
            // txtEditAccDetails
            // 
            this.txtEditAccDetails.Location = new System.Drawing.Point(9, 131);
            this.txtEditAccDetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditAccDetails.Name = "txtEditAccDetails";
            this.txtEditAccDetails.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtEditAccDetails.Properties.Appearance.Options.UseFont = true;
            this.txtEditAccDetails.Size = new System.Drawing.Size(230, 26);
            this.txtEditAccDetails.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(257, 100);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(141, 19);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "اسم الحساب (جديد)";
            // 
            // txtEditAccName
            // 
            this.txtEditAccName.Location = new System.Drawing.Point(9, 97);
            this.txtEditAccName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditAccName.Name = "txtEditAccName";
            this.txtEditAccName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtEditAccName.Properties.Appearance.Options.UseFont = true;
            this.txtEditAccName.Size = new System.Drawing.Size(230, 26);
            this.txtEditAccName.TabIndex = 2;
            // 
            // get_CurrenciesTableAdapter
            // 
            this.get_CurrenciesTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(438, 8);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(81, 19);
            this.labelControl14.TabIndex = 1;
            this.labelControl14.Text = "نوع الحساب";
            // 
            // cmbSearchPrimaryAcc
            // 
            this.cmbSearchPrimaryAcc.Location = new System.Drawing.Point(526, 5);
            this.cmbSearchPrimaryAcc.Name = "cmbSearchPrimaryAcc";
            this.cmbSearchPrimaryAcc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbSearchPrimaryAcc.Properties.Appearance.Options.UseFont = true;
            this.cmbSearchPrimaryAcc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSearchPrimaryAcc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 25, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbSearchPrimaryAcc.Properties.DataSource = this.getPrimaryAccountsBindingSource;
            this.cmbSearchPrimaryAcc.Properties.DisplayMember = "name";
            this.cmbSearchPrimaryAcc.Properties.NullText = "";
            this.cmbSearchPrimaryAcc.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbSearchPrimaryAcc.Properties.ShowFooter = false;
            this.cmbSearchPrimaryAcc.Properties.ShowHeader = false;
            this.cmbSearchPrimaryAcc.Properties.ShowLines = false;
            this.cmbSearchPrimaryAcc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbSearchPrimaryAcc.Properties.ValueMember = "Id";
            this.cmbSearchPrimaryAcc.Properties.EditValueChanged += new System.EventHandler(this.cmbSearchPrimaryAcc_Properties_EditValueChanged);
            this.cmbSearchPrimaryAcc.Size = new System.Drawing.Size(417, 26);
            this.cmbSearchPrimaryAcc.TabIndex = 1;
            this.cmbSearchPrimaryAcc.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.cmbSearchPrimaryAcc_ListChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(526, 34);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Size = new System.Drawing.Size(417, 26);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.EditValueChanged += new System.EventHandler(this.txtSearch_EditValueChanged);
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(489, 37);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(30, 19);
            this.labelControl15.TabIndex = 12;
            this.labelControl15.Text = "بحث";
            // 
            // get_PrimaryAccountsTableAdapter
            // 
            this.get_PrimaryAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // getPrimaryAccountsBindingSource1
            // 
            this.getPrimaryAccountsBindingSource1.DataMember = "Get_PrimaryAccounts";
            this.getPrimaryAccountsBindingSource1.DataSource = this.GetCurrencies;
            // 
            // frmAccounts
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 467);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.cmbSearchPrimaryAcc);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.labelControl15);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAccounts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الحسابات";
            this.Load += new System.EventHandler(this.frmAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddDebit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddCredit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAddCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCurrenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetCurrencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAddPrimaryAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPrimaryAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddAccDetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddAccName.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditDebit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditCredit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEditCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEditPrimaryAcc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditAccId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditAccDetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditAccName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSearchPrimaryAcc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPrimaryAccountsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView dgv;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtAddAccName;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtEditAccName;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtEditAccId;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit txtAddDebit;
        private DevExpress.XtraEditors.TextEdit txtAddCredit;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit cmbAddCurrency;
        private DevExpress.XtraEditors.LookUpEdit cmbAddPrimaryAccount;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtAddAccDetails;
        private DevExpress.XtraEditors.LookUpEdit cmbEditPrimaryAcc;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit cmbEditCurrency;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtEditAccDetails;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.TextEdit txtEditDebit;
        private DevExpress.XtraEditors.TextEdit txtEditCredit;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        //private StoresDataSet_1 GetPrimaryAccounts;
        private System.Windows.Forms.BindingSource getPrimaryAccountsBindingSource;
        //private StoresDataSet_1TableAdapters.Get_PrimaryAccountsTableAdapter get_PrimaryAccountsTableAdapter;
        private StoresDataSet GetCurrencies;
        private System.Windows.Forms.BindingSource getCurrenciesBindingSource;
        private StoresDataSetTableAdapters.Get_CurrenciesTableAdapter get_CurrenciesTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LookUpEdit cmbSearchPrimaryAcc;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private StoresDataSetTableAdapters.Get_PrimaryAccountsTableAdapter get_PrimaryAccountsTableAdapter;
        private System.Windows.Forms.BindingSource getPrimaryAccountsBindingSource1;
    }
}