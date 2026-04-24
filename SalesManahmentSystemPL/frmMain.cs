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
            var categoryService = new CategoryService();
            OpenForm(new frmCatagory(categoryService));
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            var productService = new ProductService();
            var categoryService = new CategoryService();
            OpenForm(new frmProduct(productService, categoryService));
        }

        private void btnSaleOrder_Click(object sender, EventArgs e)
        {
            var productService = new ProductService();
            var customerService = new CustomerService();
            var saleOrderService = new SaleOrderService();
            var stockService = new StockService();
            OpenForm(new frmSaleOrder(productService, customerService, saleOrderService, stockService));
        }

        private void btnSaleOrderReport_Click(object sender, EventArgs e)
        {
            var saleOrderProductService = new SaleOrderProductService();
            OpenForm(new frmSaleOrderReport(saleOrderProductService));
        }
        private void OpenForm(Form frm)
        {
            frm.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            var stockService = new StockService();
            OpenForm(new frmStock(stockService));
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var customerService = new CustomerService();
            OpenForm(new frmCustomer(customerService));
        }

        private void btnStockDetails_Click(object sender, EventArgs e)
        {
            var stockService = new StockService();
            var stockDetailsService = new StockDetailsService();
            OpenForm(new frmStockDetails(stockService, stockDetailsService));
        }
    }
}
