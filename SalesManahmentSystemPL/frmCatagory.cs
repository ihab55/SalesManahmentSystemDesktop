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
    public partial class frmCatagory : Form
    {
        private readonly ICategoryService _categoryService;

        public frmCatagory(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            InitializeComponent();
        }
        private bool CheckValidation(TextBox text)
        {
            if (string.IsNullOrWhiteSpace(text.Text))
            {
                errorProvider1.SetError(text, "من فضلك أضف ذلك الحقل.");
                return false;
            }
            errorProvider1.Clear();
            return true;
        }
        /// <summary>
        /// Add Category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckValidation(txtName))
            {

                int ID = Convert.ToInt32(txtID.Text);
                string name = txtName.Text;
                ;
                MessageBox.Show(await _categoryService.AddCategory(new Category(ID, name)) ?
                    "تم إضافة المجموعة!" : "هناك خطا!","معلومه", MessageBoxButtons.OK
                    ,MessageBoxIcon.Information);
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

        private async void FrmCatagory_Load(object sender, EventArgs e)
        {
            dgCatagories.DataSource = await _categoryService.GetAllCategories();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckValidation(txtName) && CheckValidation(txtID))
            {
                int ID = Convert.ToInt32(txtID.Text);
                string name = txtName.Text;
                MessageBox.Show(await _categoryService.UpdateCategory(new Category(ID, name)) ?
                    "! تم التعديل بنجاح" : "تاكد من الكتابة بشكل صحيح !", "معلومات",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmCatagory_Load(sender, e);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف تلك المجموعة",
                "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (CheckValidation(txtID))
                {
                    int ID = Convert.ToInt32(txtID.Text);
                    MessageBox.Show(await _categoryService.DeleteCategory(ID) ?
                        "تم حذف المجموعة" : "هناك مشكلة تواصل مع الدعم", "معلومة",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmCatagory_Load(sender, e);
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
                    MessageBox.Show(await _categoryService.DeleteAllCategory() ?
                        "تم حذف الجميع" : "هناك مشكلة تواصل مع الدعم", "معلومة",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmCatagory_Load(sender, e);
                }
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (CheckValidation(txtSearch))
            {
                IEnumerable<Category> categories = await _categoryService.GetAllCategoriesByPattern(txtSearch.Text);
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
