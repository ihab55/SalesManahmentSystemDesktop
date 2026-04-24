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
    public partial class frmCustomer : Form
    {
        private readonly ICustomerService _customerService;

        public frmCustomer(ICustomerService customerService)
        {
            _customerService = customerService;
            InitializeComponent();
        }

        private bool CheckValidation(params TextBox[] texts)
        {
            foreach (TextBox text in texts)
            {
                if (string.IsNullOrWhiteSpace(text.Text))
                {
                    errorProvider1.SetError(text, "برجاء ادخال قيمة.");
                    return false;
                }
            }
            errorProvider1.Clear();
            return true;
        }

        private async void frmCustomer_Load(object sender, EventArgs e)
        {
            dgCustomers.DataSource = await _customerService.GetAllCustomers();
        }

        private void dgCustomers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgCustomers.Rows[e.RowIndex].Cells["IDColumn"].Value?.ToString();
                txtName.Text = dgCustomers.Rows[e.RowIndex].Cells["NameColumn"].Value?.ToString();
                txtPhone.Text = dgCustomers.Rows[e.RowIndex].Cells["PhoneNumberColumn"].Value?.ToString();
                txtAddress.Text = dgCustomers.Rows[e.RowIndex].Cells["AddressColumn"].Value?.ToString();
                if (dgCustomers.Rows[e.RowIndex].Cells["BODColumn"].Value != null)
                {
                    dtpDOB.Value = Convert.ToDateTime(dgCustomers.Rows[e.RowIndex].Cells["BODColumn"].Value);
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Text = txtPhone.Text = txtAddress.Text = txtSearch.Text = string.Empty;
            dtpDOB.Value = DateTime.Now;
            errorProvider1.Clear();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckValidation(txtName,txtPhone,txtAddress))
            {
                string name = txtName.Text;
                string phone = txtPhone.Text;
                string address = txtAddress.Text;
                DateTime birthDate = dtpDOB.Value;

                MessageBox.Show(await _customerService.AddCustomer(new Customer(name, phone, address, birthDate)) ?
                    "تم إضافة العميل بنجاح!" : "هناك خطأ فى الإضافة!", "معلومة",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmCustomer_Load(sender, e);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckValidation(txtName, txtPhone, txtAddress))
            {
                int ID = Convert.ToInt32(txtID.Text);
                string name = txtName.Text;
                string phone = txtPhone.Text;
                string address = txtAddress.Text;
                DateTime birthDate = dtpDOB.Value;

                MessageBox.Show(await _customerService.UpdateCustomer(new Customer(ID, name, phone, address, birthDate)) ?
                    "! تم التعديل بنجاح" : "تاكد من الكتابة بشكل صحيح !", "معلومات",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmCustomer_Load(sender, e);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف هذا العميل",
                "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (!string.IsNullOrWhiteSpace(txtID.Text))
                {
                    int ID = Convert.ToInt32(txtID.Text);
                    MessageBox.Show(await _customerService.DeleteCustomer(ID) ?
                        "تم حذف العميل" : "هناك مشكلة تواصل مع الدعم", "معلومة",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmCustomer_Load(sender, e);
                }
            }
        }

        private async void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف جميع العملاء !!",
                "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(await _customerService.DeleteAllCustomer() ?
                    "تم حذف الجميع" : "هناك مشكلة تواصل مع الدعم", "معلومة",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmCustomer_Load(sender, e);
                btnNew_Click(sender, e);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                IEnumerable<Customer> customers = await _customerService.GetAllCustomersByPattern(txtSearch.Text);
                dgCustomers.DataSource = customers;
            }
            else
            {
                frmCustomer_Load(sender, e);
            }
        }
    }
}
