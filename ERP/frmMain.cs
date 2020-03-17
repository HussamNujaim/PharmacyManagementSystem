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
    }
}