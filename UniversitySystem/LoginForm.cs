using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversitySystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (usernameInput.Text == "admin" && passwordInput.Text == "admin")
            {
                var form = new AdminMenu();
                this.Hide();
                form.Show();
                return;
            }

            var people = DBConnection.DB.People;
            var query = from p in people
                        where p.loginUsername == usernameInput.Text
                        && p.loginPassword == passwordInput.Text
                        select p;
            if (query.Count() == 1) 
            {
                var f2 = new AdminMenu();
                this.Hide();
                f2.Show();
            } else
            {
                MessageBox.Show("Invalid username or password", 
                    "Login Invalid", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                usernameInput.Text = "";
                passwordInput.Text = "";
            }
        }
    }
}
