using SalesManahmentSystemBLL.DTOs;
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
    public partial class frmStockDetails : Form
    {
        public frmStockDetails()
        {
            InitializeComponent();
        }

        private void frmStockDetails_Load(object sender, EventArgs e)
        {
            cbStock.DataSource = StockService.GetAllStocks();
            cbStock.DisplayMember = "Name";
            cbStock.ValueMember = "ID";
            cbStock.SelectedIndex = -1;

            dgStockDetails.DataSource = StockDetailsService.GetAllStockDetails();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            dgStockDetails.DataSource = StockDetailsService.GetAllStockDetails();
            CalculateTotal();
        }

        private void btnSearchByStock_Click(object sender, EventArgs e)
        {
            if (cbStock.SelectedValue != null)
            {
                int stockID = Convert.ToInt32(cbStock.SelectedValue);
                dgStockDetails.DataSource = StockDetailsService.GetStockDetailsByStockID(stockID);
                CalculateTotal();
            }
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            dgStockDetails.DataSource = StockDetailsService.GetStockDetailsByDateRange(dtpFrom.Value, dtpTo.Value);
            CalculateTotal();
        }

        private void btnSearchByType_Click(object sender, EventArgs e)
        {
            StockDetails.enType type;
            if (rbSale.Checked)
                type = StockDetails.enType.Sale;
            else if (rbPurchase.Checked)
                type = StockDetails.enType.Purchase;
            else
                type = StockDetails.enType.Expense;

            dgStockDetails.DataSource = StockDetailsService.GetStockDetailsByType(type);
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgStockDetails.Rows)
            {
                if (row.Cells["cTOTAL"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["cTOTAL"].Value);
                }
            }
            numTotal.Value = total;
        }

        private void dgStockDetails_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgStockDetails.Rows[e.RowIndex].Cells["cID"].Value?.ToString();
                txtOrderID.Text = dgStockDetails.Rows[e.RowIndex].Cells["cORDERID"].Value?.ToString();
            }
        }
    }
}
