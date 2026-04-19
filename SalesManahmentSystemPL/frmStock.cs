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
    public partial class frmStock : Form
    {
        public frmStock()
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
                string Name = txtName.Text;
                decimal TotalPrice = numStocks.Value;
                MessageBox.Show(StockService.AddStock(new Stock(Name, TotalPrice)) ?
                    "تم إضافة خزنة جديدة!" : "هناك خطا فى الاضافة!","معلومة",MessageBoxButtons.OK
                    ,MessageBoxIcon.Information);
                frmStock_Load(sender, e);

            }
        }

        private void dgStocks_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgStoks.Rows[e.RowIndex].Cells[0].Value?.ToString();
                txtName.Text = dgStoks.Rows[e.RowIndex].Cells[1].Value?.ToString();
                numStocks.Value = Convert.ToInt32(dgStoks.Rows[e.RowIndex].Cells[2].Value);
            }
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            dgStoks.DataSource = StockService.GetAllStocks();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckValidation(txtName) && CheckValidation(txtID))
            {
                int ID = Convert.ToInt32(txtID.Text);
                string name = txtName.Text;
                decimal totalPrice = numStocks.Value;
                MessageBox.Show(StockService.UpdateStock(
                    new Stock(ID, name, totalPrice)) ?
                    "! تم التعديل بنجاح" : "تاكد من الكتابة بشكل صحيح !", "معلومات",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmStock_Load(sender, e);
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
                    MessageBox.Show(StockService.DeleteStock(ID) ?
                        "تم حذف المجموعة" : "هناك مشكلة تواصل مع الدعم", "معلومة",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmStock_Load(sender, e);
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
                    MessageBox.Show(StockService.DeleteAllStocks() ?
                        "تم حذف الجميع" : "هناك مشكلة تواصل مع الدعم", "معلومة",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmStock_Load(sender, e);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (CheckValidation(txtSearch))
            {
                IEnumerable<Stock> Stocks = StockService.GetAllStocksByPattern(txtSearch.Text);
                dgStoks.DataSource = Stocks;
            }
            else
            {
                frmStock_Load(sender, e);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Text = txtSearch.Text = string.Empty;
            numStocks.Value = 0;
        }
    }
}
