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
        private ApplicationContext context;
        public LoginForm(ApplicationContext context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void ChangeForm(Form newForm)
        {
            this.context.MainForm = newForm;
            this.Close();
            newForm.Show();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (usernameInput.Text == "admin" && passwordInput.Text == "admin")
            {
                ChangeForm(new AdminMenu());
                return;
            }

            var people = DBConnection.DB.People;
            var query = from p in people
                        where p.loginUsername == usernameInput.Text
                        && p.loginPassword == passwordInput.Text
                        select p;
            if (query.Count() == 1) 
            {
                var person = query.Single();
                if (person.isTeacher) 
                { 
                    ChangeForm(new TeacherMenu(person));
                } else
                {
                    ChangeForm(new StudentMenu(person));
                }
                
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
