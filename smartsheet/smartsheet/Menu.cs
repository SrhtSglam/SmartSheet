using smartsheet;

namespace smartsheet
{
    public partial class Menu : Form
    {

        public Menu()
        {
            if (context == null)
                context = new AppDbContext();
            InitializeComponent();
        }

        private AppDbContext context;

        private void Menu_Load(object sender, EventArgs e)
        {
            IsAuthSide();
        }

        public void FormLoad(object Form)
        {
            if (this.pnlBody.Controls.Count > 0)
                this.pnlBody.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlBody.Controls.Add(f);
            this.pnlBody.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //FormLoad(new Login());
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            //FormLoad(new Stock);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            //FormLoad(new Sales);

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            //FormLoad(new Reports);

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            //FormLoad(new Customers);

        }

        private void btnDataprocess_Click(object sender, EventArgs e)
        {
            //FormLoad(new Dataprocess);

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //FormLoad(new Settings);

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //FormLoad(new Help);

        }

        private void btnMinimizedScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFullscreen_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
        }

        private void IsAuthSide()
        {
            if (Auth.IsAuth == true)
            {
                this.btnCustomers.Enabled = true;
                this.btnDashboard.Enabled = true;
                this.btnDataprocess.Enabled = true;
                this.btnHelp.Enabled = true;
                this.btnReports.Enabled = true;
                this.btnSales.Enabled = true;
                this.btnSettings.Enabled = true;
                this.btnStock.Enabled = true;
            }
            else
            {
                this.btnCustomers.Enabled = false;
                this.btnDashboard.Enabled = false;
                this.btnDataprocess.Enabled = false;
                this.btnHelp.Enabled = false;
                this.btnReports.Enabled = false;
                this.btnSales.Enabled = false;
                this.btnSettings.Enabled = false;
                this.btnStock.Enabled = false;
                FormLoad(new Login(context));
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            IsAuthSide();
        }
    }
}
