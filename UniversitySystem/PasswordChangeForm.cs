using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversitySystem.Teacher
{
    public partial class PasswordChangeForm : Form
    {
        private Person person;
        public PasswordChangeForm(Person person)
        {
            this.person = person;
            InitializeComponent();
        }

        private void ResetInputs()
        {
            oldPwdInput.Text = "";
            newPwdInput1.Text = "";
            newPwdInput2.Text = "";
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (oldPwdInput.Text != this.person.loginPassword)
            {
                MessageBox.Show("Invalid password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetInputs();
                return;
            }
            if (newPwdInput1.Text != newPwdInput2.Text)
            {
                MessageBox.Show("Passwords don't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetInputs();
                return;
            }
            this.person.loginPassword = newPwdInput1.Text;
            DBConnection.DB.SaveChanges();
            MessageBox.Show("Password successfully changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
