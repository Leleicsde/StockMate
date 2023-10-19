namespace AnyStore.UI
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            pictureBoxClose = new PictureBox();
            dgvProduct = new DataGridView();
            lblCategory = new Label();
            cmbCategories = new ComboBox();
            btnAll = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.BackColor = Color.Transparent;
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(1170, 8);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(33, 32);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxClose.TabIndex = 1;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(49, 113);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.Size = new Size(1109, 363);
            dgvProduct.TabIndex = 4;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.Location = new Point(48, 79);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(81, 23);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            // 
            // cmbCategories
            // 
            cmbCategories.BackColor = Color.Silver;
            cmbCategories.FlatStyle = FlatStyle.Popup;
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(135, 76);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(412, 31);
            cmbCategories.TabIndex = 6;
            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;
            // 
            // btnAll
            // 
            btnAll.BackColor = Color.Silver;
            btnAll.FlatStyle = FlatStyle.Popup;
            btnAll.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAll.Location = new Point(1024, 78);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(134, 29);
            btnAll.TabIndex = 7;
            btnAll.Text = "SHOW ALL";
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // frmInventory
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1213, 730);
            Controls.Add(btnAll);
            Controls.Add(cmbCategories);
            Controls.Add(pictureBoxClose);
            Controls.Add(lblCategory);
            Controls.Add(dgvProduct);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInventory";
            Load += frmInventory_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxClose;
        private DataGridView dgvProduct;
        private Label lblCategory;
        private ComboBox cmbCategories;
        private Button btnAll;
    }
}