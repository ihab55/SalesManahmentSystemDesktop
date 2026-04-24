using SalesManahmentSystemBLL.Services;

namespace SalesManahmentSystemPL
{
    partial class frmSaleOrderReport
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
            panSearchByDate = new Panel();
            lbSearchByDate = new Label();
            lbFromTime = new Label();
            dtpFrom = new DateTimePicker();
            lbToTime = new Label();
            dtpTo = new DateTimePicker();
            btnSearchByDate = new Button();
            panSearchByIDName = new Panel();
            lbSearchByIDName = new Label();
            rbID = new RadioButton();
            txtID = new TextBox();
            lbID = new Label();
            rbCustomerName = new RadioButton();
            txtCustomerName = new TextBox();
            lbCustomerName = new Label();
            btnSearchByIDorName = new Button();
            dgrecit = new DataGridView();
            cSalesOrderID = new DataGridViewTextBoxColumn();
            cCUSTOMERNAME = new DataGridViewTextBoxColumn();
            cPRODUCTNAME = new DataGridViewTextBoxColumn();
            cPRODUCTQUANTITY = new DataGridViewTextBoxColumn();
            cPRODUCTPRICE = new DataGridViewTextBoxColumn();
            cPRODUCTTOTALPRICE = new DataGridViewTextBoxColumn();
            panFooter = new Panel();
            lbTotalPrice = new Label();
            numTotalPrice = new NumericUpDown();
            panTop.SuspendLayout();
            panSearch.SuspendLayout();
            panSearchByDate.SuspendLayout();
            panSearchByIDName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrecit).BeginInit();
            panFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTotalPrice).BeginInit();
            SuspendLayout();
            // panTop
            panTop.BackColor = Color.FromArgb(45, 85, 95);
            panTop.Controls.Add(lbHead);
            panTop.Dock = DockStyle.Top;
            panTop.Location = new Point(0, 0);
            panTop.Name = "panTop";
            panTop.Size = new Size(1100, 100);
            panTop.TabIndex = 0;
            // lbHead
            lbHead.Dock = DockStyle.Fill;
            lbHead.Font = new Font("Dubai", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHead.ForeColor = Color.White;
            lbHead.Location = new Point(0, 0);
            lbHead.Name = "lbHead";
            lbHead.Size = new Size(1100, 100);
            lbHead.TabIndex = 0;
            lbHead.Text = "تقارير المبيعات";
            lbHead.TextAlign = ContentAlignment.MiddleCenter;
            // panSearch
            panSearch.BackColor = Color.White;
            panSearch.Controls.Add(panSearchByIDName);
            panSearch.Controls.Add(panSearchByDate);
            panSearch.Location = new Point(50, 120);
            panSearch.Name = "panSearch";
            panSearch.Size = new Size(1000, 220);
            panSearch.TabIndex = 1;
            // panSearchByDate
            panSearchByDate.BackColor = Color.FromArgb(245, 247, 250);
            panSearchByDate.Controls.Add(btnSearchByDate);
            panSearchByDate.Controls.Add(lbToTime);
            panSearchByDate.Controls.Add(dtpTo);
            panSearchByDate.Controls.Add(lbFromTime);
            panSearchByDate.Controls.Add(dtpFrom);
            panSearchByDate.Controls.Add(lbSearchByDate);
            panSearchByDate.Location = new Point(30, 20);
            panSearchByDate.Name = "panSearchByDate";
            panSearchByDate.Size = new Size(460, 180);
            panSearchByDate.TabIndex = 0;
            // lbSearchByDate
            lbSearchByDate.Dock = DockStyle.Top;
            lbSearchByDate.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSearchByDate.ForeColor = Color.FromArgb(45, 85, 95);
            lbSearchByDate.Location = new Point(0, 0);
            lbSearchByDate.Name = "lbSearchByDate";
            lbSearchByDate.Size = new Size(460, 40);
            lbSearchByDate.TabIndex = 0;
            lbSearchByDate.Text = "📅 بحث بالتاريخ";
            lbSearchByDate.TextAlign = ContentAlignment.MiddleCenter;
            // lbFromTime
            lbFromTime.AutoSize = true;
            lbFromTime.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFromTime.Location = new Point(340, 55);
            lbFromTime.Name = "lbFromTime";
            lbFromTime.Size = new Size(93, 30);
            lbFromTime.TabIndex = 1;
            lbFromTime.Text = "من تاريخ :";
            lbFromTime.TextAlign = ContentAlignment.MiddleRight;
            // dtpFrom
            dtpFrom.Font = new Font("Dubai", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(170, 52);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(160, 38);
            dtpFrom.TabIndex = 2;
            // lbToTime
            lbToTime.AutoSize = true;
            lbToTime.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbToTime.Location = new Point(340, 100);
            lbToTime.Name = "lbToTime";
            lbToTime.Size = new Size(91, 30);
            lbToTime.TabIndex = 3;
            lbToTime.Text = "إلى تاريخ :";
            lbToTime.TextAlign = ContentAlignment.MiddleRight;
            // dtpTo
            dtpTo.Font = new Font("Dubai", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(170, 97);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(160, 38);
            dtpTo.TabIndex = 4;
            // btnSearchByDate
            btnSearchByDate.BackColor = Color.FromArgb(45, 85, 95);
            btnSearchByDate.Cursor = Cursors.Hand;
            btnSearchByDate.FlatAppearance.BorderSize = 0;
            btnSearchByDate.FlatStyle = FlatStyle.Flat;
            btnSearchByDate.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchByDate.ForeColor = Color.White;
            btnSearchByDate.Location = new Point(20, 140);
            btnSearchByDate.Name = "btnSearchByDate";
            btnSearchByDate.Size = new Size(150, 35);
            btnSearchByDate.TabIndex = 5;
            btnSearchByDate.Text = "🔍 بحث";
            btnSearchByDate.UseVisualStyleBackColor = false;
            btnSearchByDate.Click += btnSearchByDate_Click;
            // panSearchByIDName
            panSearchByIDName.BackColor = Color.FromArgb(245, 247, 250);
            panSearchByIDName.Controls.Add(btnSearchByIDorName);
            panSearchByIDName.Controls.Add(txtCustomerName);
            panSearchByIDName.Controls.Add(lbCustomerName);
            panSearchByIDName.Controls.Add(rbCustomerName);
            panSearchByIDName.Controls.Add(txtID);
            panSearchByIDName.Controls.Add(lbID);
            panSearchByIDName.Controls.Add(rbID);
            panSearchByIDName.Controls.Add(lbSearchByIDName);
            panSearchByIDName.Location = new Point(510, 20);
            panSearchByIDName.Name = "panSearchByIDName";
            panSearchByIDName.Size = new Size(460, 180);
            panSearchByIDName.TabIndex = 1;
            // lbSearchByIDName
            lbSearchByIDName.Dock = DockStyle.Top;
            lbSearchByIDName.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSearchByIDName.ForeColor = Color.FromArgb(45, 85, 95);
            lbSearchByIDName.Location = new Point(0, 0);
            lbSearchByIDName.Name = "lbSearchByIDName";
            lbSearchByIDName.Size = new Size(460, 40);
            lbSearchByIDName.TabIndex = 0;
            lbSearchByIDName.Text = "🔎 بحث برقم الفاتورة أو اسم العميل";
            lbSearchByIDName.TextAlign = ContentAlignment.MiddleCenter;
            // rbID
            rbID.AutoSize = true;
            rbID.Checked = true;
            rbID.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbID.Location = new Point(380, 55);
            rbID.Name = "rbID";
            rbID.Size = new Size(63, 33);
            rbID.TabIndex = 1;
            rbID.TabStop = true;
            rbID.Text = "رقم :";
            rbID.UseVisualStyleBackColor = true;
            rbID.CheckedChanged += rbID_CheckedChanged;
            // lbID
            lbID.AutoSize = true;
            lbID.Font = new Font("Dubai", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbID.Location = new Point(270, 57);
            lbID.Name = "lbID";
            lbID.Size = new Size(90, 28);
            lbID.TabIndex = 2;
            lbID.Text = "رقم الفاتورة";
            // txtID
            txtID.BackColor = Color.White;
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(20, 55);
            txtID.Name = "txtID";
            txtID.Size = new Size(180, 36);
            txtID.TabIndex = 3;
            txtID.TextAlign = HorizontalAlignment.Center;
            // rbCustomerName
            rbCustomerName.AutoSize = true;
            rbCustomerName.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbCustomerName.Location = new Point(380, 105);
            rbCustomerName.Name = "rbCustomerName";
            rbCustomerName.Size = new Size(63, 33);
            rbCustomerName.TabIndex = 4;
            rbCustomerName.Text = "اسم :";
            rbCustomerName.UseVisualStyleBackColor = true;
            rbCustomerName.CheckedChanged += rbCustomerName_CheckedChanged;
            // lbCustomerName
            lbCustomerName.AutoSize = true;
            lbCustomerName.Font = new Font("Dubai", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCustomerName.Location = new Point(270, 107);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new Size(77, 28);
            lbCustomerName.TabIndex = 5;
            lbCustomerName.Text = "اسم العميل";
            // txtCustomerName
            txtCustomerName.BackColor = Color.White;
            txtCustomerName.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerName.Enabled = false;
            txtCustomerName.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerName.Location = new Point(20, 105);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(180, 36);
            txtCustomerName.TabIndex = 6;
            txtCustomerName.TextAlign = HorizontalAlignment.Center;
            // btnSearchByIDorName
            btnSearchByIDorName.BackColor = Color.FromArgb(45, 85, 95);
            btnSearchByIDorName.Cursor = Cursors.Hand;
            btnSearchByIDorName.FlatAppearance.BorderSize = 0;
            btnSearchByIDorName.FlatStyle = FlatStyle.Flat;
            btnSearchByIDorName.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchByIDorName.ForeColor = Color.White;
            btnSearchByIDorName.Location = new Point(20, 140);
            btnSearchByIDorName.Name = "btnSearchByIDorName";
            btnSearchByIDorName.Size = new Size(150, 35);
            btnSearchByIDorName.TabIndex = 7;
            btnSearchByIDorName.Text = "🔍 بحث";
            btnSearchByIDorName.UseVisualStyleBackColor = false;
            btnSearchByIDorName.Click += btnSearchByIDorName_Click;
            // dgrecit
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
            dgrecit.Columns.AddRange(new DataGridViewColumn[] { cSalesOrderID, cCUSTOMERNAME, cPRODUCTNAME, cPRODUCTQUANTITY, cPRODUCTPRICE, cPRODUCTTOTALPRICE });
            dgrecit.EnableHeadersVisualStyles = false;
            dgrecit.GridColor = Color.FromArgb(224, 224, 224);
            dgrecit.Location = new Point(50, 360);
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
            dgrecit.Size = new Size(1000, 280);
            dgrecit.TabIndex = 2;
            // cSalesOrderID
            cSalesOrderID.DataPropertyName = "SalesOrderID";
            cSalesOrderID.HeaderText = "رقم الفاتورة";
            cSalesOrderID.MinimumWidth = 6;
            cSalesOrderID.Name = "cSalesOrderID";
            cSalesOrderID.ReadOnly = true;
            cSalesOrderID.Width = 120;
            // cCUSTOMERNAME
            cCUSTOMERNAME.DataPropertyName = "CustomerName";
            cCUSTOMERNAME.HeaderText = "اسم العميل";
            cCUSTOMERNAME.MinimumWidth = 6;
            cCUSTOMERNAME.Name = "cCUSTOMERNAME";
            cCUSTOMERNAME.ReadOnly = true;
            cCUSTOMERNAME.Width = 200;
            // cPRODUCTNAME
            cPRODUCTNAME.DataPropertyName = "PRODUCTNAME";
            cPRODUCTNAME.HeaderText = "اسم الصنف";
            cPRODUCTNAME.MinimumWidth = 6;
            cPRODUCTNAME.Name = "cPRODUCTNAME";
            cPRODUCTNAME.ReadOnly = true;
            cPRODUCTNAME.Width = 200;
            // cPRODUCTQUANTITY
            cPRODUCTQUANTITY.DataPropertyName = "PRODUCTQUANTITY";
            cPRODUCTQUANTITY.HeaderText = "الكمية";
            cPRODUCTQUANTITY.MinimumWidth = 6;
            cPRODUCTQUANTITY.Name = "cPRODUCTQUANTITY";
            cPRODUCTQUANTITY.ReadOnly = true;
            cPRODUCTQUANTITY.Width = 100;
            // cPRODUCTPRICE
            cPRODUCTPRICE.DataPropertyName = "PRODUCTPRICE";
            cPRODUCTPRICE.HeaderText = "سعر البيع";
            cPRODUCTPRICE.MinimumWidth = 6;
            cPRODUCTPRICE.Name = "cPRODUCTPRICE";
            cPRODUCTPRICE.ReadOnly = true;
            cPRODUCTPRICE.Width = 120;
            // cPRODUCTTOTALPRICE
            cPRODUCTTOTALPRICE.DataPropertyName = "PRODUCTTOTALPRICE";
            cPRODUCTTOTALPRICE.HeaderText = "الإجمالي";
            cPRODUCTTOTALPRICE.MinimumWidth = 6;
            cPRODUCTTOTALPRICE.Name = "cPRODUCTTOTALPRICE";
            cPRODUCTTOTALPRICE.ReadOnly = true;
            cPRODUCTTOTALPRICE.Width = 140;
            // panFooter
            panFooter.BackColor = Color.FromArgb(45, 85, 95);
            panFooter.Controls.Add(lbTotalPrice);
            panFooter.Controls.Add(numTotalPrice);
            panFooter.Dock = DockStyle.Bottom;
            panFooter.Location = new Point(0, 650);
            panFooter.Name = "panFooter";
            panFooter.Size = new Size(1100, 60);
            panFooter.TabIndex = 3;
            // lbTotalPrice
            lbTotalPrice.AutoSize = true;
            lbTotalPrice.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalPrice.ForeColor = Color.White;
            lbTotalPrice.Location = new Point(280, 15);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(122, 34);
            lbTotalPrice.TabIndex = 1;
            lbTotalPrice.Text = "إجمالي الفاتورة :";
            // numTotalPrice
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
            // frmSaleOrderReport
            AutoScaleDimensions = new SizeF(9F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1100, 710);
            Controls.Add(panFooter);
            Controls.Add(dgrecit);
            Controls.Add(panSearch);
            Controls.Add(panTop);
            Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            Name = "frmSaleOrderReport";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تقارير المبيعات";
            Load += frmSaleOrderReport_Load;
            panTop.ResumeLayout(false);
            panSearch.ResumeLayout(false);
            panSearchByDate.ResumeLayout(false);
            panSearchByDate.PerformLayout();
            panSearchByIDName.ResumeLayout(false);
            panSearchByIDName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrecit).EndInit();
            panFooter.ResumeLayout(false);
            panFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTotalPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panTop;
        private Label lbHead;
        private Panel panSearch;
        private Panel panSearchByDate;
        private Label lbSearchByDate;
        private Label lbFromTime;
        private DateTimePicker dtpFrom;
        private Label lbToTime;
        private DateTimePicker dtpTo;
        private Button btnSearchByDate;
        private Panel panSearchByIDName;
        private Label lbSearchByIDName;
        private RadioButton rbID;
        private TextBox txtID;
        private Label lbID;
        private RadioButton rbCustomerName;
        private TextBox txtCustomerName;
        private Label lbCustomerName;
        private Button btnSearchByIDorName;
        private DataGridView dgrecit;
        private Panel panFooter;
        private Label lbTotalPrice;
        private NumericUpDown numTotalPrice;
        private DataGridViewTextBoxColumn cSalesOrderID;
        private DataGridViewTextBoxColumn cCUSTOMERNAME;
        private DataGridViewTextBoxColumn cPRODUCTNAME;
        private DataGridViewTextBoxColumn cPRODUCTQUANTITY;
        private DataGridViewTextBoxColumn cPRODUCTPRICE;
        private DataGridViewTextBoxColumn cPRODUCTTOTALPRICE;
    }
}
