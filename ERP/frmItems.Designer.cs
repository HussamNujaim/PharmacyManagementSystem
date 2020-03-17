namespace ERP
{
    partial class frmItems
    {
        /// <summary>
        /// Required designer variaPresentatione.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItems));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pnlItemAdd = new DevExpress.XtraEditors.PanelControl();
            this.imgBarcode = new DevExpress.XtraEditors.PictureEdit();
            this.btnBarcodeGenerate = new DevExpress.XtraEditors.SimpleButton();
            this.cmbCurrency = new DevExpress.XtraEditors.LookUpEdit();
            this.getCurrenciesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storesDataSet = new ERP.StoresDataSet();
            this.txtBarcode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtItemName = new DevExpress.XtraEditors.TextEdit();
            this.txtItemDetails = new DevExpress.XtraEditors.TextEdit();
            this.dgvUnits = new System.Windows.Forms.DataGridView();
            this.txtItemPosition = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtItemUnitsCount = new DevExpress.XtraEditors.TextEdit();
            this.txtPurchasePrice = new DevExpress.XtraEditors.TextEdit();
            this.txtSalePrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnEditUnit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteUnit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddUnit = new DevExpress.XtraEditors.SimpleButton();
            this.dgvUnitsDisplay = new System.Windows.Forms.DataGridView();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtUnitName = new DevExpress.XtraEditors.TextEdit();
            this.getCurrenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_CurrenciesTableAdapter = new ERP.StoresDataSetTableAdapters.Get_CurrenciesTableAdapter();
            this.UnitName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UnitCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlItemAdd)).BeginInit();
            this.pnlItemAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCurrenciesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemUnitsCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchasePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitsDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCurrenciesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.RightToLeftLayout = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(716, 560);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xtraTabPage1.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(710, 526);
            this.xtraTabPage1.Text = "إضافة صنف جديد";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.pnlItemAdd);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(710, 526);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "بيانات الصنف";
            // 
            // pnlItemAdd
            // 
            this.pnlItemAdd.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlItemAdd.Controls.Add(this.imgBarcode);
            this.pnlItemAdd.Controls.Add(this.btnBarcodeGenerate);
            this.pnlItemAdd.Controls.Add(this.cmbCurrency);
            this.pnlItemAdd.Controls.Add(this.txtBarcode);
            this.pnlItemAdd.Controls.Add(this.labelControl10);
            this.pnlItemAdd.Controls.Add(this.txtItemName);
            this.pnlItemAdd.Controls.Add(this.txtItemDetails);
            this.pnlItemAdd.Controls.Add(this.dgvUnits);
            this.pnlItemAdd.Controls.Add(this.txtItemPosition);
            this.pnlItemAdd.Controls.Add(this.labelControl8);
            this.pnlItemAdd.Controls.Add(this.txtItemUnitsCount);
            this.pnlItemAdd.Controls.Add(this.txtPurchasePrice);
            this.pnlItemAdd.Controls.Add(this.txtSalePrice);
            this.pnlItemAdd.Controls.Add(this.labelControl7);
            this.pnlItemAdd.Controls.Add(this.labelControl1);
            this.pnlItemAdd.Controls.Add(this.labelControl6);
            this.pnlItemAdd.Controls.Add(this.labelControl2);
            this.pnlItemAdd.Controls.Add(this.labelControl4);
            this.pnlItemAdd.Controls.Add(this.labelControl3);
            this.pnlItemAdd.Controls.Add(this.labelControl5);
            this.pnlItemAdd.Location = new System.Drawing.Point(5, 30);
            this.pnlItemAdd.Name = "pnlItemAdd";
            this.pnlItemAdd.Size = new System.Drawing.Size(698, 431);
            this.pnlItemAdd.TabIndex = 0;
            // 
            // imgBarcode
            // 
            this.imgBarcode.Location = new System.Drawing.Point(6, 12);
            this.imgBarcode.Name = "imgBarcode";
            this.imgBarcode.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.imgBarcode.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.imgBarcode.Size = new System.Drawing.Size(172, 32);
            this.imgBarcode.TabIndex = 12;
            // 
            // btnBarcodeGenerate
            // 
            this.btnBarcodeGenerate.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnBarcodeGenerate.Appearance.Options.UseFont = true;
            this.btnBarcodeGenerate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarcodeGenerate.ImageOptions.Image")));
            this.btnBarcodeGenerate.Location = new System.Drawing.Point(185, 12);
            this.btnBarcodeGenerate.Name = "btnBarcodeGenerate";
            this.btnBarcodeGenerate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBarcodeGenerate.Size = new System.Drawing.Size(95, 32);
            this.btnBarcodeGenerate.TabIndex = 0;
            this.btnBarcodeGenerate.TabStop = false;
            this.btnBarcodeGenerate.Text = "باركود";
            this.btnBarcodeGenerate.Click += new System.EventHandler(this.btnBarcodeGenerate_Click);
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.Location = new System.Drawing.Point(6, 393);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbCurrency.Properties.Appearance.Options.UseFont = true;
            this.cmbCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCurrency.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 25, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbCurrency.Properties.DataSource = this.getCurrenciesBindingSource1;
            this.cmbCurrency.Properties.DisplayMember = "name";
            this.cmbCurrency.Properties.NullText = "";
            this.cmbCurrency.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbCurrency.Properties.ShowFooter = false;
            this.cmbCurrency.Properties.ShowHeader = false;
            this.cmbCurrency.Properties.ShowLines = false;
            this.cmbCurrency.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbCurrency.Properties.ValueMember = "Id";
            this.cmbCurrency.Size = new System.Drawing.Size(510, 26);
            this.cmbCurrency.TabIndex = 11;
            // 
            // getCurrenciesBindingSource1
            // 
            this.getCurrenciesBindingSource1.DataMember = "Get_Currencies";
            this.getCurrenciesBindingSource1.DataSource = this.storesDataSet;
            // 
            // storesDataSet
            // 
            this.storesDataSet.DataSetName = "StoresDataSet";
            this.storesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(286, 16);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBarcode.Properties.Appearance.Options.UseFont = true;
            this.txtBarcode.Properties.ReadOnly = true;
            this.txtBarcode.Size = new System.Drawing.Size(230, 26);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.TabStop = false;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(522, 19);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(48, 19);
            this.labelControl10.TabIndex = 10;
            this.labelControl10.Text = "الباركود";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(6, 48);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtItemName.Properties.Appearance.Options.UseFont = true;
            this.txtItemName.Size = new System.Drawing.Size(510, 26);
            this.txtItemName.TabIndex = 2;
            // 
            // txtItemDetails
            // 
            this.txtItemDetails.Location = new System.Drawing.Point(6, 80);
            this.txtItemDetails.Name = "txtItemDetails";
            this.txtItemDetails.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtItemDetails.Properties.Appearance.Options.UseFont = true;
            this.txtItemDetails.Size = new System.Drawing.Size(510, 26);
            this.txtItemDetails.TabIndex = 3;
            // 
            // dgvUnits
            // 
            this.dgvUnits.AllowUserToAddRows = false;
            this.dgvUnits.AllowUserToDeleteRows = false;
            this.dgvUnits.AllowUserToResizeColumns = false;
            this.dgvUnits.AllowUserToResizeRows = false;
            this.dgvUnits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnits.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUnits.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UnitName,
            this.UnitCount,
            this.initialQty});
            this.dgvUnits.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvUnits.Location = new System.Drawing.Point(6, 176);
            this.dgvUnits.Name = "dgvUnits";
            this.dgvUnits.RowHeadersVisible = false;
            this.dgvUnits.Size = new System.Drawing.Size(510, 146);
            this.dgvUnits.TabIndex = 6;
            // 
            // txtItemPosition
            // 
            this.txtItemPosition.Location = new System.Drawing.Point(6, 112);
            this.txtItemPosition.Name = "txtItemPosition";
            this.txtItemPosition.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtItemPosition.Properties.Appearance.Options.UseFont = true;
            this.txtItemPosition.Size = new System.Drawing.Size(510, 26);
            this.txtItemPosition.TabIndex = 4;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(522, 176);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(53, 19);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "الوحدات";
            // 
            // txtItemUnitsCount
            // 
            this.txtItemUnitsCount.Location = new System.Drawing.Point(6, 144);
            this.txtItemUnitsCount.Name = "txtItemUnitsCount";
            this.txtItemUnitsCount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtItemUnitsCount.Properties.Appearance.Options.UseFont = true;
            this.txtItemUnitsCount.Properties.Mask.BeepOnError = true;
            this.txtItemUnitsCount.Properties.Mask.EditMask = "f0";
            this.txtItemUnitsCount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtItemUnitsCount.Size = new System.Drawing.Size(510, 26);
            this.txtItemUnitsCount.TabIndex = 5;
            this.txtItemUnitsCount.EditValueChanged += new System.EventHandler(this.txtItemUnitsCount_EditValueChanged);
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(6, 328);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPurchasePrice.Properties.Appearance.Options.UseFont = true;
            this.txtPurchasePrice.Size = new System.Drawing.Size(510, 26);
            this.txtPurchasePrice.TabIndex = 7;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(6, 360);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtSalePrice.Properties.Appearance.Options.UseFont = true;
            this.txtSalePrice.Size = new System.Drawing.Size(510, 26);
            this.txtSalePrice.TabIndex = 8;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(522, 396);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 19);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "العملة";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(522, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "اسم الصنف";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(522, 363);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(157, 19);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "سعر البيع للوحدة الأكبر";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(522, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "التفاصيل";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(522, 147);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(83, 19);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "عدد الوحدات";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(522, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 19);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "الرف";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(522, 331);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(170, 19);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "سعر الشراء للوحدة الأكبر";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Location = new System.Drawing.Point(22, 461);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(416, 57);
            this.panelControl1.TabIndex = 1;
            this.panelControl1.TabStop = true;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(120, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSave.Size = new System.Drawing.Size(157, 46);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xtraTabPage2.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(710, 526);
            this.xtraTabPage2.Text = "تعديل صنف";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xtraTabPage3.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage3.Controls.Add(this.groupControl2);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(710, 526);
            this.xtraTabPage3.Text = "وحدات الأصناف";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.btnEditUnit);
            this.groupControl2.Controls.Add(this.btnDeleteUnit);
            this.groupControl2.Controls.Add(this.btnAddUnit);
            this.groupControl2.Controls.Add(this.dgvUnitsDisplay);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.labelControl16);
            this.groupControl2.Controls.Add(this.txtUnitName);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(710, 526);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "وحدات الأصناف";
            // 
            // btnEditUnit
            // 
            this.btnEditUnit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnEditUnit.Appearance.Options.UseFont = true;
            this.btnEditUnit.Location = new System.Drawing.Point(303, 420);
            this.btnEditUnit.Name = "btnEditUnit";
            this.btnEditUnit.Size = new System.Drawing.Size(190, 38);
            this.btnEditUnit.TabIndex = 1;
            this.btnEditUnit.Text = "تعديل الوحدة المحددة";
            // 
            // btnDeleteUnit
            // 
            this.btnDeleteUnit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnDeleteUnit.Appearance.Options.UseFont = true;
            this.btnDeleteUnit.Location = new System.Drawing.Point(102, 420);
            this.btnDeleteUnit.Name = "btnDeleteUnit";
            this.btnDeleteUnit.Size = new System.Drawing.Size(190, 38);
            this.btnDeleteUnit.TabIndex = 1;
            this.btnDeleteUnit.Text = "حذف الوحدة المحددة";
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddUnit.Appearance.Options.UseFont = true;
            this.btnAddUnit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUnit.ImageOptions.Image")));
            this.btnAddUnit.Location = new System.Drawing.Point(102, 76);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(115, 38);
            this.btnAddUnit.TabIndex = 1;
            this.btnAddUnit.Text = "إضافة";
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // dgvUnitsDisplay
            // 
            this.dgvUnitsDisplay.AllowUserToAddRows = false;
            this.dgvUnitsDisplay.AllowUserToDeleteRows = false;
            this.dgvUnitsDisplay.AllowUserToResizeColumns = false;
            this.dgvUnitsDisplay.AllowUserToResizeRows = false;
            this.dgvUnitsDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnitsDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUnitsDisplay.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvUnitsDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnitsDisplay.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvUnitsDisplay.Location = new System.Drawing.Point(102, 140);
            this.dgvUnitsDisplay.Name = "dgvUnitsDisplay";
            this.dgvUnitsDisplay.RowHeadersVisible = false;
            this.dgvUnitsDisplay.Size = new System.Drawing.Size(391, 256);
            this.dgvUnitsDisplay.TabIndex = 8;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(499, 140);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(53, 19);
            this.labelControl9.TabIndex = 4;
            this.labelControl9.Text = "الوحدات";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(499, 86);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(80, 19);
            this.labelControl16.TabIndex = 1;
            this.labelControl16.Text = "اسم الوحدة";
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(223, 83);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtUnitName.Properties.Appearance.Options.UseFont = true;
            this.txtUnitName.Size = new System.Drawing.Size(270, 26);
            this.txtUnitName.TabIndex = 0;
            // 
            // getCurrenciesBindingSource
            // 
            this.getCurrenciesBindingSource.DataMember = "Get_Currencies";
            this.getCurrenciesBindingSource.DataSource = this.storesDataSet;
            // 
            // get_CurrenciesTableAdapter
            // 
            this.get_CurrenciesTableAdapter.ClearBeforeFill = true;
            // 
            // UnitName
            // 
            this.UnitName.AutoComplete = false;
            this.UnitName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.UnitName.DisplayStyleForCurrentCellOnly = true;
            this.UnitName.HeaderText = "اسم الوحدة";
            this.UnitName.Name = "UnitName";
            // 
            // UnitCount
            // 
            this.UnitCount.HeaderText = "العبوة من الوحدة الأدنى";
            this.UnitCount.Name = "UnitCount";
            // 
            // initialQty
            // 
            this.initialQty.HeaderText = "الكمية الإفتتاحية";
            this.initialQty.Name = "initialQty";
            // 
            // frmItems
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 560);
            this.Controls.Add(this.xtraTabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmItems";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الأصناف";
            this.Load += new System.EventHandler(this.frmItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlItemAdd)).EndInit();
            this.pnlItemAdd.ResumeLayout(false);
            this.pnlItemAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCurrenciesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemDetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemUnitsCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchasePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitsDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCurrenciesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSalePrice;
        private DevExpress.XtraEditors.TextEdit txtPurchasePrice;
        private DevExpress.XtraEditors.TextEdit txtItemUnitsCount;
        private DevExpress.XtraEditors.TextEdit txtItemPosition;
        private DevExpress.XtraEditors.TextEdit txtItemDetails;
        private DevExpress.XtraEditors.TextEdit txtItemName;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.DataGridView dgvUnits;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnAddUnit;
        private System.Windows.Forms.DataGridView dgvUnitsDisplay;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit txtUnitName;
        private DevExpress.XtraEditors.SimpleButton btnEditUnit;
        private DevExpress.XtraEditors.SimpleButton btnDeleteUnit;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtBarcode;
        private DevExpress.XtraEditors.PanelControl pnlItemAdd;
        private DevExpress.XtraEditors.LookUpEdit cmbCurrency;
        private StoresDataSet storesDataSet;
        private System.Windows.Forms.BindingSource getCurrenciesBindingSource;
        private StoresDataSetTableAdapters.Get_CurrenciesTableAdapter get_CurrenciesTableAdapter;
        private System.Windows.Forms.BindingSource getCurrenciesBindingSource1;
        private DevExpress.XtraEditors.PictureEdit imgBarcode;
        private DevExpress.XtraEditors.SimpleButton btnBarcodeGenerate;
        private System.Windows.Forms.DataGridViewComboBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialQty;
    }
}