using SalesManahmentSystemBLL.DTOs;
using SalesManahmentSystemBLL.ServicesInterface;
using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SalesManahmentSystemPL
{
    public partial class frmLogin : Form
    {
        private bool _passwordVisible = false;
        private ILoginService _IloginService;
        public frmLogin(ILoginService IloginService)
        {
            this._IloginService = IloginService;
            InitializeComponent();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            _passwordVisible = !_passwordVisible;
            txtPassword.PasswordChar = _passwordVisible ? '\0' : '●';
            btnShowPassword.Text = _passwordVisible ? "🙈" : "👁";
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            LoginBasicDTO Login = new(txtUserName.Text.Trim(), txtPassword.Text);
            if (await _IloginService.Login(Login))
            {
                
                _IloginService.SaveRememberMeCredentials(chkRememberMe.Checked? 
                    Login: new LoginBasicDTO("",""));
                

                MessageBox.Show("تم تسجيل الدخول بنجاح!", "نجاح",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.SelectAll();
                txtPassword.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            LoginBasicDTO Login = new("","");
            if (_IloginService.GetStoredCredential(Login))
            {
                txtUserName.Text = Login.UserName;
                txtPassword.Text = Login.Password;
                chkRememberMe.Checked = true;
            }
        }
    }
}
