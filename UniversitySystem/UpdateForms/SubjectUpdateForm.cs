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
    public partial class SubjectUpdateForm : Form
    {
        private Subject subject;
        public SubjectUpdateForm(int? subjectId)
        {
            if (subjectId != null)
            {
                this.subject = DBConnection.DB.Subjects.Find(subjectId);
            }

            InitializeComponent();
            InitializeFacultyDropdown();
            InitializeFields();
        }

        private void InitializeFields()
        {
            if (this.subject == null) return;
            nameInput.Text = this.subject.name;
            shortcutInput.Text = this.subject.shortcut;
            facultyInput.SelectedItem = this.subject.Faculty1;
            exercisesUpDown.Value = this.subject.excerciseAmount;
            lecturesUpDown.Value = this.subject.lectureAmount;
            creditsUpDown.Value = this.subject.credits;
            semesterUpDown.Value = this.subject.semester;
            descriptionTextBox.Text = this.subject.description;
        }

        private void InitializeFacultyDropdown()
        {
            facultyInput.DataSource = DBConnection.DB.Faculties.ToList();
            facultyInput.DisplayMember = "name";
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (this.subject == null)
            {
                this.subject = new Subject();
                DBConnection.DB.Subjects.Add(this.subject);
            }

            this.subject.name = nameInput.Text;
            this.subject.shortcut = shortcutInput.Text;
            this.subject.Faculty1 = (Faculty)facultyInput.SelectedItem;
            this.subject.excerciseAmount = (int)exercisesUpDown.Value;
            this.subject.lectureAmount = (int)lecturesUpDown.Value;
            this.subject.credits = (int)creditsUpDown.Value;
            this.subject.semester = (int)semesterUpDown.Value;
            this.subject.description = descriptionTextBox.Text;

            DBConnection.DB.SaveChanges();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
