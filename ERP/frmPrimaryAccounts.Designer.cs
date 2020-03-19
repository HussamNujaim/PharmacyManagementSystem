namespace ERP
{
    partial class frmPrimaryAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimaryAccounts));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            this.dgv = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtAddName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lstAddInterfaces = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.lstEditInterfaces = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtEditName = new DevExpress.XtraEditors.TextEdit();
            this.txtEditID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstAddInterfaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstEditInterfaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.DataMember = "Get_PrimaryAccounts";
            this.dgv.DataSource = this.sqlDataSource1;
            this.dgv.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dgv.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.dgv.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dgv.Location = new System.Drawing.Point(408, 1);
            this.dgv.MainView = this.gridView1;
            this.dgv.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(292, 458);
            this.dgv.TabIndex = 7;
            this.dgv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colname});
            this.gridView1.DetailHeight = 748;
            this.gridView1.FixedLineWidth = 4;
            this.gridView1.GridControl = this.dgv;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Controls.Add(this.lstAddInterfaces);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtAddName);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(404, 430);
            this.groupControl1.TabIndex = 8;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(9, 33);
            this.txtAddName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAddName.Properties.Appearance.Options.UseFont = true;
            this.txtAddName.Size = new System.Drawing.Size(213, 26);
            this.txtAddName.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(230, 36);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(155, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "اسم الحساب الرئيسي";
            // 
            // lstAddInterfaces
            // 
            this.lstAddInterfaces.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lstAddInterfaces.Appearance.Options.UseFont = true;
            this.lstAddInterfaces.Location = new System.Drawing.Point(9, 104);
            this.lstAddInterfaces.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstAddInterfaces.Name = "lstAddInterfaces";
            this.lstAddInterfaces.Size = new System.Drawing.Size(356, 267);
            this.lstAddInterfaces.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(163, 75);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(222, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "الواجهات التي يظهر فيها الحساب";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(123, 379);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 46);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.xtraTabControl1.Appearance.Options.UseFont = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(-6, 1);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(412, 492);
            this.xtraTabControl1.TabIndex = 9;
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
            this.xtraTabPage1.Size = new System.Drawing.Size(406, 445);
            this.xtraTabPage1.Text = "إضافة حساب رئيسي";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 11F);
            this.xtraTabPage2.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage2.Controls.Add(this.groupControl2);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(406, 445);
            this.xtraTabPage2.Text = "تعديل حساب رئيسي";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnEdit);
            this.groupControl2.Controls.Add(this.lstEditInterfaces);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txtEditID);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.txtEditName);
            this.groupControl2.Location = new System.Drawing.Point(1, 1);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(404, 429);
            this.groupControl2.TabIndex = 9;
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Enabled = false;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(112, 379);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(148, 46);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "تعديل";
            // 
            // lstEditInterfaces
            // 
            this.lstEditInterfaces.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lstEditInterfaces.Appearance.Options.UseFont = true;
            this.lstEditInterfaces.Location = new System.Drawing.Point(9, 129);
            this.lstEditInterfaces.Margin = new System.Windows.Forms.Padding(4);
            this.lstEditInterfaces.Name = "lstEditInterfaces";
            this.lstEditInterfaces.Size = new System.Drawing.Size(356, 246);
            this.lstEditInterfaces.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(163, 101);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(222, 19);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "الواجهات التي يظهر فيها الحساب";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(230, 69);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(155, 19);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "اسم الحساب الرئيسي";
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(9, 66);
            this.txtEditName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtEditName.Properties.Appearance.Options.UseFont = true;
            this.txtEditName.Size = new System.Drawing.Size(213, 26);
            this.txtEditName.TabIndex = 0;
            // 
            // txtEditID
            // 
            this.txtEditID.Location = new System.Drawing.Point(9, 31);
            this.txtEditID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditID.Name = "txtEditID";
            this.txtEditID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtEditID.Properties.Appearance.Options.UseFont = true;
            this.txtEditID.Properties.ReadOnly = true;
            this.txtEditID.Size = new System.Drawing.Size(284, 26);
            this.txtEditID.TabIndex = 0;
            this.txtEditID.TabStop = false;
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
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "ERP.Properties.Settings.ERP";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "Get_PrimaryAccounts";
            storedProcQuery1.StoredProcName = "Get_PrimaryAccounts";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IkdldF9QcmltYXJ5QWNjb3Vud" +
    "HMiPjxGaWVsZCBOYW1lPSJJZCIgVHlwZT0iSW50MzIiIC8+PEZpZWxkIE5hbWU9Im5hbWUiIFR5cGU9I" +
    "lN0cmluZyIgLz48L1ZpZXc+PC9EYXRhU2V0Pg==";
            // 
            // colId
            // 
            this.colId.Caption = "الرقم";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 112;
            // 
            // colname
            // 
            this.colname.Caption = "اسم الحساب الرئيسي";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 112;
            // 
            // frmPrimaryAccounts
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 535);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrimaryAccounts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الحسابات الرئيسية";
            this.Load += new System.EventHandler(this.frmPrimaryAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstAddInterfaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstEditInterfaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckedListBoxControl lstAddInterfaces;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtAddName;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.CheckedListBoxControl lstEditInterfaces;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtEditID;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtEditName;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
    }
}