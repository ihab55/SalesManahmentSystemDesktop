using SalesManahmentSystemBLL.Services;

namespace SalesManahmentSystemPL
{
    partial class frmCustomer
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panTop = new Panel();
            lbHead = new Label();
            panInput = new Panel();
            panRow2 = new Panel();
            lbDOB = new Label();
            dtpDOB = new DateTimePicker();
            lbAddress = new Label();
            txtAddress = new TextBox();
            panRow1 = new Panel();
            lbPhone = new Label();
            txtPhone = new TextBox();
            lbName = new Label();
            txtName = new TextBox();
            lbID = new Label();
            txtID = new TextBox();
            panButtons = new Panel();
            btnDeleteAll = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnNew = new Button();
            panSearch = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgCustomers = new DataGridView();
            IDColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            PhoneNumberColumn = new DataGridViewTextBoxColumn();
            AddressColumn = new DataGridViewTextBoxColumn();
            BODColumn = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            panFooter = new Panel();
            lbFooter = new Label();
            panTop.SuspendLayout();
            panInput.SuspendLayout();
            panRow2.SuspendLayout();
            panRow1.SuspendLayout();
            panButtons.SuspendLayout();
            panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panTop
            // 
            panTop.BackColor = Color.FromArgb(45, 85, 95);
            panTop.Controls.Add(lbHead);
            panTop.Dock = DockStyle.Top;
            panTop.Location = new Point(0, 0);
            panTop.Name = "panTop";
            panTop.Size = new Size(1000, 100);
            panTop.TabIndex = 0;
            // 
            // lbHead
            // 
            lbHead.Dock = DockStyle.Fill;
            lbHead.Font = new Font("Dubai", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHead.ForeColor = Color.White;
            lbHead.Location = new Point(0, 0);
            lbHead.Name = "lbHead";
            lbHead.Size = new Size(1000, 100);
            lbHead.TabIndex = 0;
            lbHead.Text = "إدارة العملاء";
            lbHead.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panInput
            // 
            panInput.BackColor = Color.White;
            panInput.Controls.Add(panRow2);
            panInput.Controls.Add(panRow1);
            panInput.Location = new Point(50, 120);
            panInput.Name = "panInput";
            panInput.Size = new Size(900, 200);
            panInput.TabIndex = 1;
            // 
            // panRow2
            // 
            panRow2.BackColor = Color.White;
            panRow2.Controls.Add(lbDOB);
            panRow2.Controls.Add(dtpDOB);
            panRow2.Controls.Add(lbAddress);
            panRow2.Controls.Add(txtAddress);
            panRow2.Dock = DockStyle.Bottom;
            panRow2.Location = new Point(0, 110);
            panRow2.Name = "panRow2";
            panRow2.Size = new Size(900, 90);
            panRow2.TabIndex = 1;
            // 
            // lbDOB
            // 
            lbDOB.AutoSize = true;
            lbDOB.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDOB.ForeColor = Color.FromArgb(45, 85, 95);
            lbDOB.Location = new Point(200, 10);
            lbDOB.Name = "lbDOB";
            lbDOB.Size = new Size(116, 34);
            lbDOB.TabIndex = 2;
            lbDOB.Text = "تاريخ الميلاد :";
            lbDOB.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpDOB
            // 
            dtpDOB.CalendarFont = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDOB.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(30, 45);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(180, 41);
            dtpDOB.TabIndex = 3;
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAddress.ForeColor = Color.FromArgb(45, 85, 95);
            lbAddress.Location = new Point(690, 10);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(127, 34);
            lbAddress.TabIndex = 0;
            lbAddress.Text = "عنوان العميل :";
            lbAddress.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(350, 45);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(520, 41);
            txtAddress.TabIndex = 1;
            txtAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // panRow1
            // 
            panRow1.BackColor = Color.White;
            panRow1.Controls.Add(lbPhone);
            panRow1.Controls.Add(txtPhone);
            panRow1.Controls.Add(lbName);
            panRow1.Controls.Add(txtName);
            panRow1.Controls.Add(lbID);
            panRow1.Controls.Add(txtID);
            panRow1.Dock = DockStyle.Top;
            panRow1.Location = new Point(0, 0);
            panRow1.Name = "panRow1";
            panRow1.Size = new Size(900, 90);
            panRow1.TabIndex = 0;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPhone.ForeColor = Color.FromArgb(45, 85, 95);
            lbPhone.Location = new Point(130, 10);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(105, 34);
            lbPhone.TabIndex = 4;
            lbPhone.Text = "رقم الهاتف :";
            lbPhone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(30, 45);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(180, 41);
            txtPhone.TabIndex = 5;
            txtPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.ForeColor = Color.FromArgb(45, 85, 95);
            lbName.Location = new Point(430, 10);
            lbName.Name = "lbName";
            lbName.Size = new Size(116, 34);
            lbName.TabIndex = 2;
            lbName.Text = "اسم العميل :";
            lbName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(320, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 41);
            txtName.TabIndex = 3;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbID.ForeColor = Color.FromArgb(45, 85, 95);
            lbID.Location = new Point(780, 10);
            lbID.Name = "lbID";
            lbID.Size = new Size(109, 34);
            lbID.TabIndex = 0;
            lbID.Text = "رقم العميل :";
            lbID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(245, 247, 250);
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Enabled = false;
            txtID.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(620, 45);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(250, 41);
            txtID.TabIndex = 1;
            txtID.TextAlign = HorizontalAlignment.Center;
            // 
            // panButtons
            // 
            panButtons.Controls.Add(btnDeleteAll);
            panButtons.Controls.Add(btnDelete);
            panButtons.Controls.Add(btnUpdate);
            panButtons.Controls.Add(btnAdd);
            panButtons.Controls.Add(btnNew);
            panButtons.Location = new Point(50, 330);
            panButtons.Name = "panButtons";
            panButtons.Size = new Size(900, 70);
            panButtons.TabIndex = 2;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.FromArgb(97, 97, 97);
            btnDeleteAll.Cursor = Cursors.Hand;
            btnDeleteAll.FlatAppearance.BorderSize = 0;
            btnDeleteAll.FlatStyle = FlatStyle.Flat;
            btnDeleteAll.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteAll.ForeColor = Color.White;
            btnDeleteAll.Location = new Point(40, 10);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(130, 50);
            btnDeleteAll.TabIndex = 4;
            btnDeleteAll.Text = "🗑️ حذف الكل";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(211, 47, 47);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(215, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 50);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "🗑️ حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(25, 118, 210);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(390, 10);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 50);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "✏️ تعديل";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 125, 50);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(565, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 50);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "✅ إضافة";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(45, 85, 95);
            btnNew.Cursor = Cursors.Hand;
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(740, 10);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(130, 50);
            btnNew.TabIndex = 0;
            btnNew.Text = "📝 جديد";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // panSearch
            // 
            panSearch.BackColor = Color.FromArgb(245, 247, 250);
            panSearch.Controls.Add(btnSearch);
            panSearch.Controls.Add(txtSearch);
            panSearch.Location = new Point(50, 410);
            panSearch.Name = "panSearch";
            panSearch.Size = new Size(900, 70);
            panSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(45, 85, 95);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(650, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(230, 50);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "🔍 بحث";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(20, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "ابحث باسم العميل او رقم العميل... ";
            txtSearch.Size = new Size(620, 41);
            txtSearch.TabIndex = 0;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // dgCustomers
            // 
            dgCustomers.AllowUserToAddRows = false;
            dgCustomers.AllowUserToDeleteRows = false;
            dgCustomers.AllowUserToResizeColumns = false;
            dgCustomers.AllowUserToResizeRows = false;
            dgCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgCustomers.BackgroundColor = Color.White;
            dgCustomers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 85, 95);
            dataGridViewCellStyle1.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(45, 85, 95);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgCustomers.ColumnHeadersHeight = 40;
            dgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgCustomers.Columns.AddRange(new DataGridViewColumn[] { IDColumn, NameColumn, PhoneNumberColumn, AddressColumn, BODColumn });
            dgCustomers.EnableHeadersVisualStyles = false;
            dgCustomers.GridColor = Color.FromArgb(224, 224, 224);
            dgCustomers.Location = new Point(50, 500);
            dgCustomers.MultiSelect = false;
            dgCustomers.Name = "dgCustomers";
            dgCustomers.ReadOnly = true;
            dgCustomers.RowHeadersVisible = false;
            dgCustomers.RowHeadersWidth = 51;
            dgCustomers.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgCustomers.RowTemplate.DefaultCellStyle.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgCustomers.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgCustomers.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 230, 201);
            dgCustomers.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgCustomers.RowTemplate.Height = 40;
            dgCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCustomers.Size = new Size(900, 200);
            dgCustomers.TabIndex = 4;
            dgCustomers.RowEnter += dgCustomers_RowEnter;
            // 
            // IDColumn
            // 
            IDColumn.DataPropertyName = "ID";
            IDColumn.HeaderText = "رقم العميل";
            IDColumn.MinimumWidth = 6;
            IDColumn.Name = "IDColumn";
            IDColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            NameColumn.DataPropertyName = "Name";
            NameColumn.HeaderText = "اسم العميل";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            // 
            // PhoneNumberColumn
            // 
            PhoneNumberColumn.DataPropertyName = "PhoneNumber";
            PhoneNumberColumn.HeaderText = "رقم الهاتف";
            PhoneNumberColumn.MinimumWidth = 6;
            PhoneNumberColumn.Name = "PhoneNumberColumn";
            PhoneNumberColumn.ReadOnly = true;
            // 
            // AddressColumn
            // 
            AddressColumn.DataPropertyName = "Address";
            AddressColumn.HeaderText = "العنوان";
            AddressColumn.MinimumWidth = 6;
            AddressColumn.Name = "AddressColumn";
            AddressColumn.ReadOnly = true;
            // 
            // BODColumn
            // 
            BODColumn.DataPropertyName = "BirthDate";
            BODColumn.HeaderText = "تاريخ الميلاد";
            BODColumn.MinimumWidth = 6;
            BODColumn.Name = "BODColumn";
            BODColumn.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panFooter
            // 
            panFooter.BackColor = Color.FromArgb(45, 85, 95);
            panFooter.Controls.Add(lbFooter);
            panFooter.Dock = DockStyle.Bottom;
            panFooter.Location = new Point(0, 720);
            panFooter.Name = "panFooter";
            panFooter.Size = new Size(1000, 50);
            panFooter.TabIndex = 5;
            // 
            // lbFooter
            // 
            lbFooter.Dock = DockStyle.Fill;
            lbFooter.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFooter.ForeColor = Color.White;
            lbFooter.Location = new Point(0, 0);
            lbFooter.Name = "lbFooter";
            lbFooter.Size = new Size(1000, 50);
            lbFooter.TabIndex = 0;
            lbFooter.Text = "نظام إدارة المبيعات - إيهاب أيمن - ehab.ayman7420@gmail.com";
            lbFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(9F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1000, 770);
            Controls.Add(panFooter);
            Controls.Add(dgCustomers);
            Controls.Add(panSearch);
            Controls.Add(panButtons);
            Controls.Add(panInput);
            Controls.Add(panTop);
            Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            Name = "frmCustomer";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدارة العملاء";
            Load += frmCustomer_Load;
            panTop.ResumeLayout(false);
            panInput.ResumeLayout(false);
            panRow2.ResumeLayout(false);
            panRow2.PerformLayout();
            panRow1.ResumeLayout(false);
            panRow1.PerformLayout();
            panButtons.ResumeLayout(false);
            panSearch.ResumeLayout(false);
            panSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panTop;
        private Label lbHead;
        private Panel panInput;
        private Panel panRow1;
        private Label lbID;
        private TextBox txtID;
        private Label lbName;
        private TextBox txtName;
        private Label lbPhone;
        private TextBox txtPhone;
        private Panel panRow2;
        private Label lbAddress;
        private TextBox txtAddress;
        private Label lbDOB;
        private DateTimePicker dtpDOB;
        private Panel panButtons;
        private Button btnNew;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnDeleteAll;
        private Panel panSearch;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgCustomers;
        private DataGridViewTextBoxColumn IDColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn PhoneNumberColumn;
        private DataGridViewTextBoxColumn AddressColumn;
        private DataGridViewTextBoxColumn BODColumn;
        private ErrorProvider errorProvider1;
        private Panel panFooter;
        private Label lbFooter;
    }
}
