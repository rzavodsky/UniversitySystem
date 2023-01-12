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
    public partial class SubjectListForm : Form
    {
        private Person student;
        public SubjectListForm(Person student)
        {
            this.student = student;
            InitializeComponent();
            PopulateSubjectList();
        }

        private void PopulateSubjectList()
        {
            subjectList.Rows.Clear();

            var subjects = from subject in DBConnection.DB.Subjects
                           where subject.faculty == this.student.StudentGroup1.Programme1.faculty
                           && subject.name.Contains(searchInput.Text)
                           select subject;

            foreach (var subject in subjects)
            {
                subjectList.Rows.Add(new object[] {
                    subject.id,
                    subject.name,
                    subject.shortcut,
                    subject.semester,
                    subject.credits,
                });
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            var subjectId = (int)subjectList.SelectedRows[0].Cells[0].Value;
            var subject = DBConnection.DB.Subjects.Find(subjectId);
            var form = new SubjectInfoForm(subject, student);
            form.ShowDialog();
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            PopulateSubjectList();
        }
    }
}
