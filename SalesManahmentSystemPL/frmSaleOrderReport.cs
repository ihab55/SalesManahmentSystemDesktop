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
    public partial class frmSaleOrderReport : Form
    {
        private readonly ISaleOrderProductService _saleOrderProductService;

        public frmSaleOrderReport(ISaleOrderProductService saleOrderProductService)
        {
            _saleOrderProductService = saleOrderProductService;
            InitializeComponent();
        }

        private async void btnSearchByDate_Click(object sender, EventArgs e)
        {
            IEnumerable<SalesOrderReadProductDTO> saleOrderProductServiceDTOs = await
                _saleOrderProductService.GetSaleOrderProductByDate(dtpFrom.Value, dtpTo.Value);
            dgrecit.DataSource = saleOrderProductServiceDTOs;
            CaclulateTotalPrice();
        }

        private async void btnSearchByIDorName_Click(object sender, EventArgs e)
        {
            IEnumerable<SalesOrderReadProductDTO> saleOrderProductServiceDTOs;
            if (rbID.Checked)
            {
                saleOrderProductServiceDTOs = await _saleOrderProductService.
                       GetSaleOrderProductByNameOrID<int>(Convert.ToInt32(txtID.Text));
                dgrecit.DataSource = saleOrderProductServiceDTOs;
            }
            else
            {
             saleOrderProductServiceDTOs = await _saleOrderProductService.
                    GetSaleOrderProductByNameOrID<string>(txtCustomerName.Text);
                dgrecit.DataSource = saleOrderProductServiceDTOs;
            }
            CaclulateTotalPrice();
        }
        private void CaclulateTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (DataGridViewRow row in dgrecit.Rows)
            {
                if (row.Cells["cPRODUCTTOTALPRICE"].Value != null)
                {
                    totalPrice += Convert.ToDecimal(row.Cells["cPRODUCTTOTALPRICE"].Value);
                }
            }
            numTotalPrice.Value = totalPrice;
        }

        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            txtID.Enabled = rbID.Checked;
            txtCustomerName.Enabled = !rbID.Checked;
            if (rbID.Checked)
            {
                txtID.Focus();
            }
        }

        private void rbCustomerName_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomerName.Enabled = rbCustomerName.Checked;
            txtID.Enabled = !rbCustomerName.Checked;
            if (rbCustomerName.Checked)
            {
                txtCustomerName.Focus();
            }
        }

        private void frmSaleOrderReport_Load(object sender, EventArgs e)
        {
            txtID.Enabled = rbID.Checked;
            txtCustomerName.Enabled = rbCustomerName.Checked;
        }
    }
}
