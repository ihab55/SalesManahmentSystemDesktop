using SalesManahmentSystemBLL.Services;

namespace SalesManahmentSystemPL
{
    partial class frmStock
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
            lbTotalMoney = new Label();
            numTotalMoney = new NumericUpDown();
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
            dgStocks = new DataGridView();
            IDColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            ColumnTotalMoney = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            panFooter = new Panel();
            lbFooter = new Label();
            panTop.SuspendLayout();
            panInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTotalMoney).BeginInit();
            panButtons.SuspendLayout();
            panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgStocks).BeginInit();
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
            lbHead.Text = "إدارة الخزائن";
            lbHead.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panInput
            // 
            panInput.BackColor = Color.White;
            panInput.Controls.Add(lbTotalMoney);
            panInput.Controls.Add(numTotalMoney);
            panInput.Controls.Add(lbName);
            panInput.Controls.Add(txtName);
            panInput.Controls.Add(lbID);
            panInput.Controls.Add(txtID);
            panInput.Location = new Point(50, 120);
            panInput.Name = "panInput";
            panInput.Size = new Size(900, 130);
            panInput.TabIndex = 1;
            // 
            // lbTotalMoney
            // 
            lbTotalMoney.AutoSize = true;
            lbTotalMoney.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalMoney.ForeColor = Color.FromArgb(45, 85, 95);
            lbTotalMoney.Location = new Point(130, 20);
            lbTotalMoney.Name = "lbTotalMoney";
            lbTotalMoney.Size = new Size(71, 34);
            lbTotalMoney.TabIndex = 4;
            lbTotalMoney.Text = "المبلغ :";
            lbTotalMoney.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numTotalMoney
            // 
            numTotalMoney.BackColor = Color.White;
            numTotalMoney.BorderStyle = BorderStyle.FixedSingle;
            numTotalMoney.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numTotalMoney.Location = new Point(30, 55);
            numTotalMoney.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numTotalMoney.Name = "numTotalMoney";
            numTotalMoney.Size = new Size(180, 41);
            numTotalMoney.TabIndex = 5;
            numTotalMoney.TextAlign = HorizontalAlignment.Center;
            numTotalMoney.ThousandsSeparator = true;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.ForeColor = Color.FromArgb(45, 85, 95);
            lbName.Location = new Point(430, 20);
            lbName.Name = "lbName";
            lbName.Size = new Size(116, 34);
            lbName.TabIndex = 2;
            lbName.Text = "اسم الخزينة :";
            lbName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(320, 55);
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
            lbID.Location = new Point(780, 20);
            lbID.Name = "lbID";
            lbID.Size = new Size(109, 34);
            lbID.TabIndex = 0;
            lbID.Text = "رقم الخزينة :";
            lbID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(245, 247, 250);
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Enabled = false;
            txtID.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(620, 55);
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
            panButtons.Location = new Point(50, 270);
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
            panSearch.Location = new Point(50, 360);
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
            txtSearch.PlaceholderText = "ابحث باسم الخزينة او رقم الخزينة...";
            txtSearch.Size = new Size(620, 41);
            txtSearch.TabIndex = 0;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // dgStocks
            // 
            dgStocks.AllowUserToAddRows = false;
            dgStocks.AllowUserToDeleteRows = false;
            dgStocks.AllowUserToResizeColumns = false;
            dgStocks.AllowUserToResizeRows = false;
            dgStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgStocks.BackgroundColor = Color.White;
            dgStocks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgStocks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 85, 95);
            dataGridViewCellStyle1.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(45, 85, 95);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgStocks.ColumnHeadersHeight = 40;
            dgStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgStocks.Columns.AddRange(new DataGridViewColumn[] { IDColumn, NameColumn, ColumnTotalMoney });
            dgStocks.EnableHeadersVisualStyles = false;
            dgStocks.GridColor = Color.FromArgb(224, 224, 224);
            dgStocks.Location = new Point(50, 450);
            dgStocks.MultiSelect = false;
            dgStocks.Name = "dgStocks";
            dgStocks.ReadOnly = true;
            dgStocks.RowHeadersVisible = false;
            dgStocks.RowHeadersWidth = 51;
            dgStocks.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgStocks.RowTemplate.DefaultCellStyle.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgStocks.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgStocks.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 230, 201);
            dgStocks.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgStocks.RowTemplate.Height = 40;
            dgStocks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgStocks.Size = new Size(900, 250);
            dgStocks.TabIndex = 4;
            dgStocks.RowEnter += dgStocks_RowEnter;
            // 
            // IDColumn
            // 
            IDColumn.DataPropertyName = "ID";
            IDColumn.HeaderText = "رقم الخزينة";
            IDColumn.MinimumWidth = 6;
            IDColumn.Name = "IDColumn";
            IDColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            NameColumn.DataPropertyName = "Name";
            NameColumn.HeaderText = "اسم الخزينة";
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
            // frmStock
            // 
            AutoScaleDimensions = new SizeF(9F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1000, 770);
            Controls.Add(panFooter);
            Controls.Add(dgStocks);
            Controls.Add(panSearch);
            Controls.Add(panButtons);
            Controls.Add(panInput);
            Controls.Add(panTop);
            Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            Name = "frmStock";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدارة الخزائن";
            Load += frmStock_Load;
            panTop.ResumeLayout(false);
            panInput.ResumeLayout(false);
            panInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTotalMoney).EndInit();
            panButtons.ResumeLayout(false);
            panSearch.ResumeLayout(false);
            panSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgStocks).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panTop;
        private Label lbHead;
        private Panel panInput;
        private Label lbID;
        private TextBox txtID;
        private Label lbName;
        private TextBox txtName;
        private Label lbTotalMoney;
        private NumericUpDown numTotalMoney;
        private Panel panButtons;
        private Button btnNew;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnDeleteAll;
        private Panel panSearch;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgStocks;
        private DataGridViewTextBoxColumn IDColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn ColumnTotalMoney;
        private ErrorProvider errorProvider1;
        private Panel panFooter;
        private Label lbFooter;
    }
}
