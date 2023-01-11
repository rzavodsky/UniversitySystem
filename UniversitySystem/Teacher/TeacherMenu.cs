using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitySystem.Teacher;

namespace UniversitySystem
{
    public partial class TeacherMenu : Form
    {
        public static string[] DAYS_OF_WEEK = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

        private Person teacher;
        public TeacherMenu(Person teacher)
        {
            this.teacher = teacher;

            InitializeComponent();

            PopulateTimetable();
            ResizeTimetable();

            PopulateSubjectList();

            nameLabel.Text = teacher.firstName + " " + teacher.lastName;
            facultyLabel.Text = teacher.Faculty.shortcut;
            usernameLabel.Text = teacher.loginUsername;
            idLabel.Text = teacher.id.ToString();
            Text = "University Management System - " + teacher.firstName + " " + teacher.lastName;
        }

        private void PopulateSubjectList()
        {
            subjectList.Columns.Clear();
            subjectList.Columns.Add("id", "");
            subjectList.Columns[0].Visible = false;
            subjectList.Columns.Add("Name", "Name");
            subjectList.Columns.Add("Semester", "Semester");
            subjectList.Columns.Add("Students Amount", "Students Amount");
            subjectList.Columns.Add("Ungraded Students Amount", "Ungraded Students Amount");


            var subjects = from lesson in this.teacher.Lessons
                           group lesson by lesson.Subject1 into newGroup
                           select newGroup;
            subjectList.Rows.Clear();

            foreach (var subjectGrp in subjects)
            {
                var subject = subjectGrp.Key;

                subjectList.Rows.Add(new object[] {
                    subject.id,
                    subject.name,
                    subject.semester,
                    subject.StudentSubjects.Count,
                    subject.StudentSubjects.Where(s => s.grade == null).Count(),
                });
            }
        }

        private void PopulateTimetable()
        {
            timeTable.Columns.Add("", "");
            for (int hour = 7; hour <= 19; hour++)
            {
                timeTable.Columns.Add(hour.ToString(), hour + ":00");
            }
            timeTable.Columns[0].Width = 40;
            timeTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            for (int dayIndex = 0; dayIndex < DAYS_OF_WEEK.Length; dayIndex++)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = DAYS_OF_WEEK[dayIndex] });

                for (int i = 0; i < timeTable.ColumnCount - 1; i++)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell());
                }

                var lessons = from lesson in this.teacher.Lessons
                              where lesson.weekDay == dayIndex
                              orderby lesson.time ascending
                              select lesson;

                foreach (var lesson in lessons)
                {
                    var rnd = new Random();
                    var color = Color.FromArgb(128 + rnd.Next(128), 128 + rnd.Next(128), 128 + rnd.Next(128));
                    var startHour = lesson.time;
                    for (int i = 0; i < lesson.duration; i++)
                    {
                        var cell = row.Cells[startHour + i - 6];
                        cell.Value = lesson.Subject1.shortcut;
                        cell.Style.BackColor = color;
                        cell.Style.SelectionBackColor = color;
                        cell.ToolTipText = lesson.Subject1.name + "\n" + lesson.type + "\n" + lesson.Classroom1.name + "\n" + lesson.StudentGroup1.name;
                    }
                }

                timeTable.Rows.Add(row);
            }
        }

        private void ResizeTimetable()
        {
            var availableSpace = timeTable.Size.Height - timeTable.ColumnHeadersHeight;
            for (int i = 0; i < timeTable.RowCount; i++)
            {
                timeTable.Rows[i].Height = availableSpace / timeTable.RowCount;
            }
        }

        private void passwordButton_Click(object sender, EventArgs e)
        {
            var form = new PasswordChangeForm(this.teacher);
            form.ShowDialog();
        }

        private void studentListButton_Click(object sender, EventArgs e)
        {
            var subjectId = (int)subjectList.SelectedRows[0].Cells[0].Value;
            var subject = DBConnection.DB.Subjects.Find(subjectId);

            var form = new StudentListForm(subject);
            form.ShowDialog();
            PopulateSubjectList();
        }
    }
}
