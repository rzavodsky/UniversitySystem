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
            listGridView.ColumnCount = 4;
            listGridView.Columns[0].Name = "First Name";
            listGridView.Columns[1].Name = "Last Name";
            listGridView.Columns[2].Name = "Credits";
            listGridView.Columns[3].Name = "Birth Date";
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
                listGridView.Rows.Add(new string[] { 
                    student.firstName, 
                    student.lastName, 
                    student.studentCredits.ToString(), 
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
            var addForm = new StudentUpdateForm();
            addForm.Show();
            addForm.FormClosed += (object _sender, FormClosedEventArgs _e) => PopulateGridView();
        }
    }
}
