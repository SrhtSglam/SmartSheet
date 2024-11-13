using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using smartsheet;

namespace smartsheet
{
    public partial class Login : Form
    {
        private AppDbContext _context;
        private string[] loginMessages = {"User name and password is incorrect!", "User name or password is incorrect!", "Login successful!", "Unknown error!"};

        public Login(AppDbContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var users = _context.Users.ToList();
            foreach (var item in users)
            {
                if (item.Username != txtUsername.Text && item.Password != txtPassword.Text)
                    lblError.Text = loginMessages[0];
                else if (item.Username != txtUsername.Text || item.Password != txtPassword.Text)
                    lblError.Text = loginMessages[1];
                else if (item.Username == txtUsername.Text && item.Password == txtPassword.Text)
                {
                    lblError.Text = loginMessages[2];
                    Auth.IsAuth = true;
                    this.Close();
                }
                else
                    lblError.Text = loginMessages[3];
            }
        }
    }
}
