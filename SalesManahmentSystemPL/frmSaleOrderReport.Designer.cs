using SalesManahmentSystemBLL.Services;

namespace SalesManahmentSystemPL
{
    partial class frmSaleOrderReport
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
            lbTotalPrice = new Label();
            numTotalPrice = new NumericUpDown();
            txtID = new TextBox();
            lbID = new Label();
            btnSearchByDate = new Button();
            dgrecit = new DataGridView();
            lbFromTime = new Label();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            lbCustomerName = new Label();
            btnSearchByIDorName = new Button();
            txtCustomerName = new TextBox();
            rbID = new RadioButton();
            rbCustomerName = new RadioButton();
            lbToTime = new Label();
            cSalesOrderID = new DataGridViewTextBoxColumn();
            cCUSTOMERNAME = new DataGridViewTextBoxColumn();
            cPRODUCTNAME = new DataGridViewTextBoxColumn();
            cPRODUCTQUANTITY = new DataGridViewTextBoxColumn();
            cPRODUCTPRICE = new DataGridViewTextBoxColumn();
            cPRODUCTTOTALPRICE = new DataGridViewTextBoxColumn();
            panTop.SuspendLayout();
            panBotton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTotalPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgrecit).BeginInit();
            SuspendLayout();
            // 
            // panTop
            // 
            panTop.BackColor = Color.DarkSlateGray;
            panTop.Controls.Add(lbHead);
            panTop.Dock = DockStyle.Top;
            panTop.Location = new Point(0, 0);
            panTop.Name = "panTop";
            panTop.Size = new Size(1113, 93);
            panTop.TabIndex = 0;
            // 
            // lbHead
            // 
            lbHead.AutoSize = true;
            lbHead.Font = new Font("Dubai", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHead.ForeColor = SystemColors.Window;
            lbHead.Location = new Point(434, 21);
            lbHead.Name = "lbHead";
            lbHead.Size = new Size(261, 51);
            lbHead.TabIndex = 27;
            lbHead.Text = "شاشة تقارير المبيعات";
            // 
            // panBotton
            // 
            panBotton.BackColor = Color.DarkSlateGray;
            panBotton.Controls.Add(lbTotalPrice);
            panBotton.Controls.Add(numTotalPrice);
            panBotton.Dock = DockStyle.Bottom;
            panBotton.Location = new Point(0, 522);
            panBotton.Name = "panBotton";
            panBotton.Size = new Size(1113, 78);
            panBotton.TabIndex = 0;
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.AutoSize = true;
            lbTotalPrice.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalPrice.ForeColor = SystemColors.Window;
            lbTotalPrice.Location = new Point(276, 23);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(128, 34);
            lbTotalPrice.TabIndex = 23;
            lbTotalPrice.Text = "أجمالي الفاتورة :";
            // 
            // numTotalPrice
            // 
            numTotalPrice.Location = new Point(115, 21);
            numTotalPrice.Maximum = new decimal(new int[] { 50000000, 0, 0, 0 });
            numTotalPrice.Name = "numTotalPrice";
            numTotalPrice.Size = new Size(140, 36);
            numTotalPrice.TabIndex = 22;
            numTotalPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // txtID
            // 
            txtID.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(359, 248);
            txtID.Name = "txtID";
            txtID.Size = new Size(189, 41);
            txtID.TabIndex = 3;
            txtID.TextAlign = HorizontalAlignment.Center;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbID.Location = new Point(359, 211);
            lbID.Name = "lbID";
            lbID.Size = new Size(110, 34);
            lbID.TabIndex = 4;
            lbID.Text = "رقم الفاتورة :";
            // 
            // btnSearchByDate
            // 
            btnSearchByDate.BackColor = Color.DarkSlateGray;
            btnSearchByDate.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            btnSearchByDate.ForeColor = SystemColors.Window;
            btnSearchByDate.Location = new Point(127, 149);
            btnSearchByDate.Name = "btnSearchByDate";
            btnSearchByDate.Size = new Size(181, 41);
            btnSearchByDate.TabIndex = 11;
            btnSearchByDate.Text = "بحث";
            btnSearchByDate.UseVisualStyleBackColor = false;
            btnSearchByDate.Click += btnSearchByDate_Click;
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
            dgrecit.Columns.AddRange(new DataGridViewColumn[] { cSalesOrderID, cCUSTOMERNAME, cPRODUCTNAME, cPRODUCTQUANTITY, cPRODUCTPRICE, cPRODUCTTOTALPRICE });
            dgrecit.Location = new Point(0, 323);
            dgrecit.MultiSelect = false;
            dgrecit.Name = "dgrecit";
            dgrecit.ReadOnly = true;
            dgrecit.RowHeadersWidth = 51;
            dgrecit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrecit.Size = new Size(998, 199);
            dgrecit.TabIndex = 13;
            // 
            // lbFromTime
            // 
            lbFromTime.AutoSize = true;
            lbFromTime.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFromTime.Location = new Point(359, 108);
            lbFromTime.Name = "lbFromTime";
            lbFromTime.Size = new Size(102, 34);
            lbFromTime.TabIndex = 15;
            lbFromTime.Text = "من التاريخ :";
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(359, 154);
            dtpFrom.MaxDate = new DateTime(2026, 4, 14, 0, 0, 0, 0);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(189, 36);
            dtpFrom.TabIndex = 25;
            dtpFrom.Value = new DateTime(2026, 4, 14, 0, 0, 0, 0);
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(626, 154);
            dtpTo.MaxDate = new DateTime(2026, 4, 14, 0, 0, 0, 0);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(189, 36);
            dtpTo.TabIndex = 27;
            dtpTo.Value = new DateTime(2026, 4, 14, 0, 0, 0, 0);
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCustomerName.Location = new Point(626, 211);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new Size(116, 34);
            lbCustomerName.TabIndex = 30;
            lbCustomerName.Text = "أسم العميل :";
            // 
            // btnSearchByIDorName
            // 
            btnSearchByIDorName.BackColor = Color.DarkSlateGray;
            btnSearchByIDorName.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            btnSearchByIDorName.ForeColor = SystemColors.Window;
            btnSearchByIDorName.Location = new Point(127, 249);
            btnSearchByIDorName.Name = "btnSearchByIDorName";
            btnSearchByIDorName.Size = new Size(181, 41);
            btnSearchByIDorName.TabIndex = 28;
            btnSearchByIDorName.Text = "بحث";
            btnSearchByIDorName.UseVisualStyleBackColor = false;
            btnSearchByIDorName.Click += btnSearchByIDorName_Click;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerName.Location = new Point(626, 248);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(189, 41);
            txtCustomerName.TabIndex = 29;
            txtCustomerName.TextAlign = HorizontalAlignment.Center;
            // 
            // rbID
            // 
            rbID.AutoSize = true;
            rbID.BackgroundImageLayout = ImageLayout.None;
            rbID.Checked = true;
            rbID.Location = new Point(327, 261);
            rbID.Name = "rbID";
            rbID.Size = new Size(17, 16);
            rbID.TabIndex = 31;
            rbID.TabStop = true;
            rbID.UseVisualStyleBackColor = true;
            // 
            // rbCustomerName
            // 
            rbCustomerName.AutoSize = true;
            rbCustomerName.BackgroundImageLayout = ImageLayout.None;
            rbCustomerName.Location = new Point(585, 261);
            rbCustomerName.Name = "rbCustomerName";
            rbCustomerName.Size = new Size(17, 16);
            rbCustomerName.TabIndex = 32;
            rbCustomerName.UseVisualStyleBackColor = true;
            // 
            // lbToTime
            // 
            lbToTime.AutoSize = true;
            lbToTime.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbToTime.Location = new Point(626, 108);
            lbToTime.Name = "lbToTime";
            lbToTime.Size = new Size(100, 34);
            lbToTime.TabIndex = 33;
            lbToTime.Text = "إلي التاريخ :";
            // 
            // cSalesOrderID
            // 
            cSalesOrderID.DataPropertyName = "SalesOrderID";
            cSalesOrderID.HeaderText = "رقم الفاتورة";
            cSalesOrderID.MinimumWidth = 6;
            cSalesOrderID.Name = "cSalesOrderID";
            cSalesOrderID.ReadOnly = true;
            // 
            // cCUSTOMERNAME
            // 
            cCUSTOMERNAME.DataPropertyName = "CustomerName";
            cCUSTOMERNAME.HeaderText = "أسم العميل";
            cCUSTOMERNAME.MinimumWidth = 6;
            cCUSTOMERNAME.Name = "cCUSTOMERNAME";
            cCUSTOMERNAME.ReadOnly = true;
            // 
            // cPRODUCTNAME
            // 
            cPRODUCTNAME.DataPropertyName = "PRODUCTNAME";
            cPRODUCTNAME.HeaderText = "أسم الصنف";
            cPRODUCTNAME.MinimumWidth = 6;
            cPRODUCTNAME.Name = "cPRODUCTNAME";
            cPRODUCTNAME.ReadOnly = true;
            // 
            // cPRODUCTQUANTITY
            // 
            cPRODUCTQUANTITY.DataPropertyName = "PRODUCTQUANTITY";
            cPRODUCTQUANTITY.HeaderText = "الكمية";
            cPRODUCTQUANTITY.MinimumWidth = 6;
            cPRODUCTQUANTITY.Name = "cPRODUCTQUANTITY";
            cPRODUCTQUANTITY.ReadOnly = true;
            // 
            // cPRODUCTPRICE
            // 
            cPRODUCTPRICE.DataPropertyName = "PRODUCTPRICE";
            cPRODUCTPRICE.HeaderText = "سعر البيع";
            cPRODUCTPRICE.MinimumWidth = 6;
            cPRODUCTPRICE.Name = "cPRODUCTPRICE";
            cPRODUCTPRICE.ReadOnly = true;
            // 
            // cPRODUCTTOTALPRICE
            // 
            cPRODUCTTOTALPRICE.DataPropertyName = "PRODUCTTOTALPRICE";
            cPRODUCTTOTALPRICE.HeaderText = "لأجمالي";
            cPRODUCTTOTALPRICE.MinimumWidth = 6;
            cPRODUCTTOTALPRICE.Name = "cPRODUCTTOTALPRICE";
            cPRODUCTTOTALPRICE.ReadOnly = true;
            // 
            // frmSaleOrderReport
            // 
            AutoScaleDimensions = new SizeF(9F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Snow;
            ClientSize = new Size(1113, 600);
            Controls.Add(lbToTime);
            Controls.Add(rbCustomerName);
            Controls.Add(rbID);
            Controls.Add(txtCustomerName);
            Controls.Add(btnSearchByIDorName);
            Controls.Add(dtpTo);
            Controls.Add(lbCustomerName);
            Controls.Add(dtpFrom);
            Controls.Add(lbFromTime);
            Controls.Add(dgrecit);
            Controls.Add(btnSearchByDate);
            Controls.Add(lbID);
            Controls.Add(txtID);
            Controls.Add(panBotton);
            Controls.Add(panTop);
            Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Margin = new Padding(3, 5, 3, 5);
            Name = "frmSaleOrderReport";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة تقارير المبيعات";
            panTop.ResumeLayout(false);
            panTop.PerformLayout();
            panBotton.ResumeLayout(false);
            panBotton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTotalPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgrecit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panTop;
        private Panel panBotton;
        private TextBox txtID;
        private Label lbID;
        private Button btnSearchByDate;
        private DataGridView dgrecit;
        private ErrorProvider errorProvider1;
        private Label lbFromTime;
        private NumericUpDown numTotalPrice;
        private DateTimePicker dtpFrom;
        private Label lbHead;
        private Label lbTotalPrice;
        private Button btnSearchByIDorName;
        private DateTimePicker dtpTo;
        private Label lbCustomerName;
        private RadioButton rbID;
        private Label label2;
        private TextBox txtCustomerName;
        private RadioButton rbCustomerName;
        private Label lbToTime;
        private DataGridViewTextBoxColumn cSalesOrderID;
        private DataGridViewTextBoxColumn cCUSTOMERNAME;
        private DataGridViewTextBoxColumn cPRODUCTNAME;
        private DataGridViewTextBoxColumn cPRODUCTQUANTITY;
        private DataGridViewTextBoxColumn cPRODUCTPRICE;
        private DataGridViewTextBoxColumn cPRODUCTTOTALPRICE;
    }
}