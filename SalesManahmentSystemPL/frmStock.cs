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
    public partial class frmStock : Form
    {
        private readonly IStockService _stockService;

        public frmStock(IStockService stockService)
        {
            _stockService = stockService;
            InitializeComponent();
        }
        private bool CheckValidation(params TextBox [] texts)
        {
            foreach (var text in texts){
                if (string.IsNullOrWhiteSpace(text.Text))
                {
                    errorProvider1.SetError(text, "This field is required.");
                    return false;
                }
            }
            errorProvider1.Clear();
            return true;
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckValidation(txtName))
            {
                string Name = txtName.Text;
                decimal TotalPrice = numTotalMoney.Value;
                MessageBox.Show(await _stockService.AddStock(new Stock(Name, TotalPrice)) ?
                    "تم إضافة خزنة جديدة!" : "هناك خطا فى الاضافة!","معلومة",MessageBoxButtons.OK
                    ,MessageBoxIcon.Information);
                frmStock_Load(sender, e);

            }
        }

        private void dgStocks_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgStocks.Rows[e.RowIndex].Cells[0].Value?.ToString();
                txtName.Text = dgStocks.Rows[e.RowIndex].Cells[1].Value?.ToString();
                numTotalMoney.Value = Convert.ToInt32(dgStocks.Rows[e.RowIndex].Cells[2].Value);
            }
        }

        private async void frmStock_Load(object sender, EventArgs e)
        {
            dgStocks.DataSource =await _stockService.GetAllStocks();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckValidation(txtName, txtID))
            {
                int ID = Convert.ToInt32(txtID.Text);
                string name = txtName.Text;
                decimal totalPrice = numTotalMoney.Value;
                MessageBox.Show(await _stockService.UpdateStock(
                    new Stock(ID, name, totalPrice)) ?
                    "! تم التعديل بنجاح" : "تاكد من الكتابة بشكل صحيح !", "معلومات",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmStock_Load(sender, e);
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
                    MessageBox.Show(await _stockService.DeleteStock(ID) ?
                        "تم حذف المجموعة" : "هناك مشكلة تواصل مع الدعم", "معلومة",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmStock_Load(sender, e);
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
                    MessageBox.Show(await _stockService.DeleteAllStocks() ?
                        "تم حذف الجميع" : "هناك مشكلة تواصل مع الدعم", "معلومة",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmStock_Load(sender, e);
                    btnNew_Click(sender, e);
                }
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (CheckValidation(txtSearch))
            {
                IEnumerable<Stock> Stocks = await _stockService.GetAllStocksByPattern(txtSearch.Text);
                dgStocks.DataSource = Stocks;
            }
            else
            {
                frmStock_Load(sender, e);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Text = txtSearch.Text = string.Empty;
            numTotalMoney.Value = 0;
        }
    }
}
