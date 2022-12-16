using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace UniversitySystem
{
    public partial class StudentListForm : Form
    {
        string searchTerm = "";
        public StudentListForm()
        {
            InitializeComponent();

            SetupGridView();
            PopulateGridView();
        }

        private void SetupGridView()
        {
            listGridView.ColumnCount = 5;
            listGridView.Columns[0].Name = "Id";
            listGridView.Columns[0].Visible = false;
            listGridView.Columns[1].Name = "First Name";
            listGridView.Columns[2].Name = "Last Name";
            listGridView.Columns[3].Name = "Credits";
            listGridView.Columns[4].Name = "Birth Date";
        }

        private void PopulateGridView()
        {
            listGridView.Rows.Clear();
            var students = from student in DBConnection.DB.People
                           where student.isTeacher == false
                           && student.lastName.Contains(this.searchTerm)
                           select student;
            foreach (var student in students)
            {
                listGridView.Rows.Add(new object[] {
                    student.id,
                    student.firstName, 
                    student.lastName, 
                    student.studentCredits, 
                    student.birthDate.ToShortDateString(),
                });
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            this.searchTerm = this.searchBox.Text;
            PopulateGridView();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addForm = new StudentUpdateForm(null);
            addForm.Show();
            addForm.FormClosed += (object _sender, FormClosedEventArgs _e) => PopulateGridView();
        }

        private Person getSelectedStudent()
        {
            var studentId = (int)listGridView.SelectedRows[0].Cells[0].Value;
            return DBConnection.DB.People.Find(studentId);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var editForm = new StudentUpdateForm(getSelectedStudent().id);
            editForm.Show();
            editForm.FormClosed += (object _sender, FormClosedEventArgs _e) => PopulateGridView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var student = getSelectedStudent();
            DBConnection.DB.People.Remove(student);
            DBConnection.DB.SaveChanges();
            PopulateGridView();
        }
    }
}
