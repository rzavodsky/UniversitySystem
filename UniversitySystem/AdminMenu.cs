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

            new Resource("Countries", new string[]{"Name"}, (dataGridView) =>
            {
                var countries = from country in DBConnection.DB.Countries
                               select country;
                foreach (var country in countries)
                {
                    dataGridView.Rows.Add(new object[] {
                        country.id,
                        country.name,
                    });
                }
            }, (id) => new CountryUpdateForm(id),
               (id) => DBConnection.DB.Countries.Remove(DBConnection.DB.Countries.Find(id))),

            new Resource("Cities", new string[]{"Name", "Country"}, (dataGridView) =>
            {
                var cities = from city in DBConnection.DB.Cities
                               select city;
                foreach (var city in cities)
                {
                    dataGridView.Rows.Add(new object[] {
                        city.id,
                        city.name,
                        city.Country1.name,
                    });
                }
            }, (id) => new CityUpdateForm(id),
               (id) => DBConnection.DB.Cities.Remove(DBConnection.DB.Cities.Find(id))),

            new Resource("Classrooms", new string[]{"Name"}, (dataGridView) =>
            {
                var classrooms = from classroom in DBConnection.DB.Classrooms
                               select classroom;
                foreach (var classroom in classrooms)
                {
                    dataGridView.Rows.Add(new object[] {
                        classroom.id,
                        classroom.name,
                    });
                }
            }, (id) => new ClassroomUpdateForm(id),
               (id) => DBConnection.DB.Classrooms.Remove(DBConnection.DB.Classrooms.Find(id))),

            new Resource("Faculties", new string[]{"Name", "Shortcut", "Description"}, (dataGridView) =>
            {
                var faculties = from faculty in DBConnection.DB.Faculties
                               select faculty;
                foreach (var faculty in faculties)
                {
                    dataGridView.Rows.Add(new object[] {
                        faculty.id,
                        faculty.name,
                        faculty.shortcut,
                        faculty.description,
                    });
                }
            }, (id) => new FacultyUpdateForm(id),
               (id) => DBConnection.DB.Faculties.Remove(DBConnection.DB.Faculties.Find(id))),

            new Resource("Programmes", new string[]{"Name", "Faculty", "Degree Type"}, (dataGridView) =>
            {
                var programmes = from programme in DBConnection.DB.Programmes
                               select programme;
                foreach (var programme in programmes)
                {
                    dataGridView.Rows.Add(new object[] {
                        programme.id,
                        programme.name,
                        programme.Faculty1.shortcut,
                        programme.DegreeType1.name,
                    });
                }
            }, (id) => new ProgrammeUpdateForm(id),
               (id) => DBConnection.DB.Programmes.Remove(DBConnection.DB.Programmes.Find(id))),
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
