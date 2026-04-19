using SalesManahmentSystemBLL.Services;
using SalesManahmentSystemDAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesManahmentSystemPL
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCatagoreys_Click(object sender, EventArgs e)
        {
            OpenForm(new frmCatagory());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenForm(new frmProduct());
        }

        private void btnSaleOrder_Click(object sender, EventArgs e)
        {
            OpenForm(new frmSaleOrder());
        }

        private void btnSaleOrderReport_Click(object sender, EventArgs e)
        {
            OpenForm(new frmSaleOrderReport());
        }
        private void OpenForm(Form frm)
        {
            frm.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            OpenForm(new frmStock());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenForm(new frmCustomer());
        }

        private void btnStockDetails_Click(object sender, EventArgs e)
        {
            OpenForm(new frmStockDetails());
        }
    }
}
