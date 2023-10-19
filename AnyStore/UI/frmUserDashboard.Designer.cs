namespace AnyStore
{
    partial class frmUserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserDashboard));
            menuStrip1 = new MenuStrip();
            purchaseToolStripMenuItem = new ToolStripMenuItem();
            salesFormsToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            dealerAndCustomerToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblLoggedInUser = new Label();
            lblUser = new Label();
            pnlFooter = new Panel();
            lblFooter = new Label();
            menuStrip1.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightSlateGray;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { purchaseToolStripMenuItem, salesFormsToolStripMenuItem, inventoryToolStripMenuItem, dealerAndCustomerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1838, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStripTop";
            // 
            // purchaseToolStripMenuItem
            // 
            purchaseToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            purchaseToolStripMenuItem.ForeColor = Color.Black;
            purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            purchaseToolStripMenuItem.Size = new Size(93, 27);
            purchaseToolStripMenuItem.Text = "Purchase";
            purchaseToolStripMenuItem.Click += purchaseToolStripMenuItem_Click;
            // 
            // salesFormsToolStripMenuItem
            // 
            salesFormsToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            salesFormsToolStripMenuItem.ForeColor = Color.Black;
            salesFormsToolStripMenuItem.Name = "salesFormsToolStripMenuItem";
            salesFormsToolStripMenuItem.Size = new Size(67, 27);
            salesFormsToolStripMenuItem.Text = "Sales ";
            salesFormsToolStripMenuItem.Click += salesFormsToolStripMenuItem_Click;
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inventoryToolStripMenuItem.ForeColor = Color.Black;
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(96, 27);
            inventoryToolStripMenuItem.Text = "Inventory";
            inventoryToolStripMenuItem.Click += inventoryToolStripMenuItem_Click;
            // 
            // dealerAndCustomerToolStripMenuItem
            // 
            dealerAndCustomerToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dealerAndCustomerToolStripMenuItem.ForeColor = Color.Black;
            dealerAndCustomerToolStripMenuItem.Name = "dealerAndCustomerToolStripMenuItem";
            dealerAndCustomerToolStripMenuItem.Size = new Size(186, 27);
            dealerAndCustomerToolStripMenuItem.Text = "Dealer and Customer";
            dealerAndCustomerToolStripMenuItem.Click += dealerAndCustomerToolStripMenuItem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(307, 543);
            label4.Name = "label4";
            label4.Size = new Size(362, 29);
            label4.TabIndex = 12;
            label4.Text = "Billing and Inventory Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkRed;
            label2.Font = new Font("Times New Roman", 49.8000031F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(508, 448);
            label2.Name = "label2";
            label2.Size = new Size(286, 95);
            label2.TabIndex = 11;
            label2.Text = "MATE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 49.8000031F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(204, 449);
            label1.Name = "label1";
            label1.Size = new Size(313, 95);
            label1.TabIndex = 10;
            label1.Text = "STOCK";
            // 
            // lblLoggedInUser
            // 
            lblLoggedInUser.AutoSize = true;
            lblLoggedInUser.BackColor = Color.Transparent;
            lblLoggedInUser.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoggedInUser.ForeColor = Color.White;
            lblLoggedInUser.Location = new Point(57, 35);
            lblLoggedInUser.Name = "lblLoggedInUser";
            lblLoggedInUser.Size = new Size(0, 23);
            lblLoggedInUser.TabIndex = 9;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.ForeColor = Color.Black;
            lblUser.Location = new Point(3, 33);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(48, 23);
            lblUser.TabIndex = 8;
            lblUser.Text = "User:";
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.Transparent;
            pnlFooter.Controls.Add(lblFooter);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 808);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1838, 41);
            pnlFooter.TabIndex = 15;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.BackColor = Color.Transparent;
            lblFooter.Font = new Font("Gabriola", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblFooter.ForeColor = Color.Black;
            lblFooter.Location = new Point(3, 9);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(217, 31);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Developed by: Eșanu Liliana-Alexandra";
            // 
            // frmUserDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1838, 849);
            Controls.Add(pnlFooter);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblLoggedInUser);
            Controls.Add(lblUser);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmUserDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Dashboard";
            WindowState = FormWindowState.Maximized;
            FormClosed += frmUserDashboard_FormClosed;
            Load += frmUserDashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem purchaseToolStripMenuItem;
        private ToolStripMenuItem salesFormsToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label lblLoggedInUser;
        private Label lblUser;
        private ToolStripMenuItem dealerAndCustomerToolStripMenuItem;
        private Panel pnlFooter;
        private Label lblFooter;
    }
}