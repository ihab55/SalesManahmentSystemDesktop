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
            panTop = new Panel();
            lbHead = new Label();
            panBotton = new Panel();
            txtID = new TextBox();
            lbID = new Label();
            lbSPrıce = new Label();
            btnNew = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnDeleteAll = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgProducts = new DataGridView();
            IDColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            QUANTITY = new DataGridViewTextBoxColumn();
            SALEPRICE = new DataGridViewTextBoxColumn();
            BUYPRICE = new DataGridViewTextBoxColumn();
            CATEGORYID = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            lbName = new Label();
            txtName = new TextBox();
            lbBPrıce = new Label();
            lbCount = new Label();
            lbCatagory = new Label();
            numBPrıce = new NumericUpDown();
            numSPrıce = new NumericUpDown();
            numCount = new NumericUpDown();
            cbCatagory = new ComboBox();
            panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBPrıce).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSPrıce).BeginInit();
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
            panTop.Size = new Size(1148, 93);
            panTop.TabIndex = 0;
            // 
            // lbHead
            // 
            lbHead.AutoSize = true;
            lbHead.Font = new Font("Dubai", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHead.ForeColor = SystemColors.Window;
            lbHead.Location = new Point(438, 19);
            lbHead.Name = "lbHead";
            lbHead.Size = new Size(184, 51);
            lbHead.TabIndex = 1;
            lbHead.Text = "شاشة الاصناف";
            // 
            // panBotton
            // 
            panBotton.BackColor = Color.DarkSlateGray;
            panBotton.Dock = DockStyle.Bottom;
            panBotton.Location = new Point(0, 768);
            panBotton.Name = "panBotton";
            panBotton.Size = new Size(1148, 78);
            panBotton.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(80, 153);
            txtID.Name = "txtID";
            txtID.Size = new Size(242, 41);
            txtID.TabIndex = 3;
            txtID.TextAlign = HorizontalAlignment.Center;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbID.Location = new Point(80, 109);
            lbID.Name = "lbID";
            lbID.Size = new Size(117, 34);
            lbID.TabIndex = 4;
            lbID.Text = "رقم الاصناف :";
            // 
            // lbSPrıce
            // 
            lbSPrıce.AutoSize = true;
            lbSPrıce.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSPrıce.Location = new Point(80, 204);
            lbSPrıce.Name = "lbSPrıce";
            lbSPrıce.Size = new Size(101, 34);
            lbSPrıce.TabIndex = 5;
            lbSPrıce.Text = "سعر البيع :";
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.DarkSlateGray;
            btnNew.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.ForeColor = SystemColors.Window;
            btnNew.Location = new Point(50, 321);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(189, 48);
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
            btnAdd.Location = new Point(263, 321);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(189, 48);
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
            btnUpdate.Location = new Point(476, 321);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(189, 48);
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
            btnDelete.Location = new Point(689, 321);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(189, 48);
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
            btnDeleteAll.Location = new Point(902, 321);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(189, 48);
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
            btnSearch.Location = new Point(618, 397);
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
            txtSearch.Location = new Point(235, 396);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(351, 41);
            txtSearch.TabIndex = 12;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // dgProducts
            // 
            dgProducts.AllowUserToAddRows = false;
            dgProducts.AllowUserToDeleteRows = false;
            dgProducts.AllowUserToResizeColumns = false;
            dgProducts.AllowUserToResizeRows = false;
            dgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProducts.BackgroundColor = Color.MistyRose;
            dgProducts.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProducts.Columns.AddRange(new DataGridViewColumn[] { IDColumn, NameColumn, QUANTITY, SALEPRICE, BUYPRICE, CATEGORYID });
            dgProducts.Location = new Point(0, 481);
            dgProducts.MultiSelect = false;
            dgProducts.Name = "dgProducts";
            dgProducts.ReadOnly = true;
            dgProducts.RowHeadersWidth = 51;
            dgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProducts.Size = new Size(1148, 289);
            dgProducts.TabIndex = 13;
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
            NameColumn.HeaderText = "أسم الصنف";
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
            // CATEGORYID
            // 
            CATEGORYID.DataPropertyName = "CATEGORYID";
            CATEGORYID.HeaderText = "المجموعة";
            CATEGORYID.MinimumWidth = 6;
            CATEGORYID.Name = "CATEGORYID";
            CATEGORYID.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(441, 109);
            lbName.Name = "lbName";
            lbName.Size = new Size(119, 34);
            lbName.TabIndex = 15;
            lbName.Text = "أسم لاصناف :";
            // 
            // txtName
            // 
            txtName.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(441, 153);
            txtName.Name = "txtName";
            txtName.Size = new Size(242, 41);
            txtName.TabIndex = 14;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // lbBPrıce
            // 
            lbBPrıce.AutoSize = true;
            lbBPrıce.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbBPrıce.Location = new Point(441, 204);
            lbBPrıce.Name = "lbBPrıce";
            lbBPrıce.Size = new Size(112, 34);
            lbBPrıce.TabIndex = 17;
            lbBPrıce.Text = "سعر الشراء :";
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCount.Location = new Point(793, 109);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(72, 34);
            lbCount.TabIndex = 19;
            lbCount.Text = "الكمية :";
            // 
            // lbCatagory
            // 
            lbCatagory.AutoSize = true;
            lbCatagory.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCatagory.Location = new Point(793, 204);
            lbCatagory.Name = "lbCatagory";
            lbCatagory.Size = new Size(98, 34);
            lbCatagory.TabIndex = 21;
            lbCatagory.Text = "المجموعة :";
            // 
            // numBPrıce
            // 
            numBPrıce.Location = new Point(441, 253);
            numBPrıce.Name = "numBPrıce";
            numBPrıce.Size = new Size(242, 36);
            numBPrıce.TabIndex = 22;
            // 
            // numSPrıce
            // 
            numSPrıce.Location = new Point(80, 253);
            numSPrıce.Name = "numSPrıce";
            numSPrıce.Size = new Size(242, 36);
            numSPrıce.TabIndex = 22;
            // 
            // numCount
            // 
            numCount.Location = new Point(793, 155);
            numCount.Name = "numCount";
            numCount.Size = new Size(242, 36);
            numCount.TabIndex = 23;
            // 
            // cbCatagory
            // 
            cbCatagory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCatagory.FormattingEnabled = true;
            cbCatagory.Location = new Point(793, 253);
            cbCatagory.Name = "cbCatagory";
            cbCatagory.Size = new Size(242, 37);
            cbCatagory.TabIndex = 24;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(9F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Snow;
            ClientSize = new Size(1148, 846);
            Controls.Add(cbCatagory);
            Controls.Add(numCount);
            Controls.Add(numSPrıce);
            Controls.Add(numBPrıce);
            Controls.Add(lbCatagory);
            Controls.Add(lbCount);
            Controls.Add(lbBPrıce);
            Controls.Add(lbName);
            Controls.Add(txtName);
            Controls.Add(dgProducts);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnNew);
            Controls.Add(lbSPrıce);
            Controls.Add(lbID);
            Controls.Add(txtID);
            Controls.Add(panBotton);
            Controls.Add(panTop);
            Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Margin = new Padding(3, 5, 3, 5);
            Name = "frmProduct";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة الاصناف";
            Load += FrmProduct_Load;
            panTop.ResumeLayout(false);
            panTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBPrıce).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSPrıce).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panTop;
        private Label lbHead;
        private Panel panBotton;
        private TextBox txtID;
        private Label lbID;
        private Label lbSPrıce;
        private Button btnNew;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnDeleteAll;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgProducts;
        private ErrorProvider errorProvider1;
        private Label lbCatagory;
        private Label lbCount;
        private Label lbBPrıce;
        private Label lbName;
        private TextBox txtName;
        private NumericUpDown numCount;
        private NumericUpDown numSPrıce;
        private NumericUpDown numBPrıce;
        private ComboBox cbCatagory;
        private DataGridViewTextBoxColumn IDColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn QUANTITY;
        private DataGridViewTextBoxColumn SALEPRICE;
        private DataGridViewTextBoxColumn BUYPRICE;
        private DataGridViewTextBoxColumn CATEGORYID;
    }
}