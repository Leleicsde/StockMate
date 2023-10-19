namespace AnyStore.UI
{
    partial class frmTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactions));
            pictureBoxClose = new PictureBox();
            dgvTransactions = new DataGridView();
            lblTransactionType = new Label();
            cmbTransactionType = new ComboBox();
            btnAll = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.BackColor = Color.Transparent;
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(1238, 4);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(33, 32);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxClose.TabIndex = 1;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // dgvTransactions
            // 
            dgvTransactions.BackgroundColor = Color.Silver;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(272, 211);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersWidth = 51;
            dgvTransactions.RowTemplate.Height = 29;
            dgvTransactions.Size = new Size(668, 391);
            dgvTransactions.TabIndex = 3;
            // 
            // lblTransactionType
            // 
            lblTransactionType.AutoSize = true;
            lblTransactionType.BackColor = Color.Transparent;
            lblTransactionType.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTransactionType.Location = new Point(272, 177);
            lblTransactionType.Name = "lblTransactionType";
            lblTransactionType.Size = new Size(138, 23);
            lblTransactionType.TabIndex = 4;
            lblTransactionType.Text = "Transaction Type";
            // 
            // cmbTransactionType
            // 
            cmbTransactionType.BackColor = Color.Silver;
            cmbTransactionType.FlatStyle = FlatStyle.Popup;
            cmbTransactionType.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTransactionType.FormattingEnabled = true;
            cmbTransactionType.Items.AddRange(new object[] { "Purchase", "Sales" });
            cmbTransactionType.Location = new Point(416, 174);
            cmbTransactionType.Name = "cmbTransactionType";
            cmbTransactionType.Size = new Size(329, 31);
            cmbTransactionType.TabIndex = 5;
            cmbTransactionType.SelectedIndexChanged += cmbTransactionType_SelectedIndexChanged;
            // 
            // btnAll
            // 
            btnAll.BackColor = Color.Silver;
            btnAll.FlatStyle = FlatStyle.Popup;
            btnAll.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAll.Location = new Point(830, 171);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(110, 29);
            btnAll.TabIndex = 6;
            btnAll.Text = "SHOW ALL";
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // frmTransactions
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1275, 769);
            Controls.Add(btnAll);
            Controls.Add(cmbTransactionType);
            Controls.Add(pictureBoxClose);
            Controls.Add(lblTransactionType);
            Controls.Add(dgvTransactions);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTransactions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTransactions";
            Load += frmTransactions_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxClose;
        private DataGridView dgvTransactions;
        private Label lblTransactionType;
        private ComboBox cmbTransactionType;
        private Button btnAll;
    }
}