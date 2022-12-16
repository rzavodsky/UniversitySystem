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
    public partial class ProgrammeUpdateForm : Form
    {
        private Programme programme;
        public ProgrammeUpdateForm(int? programmeId)
        {
            if (programmeId == null)
            {
                this.programme = null;
            } else
            {
                this.programme = DBConnection.DB.Programmes.Find(programmeId);
            }
            InitializeComponent();
            InitializeDegreeTypeDropdown();
            InitializeFacultyDropdown();
            InitializeFields();
        }

        private void InitializeFacultyDropdown()
        {
            facultyInput.DisplayMember = "shortcut";
            facultyInput.DataSource = DBConnection.DB.Faculties.ToList();
        }

        private void InitializeDegreeTypeDropdown()
        {
            degreeTypeInput.DisplayMember = "name";
            degreeTypeInput.DataSource = DBConnection.DB.DegreeTypes.ToList();
        }

        private void InitializeFields()
        {
            if (this.programme == null) return;
            nameInput.Text = this.programme.name;
            facultyInput.SelectedItem = this.programme.Faculty1;
            degreeTypeInput.SelectedItem = this.programme.DegreeType1;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (this.programme == null)
            {
                this.programme = new Programme();
                DBConnection.DB.Programmes.Add(this.programme);
            }
            this.programme.name = nameInput.Text;
            this.programme.Faculty1 = (Faculty)facultyInput.SelectedItem;
            this.programme.DegreeType1 = (DegreeType)degreeTypeInput.SelectedItem;

            DBConnection.DB.SaveChanges();
            this.Close();
        }
    }
}
