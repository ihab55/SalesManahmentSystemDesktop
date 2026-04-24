using SalesManahmentSystemBLL.Services;

namespace SalesManahmentSystemPL
{
    partial class frmSaleOrder
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
            panType = new Panel();
            rbExpense = new RadioButton();
            rbPurchase = new RadioButton();
            rbSale = new RadioButton();
            lbType = new Label();
            numCount = new NumericUpDown();
            lbCount = new Label();
            cbProducts = new ComboBox();
            lbProduct = new Label();
            panRow1 = new Panel();
            cbCutomers = new ComboBox();
            lbCustomer = new Label();
            cbStock = new ComboBox();
            lbStock = new Label();
            dtpTime = new DateTimePicker();
            lbTime = new Label();
            txtID = new TextBox();
            lbID = new Label();
            panButtons = new Panel();
            btnSave = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            dgrecit = new DataGridView();
            cProductID = new DataGridViewTextBoxColumn();
            clProductName = new DataGridViewTextBoxColumn();
            clQuantity = new DataGridViewTextBoxColumn();
            clProductSellPrice = new DataGridViewTextBoxColumn();
            clTotal = new DataGridViewTextBoxColumn();
            panFooter = new Panel();
            lbTotalPrice = new Label();
            numTotalPrice = new NumericUpDown();
            errorProvider1 = new ErrorProvider(components);
            panTop.SuspendLayout();
            panInput.SuspendLayout();
            panRow2.SuspendLayout();
            panType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCount).BeginInit();
            panRow1.SuspendLayout();
            panButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrecit).BeginInit();
            panFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTotalPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            lbHead.Text = "شاشة المبيعات";
            lbHead.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panInput
            // 
            panInput.BackColor = Color.White;
            panInput.Controls.Add(panRow2);
            panInput.Controls.Add(panRow1);
            panInput.Location = new Point(50, 120);
            panInput.Name = "panInput";
            panInput.Size = new Size(900, 208);
            panInput.TabIndex = 1;
            // 
            // panRow2
            // 
            panRow2.Controls.Add(panType);
            panRow2.Controls.Add(numCount);
            panRow2.Controls.Add(lbCount);
            panRow2.Controls.Add(cbProducts);
            panRow2.Controls.Add(lbProduct);
            panRow2.Location = new Point(20, 116);
            panRow2.Name = "panRow2";
            panRow2.Size = new Size(860, 89);
            panRow2.TabIndex = 1;
            // 
            // panType
            // 
            panType.BackColor = Color.FromArgb(245, 247, 250);
            panType.BorderStyle = BorderStyle.FixedSingle;
            panType.Controls.Add(rbExpense);
            panType.Controls.Add(rbPurchase);
            panType.Controls.Add(rbSale);
            panType.Controls.Add(lbType);
            panType.Location = new Point(20, 5);
            panType.Name = "panType";
            panType.Size = new Size(367, 81);
            panType.TabIndex = 4;
            // 
            // rbExpense
            // 
            rbExpense.AutoSize = true;
            rbExpense.Font = new Font("Dubai", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbExpense.Location = new Point(100, 32);
            rbExpense.Name = "rbExpense";
            rbExpense.Size = new Size(105, 36);
            rbExpense.TabIndex = 3;
            rbExpense.Text = "مصروفات";
            rbExpense.UseVisualStyleBackColor = true;
            // 
            // rbPurchase
            // 
            rbPurchase.AutoSize = true;
            rbPurchase.Font = new Font("Dubai", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbPurchase.Location = new Point(210, 32);
            rbPurchase.Name = "rbPurchase";
            rbPurchase.Size = new Size(69, 36);
            rbPurchase.TabIndex = 2;
            rbPurchase.Text = "شراء";
            rbPurchase.UseVisualStyleBackColor = true;
            // 
            // rbSale
            // 
            rbSale.AutoSize = true;
            rbSale.Checked = true;
            rbSale.Font = new Font("Dubai", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbSale.Location = new Point(300, 32);
            rbSale.Name = "rbSale";
            rbSale.Size = new Size(57, 36);
            rbSale.TabIndex = 1;
            rbSale.TabStop = true;
            rbSale.Text = "بيع";
            rbSale.UseVisualStyleBackColor = true;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Font = new Font("Dubai", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbType.ForeColor = Color.FromArgb(45, 85, 95);
            lbType.Location = new Point(252, 2);
            lbType.Name = "lbType";
            lbType.Size = new Size(91, 29);
            lbType.TabIndex = 0;
            lbType.Text = "نوع الفاتورة :";
            // 
            // numCount
            // 
            numCount.BackColor = Color.White;
            numCount.BorderStyle = BorderStyle.FixedSingle;
            numCount.Font = new Font("Dubai", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numCount.Location = new Point(410, 35);
            numCount.Maximum = new decimal(new int[] { 50000000, 0, 0, 0 });
            numCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCount.Name = "numCount";
            numCount.Size = new Size(100, 38);
            numCount.TabIndex = 3;
            numCount.TextAlign = HorizontalAlignment.Center;
            numCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCount.ForeColor = Color.FromArgb(45, 85, 95);
            lbCount.Location = new Point(460, 5);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(69, 32);
            lbCount.TabIndex = 2;
            lbCount.Text = "الكمية :";
            // 
            // cbProducts
            // 
            cbProducts.BackColor = Color.White;
            cbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProducts.Font = new Font("Dubai", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(530, 35);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(300, 38);
            cbProducts.TabIndex = 1;
            // 
            // lbProduct
            // 
            lbProduct.AutoSize = true;
            lbProduct.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProduct.ForeColor = Color.FromArgb(45, 85, 95);
            lbProduct.Location = new Point(770, 5);
            lbProduct.Name = "lbProduct";
            lbProduct.Size = new Size(73, 32);
            lbProduct.TabIndex = 0;
            lbProduct.Text = "الصنف :";
            // 
            // panRow1
            // 
            panRow1.Controls.Add(cbCutomers);
            panRow1.Controls.Add(lbCustomer);
            panRow1.Controls.Add(cbStock);
            panRow1.Controls.Add(lbStock);
            panRow1.Controls.Add(dtpTime);
            panRow1.Controls.Add(lbTime);
            panRow1.Controls.Add(txtID);
            panRow1.Controls.Add(lbID);
            panRow1.Location = new Point(20, 15);
            panRow1.Name = "panRow1";
            panRow1.Size = new Size(860, 95);
            panRow1.TabIndex = 0;
            // 
            // cbCutomers
            // 
            cbCutomers.BackColor = Color.White;
            cbCutomers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCutomers.Font = new Font("Dubai", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCutomers.FormattingEnabled = true;
            cbCutomers.Location = new Point(20, 35);
            cbCutomers.Name = "cbCutomers";
            cbCutomers.Size = new Size(250, 38);
            cbCutomers.TabIndex = 7;
            // 
            // lbCustomer
            // 
            lbCustomer.AutoSize = true;
            lbCustomer.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCustomer.ForeColor = Color.FromArgb(45, 85, 95);
            lbCustomer.Location = new Point(210, 5);
            lbCustomer.Name = "lbCustomer";
            lbCustomer.Size = new Size(74, 32);
            lbCustomer.TabIndex = 6;
            lbCustomer.Text = "العميل :";
            // 
            // cbStock
            // 
            cbStock.BackColor = Color.White;
            cbStock.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStock.Font = new Font("Dubai", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStock.FormattingEnabled = true;
            cbStock.Location = new Point(330, 35);
            cbStock.Name = "cbStock";
            cbStock.Size = new Size(160, 38);
            cbStock.TabIndex = 5;
            // 
            // lbStock
            // 
            lbStock.AutoSize = true;
            lbStock.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbStock.ForeColor = Color.FromArgb(45, 85, 95);
            lbStock.Location = new Point(430, 5);
            lbStock.Name = "lbStock";
            lbStock.Size = new Size(66, 32);
            lbStock.TabIndex = 4;
            lbStock.Text = "الخزنة :";
            // 
            // dtpTime
            // 
            dtpTime.Font = new Font("Dubai", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTime.Format = DateTimePickerFormat.Short;
            dtpTime.Location = new Point(560, 35);
            dtpTime.Name = "dtpTime";
            dtpTime.Size = new Size(160, 38);
            dtpTime.TabIndex = 3;
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTime.ForeColor = Color.FromArgb(45, 85, 95);
            lbTime.Location = new Point(610, 5);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(71, 32);
            lbTime.TabIndex = 2;
            lbTime.Text = "التاريخ :";
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(245, 247, 250);
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Enabled = false;
            txtID.Font = new Font("Dubai", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(750, 35);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(100, 38);
            txtID.TabIndex = 1;
            txtID.TextAlign = HorizontalAlignment.Center;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbID.ForeColor = Color.FromArgb(45, 85, 95);
            lbID.Location = new Point(755, 5);
            lbID.Name = "lbID";
            lbID.Size = new Size(105, 32);
            lbID.TabIndex = 0;
            lbID.Text = "رقم الفاتورة :";
            // 
            // panButtons
            // 
            panButtons.Controls.Add(btnSave);
            panButtons.Controls.Add(btnDelete);
            panButtons.Controls.Add(btnAdd);
            panButtons.Location = new Point(50, 334);
            panButtons.Name = "panButtons";
            panButtons.Size = new Size(900, 70);
            panButtons.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(25, 118, 210);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(30, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(220, 50);
            btnSave.TabIndex = 2;
            btnSave.Text = "💾 حفظ الفاتورة";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(211, 47, 47);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(340, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(220, 50);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "🗑️ حذف صنف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 125, 50);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(650, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(220, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "✅ إضافة صنف";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgrecit
            // 
            dgrecit.AllowUserToAddRows = false;
            dgrecit.AllowUserToDeleteRows = false;
            dgrecit.AllowUserToResizeColumns = false;
            dgrecit.AllowUserToResizeRows = false;
            dgrecit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrecit.BackgroundColor = Color.White;
            dgrecit.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgrecit.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 85, 95);
            dataGridViewCellStyle1.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(45, 85, 95);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgrecit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgrecit.ColumnHeadersHeight = 40;
            dgrecit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgrecit.Columns.AddRange(new DataGridViewColumn[] { cProductID, clProductName, clQuantity, clProductSellPrice, clTotal });
            dgrecit.EnableHeadersVisualStyles = false;
            dgrecit.GridColor = Color.FromArgb(224, 224, 224);
            dgrecit.Location = new Point(50, 410);
            dgrecit.MultiSelect = false;
            dgrecit.Name = "dgrecit";
            dgrecit.ReadOnly = true;
            dgrecit.RowHeadersVisible = false;
            dgrecit.RowHeadersWidth = 51;
            dgrecit.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgrecit.RowTemplate.DefaultCellStyle.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgrecit.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgrecit.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 230, 201);
            dgrecit.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgrecit.RowTemplate.Height = 40;
            dgrecit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrecit.Size = new Size(900, 200);
            dgrecit.TabIndex = 3;
            // 
            // cProductID
            // 
            cProductID.DataPropertyName = "ID";
            cProductID.HeaderText = "رقم الصنف";
            cProductID.MinimumWidth = 6;
            cProductID.Name = "cProductID";
            cProductID.ReadOnly = true;
            // 
            // clProductName
            // 
            clProductName.DataPropertyName = "Name";
            clProductName.HeaderText = "اسم الصنف";
            clProductName.MinimumWidth = 6;
            clProductName.Name = "clProductName";
            clProductName.ReadOnly = true;
            // 
            // clQuantity
            // 
            clQuantity.DataPropertyName = "quantity";
            clQuantity.HeaderText = "الكمية";
            clQuantity.MinimumWidth = 6;
            clQuantity.Name = "clQuantity";
            clQuantity.ReadOnly = true;
            // 
            // clProductSellPrice
            // 
            clProductSellPrice.DataPropertyName = "SalePrice";
            clProductSellPrice.HeaderText = "سعر البيع";
            clProductSellPrice.MinimumWidth = 6;
            clProductSellPrice.Name = "clProductSellPrice";
            clProductSellPrice.ReadOnly = true;
            // 
            // clTotal
            // 
            clTotal.DataPropertyName = "lineTotal";
            clTotal.HeaderText = "الإجمالي";
            clTotal.MinimumWidth = 6;
            clTotal.Name = "clTotal";
            clTotal.ReadOnly = true;
            // 
            // panFooter
            // 
            panFooter.BackColor = Color.FromArgb(45, 85, 95);
            panFooter.Controls.Add(lbTotalPrice);
            panFooter.Controls.Add(numTotalPrice);
            panFooter.Dock = DockStyle.Bottom;
            panFooter.Location = new Point(0, 616);
            panFooter.Name = "panFooter";
            panFooter.Size = new Size(1000, 60);
            panFooter.TabIndex = 4;
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.AutoSize = true;
            lbTotalPrice.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalPrice.ForeColor = Color.White;
            lbTotalPrice.Location = new Point(280, 15);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(133, 34);
            lbTotalPrice.TabIndex = 1;
            lbTotalPrice.Text = "إجمالي الفاتورة :";
            // 
            // numTotalPrice
            // 
            numTotalPrice.BackColor = Color.FromArgb(230, 230, 230);
            numTotalPrice.Enabled = false;
            numTotalPrice.Font = new Font("Dubai", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numTotalPrice.Location = new Point(100, 12);
            numTotalPrice.Maximum = new decimal(new int[] { 50000000, 0, 0, 0 });
            numTotalPrice.Name = "numTotalPrice";
            numTotalPrice.ReadOnly = true;
            numTotalPrice.Size = new Size(160, 38);
            numTotalPrice.TabIndex = 0;
            numTotalPrice.TextAlign = HorizontalAlignment.Center;
            numTotalPrice.ThousandsSeparator = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmSaleOrder
            // 
            AutoScaleDimensions = new SizeF(9F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1000, 676);
            Controls.Add(panFooter);
            Controls.Add(dgrecit);
            Controls.Add(panButtons);
            Controls.Add(panInput);
            Controls.Add(panTop);
            Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            Name = "frmSaleOrder";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة المبيعات";
            Load += frmSaleOrder_Load;
            panTop.ResumeLayout(false);
            panInput.ResumeLayout(false);
            panRow2.ResumeLayout(false);
            panRow2.PerformLayout();
            panType.ResumeLayout(false);
            panType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCount).EndInit();
            panRow1.ResumeLayout(false);
            panRow1.PerformLayout();
            panButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrecit).EndInit();
            panFooter.ResumeLayout(false);
            panFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTotalPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panTop;
        private Label lbHead;
        private Panel panInput;
        private Panel panRow1;
        private Label lbID;
        private TextBox txtID;
        private Label lbTime;
        private DateTimePicker dtpTime;
        private Label lbCustomer;
        private ComboBox cbCutomers;
        private Panel panRow2;
        private Label lbProduct;
        private ComboBox cbProducts;
        private Label lbCount;
        private NumericUpDown numCount;
        private Panel panButtons;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSave;
        private DataGridView dgrecit;
        private DataGridViewTextBoxColumn cProductID;
        private DataGridViewTextBoxColumn clProductName;
        private DataGridViewTextBoxColumn clQuantity;
        private DataGridViewTextBoxColumn clProductSellPrice;
        private DataGridViewTextBoxColumn clTotal;
        private Panel panFooter;
        private Label lbTotalPrice;
        private NumericUpDown numTotalPrice;
        private ErrorProvider errorProvider1;
        private Label lbStock;
        private ComboBox cbStock;
        private Panel panType;
        private Label lbType;
        private RadioButton rbSale;
        private RadioButton rbPurchase;
        private RadioButton rbExpense;
    }
}
