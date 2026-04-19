using SalesManahmentSystemBLL.Services;

namespace SalesManahmentSystemPL
{
    partial class frmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panTop = new Panel();
            lbHead = new Label();
            panBotton = new Panel();
            txtName = new TextBox();
            txtID = new TextBox();
            lbID = new Label();
            lbName = new Label();
            btnNew = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnDeleteAll = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgStocks = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            lbPhone = new Label();
            txtPhone = new TextBox();
            lbAddress = new Label();
            txtAddress = new TextBox();
            dtpDOB = new DateTimePicker();
            lbDOB = new Label();
            IDColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            PhoneNumberColumn = new DataGridViewTextBoxColumn();
            AddressColumn = new DataGridViewTextBoxColumn();
            BODColumn = new DataGridViewTextBoxColumn();
            panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgStocks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panTop
            // 
            panTop.BackColor = Color.DarkSlateGray;
            panTop.Controls.Add(lbHead);
            panTop.Dock = DockStyle.Top;
            panTop.Location = new Point(0, 0);
            panTop.Name = "panTop";
            panTop.Size = new Size(1338, 93);
            panTop.TabIndex = 0;
            // 
            // lbHead
            // 
            lbHead.AutoSize = true;
            lbHead.Font = new Font("Dubai", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHead.ForeColor = SystemColors.Window;
            lbHead.Location = new Point(584, 19);
            lbHead.Name = "lbHead";
            lbHead.Size = new Size(171, 51);
            lbHead.TabIndex = 1;
            lbHead.Text = "شاشة العملاء";
            // 
            // panBotton
            // 
            panBotton.BackColor = Color.DarkSlateGray;
            panBotton.Dock = DockStyle.Bottom;
            panBotton.Location = new Point(0, 614);
            panBotton.Name = "panBotton";
            panBotton.Size = new Size(1338, 78);
            panBotton.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(296, 158);
            txtName.Name = "txtName";
            txtName.Size = new Size(242, 41);
            txtName.TabIndex = 2;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(12, 158);
            txtID.Name = "txtID";
            txtID.Size = new Size(242, 41);
            txtID.TabIndex = 3;
            txtID.TextAlign = HorizontalAlignment.Center;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbID.Location = new Point(12, 110);
            lbID.Name = "lbID";
            lbID.Size = new Size(109, 34);
            lbID.TabIndex = 4;
            lbID.Text = "رقم العميل :";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(296, 110);
            lbName.Name = "lbName";
            lbName.Size = new Size(116, 34);
            lbName.TabIndex = 5;
            lbName.Text = "أسم العميل :";
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.DarkSlateGray;
            btnNew.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.ForeColor = SystemColors.Window;
            btnNew.Location = new Point(80, 227);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(165, 52);
            btnNew.TabIndex = 6;
            btnNew.Text = "جديد";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkSlateGray;
            btnAdd.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.Window;
            btnAdd.Location = new Point(348, 227);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(165, 52);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "أضافة";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkSlateGray;
            btnUpdate.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.Window;
            btnUpdate.Location = new Point(616, 227);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(165, 52);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = " تعديل";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkSlateGray;
            btnDelete.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.Window;
            btnDelete.Location = new Point(884, 227);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(165, 52);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.DarkSlateGray;
            btnDeleteAll.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            btnDeleteAll.ForeColor = SystemColors.Window;
            btnDeleteAll.Location = new Point(1152, 227);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(165, 52);
            btnDeleteAll.TabIndex = 10;
            btnDeleteAll.Text = "حذف الجميع";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkSlateGray;
            btnSearch.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            btnSearch.ForeColor = SystemColors.Window;
            btnSearch.Location = new Point(638, 315);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(183, 41);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(255, 314);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(351, 41);
            txtSearch.TabIndex = 12;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // dgStocks
            // 
            dgStocks.AllowUserToAddRows = false;
            dgStocks.AllowUserToDeleteRows = false;
            dgStocks.AllowUserToResizeColumns = false;
            dgStocks.AllowUserToResizeRows = false;
            dgStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgStocks.BackgroundColor = Color.MistyRose;
            dgStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStocks.Columns.AddRange(new DataGridViewColumn[] { IDColumn, NameColumn, PhoneNumberColumn, AddressColumn, BODColumn });
            dgStocks.Location = new Point(0, 371);
            dgStocks.MultiSelect = false;
            dgStocks.Name = "dgStocks";
            dgStocks.ReadOnly = true;
            dgStocks.RowHeadersWidth = 51;
            dgStocks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgStocks.Size = new Size(1338, 243);
            dgStocks.TabIndex = 13;
            dgStocks.RowEnter += dgStocks_RowEnter;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPhone.Location = new Point(580, 110);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(97, 34);
            lbPhone.TabIndex = 15;
            lbPhone.Text = "رقم الفون :";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(580, 158);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(242, 41);
            txtPhone.TabIndex = 14;
            txtPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAddress.Location = new Point(864, 110);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(127, 34);
            lbAddress.TabIndex = 17;
            lbAddress.Text = "عنوان العميل :";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(864, 158);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(242, 41);
            txtAddress.TabIndex = 16;
            txtAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // dtpDOB
            // 
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(1148, 160);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(169, 36);
            dtpDOB.TabIndex = 18;
            // 
            // lbDOB
            // 
            lbDOB.AutoSize = true;
            lbDOB.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDOB.Location = new Point(1148, 110);
            lbDOB.Name = "lbDOB";
            lbDOB.Size = new Size(116, 34);
            lbDOB.TabIndex = 19;
            lbDOB.Text = "تاريخ الميلاد :";
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
            NameColumn.HeaderText = "أسم العميل";
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
            AddressColumn.HeaderText = "عنوان العميل";
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
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(9F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1338, 692);
            Controls.Add(lbDOB);
            Controls.Add(dtpDOB);
            Controls.Add(lbAddress);
            Controls.Add(txtAddress);
            Controls.Add(lbPhone);
            Controls.Add(txtPhone);
            Controls.Add(dgStocks);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnNew);
            Controls.Add(lbName);
            Controls.Add(lbID);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(panBotton);
            Controls.Add(panTop);
            Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Margin = new Padding(3, 5, 3, 5);
            Name = "frmCustomer";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة المجموعات";
            Load += frmCustomer_Load;
            panTop.ResumeLayout(false);
            panTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgStocks).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panTop;
        private Label lbHead;
        private Panel panBotton;
        private TextBox txtName;
        private TextBox txtID;
        private Label lbID;
        private Label lbName;
        private Button btnNew;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnDeleteAll;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgStocks;
        private ErrorProvider errorProvider1;
        private Label lbPhone;
        private TextBox txtPhone;
        private Label lbAddress;
        private TextBox txtAddress;
        private Label lbDOB;
        private DateTimePicker dtpDOB;
        private DataGridViewTextBoxColumn IDColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn PhoneNumberColumn;
        private DataGridViewTextBoxColumn AddressColumn;
        private DataGridViewTextBoxColumn BODColumn;
    }
}