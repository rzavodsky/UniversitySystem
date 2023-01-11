using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace UniversitySystem.Teacher
{
    public partial class GradeUpdateForm : Form
    {
        private StudentSubject studSub;
        public GradeUpdateForm(StudentSubject studSub)
        {
            this.studSub = studSub;
            InitializeComponent();

            idLabel.Text = studSub.Person.id.ToString();
            nameLabel.Text = studSub.Person.firstName + " " + studSub.Person.lastName;
            studentGroupLabel.Text = studSub.Person.StudentGroup1.name;
            gradeInput.SelectedItem = studSub.grade ?? "None";
        }

        private void UpdateCredits(string gradeBefore, string gradeAfter)
        {
            // Add credits
            if ((gradeBefore == null || gradeBefore == "Fx")
                && gradeAfter != null && gradeAfter != "Fx")
            {
                Console.WriteLine("Added credits");
                studSub.Person.studentCredits += studSub.Subject1.credits;
            }
            // Remove credits
            else if (gradeBefore != null && gradeBefore != "Fx"
                && (gradeAfter == null || gradeAfter == "Fx"))
            {
                Console.WriteLine("removed credits");
                studSub.Person.studentCredits -= studSub.Subject1.credits;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            var gradeBefore = this.studSub.grade;
            if ((string)gradeInput.SelectedItem == "None")
            {
                this.studSub.grade = null;
            } else
            {
                this.studSub.grade = (string)gradeInput.SelectedItem;
            }
            UpdateCredits(gradeBefore, this.studSub.grade);
            DBConnection.DB.SaveChanges();
            this.Close();
        }
    }
}
