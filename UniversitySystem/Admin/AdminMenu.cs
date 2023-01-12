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
            new Resource("Students", new string[]{"First Name", "Last Name", "Student Group", "Birth Date", "Credits"}, (dataGridView, searchTerm) =>
            {
                foreach (var student in DBConnection.DB.People.Where(s => !s.isTeacher && (
                    s.firstName.ToLower().Contains(searchTerm) ||
                    s.lastName.ToLower().Contains(searchTerm) ||
                    s.id.ToString().Contains(searchTerm)
                    )))
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


            new Resource("Teachers", new string[]{"First Name", "Last Name", "Faculty", "Birth Date"}, (dataGridView, searchTerm) =>
            {
                foreach (var teacher in DBConnection.DB.People.Where(t => t.isTeacher && (
                    t.firstName.ToLower().Contains(searchTerm) ||
                    t.lastName.ToLower().Contains(searchTerm) ||
                    t.id.ToString().Contains(searchTerm)
                )))
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

            new Resource("Countries", new string[]{"Name"}, (dataGridView, searchTerm) =>
            {
                foreach (var country in DBConnection.DB.Countries.Where(c => c.name.ToLower().Contains(searchTerm)))
                {
                    dataGridView.Rows.Add(new object[] {
                        country.id,
                        country.name,
                    });
                }
            }, (id) => new CountryUpdateForm(id),
               (id) => DBConnection.DB.Countries.Remove(DBConnection.DB.Countries.Find(id))),

            new Resource("Cities", new string[]{"Name", "Country"}, (dataGridView, searchTerm) =>
            {
                foreach (var city in DBConnection.DB.Cities.Where(c => c.name.ToLower().Contains(searchTerm)))
                {
                    dataGridView.Rows.Add(new object[] {
                        city.id,
                        city.name,
                        city.Country1.name,
                    });
                }
            }, (id) => new CityUpdateForm(id),
               (id) => DBConnection.DB.Cities.Remove(DBConnection.DB.Cities.Find(id))),

            new Resource("Classrooms", new string[]{"Name"}, (dataGridView, searchTerm) =>
            {
                foreach (var classroom in DBConnection.DB.Classrooms.Where(c => c.name.ToLower().Contains(searchTerm)))
                {
                    dataGridView.Rows.Add(new object[] {
                        classroom.id,
                        classroom.name,
                    });
                }
            }, (id) => new ClassroomUpdateForm(id),
               (id) => DBConnection.DB.Classrooms.Remove(DBConnection.DB.Classrooms.Find(id))),

            new Resource("Faculties", new string[]{"Name", "Shortcut", "Description"}, (dataGridView, searchTerm) =>
            {
                foreach (var faculty in DBConnection.DB.Faculties.Where(f => f.name.ToLower().Contains(searchTerm) || f.shortcut.ToLower().Contains(searchTerm)))
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

            new Resource("Programmes", new string[]{"Name", "Faculty", "Degree Type"}, (dataGridView, searchTerm) =>
            {
                foreach (var programme in DBConnection.DB.Programmes.Where(p => p.name.ToLower().Contains(searchTerm)))
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

            new Resource("Degree Types", new string[]{"Name", "Duration", "Required Credits"}, (dataGridView, searchTerm) =>
            {
                foreach (var degreeType in DBConnection.DB.DegreeTypes.Where(d => d.name.ToLower().Contains(searchTerm)))
                {
                    dataGridView.Rows.Add(new object[] {
                        degreeType.id,
                        degreeType.name,
                        degreeType.length,
                        degreeType.requiredCredits,
                    });
                }
            }, (id) => new DegreeTypeUpdateForm(id),
               (id) => DBConnection.DB.DegreeTypes.Remove(DBConnection.DB.DegreeTypes.Find(id))),

            new Resource("Student Groups", new string[]{"Name", "Programme"}, (dataGridView, searchTerm) =>
            {
                foreach (var studentGroup in DBConnection.DB.StudentGroups.Where(s => s.name.ToLower().Contains(searchTerm)))
                {
                    dataGridView.Rows.Add(new object[] {
                        studentGroup.id,
                        studentGroup.name,
                        studentGroup.Programme1.name,
                    });
                }
            }, (id) => new StudentGroupUpdateForm(id),
               (id) => DBConnection.DB.StudentGroups.Remove(DBConnection.DB.StudentGroups.Find(id))),

            new Resource("Lessons", new string[]{"Subject", "Week Day", "Time", "Duration", "Teacher", "Type", "Classroom", "Student Group"}, (dataGridView, searchTerm) =>
            {
                foreach (var lesson in DBConnection.DB.Lessons.Where(l => l.Subject1.name.ToLower().Contains(searchTerm)))
                {
                    dataGridView.Rows.Add(new object[] {
                        lesson.id,
                        lesson.Subject1.name,
                        TeacherMenu.DAYS_OF_WEEK[lesson.weekDay],
                        lesson.time + ":00",
                        lesson.duration,
                        lesson.Person.firstName + " " + lesson.Person.lastName,
                        lesson.type,
                        lesson.Classroom1.name,
                        lesson.StudentGroup1.name,
                    });
                }
            }, (id) => new LessonUpdateForm(id),
               (id) => DBConnection.DB.Lessons.Remove(DBConnection.DB.Lessons.Find(id))),

            new Resource("Subjects", new string[]{"Name", "Faculty", "Excercise Amount", "Lecture Amount", "Credits", "Semester"}, (dataGridView, searchTerm) =>
            {
                foreach (var subject in DBConnection.DB.Subjects.Where(s => s.name.ToLower().Contains(searchTerm)))
                {
                    dataGridView.Rows.Add(new object[] {
                        subject.id,
                        subject.name,
                        subject.Faculty1.shortcut,
                        subject.excerciseAmount,
                        subject.lectureAmount,
                        subject.credits,
                        subject.semester,
                    });
                }
            }, (id) => new SubjectUpdateForm(id),
               (id) => DBConnection.DB.Subjects.Remove(DBConnection.DB.Subjects.Find(id))),
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
            resource.PopulationFunction(dataGridView, searchInput.Text.ToLower());
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
            form.ShowDialog();
            PopulateDataGridView();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var resource = (Resource)resourceSelector.SelectedItem;
            var form = resource.OpenForm((int)dataGridView.SelectedRows[0].Cells[0].Value);
            form.ShowDialog();
            PopulateDataGridView();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var resource = (Resource)resourceSelector.SelectedItem;
            resource.DeleteFunction((int)dataGridView.SelectedRows[0].Cells[0].Value);
            DBConnection.DB.SaveChanges();
            PopulateDataGridView();
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
    }

    internal class Resource
    {
        public Resource(string name, string[] columns, Action<DataGridView, string> populationFunction, Func<int?, Form> openForm, Action<int> deleteFunction)
        {
            Name = name;
            Columns = columns;
            PopulationFunction = populationFunction;
            OpenForm = openForm;
            DeleteFunction = deleteFunction;
        }

        public string Name { get; set; }
        public string[] Columns { get; set; }
        public Action<DataGridView, string> PopulationFunction { get; set; }
        public Func<int?, Form> OpenForm { get; set; }
        public Action<int> DeleteFunction { get; set; }
    }
  
}
