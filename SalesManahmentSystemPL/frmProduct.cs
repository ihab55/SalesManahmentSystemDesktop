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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
            cbCatagory.DataSource = CategoryService.GetAllCategories();
            cbCatagory.DisplayMember = "Name";
            cbCatagory.ValueMember = "ID";
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
                && CheckValidation(cbCatagory) && CheckValidation(numBPrıce)
                && CheckValidation(numSPrıce) && CheckValidation(numCount);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckAllValidation())
            {
                string Name = txtName.Text;
                decimal BuyPrice = numBPrıce.Value;
                decimal SalePrice = numSPrıce.Value;
                double Quantity = Convert.ToDouble(numCount.Value);
                int CategoryID = Convert.ToInt32(cbCatagory.SelectedValue);
                
                MessageBox.Show(ProductService.AddProduct(new Product
                    (0, Name, BuyPrice, SalePrice, Quantity, CategoryID)) ?
                    "تم اضافة الصنف بنجاح!" : "هناك خطا فى الاضافة!");
                FrmProduct_Load(sender, e);

            }
        }

        private void dgProducts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgProducts.Rows[e.RowIndex].Cells["IDColumn"].Value?.ToString();
                txtName.Text = dgProducts.Rows[e.RowIndex].Cells["NameColumn"].Value?.ToString();
                numCount.Value = Convert.ToDecimal(dgProducts.Rows[e.RowIndex].Cells["QUANTITY"].Value);
                numSPrıce.Value = Convert.ToDecimal(dgProducts.Rows[e.RowIndex].Cells["SALEPRICE"].Value);
                numBPrıce.Value = Convert.ToDecimal(dgProducts.Rows[e.RowIndex].Cells["BUYPRICE"].Value);
                cbCatagory.SelectedValue = Convert.ToInt32(dgProducts.Rows[e.RowIndex].Cells["CATEGORYID"].Value);
            }
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            dgProducts.DataSource = ProductService.GetAllProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckAllValidation())
            {

                int ID = Convert.ToInt32(txtID.Text);
                string Name = txtName.Text;
                decimal BuyPrice = numBPrıce.Value;
                decimal SalePrice = numSPrıce.Value;
                double Quantity = Convert.ToDouble(numCount.Value);
                int CategoryID = Convert.ToInt32(cbCatagory.SelectedValue);

                MessageBox.Show(ProductService.UpdateProduct(new Product
                    (ID, Name, BuyPrice, SalePrice, Quantity, CategoryID)) ?
                    "! تم التعديل بنجاح" : "تاكد من الكتابة بشكل صحيح !", "معلومات",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmProduct_Load(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف تلك الصنف",
                "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (CheckValidation(txtID))
                {
                    int ID = Convert.ToInt32(txtID.Text);
                    MessageBox.Show(ProductService.DeleteProduct(ID) ?
                        "تم حذف الصنف" : "هناك مشكلة تواصل مع الدعم", "معلومة",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmProduct_Load(sender, e);
                }
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف الجميع !!",
                "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (CheckValidation(txtID))
                {
                    int ID = Convert.ToInt32(txtID.Text);
                    MessageBox.Show(ProductService.DeleteAllProduct() ?
                        "تم حذف الجميع" : "هناك مشكلة تواصل مع الدعم", "معلومة",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmProduct_Load(sender, e);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (CheckValidation(txtSearch))
            {
                IEnumerable<Product> categories = ProductService.GetAllProductsByPattern(txtSearch.Text);
                dgProducts.DataSource = categories;
            }
            else
            {
                FrmProduct_Load(sender, e);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
        }
    }
}
