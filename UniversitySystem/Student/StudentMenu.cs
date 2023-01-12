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
using UniversitySystem.Student;
using UniversitySystem.Teacher;

namespace UniversitySystem
{
    public partial class StudentMenu : Form
    {
        public static string[] DAYS_OF_WEEK = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

        private Person student;
        public StudentMenu(Person student)
        {
            this.student = student;

            InitializeComponent();

            PopulateTimetable();
            ResizeTimetable();

            PopulateSubjectList();

            nameLabel.Text = student.firstName + " " + student.lastName;
            studGroupLabel.Text = student.StudentGroup1.name;
            usernameLabel.Text = student.loginUsername;
            idLabel.Text = student.id.ToString();
            creditsLabel.Text = student.studentCredits.ToString();
            Text = "University Management System - " + student.firstName + " " + student.lastName;
        }

        private void PopulateSubjectList()
        {
            subjectList.Columns.Clear();
            subjectList.Columns.Add("Name", "Name");
            subjectList.Columns.Add("Credits", "Credits");
            subjectList.Columns.Add("Grade", "Grade");


            subjectList.Rows.Clear();

            foreach (var studSub in this.student.StudentSubjects)
            {
                var subject = studSub.Subject1;

                subjectList.Rows.Add(new object[] {
                    subject.name,
                    subject.credits,
                    studSub.grade ?? "None",
                });
            }
        }

        private void PopulateTimetable()
        {
            timeTable.Columns.Clear();
            timeTable.Rows.Clear();
            timeTable.Columns.Add("", "");
            for (int hour = 7; hour <= 19; hour++)
            {
                timeTable.Columns.Add(hour.ToString(), hour + ":00");
            }
            timeTable.Columns[0].Width = 40;
            timeTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var rnd = new Random();
            for (int dayIndex = 0; dayIndex < DAYS_OF_WEEK.Length; dayIndex++)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = DAYS_OF_WEEK[dayIndex] });

                for (int i = 0; i < timeTable.ColumnCount - 1; i++)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell());
                }

                var lessons = from lesson in DBConnection.DB.Lessons
                              join studSub in DBConnection.DB.StudentSubjects on lesson.subject equals studSub.subject
                              where lesson.weekDay == dayIndex && studSub.student == this.student.id
                              orderby lesson.time ascending
                              select lesson;

                foreach (var lesson in lessons)
                {
                    var color = Color.FromArgb(128 + rnd.Next(128), 128 + rnd.Next(128), 128 + rnd.Next(128));
                    var startHour = lesson.time;
                    for (int i = 0; i < lesson.duration; i++)
                    {
                        var cell = row.Cells[startHour + i - 6];
                        cell.Value = lesson.Subject1.shortcut;
                        cell.Style.BackColor = color;
                        cell.Style.SelectionBackColor = color;
                        cell.ToolTipText = lesson.Subject1.name + "\n" + lesson.type + "\n" + lesson.Classroom1.name + "\n" + lesson.Person.firstName + " " + lesson.Person.lastName;
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
            var form = new PasswordChangeForm(this.student);
            form.ShowDialog();
        }

        private void subjectButton_Click(object sender, EventArgs e)
        {
            var form = new SubjectListForm(this.student);
            form.ShowDialog();
            PopulateSubjectList();
            PopulateTimetable();
            ResizeTimetable();
            creditsLabel.Text = student.studentCredits.ToString();
        }
    }
}
