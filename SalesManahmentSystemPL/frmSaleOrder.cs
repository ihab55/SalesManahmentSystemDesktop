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
    public partial class frmSaleOrder : Form
    {
        public frmSaleOrder()
        {
            InitializeComponent();
        }

        private void frmSaleOrder_Load(object sender, EventArgs e)
        {
            cbProducts.DataSource = ProductService.GetAllBasicProducts();
            cbProducts.DisplayMember = "Name";
            cbProducts.ValueMember = "ID";

            cbCutomers.DataSource = CustomerService.GetAllBasicCustomers();
            cbCutomers.DisplayMember = "Name";
            cbCutomers.ValueMember = "ID";

            txtID.Text = (SaleOrderService.GetLastID() + 1).ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = ProductService.GetProductByID(Convert.ToInt32(cbProducts?.SelectedValue));
            if (product != null)
            {
                decimal quantity = Convert.ToDecimal(numCount.Value);
                if (quantity > Convert.ToDecimal(product.Quantity))
                {
                    MessageBox.Show("عدد ذلك الصنف غير موجود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                decimal lineTotal = quantity * product.SalePrice;

                dgrecit.Rows.Add(product.ID, product.Name, quantity, product.SalePrice, lineTotal);

                numTotalPrice.Value += lineTotal;
            }
            else
            {
                MessageBox.Show("أختر منتج من فضلك", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف تلك الصنف", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                int? index = dgrecit.CurrentRow?.Index;
                if (index != null)
                {
                    decimal lineTotal = Convert.ToDecimal(dgrecit.Rows[index.Value].Cells[4].Value);
                    dgrecit.Rows.RemoveAt(index.Value);
                    numTotalPrice.Value -= lineTotal;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Create the SaleOrder object
            SaleOrder saleOrder = new SaleOrder
            (
                Convert.ToInt32(txtID.Text),
                dtpTime.Value,
                Convert.ToInt32(cbCutomers?.SelectedValue),
                numTotalPrice.Value
            );
            // Create the list of SaleOrderProduct objects
            // Create Product objects 
            List<SaleOrderProduct> saleOrderProducts = new List<SaleOrderProduct>();
            List<Product> products = new List<Product>();

            foreach (DataGridViewRow row in dgrecit.Rows)
            {
                int productID = Convert.ToInt32(row.Cells["cProductID"].Value);
                double quantity = Convert.ToDouble(row.Cells["clQuantity"].Value);
                saleOrderProducts.Add(new SaleOrderProduct
                (
                    Convert.ToDecimal(row.Cells["clProductSellPrice"].Value),
                    quantity,
                    Convert.ToDecimal(row.Cells["clTotal"].Value),
                    productID,
                    saleOrder.ID
                ));
                Product? product = ProductService.GetProductByID(productID);
                if (product == null)
                {
                    MessageBox.Show("حدث خطأ في جلب بيانات المنتج", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                product.Quantity = quantity;
                products.Add(product);
            }

            // Create Stock objects
            //Somethimg wrong here, I will fix it later             --------
            Stock stock = new Stock
            (
                1,
                "Stock1",
                numTotalPrice.Value
            );
            // create StockDetail objects
            StockDetails stockDetails = new StockDetails
            (
                stock.ID,
                StockDetails.enType.Sale,
                numTotalPrice.Value,
                dtpTime.Value,
                Convert.ToInt32(txtID.Text)
            );
            
            bool IsSuccess = SaleOrderService.InsertSalesOrderTransaction(saleOrder, saleOrderProducts, products, stock, stockDetails);
            if (IsSuccess)
            {
                MessageBox.Show("تم حفظ الطلب بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                MessageBox.Show("حدث خطأ أثناء حفظ الطلب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
