using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace ERP
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnItems_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmItems frm = new frmItems();
            frm.ShowInTaskbar = true;
            frm.Show();
        }

        private void btnDeposition_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDeposition frm = new frmDeposition();
            frm.Show();
        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPrimaryAccounts frm = new frmPrimaryAccounts();
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAccounts_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAccounts frm = new frmAccounts();
            frm.Show();
        }

        private void btnCurrencies_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCurrency frm = new frmCurrency();
            frm.Show();
        }

        private void btnCashbooks_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCashbooks frm = new frmCashbooks();
            frm.Show();
        }

        private void btnPayment_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPayment frm = new frmPayment();
            frm.Show();
        }

        private void btnStores_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStores frm = new frmStores();
            frm.Show();
        }
    }
}