using SalesManahmentSystemBLL.Services;

namespace SalesManahmentSystemPL
{
    partial class frmCatagory
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
            dgCatagories = new DataGridView();
            IDColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            panFooter = new Panel();
            lbFooter = new Label();
            panTop.SuspendLayout();
            panInput.SuspendLayout();
            panButtons.SuspendLayout();
            panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCatagories).BeginInit();
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
            lbHead.Text = "إدارة المجموعات";
            lbHead.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panInput
            // 
            panInput.BackColor = Color.White;
            panInput.Controls.Add(lbName);
            panInput.Controls.Add(txtName);
            panInput.Controls.Add(lbID);
            panInput.Controls.Add(txtID);
            panInput.Location = new Point(50, 120);
            panInput.Name = "panInput";
            panInput.Size = new Size(900, 140);
            panInput.TabIndex = 1;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.ForeColor = Color.FromArgb(45, 85, 95);
            lbName.Location = new Point(280, 20);
            lbName.Name = "lbName";
            lbName.Size = new Size(136, 34);
            lbName.TabIndex = 2;
            lbName.Text = "اسم المجموعة :";
            lbName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(60, 55);
            txtName.Name = "txtName";
            txtName.Size = new Size(350, 41);
            txtName.TabIndex = 3;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbID.ForeColor = Color.FromArgb(45, 85, 95);
            lbID.Location = new Point(720, 20);
            lbID.Name = "lbID";
            lbID.Size = new Size(129, 34);
            lbID.TabIndex = 0;
            lbID.Text = "رقم المجموعة :";
            lbID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(245, 247, 250);
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Enabled = false;
            txtID.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(580, 55);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(260, 41);
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
            panButtons.Location = new Point(50, 270);
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
            panSearch.Location = new Point(50, 350);
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
            btnSearch.Location = new Point(160, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 41);
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
            txtSearch.Location = new Point(300, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "ابحث باسم المجموعة...";
            txtSearch.Size = new Size(400, 41);
            txtSearch.TabIndex = 0;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // dgCatagories
            // 
            dgCatagories.AllowUserToAddRows = false;
            dgCatagories.AllowUserToDeleteRows = false;
            dgCatagories.AllowUserToResizeColumns = false;
            dgCatagories.AllowUserToResizeRows = false;
            dgCatagories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgCatagories.BackgroundColor = Color.White;
            dgCatagories.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 85, 95);
            dataGridViewCellStyle1.Font = new Font("Dubai", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgCatagories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgCatagories.ColumnHeadersHeight = 45;
            dgCatagories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgCatagories.Columns.AddRange(new DataGridViewColumn[] { IDColumn, NameColumn });
            dgCatagories.EnableHeadersVisualStyles = false;
            dgCatagories.GridColor = Color.FromArgb(220, 220, 220);
            dgCatagories.Location = new Point(50, 430);
            dgCatagories.MultiSelect = false;
            dgCatagories.Name = "dgCatagories";
            dgCatagories.ReadOnly = true;
            dgCatagories.RowHeadersVisible = false;
            dgCatagories.RowHeadersWidth = 51;
            dgCatagories.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgCatagories.RowTemplate.DefaultCellStyle.Font = new Font("Dubai", 11F);
            dgCatagories.RowTemplate.Height = 40;
            dgCatagories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCatagories.Size = new Size(900, 280);
            dgCatagories.TabIndex = 4;
            dgCatagories.RowEnter += dgCatagories_RowEnter;
            // 
            // IDColumn
            // 
            IDColumn.DataPropertyName = "ID";
            IDColumn.HeaderText = "رقم المجموعة";
            IDColumn.MinimumWidth = 6;
            IDColumn.Name = "IDColumn";
            IDColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            NameColumn.DataPropertyName = "Name";
            NameColumn.HeaderText = "اسم المجموعة";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
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
            panFooter.Size = new Size(1000, 60);
            panFooter.TabIndex = 5;
            // 
            // lbFooter
            // 
            lbFooter.Dock = DockStyle.Fill;
            lbFooter.Font = new Font("Dubai", 10F);
            lbFooter.ForeColor = Color.FromArgb(180, 200, 205);
            lbFooter.Location = new Point(0, 0);
            lbFooter.Name = "lbFooter";
            lbFooter.Size = new Size(1000, 60);
            lbFooter.TabIndex = 0;
            lbFooter.Text = "نظام إدارة المبيعات - إيهاب أيمن - ehab.ayman7420@gmail.com";
            lbFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmCatagory
            // 
            AutoScaleDimensions = new SizeF(9F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 252);
            ClientSize = new Size(1000, 780);
            Controls.Add(dgCatagories);
            Controls.Add(panSearch);
            Controls.Add(panButtons);
            Controls.Add(panInput);
            Controls.Add(panFooter);
            Controls.Add(panTop);
            Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            Name = "frmCatagory";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدارة المجموعات";
            Load += FrmCatagory_Load;
            panTop.ResumeLayout(false);
            panInput.ResumeLayout(false);
            panInput.PerformLayout();
            panButtons.ResumeLayout(false);
            panSearch.ResumeLayout(false);
            panSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgCatagories).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panTop;
        private Label lbHead;
        private Panel panInput;
        private Label lbID;
        private TextBox txtID;
        private Label lbName;
        private TextBox txtName;
        private Panel panButtons;
        private Button btnNew;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnDeleteAll;
        private Panel panSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgCatagories;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn IDColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private Panel panFooter;
        private Label lbFooter;
    }
}