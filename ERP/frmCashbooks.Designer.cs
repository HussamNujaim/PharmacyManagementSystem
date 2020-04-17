namespace ERP
{
    partial class frmCashbooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashbooks));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.cmbCurrency = new DevExpress.XtraEditors.LookUpEdit();
            this.txtInitialBalance = new DevExpress.XtraEditors.TextEdit();
            this.chkbxIsMain = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDetails = new DevExpress.XtraEditors.TextEdit();
            this.lPresentationExchangeRate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.storesDataSet = new ERP.StoresDataSet();
            this.getCurrenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_CurrenciesTableAdapter = new ERP.StoresDataSetTableAdapters.Get_CurrenciesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInitialBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkbxIsMain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCurrenciesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Controls.Add(this.cmbCurrency);
            this.groupControl1.Controls.Add(this.txtInitialBalance);
            this.groupControl1.Controls.Add(this.chkbxIsMain);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtDetails);
            this.groupControl1.Controls.Add(this.lPresentationExchangeRate);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Location = new System.Drawing.Point(5, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(467, 260);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "بيانات الصندوق";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(128, 208);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 46);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.Location = new System.Drawing.Point(28, 107);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbCurrency.Properties.Appearance.Options.UseFont = true;
            this.cmbCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCurrency.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 25, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbCurrency.Properties.DataSource = this.getCurrenciesBindingSource;
            this.cmbCurrency.Properties.DisplayMember = "name";
            this.cmbCurrency.Properties.NullText = "";
            this.cmbCurrency.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbCurrency.Properties.ShowFooter = false;
            this.cmbCurrency.Properties.ShowHeader = false;
            this.cmbCurrency.Properties.ShowLines = false;
            this.cmbCurrency.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbCurrency.Properties.ValueMember = "Id";
            this.cmbCurrency.Size = new System.Drawing.Size(297, 26);
            this.cmbCurrency.TabIndex = 2;
            // 
            // txtInitialBalance
            // 
            this.txtInitialBalance.Location = new System.Drawing.Point(28, 141);
            this.txtInitialBalance.Margin = new System.Windows.Forms.Padding(4);
            this.txtInitialBalance.Name = "txtInitialBalance";
            this.txtInitialBalance.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtInitialBalance.Properties.Appearance.Options.UseFont = true;
            this.txtInitialBalance.Size = new System.Drawing.Size(298, 26);
            this.txtInitialBalance.TabIndex = 3;
            // 
            // chkbxIsMain
            // 
            this.chkbxIsMain.Location = new System.Drawing.Point(299, 180);
            this.chkbxIsMain.Name = "chkbxIsMain";
            this.chkbxIsMain.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkbxIsMain.Properties.Appearance.Options.UseFont = true;
            this.chkbxIsMain.Properties.Caption = "";
            this.chkbxIsMain.Size = new System.Drawing.Size(27, 19);
            this.chkbxIsMain.TabIndex = 4;
            this.chkbxIsMain.CheckedChanged += new System.EventHandler(this.chkbxIsMain_CheckedChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(333, 179);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(121, 19);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "الصندوق الرئيسي";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(336, 75);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 19);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "التفاصيل";
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
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(334, 144);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(113, 19);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "الرصيد الافتتاحي";
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(27, 72);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtDetails.Properties.Appearance.Options.UseFont = true;
            this.txtDetails.Size = new System.Drawing.Size(298, 26);
            this.txtDetails.TabIndex = 1;
            // 
            // lPresentationExchangeRate
            // 
            this.lPresentationExchangeRate.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lPresentationExchangeRate.Appearance.Options.UseFont = true;
            this.lPresentationExchangeRate.Location = new System.Drawing.Point(336, 110);
            this.lPresentationExchangeRate.Margin = new System.Windows.Forms.Padding(4);
            this.lPresentationExchangeRate.Name = "lPresentationExchangeRate";
            this.lPresentationExchangeRate.Size = new System.Drawing.Size(42, 19);
            this.lPresentationExchangeRate.TabIndex = 12;
            this.lPresentationExchangeRate.Text = "العملة";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(336, 41);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(93, 19);
            this.labelControl10.TabIndex = 14;
            this.labelControl10.Text = "اسم الصندوق";
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
            this.dgv.GridColor = System.Drawing.SystemColors.Control;
            this.dgv.Location = new System.Drawing.Point(5, 278);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
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
            this.dgv.Size = new System.Drawing.Size(467, 220);
            this.dgv.StandardTab = true;
            this.dgv.TabIndex = 1;
            // 
            // storesDataSet
            // 
            this.storesDataSet.DataSetName = "StoresDataSet";
            this.storesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // frmCashbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 510);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.Name = "frmCashbooks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الصناديق";
            this.Load += new System.EventHandler(this.frmCashbooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInitialBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkbxIsMain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCurrenciesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtInitialBalance;
        private DevExpress.XtraEditors.CheckEdit chkbxIsMain;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDetails;
        private DevExpress.XtraEditors.LabelControl lPresentationExchangeRate;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LookUpEdit cmbCurrency;
        private System.Windows.Forms.DataGridView dgv;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private StoresDataSet storesDataSet;
        private System.Windows.Forms.BindingSource getCurrenciesBindingSource;
        private StoresDataSetTableAdapters.Get_CurrenciesTableAdapter get_CurrenciesTableAdapter;
    }
}