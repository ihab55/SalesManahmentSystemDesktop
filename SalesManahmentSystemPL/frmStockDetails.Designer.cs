using SalesManahmentSystemBLL.Services;

namespace SalesManahmentSystemPL
{
    partial class frmStockDetails
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
            panTop = new Panel();
            lbHead = new Label();
            panBotton = new Panel();
            lbTotal = new Label();
            numTotal = new NumericUpDown();
            dgStockDetails = new DataGridView();
            cID = new DataGridViewTextBoxColumn();
            cStockName = new DataGridViewTextBoxColumn();
            cTypeName = new DataGridViewTextBoxColumn();
            cTOTAL = new DataGridViewTextBoxColumn();
            cDATE = new DataGridViewTextBoxColumn();
            cORDERID = new DataGridViewTextBoxColumn();
            gbSearchByStock = new GroupBox();
            btnSearchByStock = new Button();
            cbStock = new ComboBox();
            gbSearchByDate = new GroupBox();
            btnSearchByDate = new Button();
            lbTo = new Label();
            dtpTo = new DateTimePicker();
            lbFrom = new Label();
            dtpFrom = new DateTimePicker();
            gbSearchByType = new GroupBox();
            rbExpense = new RadioButton();
            rbPurchase = new RadioButton();
            rbSale = new RadioButton();
            btnSearchByType = new Button();
            btnAll = new Button();
            txtID = new TextBox();
            lbID = new Label();
            txtOrderID = new TextBox();
            lbOrderID = new Label();
            panTop.SuspendLayout();
            panBotton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgStockDetails).BeginInit();
            gbSearchByStock.SuspendLayout();
            gbSearchByDate.SuspendLayout();
            gbSearchByType.SuspendLayout();
            SuspendLayout();
            // 
            // panTop
            // 
            panTop.BackColor = Color.DarkSlateGray;
            panTop.Controls.Add(lbHead);
            panTop.Dock = DockStyle.Top;
            panTop.Location = new Point(0, 0);
            panTop.Name = "panTop";
            panTop.Size = new Size(1200, 93);
            panTop.TabIndex = 0;
            // 
            // lbHead
            // 
            lbHead.AutoSize = true;
            lbHead.Font = new Font("Dubai", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHead.ForeColor = SystemColors.Window;
            lbHead.Location = new Point(480, 19);
            lbHead.Name = "lbHead";
            lbHead.Size = new Size(240, 51);
            lbHead.TabIndex = 1;
            lbHead.Text = "شاشة حركات الخزنة";
            // 
            // panBotton
            // 
            panBotton.BackColor = Color.DarkSlateGray;
            panBotton.Controls.Add(lbTotal);
            panBotton.Controls.Add(numTotal);
            panBotton.Dock = DockStyle.Bottom;
            panBotton.Location = new Point(0, 650);
            panBotton.Name = "panBotton";
            panBotton.Size = new Size(1200, 78);
            panBotton.TabIndex = 1;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotal.ForeColor = SystemColors.Window;
            lbTotal.Location = new Point(200, 21);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(114, 34);
            lbTotal.TabIndex = 23;
            lbTotal.Text = "أجمالي المبلغ :";
            // 
            // numTotal
            // 
            numTotal.Enabled = false;
            numTotal.Location = new Point(30, 19);
            numTotal.Maximum = new decimal(new int[] { 50000000, 0, 0, 0 });
            numTotal.Name = "numTotal";
            numTotal.Size = new Size(160, 36);
            numTotal.TabIndex = 22;
            numTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // dgStockDetails
            // 
            dgStockDetails.AllowUserToAddRows = false;
            dgStockDetails.AllowUserToDeleteRows = false;
            dgStockDetails.AllowUserToResizeColumns = false;
            dgStockDetails.AllowUserToResizeRows = false;
            dgStockDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgStockDetails.BackgroundColor = Color.MistyRose;
            dgStockDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStockDetails.Columns.AddRange(new DataGridViewColumn[] { cID, cStockName, cTypeName, cTOTAL, cDATE, cORDERID });
            dgStockDetails.Location = new Point(0, 380);
            dgStockDetails.MultiSelect = false;
            dgStockDetails.Name = "dgStockDetails";
            dgStockDetails.ReadOnly = true;
            dgStockDetails.RowHeadersWidth = 51;
            dgStockDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgStockDetails.Size = new Size(1200, 270);
            dgStockDetails.TabIndex = 2;
            dgStockDetails.RowEnter += dgStockDetails_RowEnter;
            // 
            // cID
            // 
            cID.DataPropertyName = "ID";
            cID.HeaderText = "رقم الحركة";
            cID.MinimumWidth = 6;
            cID.Name = "cID";
            cID.ReadOnly = true;
            // 
            // cStockName
            // 
            cStockName.DataPropertyName = "StockName";
            cStockName.HeaderText = "اسم الخزنة";
            cStockName.MinimumWidth = 6;
            cStockName.Name = "cStockName";
            cStockName.ReadOnly = true;
            // 
            // cTypeName
            // 
            cTypeName.DataPropertyName = "TypeName";
            cTypeName.HeaderText = "نوع الحركة";
            cTypeName.MinimumWidth = 6;
            cTypeName.Name = "cTypeName";
            cTypeName.ReadOnly = true;
            // 
            // cTOTAL
            // 
            cTOTAL.DataPropertyName = "TOTAL";
            cTOTAL.HeaderText = "المبلغ";
            cTOTAL.MinimumWidth = 6;
            cTOTAL.Name = "cTOTAL";
            cTOTAL.ReadOnly = true;
            // 
            // cDATE
            // 
            cDATE.DataPropertyName = "DATE";
            cDATE.HeaderText = "التاريخ";
            cDATE.MinimumWidth = 6;
            cDATE.Name = "cDATE";
            cDATE.ReadOnly = true;
            // 
            // cORDERID
            // 
            cORDERID.DataPropertyName = "ORDERID";
            cORDERID.HeaderText = "رقم الفاتورة";
            cORDERID.MinimumWidth = 6;
            cORDERID.Name = "cORDERID";
            cORDERID.ReadOnly = true;
            // 
            // gbSearchByStock
            // 
            gbSearchByStock.Controls.Add(btnSearchByStock);
            gbSearchByStock.Controls.Add(cbStock);
            gbSearchByStock.Font = new Font("Dubai", 10.2F, FontStyle.Bold);
            gbSearchByStock.Location = new Point(30, 110);
            gbSearchByStock.Name = "gbSearchByStock";
            gbSearchByStock.Size = new Size(360, 120);
            gbSearchByStock.TabIndex = 3;
            gbSearchByStock.TabStop = false;
            gbSearchByStock.Text = "بحث بالخزنة";
            // 
            // btnSearchByStock
            // 
            btnSearchByStock.BackColor = Color.DarkSlateGray;
            btnSearchByStock.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            btnSearchByStock.ForeColor = SystemColors.Window;
            btnSearchByStock.Location = new Point(20, 70);
            btnSearchByStock.Name = "btnSearchByStock";
            btnSearchByStock.Size = new Size(140, 40);
            btnSearchByStock.TabIndex = 1;
            btnSearchByStock.Text = "بحث";
            btnSearchByStock.UseVisualStyleBackColor = false;
            btnSearchByStock.Click += btnSearchByStock_Click;
            // 
            // cbStock
            // 
            cbStock.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStock.FormattingEnabled = true;
            cbStock.Location = new Point(20, 30);
            cbStock.Name = "cbStock";
            cbStock.Size = new Size(320, 37);
            cbStock.TabIndex = 0;
            // 
            // gbSearchByDate
            // 
            gbSearchByDate.Controls.Add(btnSearchByDate);
            gbSearchByDate.Controls.Add(lbTo);
            gbSearchByDate.Controls.Add(dtpTo);
            gbSearchByDate.Controls.Add(lbFrom);
            gbSearchByDate.Controls.Add(dtpFrom);
            gbSearchByDate.Font = new Font("Dubai", 10.2F, FontStyle.Bold);
            gbSearchByDate.Location = new Point(420, 110);
            gbSearchByDate.Name = "gbSearchByDate";
            gbSearchByDate.Size = new Size(360, 180);
            gbSearchByDate.TabIndex = 4;
            gbSearchByDate.TabStop = false;
            gbSearchByDate.Text = "بحث بالتاريخ";
            // 
            // btnSearchByDate
            // 
            btnSearchByDate.BackColor = Color.DarkSlateGray;
            btnSearchByDate.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            btnSearchByDate.ForeColor = SystemColors.Window;
            btnSearchByDate.Location = new Point(20, 130);
            btnSearchByDate.Name = "btnSearchByDate";
            btnSearchByDate.Size = new Size(140, 40);
            btnSearchByDate.TabIndex = 4;
            btnSearchByDate.Text = "بحث";
            btnSearchByDate.UseVisualStyleBackColor = false;
            btnSearchByDate.Click += btnSearchByDate_Click;
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Location = new Point(200, 80);
            lbTo.Name = "lbTo";
            lbTo.Size = new Size(73, 29);
            lbTo.TabIndex = 3;
            lbTo.Text = "الي تاريخ :";
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(20, 80);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(160, 36);
            dtpTo.TabIndex = 2;
            // 
            // lbFrom
            // 
            lbFrom.AutoSize = true;
            lbFrom.Location = new Point(200, 40);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new Size(75, 29);
            lbFrom.TabIndex = 1;
            lbFrom.Text = "من تاريخ :";
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(20, 35);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(160, 36);
            dtpFrom.TabIndex = 0;
            // 
            // gbSearchByType
            // 
            gbSearchByType.Controls.Add(rbExpense);
            gbSearchByType.Controls.Add(rbPurchase);
            gbSearchByType.Controls.Add(rbSale);
            gbSearchByType.Controls.Add(btnSearchByType);
            gbSearchByType.Font = new Font("Dubai", 10.2F, FontStyle.Bold);
            gbSearchByType.Location = new Point(810, 110);
            gbSearchByType.Name = "gbSearchByType";
            gbSearchByType.Size = new Size(360, 180);
            gbSearchByType.TabIndex = 5;
            gbSearchByType.TabStop = false;
            gbSearchByType.Text = "بحث بنوع الحركة";
            // 
            // rbExpense
            // 
            rbExpense.AutoSize = true;
            rbExpense.Location = new Point(230, 90);
            rbExpense.Name = "rbExpense";
            rbExpense.Size = new Size(94, 33);
            rbExpense.TabIndex = 5;
            rbExpense.Text = "مصروفات";
            rbExpense.UseVisualStyleBackColor = true;
            // 
            // rbPurchase
            // 
            rbPurchase.AutoSize = true;
            rbPurchase.Location = new Point(260, 60);
            rbPurchase.Name = "rbPurchase";
            rbPurchase.Size = new Size(64, 33);
            rbPurchase.TabIndex = 4;
            rbPurchase.Text = "شراء";
            rbPurchase.UseVisualStyleBackColor = true;
            // 
            // rbSale
            // 
            rbSale.AutoSize = true;
            rbSale.Checked = true;
            rbSale.Location = new Point(260, 30);
            rbSale.Name = "rbSale";
            rbSale.Size = new Size(55, 33);
            rbSale.TabIndex = 3;
            rbSale.TabStop = true;
            rbSale.Text = "بيع";
            rbSale.UseVisualStyleBackColor = true;
            // 
            // btnSearchByType
            // 
            btnSearchByType.BackColor = Color.DarkSlateGray;
            btnSearchByType.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            btnSearchByType.ForeColor = SystemColors.Window;
            btnSearchByType.Location = new Point(20, 130);
            btnSearchByType.Name = "btnSearchByType";
            btnSearchByType.Size = new Size(140, 40);
            btnSearchByType.TabIndex = 2;
            btnSearchByType.Text = "بحث";
            btnSearchByType.UseVisualStyleBackColor = false;
            btnSearchByType.Click += btnSearchByType_Click;
            // 
            // btnAll
            // 
            btnAll.BackColor = Color.DarkSlateGray;
            btnAll.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            btnAll.ForeColor = SystemColors.Window;
            btnAll.Location = new Point(30, 250);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(140, 40);
            btnAll.TabIndex = 6;
            btnAll.Text = "عرض الكل";
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Dubai", 10.2F, FontStyle.Regular);
            txtID.Location = new Point(220, 250);
            txtID.Name = "txtID";
            txtID.Size = new Size(120, 36);
            txtID.TabIndex = 7;
            txtID.TextAlign = HorizontalAlignment.Center;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Dubai", 10.2F, FontStyle.Bold);
            lbID.Location = new Point(350, 255);
            lbID.Name = "lbID";
            lbID.Size = new Size(91, 29);
            lbID.TabIndex = 8;
            lbID.Text = "رقم الحركة :";
            // 
            // txtOrderID
            // 
            txtOrderID.Enabled = false;
            txtOrderID.Font = new Font("Dubai", 10.2F, FontStyle.Regular);
            txtOrderID.Location = new Point(500, 250);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(120, 36);
            txtOrderID.TabIndex = 9;
            txtOrderID.TextAlign = HorizontalAlignment.Center;
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Font = new Font("Dubai", 10.2F, FontStyle.Bold);
            lbOrderID.Location = new Point(630, 255);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new Size(91, 29);
            lbOrderID.TabIndex = 10;
            lbOrderID.Text = "رقم الفاتورة :";
            // 
            // frmStockDetails
            // 
            AutoScaleDimensions = new SizeF(9F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1200, 728);
            Controls.Add(lbOrderID);
            Controls.Add(txtOrderID);
            Controls.Add(lbID);
            Controls.Add(txtID);
            Controls.Add(btnAll);
            Controls.Add(gbSearchByType);
            Controls.Add(gbSearchByDate);
            Controls.Add(gbSearchByStock);
            Controls.Add(dgStockDetails);
            Controls.Add(panBotton);
            Controls.Add(panTop);
            Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "frmStockDetails";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة حركات الخزنة";
            Load += frmStockDetails_Load;
            panTop.ResumeLayout(false);
            panTop.PerformLayout();
            panBotton.ResumeLayout(false);
            panBotton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgStockDetails).EndInit();
            gbSearchByStock.ResumeLayout(false);
            gbSearchByDate.ResumeLayout(false);
            gbSearchByDate.PerformLayout();
            gbSearchByType.ResumeLayout(false);
            gbSearchByType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panTop;
        private Label lbHead;
        private Panel panBotton;
        private DataGridView dgStockDetails;
        private Label lbTotal;
        private NumericUpDown numTotal;
        private DataGridViewTextBoxColumn cID;
        private DataGridViewTextBoxColumn cStockName;
        private DataGridViewTextBoxColumn cTypeName;
        private DataGridViewTextBoxColumn cTOTAL;
        private DataGridViewTextBoxColumn cDATE;
        private DataGridViewTextBoxColumn cORDERID;
        private GroupBox gbSearchByStock;
        private ComboBox cbStock;
        private Button btnSearchByStock;
        private GroupBox gbSearchByDate;
        private DateTimePicker dtpFrom;
        private Label lbFrom;
        private DateTimePicker dtpTo;
        private Label lbTo;
        private Button btnSearchByDate;
        private GroupBox gbSearchByType;
        private Button btnSearchByType;
        private RadioButton rbSale;
        private RadioButton rbPurchase;
        private RadioButton rbExpense;
        private Button btnAll;
        private TextBox txtID;
        private Label lbID;
        private TextBox txtOrderID;
        private Label lbOrderID;
    }
}
