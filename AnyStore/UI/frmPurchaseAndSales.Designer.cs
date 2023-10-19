namespace AnyStore.UI
{
    partial class frmPurchaseAndSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseAndSales));
            pictureBoxClose = new PictureBox();
            pnlDeaCust = new Panel();
            dtpBillDate = new DateTimePicker();
            txtAddress = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtSearch = new TextBox();
            lblBillDate = new Label();
            lblAddress = new Label();
            lblContact = new Label();
            lblEmail = new Label();
            lblName = new Label();
            lblSearch = new Label();
            lblDeaCustTitle = new Label();
            panel2 = new Panel();
            btnAdd = new Button();
            txtQty = new TextBox();
            txtRate = new TextBox();
            txtInventory = new TextBox();
            txtProductName = new TextBox();
            txtSearchProduct = new TextBox();
            lblQuantity = new Label();
            lblRate = new Label();
            lblInventory = new Label();
            lblProductName = new Label();
            lblProductSearch = new Label();
            lblProductTitle = new Label();
            pnlDataGridView = new Panel();
            dgvAddedProducts = new DataGridView();
            lblDGVTitle = new Label();
            pnlCalculation = new Panel();
            btnSave = new Button();
            txtReturnAmount = new TextBox();
            txtPaidAmount = new TextBox();
            txtGrandTotal = new TextBox();
            txtVat = new TextBox();
            txtDiscount = new TextBox();
            txtSubTotal = new TextBox();
            lblReturnAmount = new Label();
            lblPaidAmount = new Label();
            lblGrandTotal = new Label();
            lblVat = new Label();
            lblDiscount = new Label();
            lblSubTotal = new Label();
            lblCalculationTitle = new Label();
            lblTop = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            pnlDeaCust.SuspendLayout();
            panel2.SuspendLayout();
            pnlDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddedProducts).BeginInit();
            pnlCalculation.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.BackColor = Color.Transparent;
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(1763, 3);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(33, 32);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxClose.TabIndex = 1;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // pnlDeaCust
            // 
            pnlDeaCust.BorderStyle = BorderStyle.FixedSingle;
            pnlDeaCust.Controls.Add(dtpBillDate);
            pnlDeaCust.Controls.Add(txtAddress);
            pnlDeaCust.Controls.Add(txtContact);
            pnlDeaCust.Controls.Add(txtEmail);
            pnlDeaCust.Controls.Add(txtName);
            pnlDeaCust.Controls.Add(txtSearch);
            pnlDeaCust.Controls.Add(lblBillDate);
            pnlDeaCust.Controls.Add(lblAddress);
            pnlDeaCust.Controls.Add(lblContact);
            pnlDeaCust.Controls.Add(lblEmail);
            pnlDeaCust.Controls.Add(lblName);
            pnlDeaCust.Controls.Add(lblSearch);
            pnlDeaCust.Controls.Add(lblDeaCustTitle);
            pnlDeaCust.Location = new Point(12, 54);
            pnlDeaCust.Name = "pnlDeaCust";
            pnlDeaCust.Size = new Size(1775, 140);
            pnlDeaCust.TabIndex = 3;
            // 
            // dtpBillDate
            // 
            dtpBillDate.CalendarMonthBackground = Color.RosyBrown;
            dtpBillDate.Location = new Point(1432, 44);
            dtpBillDate.Name = "dtpBillDate";
            dtpBillDate.Size = new Size(250, 27);
            dtpBillDate.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(980, 38);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(295, 80);
            txtAddress.TabIndex = 10;
            // 
            // txtContact
            // 
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtContact.Location = new Point(552, 88);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(295, 30);
            txtContact.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(552, 38);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(295, 30);
            txtEmail.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(103, 90);
            txtName.Name = "txtName";
            txtName.Size = new Size(295, 30);
            txtName.TabIndex = 10;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(102, 38);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(296, 30);
            txtSearch.TabIndex = 9;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblBillDate
            // 
            lblBillDate.AutoSize = true;
            lblBillDate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblBillDate.Location = new Point(1341, 45);
            lblBillDate.Name = "lblBillDate";
            lblBillDate.Size = new Size(73, 23);
            lblBillDate.TabIndex = 8;
            lblBillDate.Text = "Bill Date";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.Location = new Point(904, 43);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 23);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Address";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblContact.Location = new Point(476, 88);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(70, 23);
            lblContact.TabIndex = 5;
            lblContact.Text = "Contact";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(476, 40);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 23);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(40, 90);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 23);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.Location = new Point(35, 42);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(61, 23);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search";
            // 
            // lblDeaCustTitle
            // 
            lblDeaCustTitle.AutoSize = true;
            lblDeaCustTitle.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeaCustTitle.Location = new Point(2, 6);
            lblDeaCustTitle.Name = "lblDeaCustTitle";
            lblDeaCustTitle.Size = new Size(251, 23);
            lblDeaCustTitle.TabIndex = 0;
            lblDeaCustTitle.Text = "Dealer and Customer Details";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(txtQty);
            panel2.Controls.Add(txtRate);
            panel2.Controls.Add(txtInventory);
            panel2.Controls.Add(txtProductName);
            panel2.Controls.Add(txtSearchProduct);
            panel2.Controls.Add(lblQuantity);
            panel2.Controls.Add(lblRate);
            panel2.Controls.Add(lblInventory);
            panel2.Controls.Add(lblProductName);
            panel2.Controls.Add(lblProductSearch);
            panel2.Controls.Add(lblProductTitle);
            panel2.Location = new Point(12, 214);
            panel2.Name = "panel2";
            panel2.Size = new Size(1775, 109);
            panel2.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Silver;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(1630, 33);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 41);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtQty
            // 
            txtQty.BorderStyle = BorderStyle.FixedSingle;
            txtQty.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtQty.Location = new Point(1365, 41);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(207, 30);
            txtQty.TabIndex = 10;
            // 
            // txtRate
            // 
            txtRate.BorderStyle = BorderStyle.FixedSingle;
            txtRate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtRate.Location = new Point(1029, 41);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(207, 30);
            txtRate.TabIndex = 11;
            // 
            // txtInventory
            // 
            txtInventory.BorderStyle = BorderStyle.FixedSingle;
            txtInventory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtInventory.Location = new Point(724, 41);
            txtInventory.Name = "txtInventory";
            txtInventory.Size = new Size(207, 30);
            txtInventory.TabIndex = 12;
            // 
            // txtProductName
            // 
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductName.Location = new Point(389, 41);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(207, 30);
            txtProductName.TabIndex = 11;
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.BorderStyle = BorderStyle.FixedSingle;
            txtSearchProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchProduct.Location = new Point(77, 41);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(207, 30);
            txtSearchProduct.TabIndex = 10;
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.Location = new Point(1282, 42);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(77, 23);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Quantity";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblRate.Location = new Point(978, 43);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(45, 23);
            lblRate.TabIndex = 5;
            lblRate.Text = "Rate";
            // 
            // lblInventory
            // 
            lblInventory.AutoSize = true;
            lblInventory.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblInventory.Location = new Point(633, 43);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(85, 23);
            lblInventory.TabIndex = 4;
            lblInventory.Text = "Inventory";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductName.Location = new Point(327, 43);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(56, 23);
            lblProductName.TabIndex = 3;
            lblProductName.Text = "Name";
            // 
            // lblProductSearch
            // 
            lblProductSearch.AutoSize = true;
            lblProductSearch.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductSearch.Location = new Point(10, 43);
            lblProductSearch.Name = "lblProductSearch";
            lblProductSearch.Size = new Size(61, 23);
            lblProductSearch.TabIndex = 2;
            lblProductSearch.Text = "Search";
            // 
            // lblProductTitle
            // 
            lblProductTitle.AutoSize = true;
            lblProductTitle.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductTitle.Location = new Point(2, 7);
            lblProductTitle.Name = "lblProductTitle";
            lblProductTitle.Size = new Size(139, 23);
            lblProductTitle.TabIndex = 0;
            lblProductTitle.Text = "Product Details";
            // 
            // pnlDataGridView
            // 
            pnlDataGridView.BorderStyle = BorderStyle.FixedSingle;
            pnlDataGridView.Controls.Add(dgvAddedProducts);
            pnlDataGridView.Controls.Add(lblDGVTitle);
            pnlDataGridView.Location = new Point(12, 343);
            pnlDataGridView.Name = "pnlDataGridView";
            pnlDataGridView.Size = new Size(873, 395);
            pnlDataGridView.TabIndex = 5;
            // 
            // dgvAddedProducts
            // 
            dgvAddedProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddedProducts.Location = new Point(11, 45);
            dgvAddedProducts.Name = "dgvAddedProducts";
            dgvAddedProducts.RowHeadersWidth = 51;
            dgvAddedProducts.RowTemplate.Height = 29;
            dgvAddedProducts.Size = new Size(849, 327);
            dgvAddedProducts.TabIndex = 1;
            // 
            // lblDGVTitle
            // 
            lblDGVTitle.AutoSize = true;
            lblDGVTitle.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblDGVTitle.Location = new Point(-1, 9);
            lblDGVTitle.Name = "lblDGVTitle";
            lblDGVTitle.Size = new Size(145, 23);
            lblDGVTitle.TabIndex = 0;
            lblDGVTitle.Text = "Added Products";
            // 
            // pnlCalculation
            // 
            pnlCalculation.BorderStyle = BorderStyle.FixedSingle;
            pnlCalculation.Controls.Add(btnSave);
            pnlCalculation.Controls.Add(txtReturnAmount);
            pnlCalculation.Controls.Add(txtPaidAmount);
            pnlCalculation.Controls.Add(txtGrandTotal);
            pnlCalculation.Controls.Add(txtVat);
            pnlCalculation.Controls.Add(txtDiscount);
            pnlCalculation.Controls.Add(txtSubTotal);
            pnlCalculation.Controls.Add(lblReturnAmount);
            pnlCalculation.Controls.Add(lblPaidAmount);
            pnlCalculation.Controls.Add(lblGrandTotal);
            pnlCalculation.Controls.Add(lblVat);
            pnlCalculation.Controls.Add(lblDiscount);
            pnlCalculation.Controls.Add(lblSubTotal);
            pnlCalculation.Controls.Add(lblCalculationTitle);
            pnlCalculation.Location = new Point(918, 343);
            pnlCalculation.Name = "pnlCalculation";
            pnlCalculation.Size = new Size(869, 395);
            pnlCalculation.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Silver;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(698, 170);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 41);
            btnSave.TabIndex = 16;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtReturnAmount
            // 
            txtReturnAmount.BorderStyle = BorderStyle.FixedSingle;
            txtReturnAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtReturnAmount.ForeColor = Color.DarkRed;
            txtReturnAmount.Location = new Point(156, 324);
            txtReturnAmount.Name = "txtReturnAmount";
            txtReturnAmount.ReadOnly = true;
            txtReturnAmount.Size = new Size(449, 30);
            txtReturnAmount.TabIndex = 15;
            // 
            // txtPaidAmount
            // 
            txtPaidAmount.BorderStyle = BorderStyle.FixedSingle;
            txtPaidAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaidAmount.Location = new Point(156, 265);
            txtPaidAmount.Name = "txtPaidAmount";
            txtPaidAmount.Size = new Size(449, 30);
            txtPaidAmount.TabIndex = 14;
            txtPaidAmount.TextChanged += txtPaidAmount_TextChanged;
            // 
            // txtGrandTotal
            // 
            txtGrandTotal.BorderStyle = BorderStyle.FixedSingle;
            txtGrandTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtGrandTotal.Location = new Point(156, 206);
            txtGrandTotal.Name = "txtGrandTotal";
            txtGrandTotal.Size = new Size(449, 30);
            txtGrandTotal.TabIndex = 13;
            txtGrandTotal.TextChanged += txtGrandTotal_TextChanged;
            // 
            // txtVat
            // 
            txtVat.BorderStyle = BorderStyle.FixedSingle;
            txtVat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtVat.Location = new Point(156, 154);
            txtVat.Name = "txtVat";
            txtVat.Size = new Size(449, 30);
            txtVat.TabIndex = 12;
            txtVat.TextChanged += txtVat_TextChanged;
            // 
            // txtDiscount
            // 
            txtDiscount.BorderStyle = BorderStyle.FixedSingle;
            txtDiscount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiscount.Location = new Point(156, 98);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(449, 30);
            txtDiscount.TabIndex = 11;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            // 
            // txtSubTotal
            // 
            txtSubTotal.BorderStyle = BorderStyle.FixedSingle;
            txtSubTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubTotal.Location = new Point(156, 45);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(449, 30);
            txtSubTotal.TabIndex = 10;
            txtSubTotal.Text = "0";
            // 
            // lblReturnAmount
            // 
            lblReturnAmount.AutoSize = true;
            lblReturnAmount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblReturnAmount.Location = new Point(21, 331);
            lblReturnAmount.Name = "lblReturnAmount";
            lblReturnAmount.Size = new Size(129, 23);
            lblReturnAmount.TabIndex = 8;
            lblReturnAmount.Text = "Return Amount";
            // 
            // lblPaidAmount
            // 
            lblPaidAmount.AutoSize = true;
            lblPaidAmount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPaidAmount.Location = new Point(21, 267);
            lblPaidAmount.Name = "lblPaidAmount";
            lblPaidAmount.Size = new Size(110, 23);
            lblPaidAmount.TabIndex = 7;
            lblPaidAmount.Text = "Paid Amount";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrandTotal.Location = new Point(21, 208);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(98, 23);
            lblGrandTotal.TabIndex = 6;
            lblGrandTotal.Text = "Grand Total";
            // 
            // lblVat
            // 
            lblVat.AutoSize = true;
            lblVat.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblVat.Location = new Point(21, 156);
            lblVat.Name = "lblVat";
            lblVat.Size = new Size(65, 23);
            lblVat.TabIndex = 5;
            lblVat.Text = "VAT(%)";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiscount.Location = new Point(21, 98);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(103, 23);
            lblDiscount.TabIndex = 4;
            lblDiscount.Text = "Discount(%)";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubTotal.Location = new Point(22, 45);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(80, 23);
            lblSubTotal.TabIndex = 3;
            lblSubTotal.Text = "Sub Total";
            // 
            // lblCalculationTitle
            // 
            lblCalculationTitle.AutoSize = true;
            lblCalculationTitle.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblCalculationTitle.Location = new Point(13, 9);
            lblCalculationTitle.Name = "lblCalculationTitle";
            lblCalculationTitle.Size = new Size(167, 23);
            lblCalculationTitle.TabIndex = 1;
            lblCalculationTitle.Text = "Calculation Details";
            // 
            // lblTop
            // 
            lblTop.AutoSize = true;
            lblTop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTop.Location = new Point(793, 9);
            lblTop.Name = "lblTop";
            lblTop.Size = new Size(228, 28);
            lblTop.TabIndex = 7;
            lblTop.Text = "PURCHASE AND SALES";
            // 
            // frmPurchaseAndSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1799, 751);
            Controls.Add(lblTop);
            Controls.Add(pnlCalculation);
            Controls.Add(pnlDataGridView);
            Controls.Add(pictureBoxClose);
            Controls.Add(panel2);
            Controls.Add(pnlDeaCust);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPurchaseAndSales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purchase and Sales";
            Load += frmPurchaseAndSales_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            pnlDeaCust.ResumeLayout(false);
            pnlDeaCust.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlDataGridView.ResumeLayout(false);
            pnlDataGridView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddedProducts).EndInit();
            pnlCalculation.ResumeLayout(false);
            pnlCalculation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxClose;
        private Panel pnlDeaCust;
        private Label lblSearch;
        private Label lblDeaCustTitle;
        private Label lblBillDate;
        private Label lblAddress;
        private Label lblContact;
        private Label lblEmail;
        private Label lblName;
        private TextBox txtAddress;
        private TextBox txtContact;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtSearch;
        private DateTimePicker dtpBillDate;
        private Panel panel2;
        private Label lblProductSearch;
        private Label lblProductTitle;
        private Button btnAdd;
        private TextBox txtQty;
        private TextBox txtRate;
        private TextBox txtInventory;
        private TextBox txtProductName;
        private TextBox txtSearchProduct;
        private Label lblQuantity;
        private Label lblRate;
        private Label lblInventory;
        private Label lblProductName;
        private Panel pnlDataGridView;
        private DataGridView dgvAddedProducts;
        private Label lblDGVTitle;
        private Panel pnlCalculation;
        private Label lblDiscount;
        private Label lblSubTotal;
        private Label lblCalculationTitle;
        private Label lblGrandTotal;
        private Label lblVat;
        private TextBox txtReturnAmount;
        private TextBox txtPaidAmount;
        private TextBox txtGrandTotal;
        private TextBox txtVat;
        private TextBox txtDiscount;
        private TextBox txtSubTotal;
        private Label lblReturnAmount;
        private Label lblPaidAmount;
        private Button btnSave;
        private Label lblTop;
    }
}