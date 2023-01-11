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
    public partial class ClassroomUpdateForm : Form
    {

        private Classroom classroom;

        public ClassroomUpdateForm(int? classroomId)
        {
            if (classroomId == null)
            {
                this.classroom = null;
            } else
            {
                this.classroom = DBConnection.DB.Classrooms.Find(classroomId);
            }
            InitializeComponent();
            InitializeFields();
        }

        private void InitializeFields()
        {
            if (this.classroom == null) return;
            nameInput.Text = this.classroom.name;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (this.classroom == null)
            {
                this.classroom = new Classroom();
                DBConnection.DB.Classrooms.Add(this.classroom);
            }

            this.classroom.name = nameInput.Text;
            DBConnection.DB.SaveChanges();
            this.Close();
        }
    }
}
