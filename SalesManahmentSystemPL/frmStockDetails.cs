using SalesManahmentSystemBLL.DTOs;
using SalesManahmentSystemBLL.Services;
using SalesManahmentSystemBLL.ServicesInterface;
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
        private readonly IStockService _stockService;
        private readonly IStockDetailsService _stockDetailsService;

        public frmStockDetails(IStockService stockService, IStockDetailsService stockDetailsService)
        {
            _stockService = stockService;
            _stockDetailsService = stockDetailsService;
            InitializeComponent();
        }

        private async void frmStockDetails_Load(object sender, EventArgs e)
        {
            cbStock.DataSource = await _stockService.GetAllBasicStocks();
            cbStock.DisplayMember = "Name";
            cbStock.ValueMember = "ID";
            cbStock.SelectedIndex = -1;

            dgStockDetails.DataSource = await _stockDetailsService.GetAllStockDetails();
        }

        private async void btnAll_Click(object sender, EventArgs e)
        {
            dgStockDetails.DataSource = await _stockDetailsService.GetAllStockDetails();
            CalculateTotal();
        }

        private async void btnSearchByStock_Click(object sender, EventArgs e)
        {
            if (cbStock.SelectedValue != null)
            {
                int stockID = Convert.ToInt32(cbStock.SelectedValue);
                dgStockDetails.DataSource = await _stockDetailsService
                    .GetStockDetailsByStockID(stockID);
                CalculateTotal();
            }
        }

        private async void btnSearchByDate_Click(object sender, EventArgs e)
        {
            dgStockDetails.DataSource = await _stockDetailsService
                .GetStockDetailsByDateRange(dtpFrom.Value, dtpTo.Value);
            CalculateTotal();
        }

        private async void btnSearchByType_Click(object sender, EventArgs e)
        {
            StockDetails.enType type;
            if (rbSale.Checked)
                type = StockDetails.enType.Sale;
            else if (rbPurchase.Checked)
                type = StockDetails.enType.Purchase;
            else
                type = StockDetails.enType.Expense;

            dgStockDetails.DataSource = await _stockDetailsService.GetStockDetailsByType(type);
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
