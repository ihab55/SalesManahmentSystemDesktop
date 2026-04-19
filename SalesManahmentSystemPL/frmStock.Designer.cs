using SalesManahmentSystemBLL.Services;

namespace SalesManahmentSystemPL
{
    partial class frmStock
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
            dgStoks = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            lbStocls = new Label();
            numStocks = new NumericUpDown();
            IDColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            ColumnTotalMoney = new DataGridViewTextBoxColumn();
            panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgStoks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStocks).BeginInit();
            SuspendLayout();
            // 
            // panTop
            // 
            panTop.BackColor = Color.DarkSlateGray;
            panTop.Controls.Add(lbHead);
            panTop.Dock = DockStyle.Top;
            panTop.Location = new Point(0, 0);
            panTop.Name = "panTop";
            panTop.Size = new Size(1084, 93);
            panTop.TabIndex = 0;
            // 
            // lbHead
            // 
            lbHead.AutoSize = true;
            lbHead.Font = new Font("Dubai", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHead.ForeColor = SystemColors.Window;
            lbHead.Location = new Point(438, 19);
            lbHead.Name = "lbHead";
            lbHead.Size = new Size(159, 51);
            lbHead.TabIndex = 1;
            lbHead.Text = "شاشة الخزن";
            // 
            // panBotton
            // 
            panBotton.BackColor = Color.DarkSlateGray;
            panBotton.Dock = DockStyle.Bottom;
            panBotton.Location = new Point(0, 611);
            panBotton.Name = "panBotton";
            panBotton.Size = new Size(1084, 78);
            panBotton.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(424, 133);
            txtName.Name = "txtName";
            txtName.Size = new Size(242, 41);
            txtName.TabIndex = 2;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(60, 133);
            txtID.Name = "txtID";
            txtID.Size = new Size(242, 41);
            txtID.TabIndex = 3;
            txtID.TextAlign = HorizontalAlignment.Center;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbID.Location = new Point(60, 96);
            lbID.Name = "lbID";
            lbID.Size = new Size(100, 34);
            lbID.TabIndex = 4;
            lbID.Text = "رقم الخزنة :";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(424, 96);
            lbName.Name = "lbName";
            lbName.Size = new Size(107, 34);
            lbName.TabIndex = 5;
            lbName.Text = "أسم الخزنة :";
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.DarkSlateGray;
            btnNew.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.ForeColor = SystemColors.Window;
            btnNew.Location = new Point(65, 209);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(124, 61);
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
            btnAdd.Location = new Point(258, 209);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 61);
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
            btnUpdate.Location = new Point(468, 209);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(124, 61);
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
            btnDelete.Location = new Point(680, 209);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 61);
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
            btnDeleteAll.Location = new Point(884, 209);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(124, 61);
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
            // dgStoks
            // 
            dgStoks.AllowUserToAddRows = false;
            dgStoks.AllowUserToDeleteRows = false;
            dgStoks.AllowUserToResizeColumns = false;
            dgStoks.AllowUserToResizeRows = false;
            dgStoks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgStoks.BackgroundColor = Color.MistyRose;
            dgStoks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStoks.Columns.AddRange(new DataGridViewColumn[] { IDColumn, NameColumn, ColumnTotalMoney });
            dgStoks.Location = new Point(0, 374);
            dgStoks.MultiSelect = false;
            dgStoks.Name = "dgStoks";
            dgStoks.ReadOnly = true;
            dgStoks.RowHeadersWidth = 51;
            dgStoks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgStoks.Size = new Size(1084, 243);
            dgStoks.TabIndex = 13;
            dgStoks.RowEnter += dgStocks_RowEnter;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lbStocls
            // 
            lbStocls.AutoSize = true;
            lbStocls.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbStocls.Location = new Point(808, 96);
            lbStocls.Name = "lbStocls";
            lbStocls.Size = new Size(71, 34);
            lbStocls.TabIndex = 15;
            lbStocls.Text = "المبلغ :";
            // 
            // numStocks
            // 
            numStocks.Location = new Point(808, 138);
            numStocks.Name = "numStocks";
            numStocks.Size = new Size(185, 36);
            numStocks.TabIndex = 16;
            numStocks.TextAlign = HorizontalAlignment.Center;
            numStocks.Maximum = 485121540546m;
            // 
            // IDColumn
            // 
            IDColumn.DataPropertyName = "ID";
            IDColumn.HeaderText = "رقم الخزنة";
            IDColumn.MinimumWidth = 6;
            IDColumn.Name = "IDColumn";
            IDColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            NameColumn.DataPropertyName = "Name";
            NameColumn.HeaderText = "أسم الخزنة";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            // 
            // ColumnTotalMoney
            // 
            ColumnTotalMoney.DataPropertyName = "TotalMoney";
            ColumnTotalMoney.HeaderText = "المبلغ";
            ColumnTotalMoney.MinimumWidth = 6;
            ColumnTotalMoney.Name = "ColumnTotalMoney";
            ColumnTotalMoney.ReadOnly = true;
            // 
            // frmStock
            // 
            AutoScaleDimensions = new SizeF(9F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1084, 689);
            Controls.Add(numStocks);
            Controls.Add(lbStocls);
            Controls.Add(dgStoks);
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
            Name = "frmStock";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة المجموعات";
            Load += frmStock_Load;
            panTop.ResumeLayout(false);
            panTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgStoks).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStocks).EndInit();
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
        private DataGridView dgStoks;
        private ErrorProvider errorProvider1;
        private NumericUpDown numStocks;
        private Label lbStocls;
        private DataGridViewTextBoxColumn IDColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn ColumnTotalMoney;
    }
}