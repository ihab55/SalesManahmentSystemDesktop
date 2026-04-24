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
    public partial class frmSaleOrder : Form
    {
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;
        private readonly ISaleOrderService _saleOrderService;
        private readonly IStockService _stockService;

        public frmSaleOrder(IProductService productService, ICustomerService customerService, ISaleOrderService saleOrderService, IStockService stockService)
        {
            _productService = productService;
            _customerService = customerService;
            _saleOrderService = saleOrderService;
            _stockService = stockService;
            InitializeComponent();
        }

        private async void frmSaleOrder_Load(object sender, EventArgs e)
        {
            cbProducts.DataSource = await _productService.GetAllBasicProducts();
            cbProducts.DisplayMember = "Name";
            cbProducts.ValueMember = "ID";

            cbCutomers.DataSource = await _customerService.GetAllBasicCustomers();
            cbCutomers.DisplayMember = "Name";
            cbCutomers.ValueMember = "ID";

            cbStock.DataSource = await _stockService.GetAllBasicStocks();
            cbStock.DisplayMember = "Name";
            cbStock.ValueMember = "ID";

            // Set default type to Sale
            rbSale.Checked = true;

            txtID.Text = (await _saleOrderService.GetLastID() + 1).ToString();
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Product? product = await _productService.GetProductByID(Convert.ToInt32(cbProducts?.SelectedValue));
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

        private async void btnSave_Click(object sender, EventArgs e)
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
                Product? product = await _productService.GetProductByID(productID);
                if (product == null)
                {
                    MessageBox.Show("حدث خطأ في جلب بيانات المنتج", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                product.Quantity = quantity;
                products.Add(product);
            }

            // Get selected stock
            int selectedStockId = Convert.ToInt32(cbStock.SelectedValue);
            StockBasicDTO? selectedStock = (cbStock.SelectedItem as StockBasicDTO);
            Stock stock = new Stock
            (
                selectedStockId,
                selectedStock?.Name ?? "",
                numTotalPrice.Value
            );

            // Determine selected type
            StockDetails.enType selectedType = StockDetails.enType.Sale;
            if (rbPurchase.Checked) selectedType = StockDetails.enType.Purchase;
            else if (rbExpense.Checked) selectedType = StockDetails.enType.Expense;

            // create StockDetail objects
            StockDetails stockDetails = new StockDetails
            (
                selectedStockId,
                selectedType,
                numTotalPrice.Value,
                dtpTime.Value,
                Convert.ToInt32(txtID.Text)
            );

            if (rbPurchase.Checked) 
                {
                  saleOrder.TotalOrder *= -1;
                products.ForEach(p => p.Quantity *= -1);
                 stock.TotalMoney *= -1;
                 stockDetails.Total *= -1;
                 stockDetails.Type = StockDetails.enType.Purchase;

            }
            bool IsSuccess = await _saleOrderService.InsertSalesOrderTransaction(saleOrder, saleOrderProducts, products, stock, stockDetails);
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
