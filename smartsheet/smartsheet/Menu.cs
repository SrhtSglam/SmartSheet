using smartsheet;

namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        AppDbContext context;

        private void Menu_Load(object sender, EventArgs e)
        {
            if (context == null)
                context = new AppDbContext();
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
            //FormLoad(new Dashboard);
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
    }
}
