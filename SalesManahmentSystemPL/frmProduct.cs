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
    public partial class frmProduct : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public frmProduct(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
             InitializeComponent();
        }
        private bool CheckValidation(TextBox text)
        {
            if (string.IsNullOrWhiteSpace(text.Text))
            {
                errorProvider1.SetError(text, "برجاء ادخال قيمة.");
                return false;
            }
            errorProvider1.Clear();
            return true;
        }
        private bool CheckValidation(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex < 0)
            {
                errorProvider1.SetError(comboBox, "برجاء اختيار شئ.");
                return false;
            }
            errorProvider1.Clear();
            return true;
        }
        private bool CheckValidation(NumericUpDown numericUpDown)
        {
            if (numericUpDown.Value <= 0)
            {
                errorProvider1.SetError(numericUpDown, "ادخل الرقم بشكل صحيح");
                return false;
            }
            errorProvider1.Clear();
            return true;
        }
        private bool CheckAllValidation()
        {
            return  CheckValidation(txtName) 
                && CheckValidation(cbCatagory) && CheckValidation(numBPrice)
                && CheckValidation(numSPrice) && CheckValidation(numCount);
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckAllValidation())
            {
                string Name = txtName.Text;
                decimal BuyPrice = numBPrice.Value;
                decimal SalePrice = numSPrice.Value;
                double Quantity = Convert.ToDouble(numCount.Value);
                int CategoryID = Convert.ToInt32(cbCatagory.SelectedValue);
                
                MessageBox.Show(await _productService.AddProduct(new Product
                    (0, Name, BuyPrice, SalePrice, Quantity, CategoryID)) ?
                    "تم اضافة الصنف بنجاح!" : "هناك خطا فى الاضافة!","معلومه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadProducts();

            }
        }

        private void dgProducts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgProducts.Rows[e.RowIndex].Cells["IDColumn"].Value?.ToString();
                txtName.Text = dgProducts.Rows[e.RowIndex].Cells["NameColumn"].Value?.ToString();
                numCount.Value = Convert.ToDecimal(dgProducts.Rows[e.RowIndex].Cells["QUANTITY"].Value);
                numSPrice.Value = Convert.ToDecimal(dgProducts.Rows[e.RowIndex].Cells["SALEPRICE"].Value);
                numBPrice.Value = Convert.ToDecimal(dgProducts.Rows[e.RowIndex].Cells["BUYPRICE"].Value);
                cbCatagory.Text = dgProducts.Rows[e.RowIndex].Cells["CATEGORYNAME"].Value?.ToString();
            }
        }

        private async void FrmProduct_Load(object sender, EventArgs e)
        {
            cbCatagory.DataSource = await _categoryService.GetAllBasicCategories();
            cbCatagory.DisplayMember = "Name";
            cbCatagory.ValueMember = "ID";
            await LoadProducts();
        }
        private async Task LoadProducts()
        {
            dgProducts.DataSource = await _productService.GetAllProducts();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckAllValidation())
            {

                int ID = Convert.ToInt32(txtID.Text);
                string Name = txtName.Text;
                decimal BuyPrice = numBPrice.Value;
                decimal SalePrice = numSPrice.Value;
                double Quantity = Convert.ToDouble(numCount.Value);
                int CategoryID = Convert.ToInt32(cbCatagory.SelectedValue);

                MessageBox.Show(await _productService.UpdateProduct(new Product
                    (ID, Name, BuyPrice, SalePrice, Quantity, CategoryID)) ?
                    "! تم التعديل بنجاح" : "تاكد من الكتابة بشكل صحيح !", "معلومات",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                 await LoadProducts();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف تلك الصنف",
                "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (CheckValidation(txtID))
                {
                    int ID = Convert.ToInt32(txtID.Text);
                    MessageBox.Show(await _productService.DeleteProduct(ID) ?
                        "تم حذف الصنف" : "هناك مشكلة تواصل مع الدعم", "معلومة",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                     await LoadProducts();
                }
            }
        }

        private async void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف الجميع !!",
                "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (CheckValidation(txtID))
                {
                    int ID = Convert.ToInt32(txtID.Text);
                    MessageBox.Show(await _productService.DeleteAllProduct() ?
                        "تم حذف الجميع" : "هناك مشكلة تواصل مع الدعم", "معلومة",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadProducts();
                }
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (CheckValidation(txtSearch))
            {
                dgProducts.DataSource =
                    await _productService.GetAllProductsByPattern(txtSearch.Text);
                
            }
            else
            {
                 await LoadProducts();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Text = txtSearch.Text = string.Empty;
            numBPrice.Value = numSPrice.Value = numCount.Value = 0;
        }
    }
}
