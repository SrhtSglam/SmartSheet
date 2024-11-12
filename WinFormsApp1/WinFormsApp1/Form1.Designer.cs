namespace WinFormsApp1
{
    partial class Form1
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
            pnlTop = new Panel();
            pnlBody = new Panel();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.DimGray;
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 70);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(300, 650);
            pnlLeft.TabIndex = 0;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.Gray;
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1280, 70);
            pnlTop.TabIndex = 1;
            // 
            // pnlBody
            // 
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(300, 70);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(980, 650);
            pnlBody.TabIndex = 2;
            // 
            // Form1
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
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private Panel pnlTop;
        private Panel pnlBody;
    }
}
