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
    public partial class FacultyUpdateForm : Form
    {
        private Faculty faculty;
        public FacultyUpdateForm(int? facultyId)
        {
            if (facultyId == null)
            {
                this.faculty = null;
            } else
            {
                this.faculty = DBConnection.DB.Faculties.Find(facultyId);
            }
            InitializeComponent();
            InitializeFields();
        }

        private void InitializeFields()
        {
            if (this.faculty == null) return;
            nameInput.Text = this.faculty.name;
            descriptionInput.Text = this.faculty.description;
            shortcutInput.Text = this.faculty.shortcut;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (this.faculty == null)
            {
                this.faculty = new Faculty();
                DBConnection.DB.Faculties.Add(this.faculty);
            }
            this.faculty.name = nameInput.Text;
            this.faculty.description = descriptionInput.Text;
            this.faculty.shortcut = shortcutInput.Text;

            DBConnection.DB.SaveChanges();
            this.Close();
        }
    }
}
