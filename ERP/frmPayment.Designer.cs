namespace ERP
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblPalance = new System.Windows.Forms.Label();
            this.txtArabic = new System.Windows.Forms.TextBox();
            this.txtArabicPrice = new System.Windows.Forms.MaskedTextBox();
            this.cboCurrency = new System.Windows.Forms.ComboBox();
            this.cmbDetails = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtp = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.cmbCashbook = new DevExpress.XtraEditors.LookUpEdit();
            this.getCashbooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storesDataSet = new ERP.StoresDataSet();
            this.cmbSecondaryAcc = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbPrimaryAcc = new DevExpress.XtraEditors.LookUpEdit();
            this.getPrimaryAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtLastPalance = new DevExpress.XtraEditors.TextEdit();
            this.txtPalance = new DevExpress.XtraEditors.TextEdit();
            this.lPresentationExchangeRate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtArabicWord = new DevExpress.XtraEditors.MemoEdit();
            this.get_PrimaryAccountsTableAdapter = new ERP.StoresDataSetTableAdapters.Get_PrimaryAccountsTableAdapter();
            this.get_CashbooksTableAdapter = new ERP.StoresDataSetTableAdapters.Get_CashbooksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCashbook.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCashbooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSecondaryAcc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPrimaryAcc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPrimaryAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastPalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArabicWord.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.lblPalance);
            this.groupControl1.Controls.Add(this.txtArabic);
            this.groupControl1.Controls.Add(this.txtArabicPrice);
            this.groupControl1.Controls.Add(this.cboCurrency);
            this.groupControl1.Controls.Add(this.cmbDetails);
            this.groupControl1.Controls.Add(this.dtp);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Controls.Add(this.cmbCashbook);
            this.groupControl1.Controls.Add(this.cmbSecondaryAcc);
            this.groupControl1.Controls.Add(this.cmbPrimaryAcc);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtLastPalance);
            this.groupControl1.Controls.Add(this.txtPalance);
            this.groupControl1.Controls.Add(this.lPresentationExchangeRate);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.txtArabicWord);
            this.groupControl1.Location = new System.Drawing.Point(6, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(573, 414);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "بيانات سند الصرف";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // lblPalance
            // 
            this.lblPalance.AutoSize = true;
            this.lblPalance.Location = new System.Drawing.Point(473, 188);
            this.lblPalance.Name = "lblPalance";
            this.lblPalance.Size = new System.Drawing.Size(0, 13);
            this.lblPalance.TabIndex = 30;
            // 
            // txtArabic
            // 
            this.txtArabic.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArabic.Location = new System.Drawing.Point(484, 233);
            this.txtArabic.Multiline = true;
            this.txtArabic.Name = "txtArabic";
            this.txtArabic.ReadOnly = true;
            this.txtArabic.Size = new System.Drawing.Size(83, 37);
            this.txtArabic.TabIndex = 28;
            this.txtArabic.Visible = false;
            // 
            // txtArabicPrice
            // 
            this.txtArabicPrice.BeepOnError = true;
            this.txtArabicPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArabicPrice.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtArabicPrice.HidePromptOnLeave = true;
            this.txtArabicPrice.Location = new System.Drawing.Point(441, 247);
            this.txtArabicPrice.Name = "txtArabicPrice";
            this.txtArabicPrice.PromptChar = ' ';
            this.txtArabicPrice.ResetOnPrompt = false;
            this.txtArabicPrice.ResetOnSpace = false;
            this.txtArabicPrice.Size = new System.Drawing.Size(46, 21);
            this.txtArabicPrice.SkipLiterals = false;
            this.txtArabicPrice.TabIndex = 27;
            this.txtArabicPrice.Tag = "ادخل مبلغ";
            this.txtArabicPrice.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtArabicPrice.Visible = false;
            this.txtArabicPrice.TextChanged += new System.EventHandler(this.txtArabicPrice_TextChanged);
            // 
            // cboCurrency
            // 
            this.cboCurrency.DisplayMember = "EnglishCurrencyName";
            this.cboCurrency.FormattingEnabled = true;
            this.cboCurrency.Location = new System.Drawing.Point(446, 366);
            this.cboCurrency.Name = "cboCurrency";
            this.cboCurrency.Size = new System.Drawing.Size(121, 21);
            this.cboCurrency.TabIndex = 29;
            this.cboCurrency.TabStop = false;
            this.cboCurrency.ValueMember = "CurrencyID";
            this.cboCurrency.Visible = false;
            // 
            // cmbDetails
            // 
            this.cmbDetails.Location = new System.Drawing.Point(6, 310);
            this.cmbDetails.Name = "cmbDetails";
            this.cmbDetails.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbDetails.Properties.Appearance.Options.UseFont = true;
            this.cmbDetails.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDetails.Properties.Items.AddRange(new object[] {
            "دفعة من الحساب"});
            this.cmbDetails.Size = new System.Drawing.Size(427, 26);
            this.cmbDetails.TabIndex = 7;
            this.cmbDetails.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // dtp
            // 
            this.dtp.EditValue = null;
            this.dtp.Location = new System.Drawing.Point(6, 274);
            this.dtp.Name = "dtp";
            this.dtp.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.dtp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dtp.Properties.Appearance.Options.UseFont = true;
            this.dtp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp.Size = new System.Drawing.Size(427, 26);
            this.dtp.TabIndex = 6;
            this.dtp.EditValueChanged += new System.EventHandler(this.dtp_EditValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(28, 360);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(142, 46);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "طباعة";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(183, 360);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 46);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbCashbook
            // 
            this.cmbCashbook.Location = new System.Drawing.Point(7, 180);
            this.cmbCashbook.Name = "cmbCashbook";
            this.cmbCashbook.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbCashbook.Properties.Appearance.Options.UseFont = true;
            this.cmbCashbook.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCashbook.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 25, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbCashbook.Properties.DataSource = this.getCashbooksBindingSource;
            this.cmbCashbook.Properties.DisplayMember = "name";
            this.cmbCashbook.Properties.NullText = "";
            this.cmbCashbook.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbCashbook.Properties.ShowFooter = false;
            this.cmbCashbook.Properties.ShowHeader = false;
            this.cmbCashbook.Properties.ShowLines = false;
            this.cmbCashbook.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbCashbook.Properties.ValueMember = "Id";
            this.cmbCashbook.Size = new System.Drawing.Size(426, 26);
            this.cmbCashbook.TabIndex = 4;
            this.cmbCashbook.EditValueChanged += new System.EventHandler(this.cmbCashbook_EditValueChanged);
            // 
            // getCashbooksBindingSource
            // 
            this.getCashbooksBindingSource.DataMember = "Get_Cashbooks";
            this.getCashbooksBindingSource.DataSource = this.storesDataSet;
            // 
            // storesDataSet
            // 
            this.storesDataSet.DataSetName = "StoresDataSet";
            this.storesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbSecondaryAcc
            // 
            this.cmbSecondaryAcc.Location = new System.Drawing.Point(169, 107);
            this.cmbSecondaryAcc.Name = "cmbSecondaryAcc";
            this.cmbSecondaryAcc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbSecondaryAcc.Properties.Appearance.Options.UseFont = true;
            this.cmbSecondaryAcc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSecondaryAcc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 25, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbSecondaryAcc.Properties.DisplayMember = "اسم الحساب";
            this.cmbSecondaryAcc.Properties.NullText = "";
            this.cmbSecondaryAcc.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbSecondaryAcc.Properties.ShowFooter = false;
            this.cmbSecondaryAcc.Properties.ShowHeader = false;
            this.cmbSecondaryAcc.Properties.ShowLines = false;
            this.cmbSecondaryAcc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbSecondaryAcc.Properties.ValueMember = "رقم الحساب";
            this.cmbSecondaryAcc.Size = new System.Drawing.Size(264, 26);
            this.cmbSecondaryAcc.TabIndex = 2;
            this.cmbSecondaryAcc.EditValueChanged += new System.EventHandler(this.cmbSecondaryAcc_EditValueChanged);
            // 
            // cmbPrimaryAcc
            // 
            this.cmbPrimaryAcc.Location = new System.Drawing.Point(7, 72);
            this.cmbPrimaryAcc.Name = "cmbPrimaryAcc";
            this.cmbPrimaryAcc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbPrimaryAcc.Properties.Appearance.Options.UseFont = true;
            this.cmbPrimaryAcc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPrimaryAcc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 25, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbPrimaryAcc.Properties.DataSource = this.getPrimaryAccountsBindingSource;
            this.cmbPrimaryAcc.Properties.DisplayMember = "name";
            this.cmbPrimaryAcc.Properties.NullText = "";
            this.cmbPrimaryAcc.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbPrimaryAcc.Properties.ShowFooter = false;
            this.cmbPrimaryAcc.Properties.ShowHeader = false;
            this.cmbPrimaryAcc.Properties.ShowLines = false;
            this.cmbPrimaryAcc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbPrimaryAcc.Properties.ValueMember = "Id";
            this.cmbPrimaryAcc.Properties.EditValueChanged += new System.EventHandler(this.cmbPrimaryAcc_Properties_EditValueChanged);
            this.cmbPrimaryAcc.Size = new System.Drawing.Size(426, 26);
            this.cmbPrimaryAcc.TabIndex = 1;
            this.cmbPrimaryAcc.EditValueChanged += new System.EventHandler(this.cmbPrimaryAcc_EditValueChanged);
            // 
            // getPrimaryAccountsBindingSource
            // 
            this.getPrimaryAccountsBindingSource.DataMember = "Get_PrimaryAccounts";
            this.getPrimaryAccountsBindingSource.DataSource = this.storesDataSet;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(444, 146);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 19);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "المبلغ المدفوع";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(6, 35);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Properties.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(427, 26);
            this.txtId.TabIndex = 0;
            this.txtId.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(444, 277);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 19);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "التاريخ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(444, 183);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 19);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "من صندوق";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(442, 313);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 19);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "وذلك مقابل";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(444, 110);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 19);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "إلى حساب";
            // 
            // txtLastPalance
            // 
            this.txtLastPalance.Location = new System.Drawing.Point(6, 107);
            this.txtLastPalance.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastPalance.Name = "txtLastPalance";
            this.txtLastPalance.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtLastPalance.Properties.Appearance.Options.UseFont = true;
            this.txtLastPalance.Properties.ReadOnly = true;
            this.txtLastPalance.Size = new System.Drawing.Size(160, 26);
            this.txtLastPalance.TabIndex = 1;
            this.txtLastPalance.TabStop = false;
            // 
            // txtPalance
            // 
            this.txtPalance.Location = new System.Drawing.Point(6, 143);
            this.txtPalance.Margin = new System.Windows.Forms.Padding(4);
            this.txtPalance.Name = "txtPalance";
            this.txtPalance.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPalance.Properties.Appearance.Options.UseFont = true;
            this.txtPalance.Size = new System.Drawing.Size(427, 26);
            this.txtPalance.TabIndex = 3;
            this.txtPalance.EditValueChanged += new System.EventHandler(this.txtPalance_EditValueChanged);
            // 
            // lPresentationExchangeRate
            // 
            this.lPresentationExchangeRate.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lPresentationExchangeRate.Appearance.Options.UseFont = true;
            this.lPresentationExchangeRate.Location = new System.Drawing.Point(444, 75);
            this.lPresentationExchangeRate.Margin = new System.Windows.Forms.Padding(4);
            this.lPresentationExchangeRate.Name = "lPresentationExchangeRate";
            this.lPresentationExchangeRate.Size = new System.Drawing.Size(119, 19);
            this.lPresentationExchangeRate.TabIndex = 12;
            this.lPresentationExchangeRate.Text = "الحساب الرئيسي";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(444, 38);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(70, 19);
            this.labelControl10.TabIndex = 14;
            this.labelControl10.Text = "رقم السند";
            // 
            // txtArabicWord
            // 
            this.txtArabicWord.Location = new System.Drawing.Point(6, 213);
            this.txtArabicWord.Margin = new System.Windows.Forms.Padding(4);
            this.txtArabicWord.Name = "txtArabicWord";
            this.txtArabicWord.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtArabicWord.Properties.Appearance.Options.UseFont = true;
            this.txtArabicWord.Properties.ReadOnly = true;
            this.txtArabicWord.Size = new System.Drawing.Size(427, 50);
            this.txtArabicWord.TabIndex = 5;
            // 
            // get_PrimaryAccountsTableAdapter
            // 
            this.get_PrimaryAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // get_CashbooksTableAdapter
            // 
            this.get_CashbooksTableAdapter.ClearBeforeFill = true;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 421);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.Name = "frmPayment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سند صرف";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCashbook.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCashbooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSecondaryAcc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPrimaryAcc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPrimaryAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastPalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArabicWord.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.LookUpEdit cmbCashbook;
        private DevExpress.XtraEditors.LookUpEdit cmbSecondaryAcc;
        private DevExpress.XtraEditors.LookUpEdit cmbPrimaryAcc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPalance;
        private DevExpress.XtraEditors.LabelControl lPresentationExchangeRate;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateEdit dtp;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit txtArabicWord;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDetails;
        private DevExpress.XtraEditors.TextEdit txtLastPalance;
        private System.Windows.Forms.Label lblPalance;
        private System.Windows.Forms.TextBox txtArabic;
        private System.Windows.Forms.MaskedTextBox txtArabicPrice;
        private System.Windows.Forms.ComboBox cboCurrency;
        private StoresDataSet storesDataSet;
        private System.Windows.Forms.BindingSource getPrimaryAccountsBindingSource;
        private StoresDataSetTableAdapters.Get_PrimaryAccountsTableAdapter get_PrimaryAccountsTableAdapter;
        private System.Windows.Forms.BindingSource getCashbooksBindingSource;
        private StoresDataSetTableAdapters.Get_CashbooksTableAdapter get_CashbooksTableAdapter;
    }
}