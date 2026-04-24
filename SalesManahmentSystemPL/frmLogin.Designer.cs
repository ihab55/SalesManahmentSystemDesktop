namespace SalesManahmentSystemPL
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panTop = new Panel();
            lbHead = new Label();
            panLogin = new Panel();
            btnLogin = new Button();
            chkRememberMe = new CheckBox();
            btnShowPassword = new Button();
            txtPassword = new TextBox();
            lbPassword = new Label();
            txtUserName = new TextBox();
            lbUserName = new Label();
            panTop.SuspendLayout();
            panLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panTop
            // 
            panTop.BackColor = Color.FromArgb(45, 85, 95);
            panTop.Controls.Add(lbHead);
            panTop.Dock = DockStyle.Top;
            panTop.Location = new Point(0, 0);
            panTop.Name = "panTop";
            panTop.Size = new Size(450, 80);
            panTop.TabIndex = 0;
            // 
            // lbHead
            // 
            lbHead.Dock = DockStyle.Fill;
            lbHead.Font = new Font("Dubai", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHead.ForeColor = Color.White;
            lbHead.Location = new Point(0, 0);
            lbHead.Name = "lbHead";
            lbHead.Size = new Size(450, 80);
            lbHead.TabIndex = 0;
            lbHead.Text = "تسجيل الدخول";
            lbHead.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panLogin
            // 
            panLogin.BackColor = Color.White;
            panLogin.Controls.Add(btnLogin);
            panLogin.Controls.Add(chkRememberMe);
            panLogin.Controls.Add(btnShowPassword);
            panLogin.Controls.Add(txtPassword);
            panLogin.Controls.Add(lbPassword);
            panLogin.Controls.Add(txtUserName);
            panLogin.Controls.Add(lbUserName);
            panLogin.Location = new Point(50, 100);
            panLogin.Name = "panLogin";
            panLogin.Size = new Size(350, 280);
            panLogin.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(45, 85, 95);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Dubai", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(20, 230);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(310, 50);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "🔐 تسجيل الدخول";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Font = new Font("Dubai", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkRememberMe.Location = new Point(20, 195);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(80, 36);
            chkRememberMe.TabIndex = 5;
            chkRememberMe.Text = "تذكرني";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // btnShowPassword
            // 
            btnShowPassword.BackColor = Color.FromArgb(230, 230, 230);
            btnShowPassword.Cursor = Cursors.Hand;
            btnShowPassword.FlatAppearance.BorderSize = 0;
            btnShowPassword.FlatStyle = FlatStyle.Flat;
            btnShowPassword.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowPassword.Location = new Point(290, 140);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(40, 40);
            btnShowPassword.TabIndex = 4;
            btnShowPassword.Text = "👁";
            btnShowPassword.UseVisualStyleBackColor = false;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(20, 140);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(270, 41);
            txtPassword.TabIndex = 3;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPassword.ForeColor = Color.FromArgb(45, 85, 95);
            lbPassword.Location = new Point(280, 105);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(109, 34);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "كلمة المرور :";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.White;
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(20, 55);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(310, 41);
            txtUserName.TabIndex = 1;
            txtUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUserName.ForeColor = Color.FromArgb(45, 85, 95);
            lbUserName.Location = new Point(270, 20);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(141, 34);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "اسم المستخدم :";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(450, 400);
            Controls.Add(panLogin);
            Controls.Add(panTop);
            Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تسجيل الدخول";
            Load += frmLogin_Load;
            panTop.ResumeLayout(false);
            panLogin.ResumeLayout(false);
            panLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panTop;
        private Label lbHead;
        private Panel panLogin;
        private Label lbUserName;
        private TextBox txtUserName;
        private Label lbPassword;
        private TextBox txtPassword;
        private Button btnShowPassword;
        private CheckBox chkRememberMe;
        private Button btnLogin;
    }
}
