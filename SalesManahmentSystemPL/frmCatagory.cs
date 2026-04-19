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
    public partial class frmCatagory : Form
    {
        public frmCatagory()
        {
            InitializeComponent();
        }
        private bool CheckValidation(TextBox text)
        {
            if (string.IsNullOrWhiteSpace(text.Text))
            {
                errorProvider1.SetError(text, "This field is required.");
                return false;
            }
            errorProvider1.Clear();
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckValidation(txtName))
            {

                int ID = Convert.ToInt32(txtID.Text);
                string name = txtName.Text;
                ;
                MessageBox.Show(CategoryService.AddCategory(new Category(ID, name)) ?
                    "Category added successfully!" : "Category Failed to add!");
                FrmCatagory_Load(sender, e);

            }
        }

        private void dgCatagories_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgCatagories.Rows[e.RowIndex].Cells[0].Value?.ToString();
                txtName.Text = dgCatagories.Rows[e.RowIndex].Cells[1].Value?.ToString();
            }
        }

        private void FrmCatagory_Load(object sender, EventArgs e)
        {
            dgCatagories.DataSource = CategoryService.GetAllCategories();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckValidation(txtName) && CheckValidation(txtID))
            {
                int ID = Convert.ToInt32(txtID.Text);
                string name = txtName.Text;
                MessageBox.Show(CategoryService.UpdateCategory(new Category(ID, name)) ?
                    "! تم التعديل بنجاح" : "تاكد من الكتابة بشكل صحيح !", "معلومات",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmCatagory_Load(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف تلك المجموعة",
                "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (CheckValidation(txtID))
                {
                    int ID = Convert.ToInt32(txtID.Text);
                    MessageBox.Show(CategoryService.DeleteCategory(ID) ?
                        "تم حذف المجموعة" : "هناك مشكلة تواصل مع الدعم", "معلومة",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmCatagory_Load(sender, e);
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
                    MessageBox.Show(CategoryService.DeleteAllCategory() ?
                        "تم حذف الجميع" : "هناك مشكلة تواصل مع الدعم", "معلومة",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmCatagory_Load(sender, e);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (CheckValidation(txtSearch))
            {
                IEnumerable<Category> categories = CategoryService.GetAllCategoriesByPattern(txtSearch.Text);
                dgCatagories.DataSource = categories;
            }
            else
            {
                FrmCatagory_Load(sender, e);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Text = txtSearch.Text = string.Empty;
        }
    }
}
