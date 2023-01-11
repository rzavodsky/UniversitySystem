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
    public partial class LessonUpdateForm : Form
    {
        private Lesson lesson;
        public LessonUpdateForm(int? lessonId)
        {
            if (lessonId != null) 
            { 
                this.lesson = DBConnection.DB.Lessons.Find(lessonId);
            }

            InitializeComponent();
            InitializeSubjectDropdown();
            InitializeTeacherDropdown();
            InitializeClassroomDropdown();
            InitializeStudentGroupDropdown();
            InitializeFields();
        }

        private void InitializeStudentGroupDropdown()
        {
            studentGroupInput.DataSource = DBConnection.DB.StudentGroups.ToList();
            studentGroupInput.DisplayMember = "name";
        }

        private void InitializeClassroomDropdown()
        {
            classroomInput.DataSource = DBConnection.DB.Classrooms.ToList();
            classroomInput.DisplayMember = "name";
        }

        private void InitializeTeacherDropdown()
        {
            teacherInput.DataSource = DBConnection.DB.People
                .Where(p => p.isTeacher)
                .Select(p => new TeacherRecord {
                    Id = p.id,
                    Name = p.firstName + " " + p.lastName,
                })
                .ToList();
            teacherInput.DisplayMember = "Name";
        }

        private void InitializeSubjectDropdown()
        {
            subjectNameInput.DataSource = DBConnection.DB.Subjects.ToList();
            subjectNameInput.DisplayMember = "name";
        }

        private void InitializeFields()
        {
            weekDayInput.SelectedIndex = 0;
            typeInput.SelectedIndex = 0;
            if (this.lesson == null) return;
            subjectNameInput.SelectedItem = this.lesson.Subject1;
            weekDayInput.SelectedIndex = this.lesson.weekDay;
            timeUpDown.Value = this.lesson.time;
            durationUpDown.Value = this.lesson.duration;
            teacherInput.SelectedItem = new TeacherRecord
            {
                Id = this.lesson.Person.id,
                Name = this.lesson.Person.firstName + " " + this.lesson.Person.lastName,
            };
            typeInput.SelectedItem = this.lesson.type;
            classroomInput.SelectedItem = this.lesson.Classroom1;
            studentGroupInput.SelectedItem = this.lesson.StudentGroup1;
        }

        private void timeUpDown_ValueChanged(object sender, EventArgs e)
        {
            durationUpDown.Maximum = 20 - timeUpDown.Value;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (this.lesson == null)
            {
                this.lesson = new Lesson();
                DBConnection.DB.Lessons.Add(this.lesson);
            }

            this.lesson.Subject1 = (Subject)subjectNameInput.SelectedItem;
            this.lesson.weekDay = weekDayInput.SelectedIndex;
            this.lesson.time = (int)timeUpDown.Value;
            this.lesson.duration = (int)durationUpDown.Value;
            this.lesson.Person = DBConnection.DB.People.Find(((TeacherRecord)teacherInput.SelectedItem).Id);
            this.lesson.type = (string)typeInput.SelectedItem;
            this.lesson.Classroom1 = (Classroom)classroomInput.SelectedItem;
            this.lesson.StudentGroup1 = (StudentGroup)studentGroupInput.SelectedItem;

            DBConnection.DB.SaveChanges();
            this.Close();
        }

        private class TeacherRecord
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
