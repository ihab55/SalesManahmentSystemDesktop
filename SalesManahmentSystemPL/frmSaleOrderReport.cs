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
    public partial class frmSaleOrderReport : Form
    {
        public frmSaleOrderReport()
        {
            InitializeComponent();
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            IEnumerable<SalesOrderReadProductDTO> saleOrderProductServiceDTOs = 
                SaleOrderProductService.GetSaleOrderProductByDate(dtpFrom.Value, dtpTo.Value);
            dgrecit.DataSource = saleOrderProductServiceDTOs;
            CaclulateTotalPrice();
        }

        private void btnSearchByIDorName_Click(object sender, EventArgs e)
        {
            IEnumerable<SalesOrderReadProductDTO> saleOrderProductServiceDTOs;
            if (rbID.Checked)
            {
                saleOrderProductServiceDTOs = SaleOrderProductService.
                       GetSaleOrderProductByNameOrID<int>(Convert.ToInt32(txtID.Text));
                dgrecit.DataSource = saleOrderProductServiceDTOs;
            }
            else
            {
             saleOrderProductServiceDTOs = SaleOrderProductService.
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
    }
}
