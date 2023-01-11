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
    public partial class StudentListForm : Form
    {
        private Subject subject;
        public StudentListForm(Subject subject)
        {
            this.subject = subject;

            InitializeComponent();
            InitializeStudentList();
            PopulateStudentList();
        }

        private void InitializeStudentList()
        {
            studentList.Columns.Add("Id", "Id");
            studentList.Columns.Add("First Name", "First Name");
            studentList.Columns.Add("Last Name", "Last Name");
            studentList.Columns.Add("Student Group", "Student Group");
            studentList.Columns.Add("Grade", "Grade");
        }
        private void PopulateStudentList()
        {
            studentList.Rows.Clear();
            var searchTerm = searchInput.Text;

            var studentSubs = subject.StudentSubjects.Where(ss =>
                ss.Person.firstName.Contains(searchTerm) ||
                ss.Person.lastName.Contains(searchTerm) ||
                ss.Person.id.ToString().Contains(searchTerm) ||
                ss.Person.StudentGroup1.name.Contains(searchTerm));

            foreach (var studentSubject in studentSubs) 
            {
                studentList.Rows.Add(new object[]
                {
                    studentSubject.Person.id,
                    studentSubject.Person.firstName,
                    studentSubject.Person.lastName,
                    studentSubject.Person.StudentGroup1.name,
                    studentSubject.grade ?? "None",
                });
            }
        }

        private void gradeButton_Click(object sender, EventArgs e)
        {
            var studentId = (int)studentList.SelectedRows[0].Cells[0].Value;
            var studSub = this.subject.StudentSubjects.Where(ss => ss.Person.id == studentId).Single();

            var form = new GradeUpdateForm(studSub);
            form.ShowDialog();
            PopulateStudentList();
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            PopulateStudentList();
        }
    }
}
