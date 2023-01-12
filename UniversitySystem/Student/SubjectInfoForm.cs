using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversitySystem.Student
{
    public partial class SubjectInfoForm : Form
    {
        private Subject subject;
        private Person student;
        private StudentSubject studSub;

        public SubjectInfoForm(Subject subject, Person student)
        {
            this.subject = subject;
            this.student = student;

            InitializeComponent();

            Text = "Subject Info - " + subject.name;
            idLabel.Text = subject.id.ToString();
            nameLabel.Text = subject.name;
            creditsLabel.Text = subject.credits.ToString();
            semesterLabel.Text = subject.semester.ToString();
            lecturesLabel.Text = subject.lectureAmount.ToString();
            excerciseLabel.Text = subject.excerciseAmount.ToString();
            var teacherNames = from lesson in subject.Lessons
                               group lesson by lesson.Person into teacher
                               select teacher.Key.firstName + " " + teacher.Key.lastName;
            teachersLabel.Text = String.Join(", ", teacherNames);
            descriptionLabel.Text = subject.description;

            var studSubs = from studSub in DBConnection.DB.StudentSubjects
                           where studSub.subject == subject.id 
                           && studSub.student == student.id
                           select studSub;
            studSub = studSubs.SingleOrDefault();
            if (studSub != null)
            {
                acceptButton.Text = "Leave subject";
            } else
            {
                acceptButton.Text = "Join subject";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (studSub != null)
            {
                var answer = MessageBox.Show("Are you sure you want to leave this subject?",
                    "Confirm Disenrollment",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (studSub.grade != null && studSub.grade != "Fx")
                    {
                        student.studentCredits -= subject.credits;
                    }
                    DBConnection.DB.StudentSubjects.Remove(studSub);
                    DBConnection.DB.SaveChanges();
                    this.Close();
                }
            } else
            {
                var answer = MessageBox.Show("Are you sure you want to join this subject?",
                    "Confirm Enrollment",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    studSub = new StudentSubject
                    {
                        Person = this.student,
                        Subject1 = this.subject,
                    };
                    DBConnection.DB.StudentSubjects.Add(studSub);
                    DBConnection.DB.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}
