using SalesManahmentSystemBLL.Services;

namespace SalesManahmentSystemPL
{
    partial class frmStockDetails
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panTop = new Panel();
            lbHead = new Label();
            panSearch = new Panel();
            panSearchByType = new Panel();
            btnSearchByType = new Button();
            rbExpense = new RadioButton();
            rbPurchase = new RadioButton();
            rbSale = new RadioButton();
            lbSearchByType = new Label();
            panSearchByDate = new Panel();
            btnSearchByDate = new Button();
            lbTo = new Label();
            dtpTo = new DateTimePicker();
            lbFrom = new Label();
            dtpFrom = new DateTimePicker();
            lbSearchByDate = new Label();
            panSearchByStock = new Panel();
            btnSearchByStock = new Button();
            cbStock = new ComboBox();
            lbSearchByStock = new Label();
            btnAll = new Button();
            dgStockDetails = new DataGridView();
            cID = new DataGridViewTextBoxColumn();
            cStockName = new DataGridViewTextBoxColumn();
            cTypeName = new DataGridViewTextBoxColumn();
            cTOTAL = new DataGridViewTextBoxColumn();
            cDATE = new DataGridViewTextBoxColumn();
            cORDERID = new DataGridViewTextBoxColumn();
            panDetails = new Panel();
            lbTotal = new Label();
            numTotal = new NumericUpDown();
            lbOrderID = new Label();
            txtOrderID = new TextBox();
            lbID = new Label();
            txtID = new TextBox();
            panFooter = new Panel();
            lbFooter = new Label();
            panTop.SuspendLayout();
            panSearch.SuspendLayout();
            panSearchByType.SuspendLayout();
            panSearchByDate.SuspendLayout();
            panSearchByStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgStockDetails).BeginInit();
            panDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTotal).BeginInit();
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
            panTop.Size = new Size(1200, 100);
            panTop.TabIndex = 0;
            // 
            // lbHead
            // 
            lbHead.Dock = DockStyle.Fill;
            lbHead.Font = new Font("Dubai", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHead.ForeColor = Color.White;
            lbHead.Location = new Point(0, 0);
            lbHead.Name = "lbHead";
            lbHead.Size = new Size(1200, 100);
            lbHead.TabIndex = 0;
            lbHead.Text = "حركات الخزائن";
            lbHead.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panSearch
            // 
            panSearch.BackColor = Color.White;
            panSearch.Controls.Add(panSearchByType);
            panSearch.Controls.Add(panSearchByDate);
            panSearch.Controls.Add(panSearchByStock);
            panSearch.Location = new Point(50, 120);
            panSearch.Name = "panSearch";
            panSearch.Size = new Size(1100, 240);
            panSearch.TabIndex = 1;
            // 
            // panSearchByType
            // 
            panSearchByType.BackColor = Color.FromArgb(245, 247, 250);
            panSearchByType.Controls.Add(btnSearchByType);
            panSearchByType.Controls.Add(rbExpense);
            panSearchByType.Controls.Add(rbPurchase);
            panSearchByType.Controls.Add(rbSale);
            panSearchByType.Controls.Add(lbSearchByType);
            panSearchByType.Location = new Point(740, 20);
            panSearchByType.Name = "panSearchByType";
            panSearchByType.Size = new Size(330, 200);
            panSearchByType.TabIndex = 2;
            // 
            // btnSearchByType
            // 
            btnSearchByType.BackColor = Color.FromArgb(45, 85, 95);
            btnSearchByType.Cursor = Cursors.Hand;
            btnSearchByType.FlatAppearance.BorderSize = 0;
            btnSearchByType.FlatStyle = FlatStyle.Flat;
            btnSearchByType.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchByType.ForeColor = Color.White;
            btnSearchByType.Location = new Point(30, 145);
            btnSearchByType.Name = "btnSearchByType";
            btnSearchByType.Size = new Size(150, 45);
            btnSearchByType.TabIndex = 4;
            btnSearchByType.Text = "بحث";
            btnSearchByType.UseVisualStyleBackColor = false;
            btnSearchByType.Click += btnSearchByType_Click;
            // 
            // rbExpense
            // 
            rbExpense.AutoSize = true;
            rbExpense.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbExpense.Location = new Point(210, 125);
            rbExpense.Name = "rbExpense";
            rbExpense.Size = new Size(95, 33);
            rbExpense.TabIndex = 3;
            rbExpense.Text = "مصروفات";
            rbExpense.UseVisualStyleBackColor = true;
            // 
            // rbPurchase
            // 
            rbPurchase.AutoSize = true;
            rbPurchase.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbPurchase.Location = new Point(240, 90);
            rbPurchase.Name = "rbPurchase";
            rbPurchase.Size = new Size(64, 33);
            rbPurchase.TabIndex = 2;
            rbPurchase.Text = "شراء";
            rbPurchase.UseVisualStyleBackColor = true;
            // 
            // rbSale
            // 
            rbSale.AutoSize = true;
            rbSale.Checked = true;
            rbSale.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbSale.Location = new Point(250, 55);
            rbSale.Name = "rbSale";
            rbSale.Size = new Size(55, 33);
            rbSale.TabIndex = 1;
            rbSale.TabStop = true;
            rbSale.Text = "بيع";
            rbSale.UseVisualStyleBackColor = true;
            // 
            // lbSearchByType
            // 
            lbSearchByType.Dock = DockStyle.Top;
            lbSearchByType.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSearchByType.ForeColor = Color.FromArgb(45, 85, 95);
            lbSearchByType.Location = new Point(0, 0);
            lbSearchByType.Name = "lbSearchByType";
            lbSearchByType.Size = new Size(330, 40);
            lbSearchByType.TabIndex = 0;
            lbSearchByType.Text = "📊 بحث بنوع الحركة";
            lbSearchByType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panSearchByDate
            // 
            panSearchByDate.BackColor = Color.FromArgb(245, 247, 250);
            panSearchByDate.Controls.Add(btnSearchByDate);
            panSearchByDate.Controls.Add(lbTo);
            panSearchByDate.Controls.Add(dtpTo);
            panSearchByDate.Controls.Add(lbFrom);
            panSearchByDate.Controls.Add(dtpFrom);
            panSearchByDate.Controls.Add(lbSearchByDate);
            panSearchByDate.Location = new Point(385, 20);
            panSearchByDate.Name = "panSearchByDate";
            panSearchByDate.Size = new Size(330, 200);
            panSearchByDate.TabIndex = 1;
            // 
            // btnSearchByDate
            // 
            btnSearchByDate.BackColor = Color.FromArgb(45, 85, 95);
            btnSearchByDate.Cursor = Cursors.Hand;
            btnSearchByDate.FlatAppearance.BorderSize = 0;
            btnSearchByDate.FlatStyle = FlatStyle.Flat;
            btnSearchByDate.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchByDate.ForeColor = Color.White;
            btnSearchByDate.Location = new Point(50, 145);
            btnSearchByDate.Name = "btnSearchByDate";
            btnSearchByDate.Size = new Size(230, 45);
            btnSearchByDate.TabIndex = 5;
            btnSearchByDate.Text = "بحث";
            btnSearchByDate.UseVisualStyleBackColor = false;
            btnSearchByDate.Click += btnSearchByDate_Click;
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Font = new Font("Dubai", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTo.Location = new Point(230, 100);
            lbTo.Name = "lbTo";
            lbTo.Size = new Size(75, 29);
            lbTo.TabIndex = 3;
            lbTo.Text = "إلى تاريخ :";
            lbTo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpTo
            // 
            dtpTo.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(50, 100);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(160, 36);
            dtpTo.TabIndex = 4;
            // 
            // lbFrom
            // 
            lbFrom.AutoSize = true;
            lbFrom.Font = new Font("Dubai", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFrom.Location = new Point(230, 55);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new Size(77, 29);
            lbFrom.TabIndex = 1;
            lbFrom.Text = "من تاريخ :";
            lbFrom.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpFrom
            // 
            dtpFrom.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(50, 55);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(160, 36);
            dtpFrom.TabIndex = 2;
            // 
            // lbSearchByDate
            // 
            lbSearchByDate.Dock = DockStyle.Top;
            lbSearchByDate.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSearchByDate.ForeColor = Color.FromArgb(45, 85, 95);
            lbSearchByDate.Location = new Point(0, 0);
            lbSearchByDate.Name = "lbSearchByDate";
            lbSearchByDate.Size = new Size(330, 40);
            lbSearchByDate.TabIndex = 0;
            lbSearchByDate.Text = "📅 بحث بالتاريخ";
            lbSearchByDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panSearchByStock
            // 
            panSearchByStock.BackColor = Color.FromArgb(245, 247, 250);
            panSearchByStock.Controls.Add(btnSearchByStock);
            panSearchByStock.Controls.Add(cbStock);
            panSearchByStock.Controls.Add(lbSearchByStock);
            panSearchByStock.Location = new Point(30, 20);
            panSearchByStock.Name = "panSearchByStock";
            panSearchByStock.Size = new Size(330, 200);
            panSearchByStock.TabIndex = 0;
            // 
            // btnSearchByStock
            // 
            btnSearchByStock.BackColor = Color.FromArgb(45, 85, 95);
            btnSearchByStock.Cursor = Cursors.Hand;
            btnSearchByStock.FlatAppearance.BorderSize = 0;
            btnSearchByStock.FlatStyle = FlatStyle.Flat;
            btnSearchByStock.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchByStock.ForeColor = Color.White;
            btnSearchByStock.Location = new Point(20, 130);
            btnSearchByStock.Name = "btnSearchByStock";
            btnSearchByStock.Size = new Size(290, 50);
            btnSearchByStock.TabIndex = 2;
            btnSearchByStock.Text = "بحث";
            btnSearchByStock.UseVisualStyleBackColor = false;
            btnSearchByStock.Click += btnSearchByStock_Click;
            // 
            // cbStock
            // 
            cbStock.BackColor = Color.White;
            cbStock.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStock.Font = new Font("Dubai", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStock.FormattingEnabled = true;
            cbStock.Location = new Point(20, 60);
            cbStock.Name = "cbStock";
            cbStock.Size = new Size(290, 38);
            cbStock.TabIndex = 1;
            // 
            // lbSearchByStock
            // 
            lbSearchByStock.Dock = DockStyle.Top;
            lbSearchByStock.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSearchByStock.ForeColor = Color.FromArgb(45, 85, 95);
            lbSearchByStock.Location = new Point(0, 0);
            lbSearchByStock.Name = "lbSearchByStock";
            lbSearchByStock.Size = new Size(330, 40);
            lbSearchByStock.TabIndex = 0;
            lbSearchByStock.Text = "🔍 بحث بالخزنة";
            lbSearchByStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAll
            // 
            btnAll.BackColor = Color.Green;
            btnAll.Cursor = Cursors.Hand;
            btnAll.FlatAppearance.BorderSize = 0;
            btnAll.FlatStyle = FlatStyle.Flat;
            btnAll.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAll.ForeColor = Color.White;
            btnAll.Location = new Point(34, 0);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(290, 50);
            btnAll.TabIndex = 4;
            btnAll.Text = "📋 عرض الكل";
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // dgStockDetails
            // 
            dgStockDetails.AllowUserToAddRows = false;
            dgStockDetails.AllowUserToDeleteRows = false;
            dgStockDetails.AllowUserToResizeColumns = false;
            dgStockDetails.AllowUserToResizeRows = false;
            dgStockDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgStockDetails.BackgroundColor = Color.White;
            dgStockDetails.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgStockDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 85, 95);
            dataGridViewCellStyle1.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(45, 85, 95);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgStockDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgStockDetails.ColumnHeadersHeight = 40;
            dgStockDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgStockDetails.Columns.AddRange(new DataGridViewColumn[] { cID, cStockName, cTypeName, cTOTAL, cDATE, cORDERID });
            dgStockDetails.EnableHeadersVisualStyles = false;
            dgStockDetails.GridColor = Color.FromArgb(224, 224, 224);
            dgStockDetails.Location = new Point(50, 380);
            dgStockDetails.MultiSelect = false;
            dgStockDetails.Name = "dgStockDetails";
            dgStockDetails.ReadOnly = true;
            dgStockDetails.RowHeadersVisible = false;
            dgStockDetails.RowHeadersWidth = 51;
            dgStockDetails.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgStockDetails.RowTemplate.DefaultCellStyle.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgStockDetails.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgStockDetails.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 230, 201);
            dgStockDetails.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgStockDetails.RowTemplate.Height = 40;
            dgStockDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgStockDetails.Size = new Size(1100, 280);
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
            // panDetails
            // 
            panDetails.BackColor = Color.FromArgb(245, 247, 250);
            panDetails.Controls.Add(lbTotal);
            panDetails.Controls.Add(numTotal);
            panDetails.Controls.Add(lbOrderID);
            panDetails.Controls.Add(txtOrderID);
            panDetails.Controls.Add(lbID);
            panDetails.Controls.Add(txtID);
            panDetails.Location = new Point(50, 675);
            panDetails.Name = "panDetails";
            panDetails.Size = new Size(1100, 60);
            panDetails.TabIndex = 3;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotal.ForeColor = Color.FromArgb(45, 85, 95);
            lbTotal.Location = new Point(180, 15);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(118, 32);
            lbTotal.TabIndex = 4;
            lbTotal.Text = "أجمالي المبلغ :";
            lbTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numTotal
            // 
            numTotal.BackColor = Color.FromArgb(230, 230, 230);
            numTotal.Enabled = false;
            numTotal.Font = new Font("Dubai", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numTotal.Location = new Point(20, 12);
            numTotal.Maximum = new decimal(new int[] { 50000000, 0, 0, 0 });
            numTotal.Minimum = new decimal(new int[] { 2013979688, 131, 0, int.MinValue });
            numTotal.Name = "numTotal";
            numTotal.ReadOnly = true;
            numTotal.Size = new Size(150, 38);
            numTotal.TabIndex = 5;
            numTotal.TextAlign = HorizontalAlignment.Center;
            numTotal.ThousandsSeparator = true;
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbOrderID.ForeColor = Color.FromArgb(45, 85, 95);
            lbOrderID.Location = new Point(550, 15);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new Size(105, 32);
            lbOrderID.TabIndex = 2;
            lbOrderID.Text = "رقم الفاتورة :";
            lbOrderID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtOrderID
            // 
            txtOrderID.BackColor = Color.FromArgb(230, 230, 230);
            txtOrderID.BorderStyle = BorderStyle.FixedSingle;
            txtOrderID.Enabled = false;
            txtOrderID.Font = new Font("Dubai", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOrderID.Location = new Point(400, 12);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.ReadOnly = true;
            txtOrderID.Size = new Size(140, 38);
            txtOrderID.TabIndex = 3;
            txtOrderID.TextAlign = HorizontalAlignment.Center;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbID.ForeColor = Color.FromArgb(45, 85, 95);
            lbID.Location = new Point(950, 15);
            lbID.Name = "lbID";
            lbID.Size = new Size(99, 32);
            lbID.TabIndex = 0;
            lbID.Text = "رقم الحركة :";
            lbID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(230, 230, 230);
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Enabled = false;
            txtID.Font = new Font("Dubai", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(800, 12);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(140, 38);
            txtID.TabIndex = 1;
            txtID.TextAlign = HorizontalAlignment.Center;
            // 
            // panFooter
            // 
            panFooter.BackColor = Color.FromArgb(45, 85, 95);
            panFooter.Controls.Add(btnAll);
            panFooter.Controls.Add(lbFooter);
            panFooter.Dock = DockStyle.Bottom;
            panFooter.Location = new Point(0, 750);
            panFooter.Name = "panFooter";
            panFooter.Size = new Size(1200, 50);
            panFooter.TabIndex = 4;
            // 
            // lbFooter
            // 
            lbFooter.Dock = DockStyle.Fill;
            lbFooter.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFooter.ForeColor = Color.White;
            lbFooter.Location = new Point(0, 0);
            lbFooter.Name = "lbFooter";
            lbFooter.Size = new Size(1200, 50);
            lbFooter.TabIndex = 0;
            lbFooter.Text = "نظام إدارة المبيعات - إيهاب أيمن - ehab.ayman7420@gmail.com";
            lbFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmStockDetails
            // 
            AutoScaleDimensions = new SizeF(9F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1200, 800);
            Controls.Add(panFooter);
            Controls.Add(panDetails);
            Controls.Add(dgStockDetails);
            Controls.Add(panSearch);
            Controls.Add(panTop);
            Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            Name = "frmStockDetails";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "حركات الخزائن";
            Load += frmStockDetails_Load;
            panTop.ResumeLayout(false);
            panSearch.ResumeLayout(false);
            panSearchByType.ResumeLayout(false);
            panSearchByType.PerformLayout();
            panSearchByDate.ResumeLayout(false);
            panSearchByDate.PerformLayout();
            panSearchByStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgStockDetails).EndInit();
            panDetails.ResumeLayout(false);
            panDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTotal).EndInit();
            panFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panTop;
        private Label lbHead;
        private Panel panSearch;
        private Panel panSearchByStock;
        private Label lbSearchByStock;
        private ComboBox cbStock;
        private Button btnSearchByStock;
        private Panel panSearchByDate;
        private Label lbSearchByDate;
        private Label lbTo;
        private DateTimePicker dtpTo;
        private Label lbFrom;
        private DateTimePicker dtpFrom;
        private Button btnSearchByDate;
        private Panel panSearchByType;
        private Label lbSearchByType;
        private RadioButton rbExpense;
        private RadioButton rbPurchase;
        private RadioButton rbSale;
        private Button btnSearchByType;
        private Button btnAll;
        private DataGridView dgStockDetails;
        private DataGridViewTextBoxColumn cID;
        private DataGridViewTextBoxColumn cStockName;
        private DataGridViewTextBoxColumn cTypeName;
        private DataGridViewTextBoxColumn cTOTAL;
        private DataGridViewTextBoxColumn cDATE;
        private DataGridViewTextBoxColumn cORDERID;
        private Panel panDetails;
        private Label lbOrderID;
        private TextBox txtOrderID;
        private Label lbID;
        private TextBox txtID;
        private Label lbTotal;
        private NumericUpDown numTotal;
        private Panel panFooter;
        private Label lbFooter;
    }
}
