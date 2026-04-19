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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
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

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            dgStocks.DataSource = CustomerService.GetAllCustomers();
        }

        private void dgStocks_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgStocks.Rows[e.RowIndex].Cells["IDColumn"].Value?.ToString();
                txtName.Text = dgStocks.Rows[e.RowIndex].Cells["NameColumn"].Value?.ToString();
                txtPhone.Text = dgStocks.Rows[e.RowIndex].Cells["PhoneNumberColumn"].Value?.ToString();
                txtAddress.Text = dgStocks.Rows[e.RowIndex].Cells["AddressColumn"].Value?.ToString();
                if (dgStocks.Rows[e.RowIndex].Cells["BODColumn"].Value != null)
                {
                    dtpDOB.Value = Convert.ToDateTime(dgStocks.Rows[e.RowIndex].Cells["BODColumn"].Value);
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtID.Text = txtName.Text = txtPhone.Text = txtAddress.Text = txtSearch.Text = string.Empty;
            dtpDOB.Value = DateTime.Now;
            errorProvider1.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckValidation(txtName) && CheckValidation(txtPhone) && CheckValidation(txtAddress))
            {
                string name = txtName.Text;
                string phone = txtPhone.Text;
                string address = txtAddress.Text;
                DateTime birthDate = dtpDOB.Value;

                MessageBox.Show(CustomerService.AddCustomer(new Customer(name, phone, address, birthDate)) ?
                    "تم إضافة العميل بنجاح!" : "هناك خطأ فى الإضافة!", "معلومة",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmCustomer_Load(sender, e);
                btnNew_Click(sender, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckValidation(txtName) && CheckValidation(txtPhone) && CheckValidation(txtAddress))
            {
                int ID = Convert.ToInt32(txtID.Text);
                string name = txtName.Text;
                string phone = txtPhone.Text;
                string address = txtAddress.Text;
                DateTime birthDate = dtpDOB.Value;

                MessageBox.Show(CustomerService.UpdateCustomer(new Customer(ID, name, phone, address, birthDate)) ?
                    "! تم التعديل بنجاح" : "تاكد من الكتابة بشكل صحيح !", "معلومات",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmCustomer_Load(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف هذا العميل",
                "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (!string.IsNullOrWhiteSpace(txtID.Text))
                {
                    int ID = Convert.ToInt32(txtID.Text);
                    MessageBox.Show(CustomerService.DeleteCustomer(ID) ?
                        "تم حذف العميل" : "هناك مشكلة تواصل مع الدعم", "معلومة",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmCustomer_Load(sender, e);
                    btnNew_Click(sender, e);
                }
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف جميع العملاء !!",
                "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(CustomerService.DeleteAllCustomer() ?
                    "تم حذف الجميع" : "هناك مشكلة تواصل مع الدعم", "معلومة",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmCustomer_Load(sender, e);
                btnNew_Click(sender, e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                IEnumerable<Customer> customers = CustomerService.GetAllCustomersByPattern(txtSearch.Text);
                dgStocks.DataSource = customers;
            }
            else
            {
                frmCustomer_Load(sender, e);
            }
        }
    }
}
