using SalesManahmentSystemBLL.Services;

namespace SalesManahmentSystemPL
{
    partial class frmSaleOrder
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
            lbTotalPrice = new Label();
            numTotalPrice = new NumericUpDown();
            txtID = new TextBox();
            lbID = new Label();
            lbProduct = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            dgrecit = new DataGridView();
            cProductID = new DataGridViewTextBoxColumn();
            clProductName = new DataGridViewTextBoxColumn();
            clQuantity = new DataGridViewTextBoxColumn();
            clProductSellPrice = new DataGridViewTextBoxColumn();
            clTotal = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            lbTime = new Label();
            lbCustomer = new Label();
            numCount = new NumericUpDown();
            cbProducts = new ComboBox();
            dtpTime = new DateTimePicker();
            cbCutomers = new ComboBox();
            panTop.SuspendLayout();
            panBotton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTotalPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgrecit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCount).BeginInit();
            SuspendLayout();
            // 
            // panTop
            // 
            panTop.BackColor = Color.DarkSlateGray;
            panTop.Controls.Add(lbHead);
            panTop.Dock = DockStyle.Top;
            panTop.Location = new Point(0, 0);
            panTop.Name = "panTop";
            panTop.Size = new Size(1062, 93);
            panTop.TabIndex = 0;
            // 
            // lbHead
            // 
            lbHead.AutoSize = true;
            lbHead.Font = new Font("Dubai", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHead.ForeColor = SystemColors.Window;
            lbHead.Location = new Point(434, 21);
            lbHead.Name = "lbHead";
            lbHead.Size = new Size(194, 51);
            lbHead.TabIndex = 27;
            lbHead.Text = "شاشة المبيعات";
            // 
            // panBotton
            // 
            panBotton.BackColor = Color.DarkSlateGray;
            panBotton.Controls.Add(lbTotalPrice);
            panBotton.Controls.Add(numTotalPrice);
            panBotton.Dock = DockStyle.Bottom;
            panBotton.Location = new Point(0, 540);
            panBotton.Name = "panBotton";
            panBotton.Size = new Size(1062, 78);
            panBotton.TabIndex = 0;
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.AutoSize = true;
            lbTotalPrice.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalPrice.ForeColor = SystemColors.Window;
            lbTotalPrice.Location = new Point(188, 21);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(128, 34);
            lbTotalPrice.TabIndex = 23;
            lbTotalPrice.Text = "أجمالي الفاتورة :";
            // 
            // numTotalPrice
            // 
            numTotalPrice.Location = new Point(27, 19);
            numTotalPrice.Maximum = new decimal(new int[] { 50000000, 0, 0, 0 });
            numTotalPrice.Name = "numTotalPrice";
            numTotalPrice.Size = new Size(140, 36);
            numTotalPrice.TabIndex = 22;
            numTotalPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(43, 153);
            txtID.Name = "txtID";
            txtID.Size = new Size(189, 41);
            txtID.TabIndex = 3;
            txtID.TextAlign = HorizontalAlignment.Center;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbID.Location = new Point(43, 109);
            lbID.Name = "lbID";
            lbID.Size = new Size(110, 34);
            lbID.TabIndex = 4;
            lbID.Text = "رقم الفاتورة :";
            // 
            // lbProduct
            // 
            lbProduct.AutoSize = true;
            lbProduct.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProduct.Location = new Point(233, 214);
            lbProduct.Name = "lbProduct";
            lbProduct.Size = new Size(86, 34);
            lbProduct.TabIndex = 5;
            lbProduct.Text = "الاصناف :";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkSlateGray;
            btnAdd.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.Window;
            btnAdd.Location = new Point(599, 246);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 48);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "أضافة";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkSlateGray;
            btnDelete.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.Window;
            btnDelete.Location = new Point(746, 246);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 48);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearchByDate
            // 
            btnSave.BackColor = Color.DarkSlateGray;
            btnSave.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.Window;
            btnSave.Location = new Point(817, 150);
            btnSave.Name = "btnSearchByDate";
            btnSave.Size = new Size(195, 41);
            btnSave.TabIndex = 11;
            btnSave.Text = "حفظ";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dgrecit
            // 
            dgrecit.AllowUserToAddRows = false;
            dgrecit.AllowUserToDeleteRows = false;
            dgrecit.AllowUserToResizeColumns = false;
            dgrecit.AllowUserToResizeRows = false;
            dgrecit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrecit.BackgroundColor = Color.MistyRose;
            dgrecit.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgrecit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrecit.Columns.AddRange(new DataGridViewColumn[] { cProductID, clProductName, clQuantity, clProductSellPrice, clTotal });
            dgrecit.Location = new Point(0, 335);
            dgrecit.MultiSelect = false;
            dgrecit.Name = "dgrecit";
            dgrecit.ReadOnly = true;
            dgrecit.RowHeadersWidth = 51;
            dgrecit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrecit.Size = new Size(1059, 199);
            dgrecit.TabIndex = 13;
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
            clProductName.HeaderText = "أسم الصنف";
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
            clTotal.HeaderText = "لأجمالي";
            clTotal.MinimumWidth = 6;
            clTotal.Name = "clTotal";
            clTotal.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTime.Location = new Point(314, 109);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(74, 34);
            lbTime.TabIndex = 15;
            lbTime.Text = "التاريخ :";
            // 
            // lbCustomer
            // 
            lbCustomer.AutoSize = true;
            lbCustomer.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCustomer.Location = new Point(570, 109);
            lbCustomer.Name = "lbCustomer";
            lbCustomer.Size = new Size(78, 34);
            lbCustomer.TabIndex = 19;
            lbCustomer.Text = "العميل :";
            // 
            // numCount
            // 
            numCount.Location = new Point(495, 254);
            numCount.Maximum = new decimal(new int[] { 50000000, 0, 0, 0 });
            numCount.Name = "numCount";
            numCount.Size = new Size(65, 36);
            numCount.TabIndex = 22;
            numCount.TextAlign = HorizontalAlignment.Center;
            // 
            // cbProducts
            // 
            cbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(233, 253);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(237, 37);
            cbProducts.TabIndex = 24;
            // 
            // dtpFrom
            // 
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.Location = new Point(314, 155);
            dtpTime.Name = "dtpFrom";
            dtpTime.Size = new Size(189, 36);
            dtpTime.TabIndex = 25;
            // 
            // cbCutomers
            // 
            cbCutomers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCutomers.FormattingEnabled = true;
            cbCutomers.Location = new Point(570, 155);
            cbCutomers.Name = "cbCutomers";
            cbCutomers.Size = new Size(189, 37);
            cbCutomers.TabIndex = 26;
            // 
            // frmSaleOrder
            // 
            AutoScaleDimensions = new SizeF(9F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Snow;
            ClientSize = new Size(1062, 618);
            Controls.Add(cbCutomers);
            Controls.Add(dtpTime);
            Controls.Add(cbProducts);
            Controls.Add(numCount);
            Controls.Add(lbCustomer);
            Controls.Add(lbTime);
            Controls.Add(dgrecit);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lbProduct);
            Controls.Add(lbID);
            Controls.Add(txtID);
            Controls.Add(panBotton);
            Controls.Add(panTop);
            Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Margin = new Padding(3, 5, 3, 5);
            Name = "frmSaleOrder";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة الاصناف";
            Load += frmSaleOrder_Load;
            panTop.ResumeLayout(false);
            panTop.PerformLayout();
            panBotton.ResumeLayout(false);
            panBotton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTotalPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgrecit).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panTop;
        private Panel panBotton;
        private TextBox txtID;
        private Label lbID;
        private Label lbProduct;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSave;
        private DataGridView dgrecit;
        private ErrorProvider errorProvider1;
        private Label lbTime;
        private Label lbCustomer;
        private NumericUpDown numCount;
        private NumericUpDown numTotalPrice;
        private ComboBox cbProducts;
        private ComboBox cbCutomers;
        private DateTimePicker dtpTime;
        private Label lbHead;
        private Label lbTotalPrice;
        private DataGridViewTextBoxColumn cProductID;
        private DataGridViewTextBoxColumn clProductName;
        private DataGridViewTextBoxColumn clQuantity;
        private DataGridViewTextBoxColumn clProductSellPrice;
        private DataGridViewTextBoxColumn clTotal;
    }
}