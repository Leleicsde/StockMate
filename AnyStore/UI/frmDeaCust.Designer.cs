namespace AnyStore.UI
{
    partial class frmDeaCust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeaCust));
            pictureBoxClose = new PictureBox();
            lblDeaCust = new Label();
            lblType = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblContact = new Label();
            lblAddress = new Label();
            txtDeaCustID = new TextBox();
            txtName = new TextBox();
            cmbDeaCust = new ComboBox();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            txtAddress = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvDeaCrust = new DataGridView();
            txtSearch = new TextBox();
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeaCrust).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.BackColor = Color.Transparent;
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(1336, 9);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(33, 32);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxClose.TabIndex = 1;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // lblDeaCust
            // 
            lblDeaCust.AutoSize = true;
            lblDeaCust.BackColor = Color.Transparent;
            lblDeaCust.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeaCust.Location = new Point(35, 25);
            lblDeaCust.Name = "lblDeaCust";
            lblDeaCust.Size = new Size(96, 23);
            lblDeaCust.TabIndex = 4;
            lblDeaCust.Text = "DeaCust ID";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.BackColor = Color.Transparent;
            lblType.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.Location = new Point(35, 79);
            lblType.Name = "lblType";
            lblType.Size = new Size(46, 23);
            lblType.TabIndex = 5;
            lblType.Text = "Type";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(35, 133);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 23);
            lblName.TabIndex = 6;
            lblName.Text = "Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(388, 29);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 23);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.BackColor = Color.Transparent;
            lblContact.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblContact.Location = new Point(388, 84);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(70, 23);
            lblContact.TabIndex = 8;
            lblContact.Text = "Contact";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.Location = new Point(388, 143);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 23);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Address";
            // 
            // txtDeaCustID
            // 
            txtDeaCustID.BorderStyle = BorderStyle.FixedSingle;
            txtDeaCustID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDeaCustID.Location = new Point(153, 25);
            txtDeaCustID.Name = "txtDeaCustID";
            txtDeaCustID.ReadOnly = true;
            txtDeaCustID.Size = new Size(220, 30);
            txtDeaCustID.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(153, 133);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 27);
            txtName.TabIndex = 11;
            // 
            // cmbDeaCust
            // 
            cmbDeaCust.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDeaCust.FormattingEnabled = true;
            cmbDeaCust.Items.AddRange(new object[] { "Dealer", "Customer" });
            cmbDeaCust.Location = new Point(153, 79);
            cmbDeaCust.Name = "cmbDeaCust";
            cmbDeaCust.Size = new Size(220, 31);
            cmbDeaCust.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(469, 25);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 27);
            txtEmail.TabIndex = 13;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(469, 81);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(220, 27);
            txtContact.TabIndex = 14;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(469, 133);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(220, 47);
            txtAddress.TabIndex = 15;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Silver;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(528, 699);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(172, 39);
            btnDelete.TabIndex = 35;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Silver;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(279, 699);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(172, 39);
            btnUpdate.TabIndex = 34;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Silver;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(35, 699);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(172, 39);
            btnAdd.TabIndex = 33;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvDeaCrust
            // 
            dgvDeaCrust.BackgroundColor = Color.Silver;
            dgvDeaCrust.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeaCrust.Location = new Point(35, 275);
            dgvDeaCrust.Name = "dgvDeaCrust";
            dgvDeaCrust.RowHeadersWidth = 51;
            dgvDeaCrust.RowTemplate.Height = 29;
            dgvDeaCrust.Size = new Size(654, 390);
            dgvDeaCrust.TabIndex = 36;
            dgvDeaCrust.RowHeaderMouseClick += dgvDeaCrust_RowHeaderMouseClick;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(102, 213);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(587, 30);
            txtSearch.TabIndex = 38;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.Location = new Point(35, 215);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(61, 23);
            lblSearch.TabIndex = 37;
            lblSearch.Text = "Search";
            // 
            // frmDeaCust
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1379, 763);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(pictureBoxClose);
            Controls.Add(dgvDeaCrust);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(txtContact);
            Controls.Add(txtEmail);
            Controls.Add(cmbDeaCust);
            Controls.Add(txtName);
            Controls.Add(txtDeaCustID);
            Controls.Add(lblAddress);
            Controls.Add(lblContact);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(lblType);
            Controls.Add(lblDeaCust);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDeaCust";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDeaCust";
            Load += frmDeaCust_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeaCrust).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxClose;
        private Label lblDeaCust;
        private Label lblType;
        private Label lblName;
        private Label lblEmail;
        private Label lblContact;
        private Label lblAddress;
        private TextBox txtDeaCustID;
        private TextBox txtName;
        private ComboBox cmbDeaCust;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtAddress;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvDeaCrust;
        private TextBox txtSearch;
        private Label lblSearch;
    }
}