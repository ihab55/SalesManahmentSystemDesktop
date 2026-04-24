using SalesManahmentSystemBLL.Services;

namespace SalesManahmentSystemPL
{
    partial class frmProduct
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panTop = new Panel();
            lbHead = new Label();
            panInput = new Panel();
            panRow2 = new Panel();
            lbCatagory = new Label();
            cbCatagory = new ComboBox();
            lbBPrice = new Label();
            numBPrice = new NumericUpDown();
            lbSPrice = new Label();
            numSPrice = new NumericUpDown();
            panRow1 = new Panel();
            lbCount = new Label();
            numCount = new NumericUpDown();
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
            dgProducts = new DataGridView();
            IDColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            QUANTITY = new DataGridViewTextBoxColumn();
            SALEPRICE = new DataGridViewTextBoxColumn();
            BUYPRICE = new DataGridViewTextBoxColumn();
            CATEGORYNAME = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            panFooter = new Panel();
            lbFooter = new Label();
            panTop.SuspendLayout();
            panInput.SuspendLayout();
            panRow2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSPrice).BeginInit();
            panRow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCount).BeginInit();
            panButtons.SuspendLayout();
            panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
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
            lbHead.Text = "إدارة الأصناف";
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
            panRow2.Controls.Add(lbCatagory);
            panRow2.Controls.Add(cbCatagory);
            panRow2.Controls.Add(lbBPrice);
            panRow2.Controls.Add(numBPrice);
            panRow2.Controls.Add(lbSPrice);
            panRow2.Controls.Add(numSPrice);
            panRow2.Dock = DockStyle.Bottom;
            panRow2.Location = new Point(0, 110);
            panRow2.Name = "panRow2";
            panRow2.Size = new Size(900, 90);
            panRow2.TabIndex = 1;
            // 
            // lbCatagory
            // 
            lbCatagory.AutoSize = true;
            lbCatagory.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCatagory.ForeColor = Color.FromArgb(45, 85, 95);
            lbCatagory.Location = new Point(150, 10);
            lbCatagory.Name = "lbCatagory";
            lbCatagory.Size = new Size(98, 34);
            lbCatagory.TabIndex = 4;
            lbCatagory.Text = "المجموعة :";
            lbCatagory.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbCatagory
            // 
            cbCatagory.BackColor = Color.White;
            cbCatagory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCatagory.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCatagory.FormattingEnabled = true;
            cbCatagory.Location = new Point(30, 45);
            cbCatagory.Name = "cbCatagory";
            cbCatagory.Size = new Size(180, 42);
            cbCatagory.TabIndex = 5;
            // 
            // lbBPrice
            // 
            lbBPrice.AutoSize = true;
            lbBPrice.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbBPrice.ForeColor = Color.FromArgb(45, 85, 95);
            lbBPrice.Location = new Point(430, 10);
            lbBPrice.Name = "lbBPrice";
            lbBPrice.Size = new Size(112, 34);
            lbBPrice.TabIndex = 2;
            lbBPrice.Text = "سعر الشراء :";
            lbBPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numBPrice
            // 
            numBPrice.BackColor = Color.White;
            numBPrice.BorderStyle = BorderStyle.FixedSingle;
            numBPrice.DecimalPlaces = 2;
            numBPrice.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numBPrice.Location = new Point(320, 45);
            numBPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numBPrice.Name = "numBPrice";
            numBPrice.Size = new Size(220, 41);
            numBPrice.TabIndex = 3;
            numBPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // lbSPrice
            // 
            lbSPrice.AutoSize = true;
            lbSPrice.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSPrice.ForeColor = Color.FromArgb(45, 85, 95);
            lbSPrice.Location = new Point(780, 10);
            lbSPrice.Name = "lbSPrice";
            lbSPrice.Size = new Size(101, 34);
            lbSPrice.TabIndex = 0;
            lbSPrice.Text = "سعر البيع :";
            lbSPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numSPrice
            // 
            numSPrice.BackColor = Color.White;
            numSPrice.BorderStyle = BorderStyle.FixedSingle;
            numSPrice.DecimalPlaces = 2;
            numSPrice.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numSPrice.Location = new Point(620, 45);
            numSPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSPrice.Name = "numSPrice";
            numSPrice.Size = new Size(250, 41);
            numSPrice.TabIndex = 1;
            numSPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // panRow1
            // 
            panRow1.BackColor = Color.White;
            panRow1.Controls.Add(lbCount);
            panRow1.Controls.Add(numCount);
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
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCount.ForeColor = Color.FromArgb(45, 85, 95);
            lbCount.Location = new Point(150, 10);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(72, 34);
            lbCount.TabIndex = 4;
            lbCount.Text = "الكمية :";
            lbCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numCount
            // 
            numCount.BackColor = Color.White;
            numCount.BorderStyle = BorderStyle.FixedSingle;
            numCount.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numCount.Location = new Point(30, 45);
            numCount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numCount.Name = "numCount";
            numCount.Size = new Size(180, 41);
            numCount.TabIndex = 5;
            numCount.TextAlign = HorizontalAlignment.Center;
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
            lbName.Text = "اسم الصنف :";
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
            lbID.Text = "رقم الصنف :";
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
            txtSearch.PlaceholderText = "ابحث باسم المجموعة او رقم الصنف... ";
            txtSearch.Size = new Size(620, 41);
            txtSearch.TabIndex = 0;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // dgProducts
            // 
            dgProducts.AllowUserToAddRows = false;
            dgProducts.AllowUserToDeleteRows = false;
            dgProducts.AllowUserToResizeColumns = false;
            dgProducts.AllowUserToResizeRows = false;
            dgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProducts.BackgroundColor = Color.White;
            dgProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 85, 95);
            dataGridViewCellStyle1.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(45, 85, 95);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgProducts.ColumnHeadersHeight = 40;
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgProducts.Columns.AddRange(new DataGridViewColumn[] { IDColumn, NameColumn, QUANTITY, SALEPRICE, BUYPRICE, CATEGORYNAME });
            dgProducts.EnableHeadersVisualStyles = false;
            dgProducts.GridColor = Color.FromArgb(224, 224, 224);
            dgProducts.Location = new Point(50, 500);
            dgProducts.MultiSelect = false;
            dgProducts.Name = "dgProducts";
            dgProducts.ReadOnly = true;
            dgProducts.RowHeadersVisible = false;
            dgProducts.RowHeadersWidth = 51;
            dgProducts.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgProducts.RowTemplate.DefaultCellStyle.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgProducts.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgProducts.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 230, 201);
            dgProducts.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgProducts.RowTemplate.Height = 40;
            dgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProducts.Size = new Size(900, 200);
            dgProducts.TabIndex = 4;
            dgProducts.RowEnter += dgProducts_RowEnter;
            // 
            // IDColumn
            // 
            IDColumn.DataPropertyName = "ID";
            IDColumn.HeaderText = "رقم الصنف";
            IDColumn.MinimumWidth = 6;
            IDColumn.Name = "IDColumn";
            IDColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            NameColumn.DataPropertyName = "Name";
            NameColumn.HeaderText = "اسم الصنف";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            // 
            // QUANTITY
            // 
            QUANTITY.DataPropertyName = "QUANTITY";
            QUANTITY.HeaderText = "الكمية";
            QUANTITY.MinimumWidth = 6;
            QUANTITY.Name = "QUANTITY";
            QUANTITY.ReadOnly = true;
            // 
            // SALEPRICE
            // 
            SALEPRICE.DataPropertyName = "SALEPRICE";
            SALEPRICE.HeaderText = "سعر البيع";
            SALEPRICE.MinimumWidth = 6;
            SALEPRICE.Name = "SALEPRICE";
            SALEPRICE.ReadOnly = true;
            // 
            // BUYPRICE
            // 
            BUYPRICE.DataPropertyName = "BUYPRICE";
            BUYPRICE.HeaderText = "سعر الشراء";
            BUYPRICE.MinimumWidth = 6;
            BUYPRICE.Name = "BUYPRICE";
            BUYPRICE.ReadOnly = true;
            // 
            // CATEGORYNAME
            // 
            CATEGORYNAME.DataPropertyName = "CATEGORYNAME";
            CATEGORYNAME.HeaderText = "المجموعة";
            CATEGORYNAME.MinimumWidth = 6;
            CATEGORYNAME.Name = "CATEGORYNAME";
            CATEGORYNAME.ReadOnly = true;
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
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(9F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1000, 770);
            Controls.Add(panFooter);
            Controls.Add(dgProducts);
            Controls.Add(panSearch);
            Controls.Add(panButtons);
            Controls.Add(panInput);
            Controls.Add(panTop);
            Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            Name = "frmProduct";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدارة الأصناف";
            Load += FrmProduct_Load;
            panTop.ResumeLayout(false);
            panInput.ResumeLayout(false);
            panRow2.ResumeLayout(false);
            panRow2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSPrice).EndInit();
            panRow1.ResumeLayout(false);
            panRow1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCount).EndInit();
            panButtons.ResumeLayout(false);
            panSearch.ResumeLayout(false);
            panSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
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
        private Label lbCount;
        private NumericUpDown numCount;
        private Panel panRow2;
        private Label lbSPrice;
        private NumericUpDown numSPrice;
        private Label lbBPrice;
        private NumericUpDown numBPrice;
        private Label lbCatagory;
        private ComboBox cbCatagory;
        private Panel panButtons;
        private Button btnNew;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnDeleteAll;
        private Panel panSearch;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgProducts;
        private ErrorProvider errorProvider1;
        private Panel panFooter;
        private Label lbFooter;
        private DataGridViewTextBoxColumn IDColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn QUANTITY;
        private DataGridViewTextBoxColumn SALEPRICE;
        private DataGridViewTextBoxColumn BUYPRICE;
        private DataGridViewTextBoxColumn CATEGORYNAME;
    }
}