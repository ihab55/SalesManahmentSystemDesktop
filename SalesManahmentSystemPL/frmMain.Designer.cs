using SalesManahmentSystemBLL.Services;

namespace SalesManahmentSystemPL
{
    partial class frmMain
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
            panHeader = new Panel();
            lbSubtitle = new Label();
            lbTitle = new Label();
            panMenu = new Panel();
            btnSalesOrder = new Button();
            btnSalesOrderReport = new Button();
            btnStockDetails = new Button();
            btnStock = new Button();
            btnCustomer = new Button();
            btnProduct = new Button();
            btnCatagoreys = new Button();
            panFooter = new Panel();
            lbFooter = new Label();
            panHeader.SuspendLayout();
            panMenu.SuspendLayout();
            panFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panHeader
            // 
            panHeader.BackColor = Color.FromArgb(45, 85, 95);
            panHeader.Controls.Add(lbSubtitle);
            panHeader.Controls.Add(lbTitle);
            panHeader.Dock = DockStyle.Top;
            panHeader.Location = new Point(0, 0);
            panHeader.Name = "panHeader";
            panHeader.Size = new Size(1000, 140);
            panHeader.TabIndex = 0;
            // 
            // lbSubtitle
            // 
            lbSubtitle.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSubtitle.ForeColor = Color.FromArgb(200, 220, 225);
            lbSubtitle.Location = new Point(0, 80);
            lbSubtitle.Name = "lbSubtitle";
            lbSubtitle.Size = new Size(1000, 40);
            lbSubtitle.TabIndex = 1;
            lbSubtitle.Text = "الواجهة الرئيسية - اختر القسم المناسب";
            lbSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTitle
            // 
            lbTitle.Font = new Font("Dubai", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.White;
            lbTitle.Location = new Point(0, 20);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(1000, 60);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "نظام إدارة المبيعات";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panMenu
            // 
            panMenu.BackColor = Color.FromArgb(245, 247, 250);
            panMenu.Controls.Add(btnSalesOrder);
            panMenu.Controls.Add(btnSalesOrderReport);
            panMenu.Controls.Add(btnStockDetails);
            panMenu.Controls.Add(btnStock);
            panMenu.Controls.Add(btnCustomer);
            panMenu.Controls.Add(btnProduct);
            panMenu.Controls.Add(btnCatagoreys);
            panMenu.Dock = DockStyle.Fill;
            panMenu.Location = new Point(0, 140);
            panMenu.Name = "panMenu";
            panMenu.Padding = new Padding(80, 40, 80, 40);
            panMenu.Size = new Size(1000, 460);
            panMenu.TabIndex = 1;
            // 
            // btnSalesOrder
            // 
            btnSalesOrder.BackColor = Color.FromArgb(45, 85, 95);
            btnSalesOrder.Cursor = Cursors.Hand;
            btnSalesOrder.FlatAppearance.BorderSize = 0;
            btnSalesOrder.FlatStyle = FlatStyle.Flat;
            btnSalesOrder.Font = new Font("Dubai", 13F, FontStyle.Bold);
            btnSalesOrder.ForeColor = Color.White;
            btnSalesOrder.Location = new Point(680, 40);
            btnSalesOrder.Margin = new Padding(20);
            btnSalesOrder.Name = "btnSalesOrder";
            btnSalesOrder.Size = new Size(220, 90);
            btnSalesOrder.TabIndex = 0;
            btnSalesOrder.Text = "📝  إنشاء فاتورة";
            btnSalesOrder.UseVisualStyleBackColor = false;
            btnSalesOrder.Click += btnSaleOrder_Click;
            // 
            // btnSalesOrderReport
            // 
            btnSalesOrderReport.BackColor = Color.FromArgb(65, 105, 115);
            btnSalesOrderReport.Cursor = Cursors.Hand;
            btnSalesOrderReport.FlatAppearance.BorderSize = 0;
            btnSalesOrderReport.FlatStyle = FlatStyle.Flat;
            btnSalesOrderReport.Font = new Font("Dubai", 13F, FontStyle.Bold);
            btnSalesOrderReport.ForeColor = Color.White;
            btnSalesOrderReport.Location = new Point(390, 40);
            btnSalesOrderReport.Margin = new Padding(20);
            btnSalesOrderReport.Name = "btnSalesOrderReport";
            btnSalesOrderReport.Size = new Size(220, 90);
            btnSalesOrderReport.TabIndex = 1;
            btnSalesOrderReport.Text = "📊  التقارير";
            btnSalesOrderReport.UseVisualStyleBackColor = false;
            btnSalesOrderReport.Click += btnSaleOrderReport_Click;
            // 
            // btnStockDetails
            // 
            btnStockDetails.BackColor = Color.FromArgb(85, 125, 135);
            btnStockDetails.Cursor = Cursors.Hand;
            btnStockDetails.FlatAppearance.BorderSize = 0;
            btnStockDetails.FlatStyle = FlatStyle.Flat;
            btnStockDetails.Font = new Font("Dubai", 13F, FontStyle.Bold);
            btnStockDetails.ForeColor = Color.White;
            btnStockDetails.Location = new Point(100, 40);
            btnStockDetails.Margin = new Padding(20);
            btnStockDetails.Name = "btnStockDetails";
            btnStockDetails.Size = new Size(220, 90);
            btnStockDetails.TabIndex = 2;
            btnStockDetails.Text = "💰  حركات الخزنة";
            btnStockDetails.UseVisualStyleBackColor = false;
            btnStockDetails.Click += btnStockDetails_Click;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.FromArgb(75, 115, 125);
            btnStock.Cursor = Cursors.Hand;
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Dubai", 13F, FontStyle.Bold);
            btnStock.ForeColor = Color.White;
            btnStock.Location = new Point(680, 170);
            btnStock.Margin = new Padding(20);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(220, 90);
            btnStock.TabIndex = 3;
            btnStock.Text = "🏦  الخزائن";
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.FromArgb(95, 135, 145);
            btnCustomer.Cursor = Cursors.Hand;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Dubai", 13F, FontStyle.Bold);
            btnCustomer.ForeColor = Color.White;
            btnCustomer.Location = new Point(390, 170);
            btnCustomer.Margin = new Padding(20);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(220, 90);
            btnCustomer.TabIndex = 4;
            btnCustomer.Text = "👥  العملاء";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.FromArgb(105, 145, 155);
            btnProduct.Cursor = Cursors.Hand;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Dubai", 13F, FontStyle.Bold);
            btnProduct.ForeColor = Color.White;
            btnProduct.Location = new Point(100, 170);
            btnProduct.Margin = new Padding(20);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(220, 90);
            btnProduct.TabIndex = 5;
            btnProduct.Text = "📦  الأصناف";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnCatagoreys
            // 
            btnCatagoreys.BackColor = Color.FromArgb(115, 155, 165);
            btnCatagoreys.Cursor = Cursors.Hand;
            btnCatagoreys.FlatAppearance.BorderSize = 0;
            btnCatagoreys.FlatStyle = FlatStyle.Flat;
            btnCatagoreys.Font = new Font("Dubai", 13F, FontStyle.Bold);
            btnCatagoreys.ForeColor = Color.White;
            btnCatagoreys.Location = new Point(390, 300);
            btnCatagoreys.Margin = new Padding(20);
            btnCatagoreys.Name = "btnCatagoreys";
            btnCatagoreys.Size = new Size(220, 90);
            btnCatagoreys.TabIndex = 6;
            btnCatagoreys.Text = "🏷️  المجموعات";
            btnCatagoreys.UseVisualStyleBackColor = false;
            btnCatagoreys.Click += btnCatagoreys_Click;
            // 
            // panFooter
            // 
            panFooter.BackColor = Color.FromArgb(45, 85, 95);
            panFooter.Controls.Add(lbFooter);
            panFooter.Dock = DockStyle.Bottom;
            panFooter.Location = new Point(0, 600);
            panFooter.Name = "panFooter";
            panFooter.Size = new Size(1000, 50);
            panFooter.TabIndex = 2;
            // 
            // lbFooter
            // 
            lbFooter.Dock = DockStyle.Fill;
            lbFooter.Font = new Font("Dubai", 10F);
            lbFooter.ForeColor = Color.FromArgb(180, 200, 205);
            lbFooter.Location = new Point(0, 0);
            lbFooter.Name = "lbFooter";
            lbFooter.Size = new Size(1000, 50);
            lbFooter.TabIndex = 0;
            lbFooter.Text = "نظام إدارة المبيعات - إيهاب أيمن - ehab.ayman7420@gmail.com";
            lbFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 650);
            Controls.Add(panMenu);
            Controls.Add(panFooter);
            Controls.Add(panHeader);
            Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            Name = "frmMain";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "نظام إدارة المبيعات - الرئيسية";
            panHeader.ResumeLayout(false);
            panMenu.ResumeLayout(false);
            panFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panHeader;
        private Label lbTitle;
        private Label lbSubtitle;
        private Panel panMenu;
        private Button btnSalesOrder;
        private Button btnSalesOrderReport;
        private Button btnStockDetails;
        private Button btnStock;
        private Button btnCustomer;
        private Button btnProduct;
        private Button btnCatagoreys;
        private Panel panFooter;
        private Label lbFooter;
    }
}