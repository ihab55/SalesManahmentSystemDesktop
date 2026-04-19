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
            btnCatagoreys = new Button();
            btnProduct = new Button();
            btnSalesOrder = new Button();
            btnSalesOrderReport = new Button();
            btnStock = new Button();
            btnCustomer = new Button();
            btnStockDetails = new Button();
            SuspendLayout();
            // 
            // btnCatagoreys
            // 
            btnCatagoreys.BackColor = Color.DarkSlateGray;
            btnCatagoreys.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            btnCatagoreys.ForeColor = SystemColors.Window;
            btnCatagoreys.Location = new Point(446, 321);
            btnCatagoreys.Name = "btnCatagoreys";
            btnCatagoreys.Size = new Size(189, 48);
            btnCatagoreys.TabIndex = 9;
            btnCatagoreys.Text = "المجموع";
            btnCatagoreys.UseVisualStyleBackColor = false;
            btnCatagoreys.Click += btnCatagoreys_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.DarkSlateGray;
            btnProduct.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            btnProduct.ForeColor = SystemColors.Window;
            btnProduct.Location = new Point(754, 321);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(189, 48);
            btnProduct.TabIndex = 10;
            btnProduct.Text = "الاصناف";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnSalesOrder
            // 
            btnSalesOrder.BackColor = Color.DarkSlateGray;
            btnSalesOrder.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            btnSalesOrder.ForeColor = SystemColors.Window;
            btnSalesOrder.Location = new Point(467, 418);
            btnSalesOrder.Name = "btnSalesOrder";
            btnSalesOrder.Size = new Size(189, 48);
            btnSalesOrder.TabIndex = 11;
            btnSalesOrder.Text = "أنشاء فاتورة";
            btnSalesOrder.UseVisualStyleBackColor = false;
            btnSalesOrder.Click += btnSaleOrder_Click;
            // 
            // btnSalesOrderReport
            // 
            btnSalesOrderReport.BackColor = Color.DarkSlateGray;
            btnSalesOrderReport.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            btnSalesOrderReport.ForeColor = SystemColors.Window;
            btnSalesOrderReport.Location = new Point(742, 418);
            btnSalesOrderReport.Name = "btnSalesOrderReport";
            btnSalesOrderReport.Size = new Size(189, 48);
            btnSalesOrderReport.TabIndex = 12;
            btnSalesOrderReport.Text = "التقارير";
            btnSalesOrderReport.UseVisualStyleBackColor = false;
            btnSalesOrderReport.Click += btnSaleOrderReport_Click;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.DarkSlateGray;
            btnStock.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            btnStock.ForeColor = SystemColors.Window;
            btnStock.Location = new Point(446, 510);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(189, 48);
            btnStock.TabIndex = 13;
            btnStock.Text = "الخزانة";
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.DarkSlateGray;
            btnCustomer.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            btnCustomer.ForeColor = SystemColors.Window;
            btnCustomer.Location = new Point(754, 510);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(189, 48);
            btnCustomer.TabIndex = 14;
            btnCustomer.Text = "العملاء";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnStockDetails
            // 
            btnStockDetails.BackColor = Color.DarkSlateGray;
            btnStockDetails.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            btnStockDetails.ForeColor = SystemColors.Window;
            btnStockDetails.Location = new Point(600, 600);
            btnStockDetails.Name = "btnStockDetails";
            btnStockDetails.Size = new Size(189, 48);
            btnStockDetails.TabIndex = 15;
            btnStockDetails.Text = "حركات الخزنة";
            btnStockDetails.UseVisualStyleBackColor = false;
            btnStockDetails.Click += btnStockDetails_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Snow;
            ClientSize = new Size(1148, 846);
            Controls.Add(btnStockDetails);
            Controls.Add(btnCustomer);
            Controls.Add(btnStock);
            Controls.Add(btnSalesOrderReport);
            Controls.Add(btnSalesOrder);
            Controls.Add(btnProduct);
            Controls.Add(btnCatagoreys);
            Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Margin = new Padding(3, 5, 3, 5);
            Name = "frmMain";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة الاصناف";
            ResumeLayout(false);
        }

        #endregion
        private Button btnCatagoreys;
        private Button btnProduct;
        private Button btnSalesOrder;
        private Button btnSalesOrderReport;
        private Button btnStock;
        private Button btnCustomer;
        private Button btnStockDetails;
    }
}