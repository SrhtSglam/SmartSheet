namespace WinFormsApp1
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLeft = new Panel();
            btnHelp = new Button();
            lblBusinessName = new Label();
            btnSettings = new Button();
            pcbLogo = new PictureBox();
            btnDataprocess = new Button();
            btnDashboard = new Button();
            btnReports = new Button();
            btnStock = new Button();
            btnCustomers = new Button();
            btnSales = new Button();
            pnlTop = new Panel();
            button1 = new Button();
            pnlBody = new Panel();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.DimGray;
            pnlLeft.Controls.Add(btnHelp);
            pnlLeft.Controls.Add(lblBusinessName);
            pnlLeft.Controls.Add(btnSettings);
            pnlLeft.Controls.Add(pcbLogo);
            pnlLeft.Controls.Add(btnDataprocess);
            pnlLeft.Controls.Add(btnDashboard);
            pnlLeft.Controls.Add(btnReports);
            pnlLeft.Controls.Add(btnStock);
            pnlLeft.Controls.Add(btnCustomers);
            pnlLeft.Controls.Add(btnSales);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 70);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(300, 650);
            pnlLeft.TabIndex = 0;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = Color.DimGray;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.ForeColor = Color.White;
            btnHelp.Image = smartsheet.Properties.Resources.Help_Ico;
            btnHelp.ImageAlign = ContentAlignment.MiddleLeft;
            btnHelp.Location = new Point(0, 504);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(300, 52);
            btnHelp.TabIndex = 7;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // lblBusinessName
            // 
            lblBusinessName.AutoSize = true;
            lblBusinessName.Font = new Font("Segoe UI", 16F);
            lblBusinessName.ForeColor = Color.White;
            lblBusinessName.Location = new Point(82, 19);
            lblBusinessName.Name = "lblBusinessName";
            lblBusinessName.Size = new Size(90, 37);
            lblBusinessName.TabIndex = 8;
            lblBusinessName.Text = "label1";
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.DimGray;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = smartsheet.Properties.Resources.Settings_Ico;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 446);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(300, 52);
            btnSettings.TabIndex = 6;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // pcbLogo
            // 
            pcbLogo.Location = new Point(12, 6);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(64, 64);
            pcbLogo.TabIndex = 8;
            pcbLogo.TabStop = false;
            // 
            // btnDataprocess
            // 
            btnDataprocess.BackColor = Color.DimGray;
            btnDataprocess.FlatAppearance.BorderSize = 0;
            btnDataprocess.FlatStyle = FlatStyle.Flat;
            btnDataprocess.ForeColor = Color.White;
            btnDataprocess.Image = smartsheet.Properties.Resources.DataExcel_Ico;
            btnDataprocess.ImageAlign = ContentAlignment.MiddleLeft;
            btnDataprocess.Location = new Point(0, 388);
            btnDataprocess.Name = "btnDataprocess";
            btnDataprocess.Size = new Size(300, 52);
            btnDataprocess.TabIndex = 5;
            btnDataprocess.Text = "Data Process";
            btnDataprocess.UseVisualStyleBackColor = false;
            btnDataprocess.Click += btnDataprocess_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.DimGray;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = smartsheet.Properties.Resources.Desktop_Ico;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 98);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(300, 52);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.DimGray;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.White;
            btnReports.Image = smartsheet.Properties.Resources.Repors_Ico;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(0, 330);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(300, 52);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.DimGray;
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.ForeColor = Color.White;
            btnStock.Image = smartsheet.Properties.Resources.Stock_Ico;
            btnStock.ImageAlign = ContentAlignment.MiddleLeft;
            btnStock.Location = new Point(0, 156);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(300, 52);
            btnStock.TabIndex = 1;
            btnStock.Text = "Stock Manager";
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.DimGray;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Image = smartsheet.Properties.Resources.Customers_Ico;
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(0, 272);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(300, 52);
            btnCustomers.TabIndex = 3;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.DimGray;
            btnSales.FlatAppearance.BorderSize = 0;
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.ForeColor = Color.White;
            btnSales.Image = smartsheet.Properties.Resources.Sales_Ico;
            btnSales.ImageAlign = ContentAlignment.MiddleLeft;
            btnSales.Location = new Point(0, 214);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(300, 52);
            btnSales.TabIndex = 2;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.Gray;
            pnlTop.Controls.Add(button1);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1280, 70);
            pnlTop.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1216, 12);
            button1.Name = "button1";
            button1.Size = new Size(52, 52);
            button1.TabIndex = 9;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnlBody
            // 
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(300, 70);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(980, 650);
            pnlBody.TabIndex = 2;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1280, 720);
            Controls.Add(pnlBody);
            Controls.Add(pnlLeft);
            Controls.Add(pnlTop);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Menu";
            Text = "Form1";
            Load += Menu_Load;
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            pnlTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private Panel pnlTop;
        private Panel pnlBody;
        private Button btnDashboard;
        private Button btnDataprocess;
        private Button btnReports;
        private Button btnCustomers;
        private Button btnSales;
        private Button btnStock;
        private Button btnHelp;
        private Label lblBusinessName;
        private Button btnSettings;
        private PictureBox pcbLogo;
        private Button button1;
    }
}
