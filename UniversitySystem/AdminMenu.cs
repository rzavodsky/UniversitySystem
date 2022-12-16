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
    public partial class AdminMenu : Form
    {
        private static Resource[] RESOURCES =
        {
            new Resource("Students", new string[]{"First Name", "Last Name", "Student Group", "Birth Date", "Credits"}, (dataGridView) =>
            {
                var students = from student in DBConnection.DB.People
                           where student.isTeacher == false
                           select student;
                foreach (var student in students)
                {
                    dataGridView.Rows.Add(new object[] {
                        student.id,
                        student.firstName,
                        student.lastName,
                        student.StudentGroup1.name,
                        student.birthDate.ToShortDateString(),
                        student.studentCredits,
                    });
                }
            }, (id) => new StudentUpdateForm(id), 
               (id) => DBConnection.DB.People.Remove(DBConnection.DB.People.Find(id))),


            new Resource("Teachers", new string[]{"First Name", "Last Name", "Faculty", "Birth Date"}, (dataGridView) =>
            {
                var teachers = from teacher in DBConnection.DB.People
                               where teacher.isTeacher == true
                               select teacher;
                foreach (var teacher in teachers)
                {
                    dataGridView.Rows.Add(new object[] {
                        teacher.id,
                        teacher.firstName,
                        teacher.lastName,
                        teacher.Faculty.shortcut,
                        teacher.birthDate.ToShortDateString(),
                    });
                }
            }, (id) => new TeacherUpdateForm(id), 
               (id) => DBConnection.DB.People.Remove(DBConnection.DB.People.Find(id))),
        };

        public AdminMenu()
        {
            InitializeComponent();
            resourceSelector.DataSource = RESOURCES;
            resourceSelector.DisplayMember = "Name";
            InitializeDataGridView();
            PopulateDataGridView();
        }

        private void InitializeDataGridView()
        {
            var resource = (Resource)resourceSelector.SelectedItem;
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("Id", "Id");
            dataGridView.Columns[0].Visible = false;
            foreach (var column in resource.Columns)
            {
                dataGridView.Columns.Add(column, column);
            }

        }

        private void PopulateDataGridView()
        {
            var resource = (Resource)resourceSelector.SelectedItem;
            dataGridView.Rows.Clear();
            resource.PopulationFunction(dataGridView);
        }

        private void resourceSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeDataGridView();
            PopulateDataGridView();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var resource = (Resource)resourceSelector.SelectedItem;
            var form = resource.OpenForm(null);
            form.Show();
            form.FormClosed += (object _sender, FormClosedEventArgs _e) => PopulateDataGridView();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var resource = (Resource)resourceSelector.SelectedItem;
            var form = resource.OpenForm((int)dataGridView.SelectedRows[0].Cells[0].Value);
            form.Show();
            form.FormClosed += (object _sender, FormClosedEventArgs _e) => PopulateDataGridView();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var resource = (Resource)resourceSelector.SelectedItem;
            resource.DeleteFunction((int)dataGridView.SelectedRows[0].Cells[0].Value);
            DBConnection.DB.SaveChanges();
            PopulateDataGridView();
        }
    }

    internal class Resource
    {
        public Resource(string name, string[] columns, Action<DataGridView> populationFunction, Func<int?, Form> openForm, Action<int> deleteFunction)
        {
            Name = name;
            Columns = columns;
            PopulationFunction = populationFunction;
            OpenForm = openForm;
            DeleteFunction = deleteFunction;
        }

        public string Name { get; set; }
        public string[] Columns { get; set; }
        public Action<DataGridView> PopulationFunction { get; set; }
        public Func<int?, Form> OpenForm { get; set; }
        public Action<int> DeleteFunction { get; set; }
    }
  
}
