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
            var people = DBConnection.DB.People;
            var query = from p in people
                        where p.loginUsername == usernameInput.Text
                        && p.loginPassword == passwordInput.Text
                        select p;
            if (query.Count() == 1) 
            {
                var f2 = new StudentListForm();
                this.Hide();
                f2.Show();
            }
        }
    }
}
