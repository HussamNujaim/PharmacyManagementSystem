﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ERP
{
    public partial class frmPrimaryAccounts : DevExpress.XtraEditors.XtraForm
    {
        Presentation.CLS_Accounts acc = new Presentation.CLS_Accounts();
        public frmPrimaryAccounts()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            //sqlDataSource1.Fill();
        }

        private void frmPrimaryAccounts_Load(object sender, EventArgs e)
        {
            lstAddInterfaces.DataSource = acc.Get_Interfaces();
            lstAddInterfaces.DisplayMember = "name";
            lstAddInterfaces.ValueMember = "Id";
            lstEditInterfaces.DataSource = acc.Get_Interfaces();
            lstEditInterfaces.DisplayMember = "name";
            lstEditInterfaces.ValueMember = "Id";
            lstAddInterfaces.UnCheckAll();
            lstEditInterfaces.UnCheckAll();
            //
            dgv.DataSource = acc.Get_PrimaryAccounts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var lst = lstAddInterfaces.CheckedItems.Cast<DataRowView>();
            if (txtAddName.Text != "" && lstAddInterfaces.SelectedItems.Count > 0)
            {
                int[] interfaces = new int[lstAddInterfaces.SelectedItems.Count];
                int i = 0;
                foreach (var item in lst)
                {
                    interfaces[i++] = int.Parse(item.Row[0].ToString());
                }
                acc.Add_PrimaryAccount(txtAddName.Text, interfaces);
                txtAddName.Text = "";
                lstAddInterfaces.UnCheckAll();
                //sqlDataSource1.Fill();
                dgv.DataSource = acc.Get_PrimaryAccounts();

            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable dt = acc.Get_PrimaryAccount(dgv.SelectedRows[0].Cells[0].Value.ToString());
                txtEditID.Text = dt.Rows[0][0].ToString();
                txtEditName.Text = dt.Rows[0][1].ToString();
                dt = acc.Get_pAccountInterface(txtEditID.Text);
                lstEditInterfaces.UnCheckAll();
                for (int j=0; j<lstEditInterfaces.ItemCount;j++)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (int.Parse(lstEditInterfaces.GetItemValue(j).ToString()) == int.Parse(dt.Rows[i][0].ToString()))
                        {
                            lstEditInterfaces.SetItemChecked(j,true);
                            break;
                        }
                    }
                }
            }
            catch { }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var lst = lstEditInterfaces.SelectedItems.Cast<DataRowView>();
            if (txtEditID.Text != "" && txtEditName.Text != "" && lstEditInterfaces.SelectedItems.Count > 0)
            {
                int[] interfaces = new int[lstEditInterfaces.SelectedItems.Count];
                int i = 0;
                foreach (var item in lst)
                {
                    interfaces[i++] = int.Parse(item.Row[0].ToString());
                }
                acc.Edit_PrimaryAccount(txtEditID.Text, txtEditName.Text, interfaces);
                txtEditID.Text = "";
                txtEditName.Text = "";
                lstEditInterfaces.UnCheckAll();
                dgv.DataSource = null;
                dgv.DataSource = acc.Get_PrimaryAccounts();
                dgv.ClearSelection();

            }
        }
    }
}