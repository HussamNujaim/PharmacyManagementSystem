namespace ERP
{
    partial class frmCurrency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurrency));
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.txtSymbol = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lPresentationExchangeRate = new DevExpress.XtraEditors.LabelControl();
            this.txtExchangeRate = new DevExpress.XtraEditors.TextEdit();
            this.chkbxIsMain = new DevExpress.XtraEditors.CheckEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dgv = new DevExpress.XtraGrid.GridControl();
            this.getCurrenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storesDataSet = new ERP.StoresDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsMain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExchangeRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkbxAdd = new DevExpress.XtraEditors.CheckButton();
            this.chkbtnEdit = new DevExpress.XtraEditors.CheckButton();
            this.lPresentationEdit = new DevExpress.XtraEditors.LabelControl();
            this.get_CurrenciesTableAdapter = new ERP.StoresDataSetTableAdapters.Get_CurrenciesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txtSymbol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkbxIsMain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCurrenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Enabled = false;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(304, 269);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(148, 46);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "تعديل";
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(27, 72);
            this.txtSymbol.Margin = new System.Windows.Forms.Padding(4);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtSymbol.Properties.Appearance.Options.UseFont = true;
            this.txtSymbol.Size = new System.Drawing.Size(298, 26);
            this.txtSymbol.TabIndex = 1;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(336, 41);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(78, 19);
            this.labelControl10.TabIndex = 14;
            this.labelControl10.Text = "اسم العملة";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(27, 38);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(298, 26);
            this.txtName.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(336, 75);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 19);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "الرمز";
            // 
            // lPresentationExchangeRate
            // 
            this.lPresentationExchangeRate.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lPresentationExchangeRate.Appearance.Options.UseFont = true;
            this.lPresentationExchangeRate.Location = new System.Drawing.Point(331, 141);
            this.lPresentationExchangeRate.Margin = new System.Windows.Forms.Padding(4);
            this.lPresentationExchangeRate.Name = "lPresentationExchangeRate";
            this.lPresentationExchangeRate.Size = new System.Drawing.Size(120, 38);
            this.lPresentationExchangeRate.TabIndex = 12;
            this.lPresentationExchangeRate.Text = "سعر الصرف مقابل\r\n العملة الرئيسية";
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.Location = new System.Drawing.Point(27, 153);
            this.txtExchangeRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtExchangeRate.Properties.Appearance.Options.UseFont = true;
            this.txtExchangeRate.Size = new System.Drawing.Size(298, 26);
            this.txtExchangeRate.TabIndex = 3;
            // 
            // chkbxIsMain
            // 
            this.chkbxIsMain.Location = new System.Drawing.Point(299, 114);
            this.chkbxIsMain.Name = "chkbxIsMain";
            this.chkbxIsMain.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkbxIsMain.Properties.Appearance.Options.UseFont = true;
            this.chkbxIsMain.Properties.Caption = "";
            this.chkbxIsMain.Size = new System.Drawing.Size(27, 19);
            this.chkbxIsMain.TabIndex = 2;
            this.chkbxIsMain.CheckedChanged += new System.EventHandler(this.chkbxIsMain_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(154, 269);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 46);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.txtExchangeRate);
            this.groupControl1.Controls.Add(this.chkbxIsMain);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.txtSymbol);
            this.groupControl1.Controls.Add(this.lPresentationExchangeRate);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Location = new System.Drawing.Point(12, 67);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(467, 190);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "بيانات العملة";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(336, 114);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(105, 19);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "العملة الرئيسية";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgv);
            this.panelControl1.Location = new System.Drawing.Point(1, 322);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(488, 189);
            this.panelControl1.TabIndex = 17;
            // 
            // dgv
            // 
            this.dgv.DataSource = this.getCurrenciesBindingSource;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dgv.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.dgv.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dgv.Location = new System.Drawing.Point(2, 2);
            this.dgv.MainView = this.gridView1;
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(484, 185);
            this.dgv.TabIndex = 5;
            this.dgv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // getCurrenciesBindingSource
            // 
            this.getCurrenciesBindingSource.DataMember = "Get_Currencies";
            this.getCurrenciesBindingSource.DataSource = this.storesDataSet;
            // 
            // storesDataSet
            // 
            this.storesDataSet.DataSetName = "StoresDataSet";
            this.storesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname,
            this.colIsMain,
            this.colExchangeRate,
            this.gridColumn1});
            this.gridView1.DetailHeight = 512;
            this.gridView1.FixedLineWidth = 3;
            this.gridView1.GridControl = this.dgv;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colname
            // 
            this.colname.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colname.AppearanceCell.Options.UseFont = true;
            this.colname.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colname.AppearanceHeader.Options.UseFont = true;
            this.colname.Caption = "اسم العملة";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            // 
            // colIsMain
            // 
            this.colIsMain.Caption = "نوع العملة";
            this.colIsMain.FieldName = "IsMain";
            this.colIsMain.Name = "colIsMain";
            // 
            // colExchangeRate
            // 
            this.colExchangeRate.FieldName = "ExchangeRate";
            this.colExchangeRate.Name = "colExchangeRate";
            this.colExchangeRate.ShowUnboundExpressionMenu = true;
            this.colExchangeRate.UnboundExpression = "2";
            this.colExchangeRate.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "سعر الصرف";
            this.gridColumn1.FieldName = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundExpression = "Round([ExchangeRate], 2)";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // chkbxAdd
            // 
            this.chkbxAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkbxAdd.Appearance.Options.UseFont = true;
            this.chkbxAdd.Checked = true;
            this.chkbxAdd.GroupIndex = 1;
            this.chkbxAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chkbxAdd.ImageOptions.Image")));
            this.chkbxAdd.Location = new System.Drawing.Point(12, 12);
            this.chkbxAdd.Name = "chkbxAdd";
            this.chkbxAdd.Size = new System.Drawing.Size(158, 46);
            this.chkbxAdd.TabIndex = 0;
            this.chkbxAdd.Text = "إضافة";
            this.chkbxAdd.CheckedChanged += new System.EventHandler(this.chkbxAdd_CheckedChanged);
            this.chkbxAdd.Click += new System.EventHandler(this.chkbxAdd_Click);
            // 
            // chkbtnEdit
            // 
            this.chkbtnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkbtnEdit.Appearance.Options.UseFont = true;
            this.chkbtnEdit.GroupIndex = 1;
            this.chkbtnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chkbtnEdit.ImageOptions.Image")));
            this.chkbtnEdit.Location = new System.Drawing.Point(176, 12);
            this.chkbtnEdit.Name = "chkbtnEdit";
            this.chkbtnEdit.Size = new System.Drawing.Size(158, 46);
            this.chkbtnEdit.TabIndex = 1;
            this.chkbtnEdit.TabStop = false;
            this.chkbtnEdit.Text = "تعديل";
            this.chkbtnEdit.CheckedChanged += new System.EventHandler(this.chkbtnEdit_CheckedChanged);
            this.chkbtnEdit.Click += new System.EventHandler(this.chkbtnEdit_Click);
            // 
            // lPresentationEdit
            // 
            this.lPresentationEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lPresentationEdit.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lPresentationEdit.Appearance.Options.UseFont = true;
            this.lPresentationEdit.Appearance.Options.UseForeColor = true;
            this.lPresentationEdit.Location = new System.Drawing.Point(342, 22);
            this.lPresentationEdit.Margin = new System.Windows.Forms.Padding(4);
            this.lPresentationEdit.Name = "lPresentationEdit";
            this.lPresentationEdit.Size = new System.Drawing.Size(149, 39);
            this.lPresentationEdit.TabIndex = 14;
            this.lPresentationEdit.Text = "* قم باختيار العملة التي ترغب * \r\n بتعديلها من الجدول الأسفل\r\n\r\n";
            this.lPresentationEdit.Visible = false;
            // 
            // get_CurrenciesTableAdapter
            // 
            this.get_CurrenciesTableAdapter.ClearBeforeFill = true;
            // 
            // frmCurrency
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 512);
            this.Controls.Add(this.chkbtnEdit);
            this.Controls.Add(this.chkbxAdd);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lPresentationEdit);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCurrency";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة العملات";
            this.Load += new System.EventHandler(this.frmCurrency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSymbol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkbxIsMain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCurrenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.TextEdit txtSymbol;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lPresentationExchangeRate;
        private DevExpress.XtraEditors.TextEdit txtExchangeRate;
        private DevExpress.XtraEditors.CheckEdit chkbxIsMain;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl dgv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.CheckButton chkbxAdd;
        private DevExpress.XtraEditors.CheckButton chkbtnEdit;
        private DevExpress.XtraEditors.LabelControl lPresentationEdit;
        private StoresDataSet storesDataSet;
        private System.Windows.Forms.BindingSource getCurrenciesBindingSource;
        private StoresDataSetTableAdapters.Get_CurrenciesTableAdapter get_CurrenciesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colIsMain;
        private DevExpress.XtraGrid.Columns.GridColumn colExchangeRate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}