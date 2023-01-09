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
    public partial class StudentGroupUpdateForm : Form
    {
        private StudentGroup studentGroup;
        public StudentGroupUpdateForm(int? studentGroupId)
        {
            if (studentGroupId != null)
            {
                this.studentGroup = DBConnection.DB.StudentGroups.Find(studentGroupId);
            }

            InitializeComponent();
            InitializeProgrammeDropdown();
            InitializeFields();
        }

        private void InitializeProgrammeDropdown()
        {
            programmeInput.DisplayMember = "name";
            programmeInput.DataSource = DBConnection.DB.Programmes.ToList();
        }

        private void InitializeFields()
        {
            if (this.studentGroup == null) return;

            nameInput.Text = this.studentGroup.name;
            programmeInput.SelectedItem = this.studentGroup.Programme1;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (this.studentGroup == null)
            {
                this.studentGroup = new StudentGroup();
                DBConnection.DB.StudentGroups.Add(this.studentGroup);
            }

            this.studentGroup.name = nameInput.Text;
            this.studentGroup.Programme1 = (Programme)programmeInput.SelectedItem;

            DBConnection.DB.SaveChanges();
            this.Close();
        }
    }
}
