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
    public partial class TeacherUpdateForm : Form
    {
        private Person teacher;
        public TeacherUpdateForm(Person teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
            InitializeComponent();
            InitializeCountryDropDown();
            InitializeCityDropDown();
            InitializeFacultyDropDown();
            InitializeFields();
        }

        private void InitializeFacultyDropDown()
        {
            facultyInput.DisplayMember = "name";
            facultyInput.DataSource = DBConnection.DB.Faculties.ToList();
        }

        private void InitializeFields()
        {
            if (this.teacher == null) return;

            firstNameInput.Text = this.teacher.firstName;
            lastNameInput.Text = this.teacher.lastName;
            birthDateInput.Value = this.teacher.birthDate;
            genderInput.Text = this.teacher.gender;
            countryInput.SelectedItem = this.teacher.City1.Country1;
            cityInput.SelectedItem = this.teacher.City1;
            facultyInput.SelectedItem = this.teacher.Faculty;
        }
        private void InitializeCityDropDown()
        {
            cityInput.DisplayMember = "name";
            cityInput.DataSource = ((Country)this.countryInput.SelectedItem).Cities.ToList();
        }

        private void InitializeCountryDropDown()
        {
            countryInput.DisplayMember = "name";
            countryInput.DataSource = DBConnection.DB.Countries.ToList();
        }

        private void countryInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeCityDropDown();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (this.teacher == null)
            {
                this.teacher = new Person();
                DBConnection.DB.People.Add(this.teacher);
            }

            this.teacher.firstName = firstNameInput.Text;
            this.teacher.lastName = lastNameInput.Text;
            this.teacher.birthDate = birthDateInput.Value;
            this.teacher.gender = genderInput.Text;
            this.teacher.City1 = (City)cityInput.SelectedItem;
           
            if (this.teacher.loginUsername == null)
            {
                var sameNamedPeople = from p in DBConnection.DB.People
                                      where p.lastName.ToLower() == this.teacher.lastName.ToLower()
                                      select p;
                this.teacher.loginUsername = this.teacher.lastName.ToLower() + (sameNamedPeople.Count() + 1);
            }

            if (this.teacher.loginPassword == null)
            {
                this.teacher.loginPassword = "password";

            }

            this.teacher.Faculty = (Faculty)facultyInput.SelectedItem;
            this.teacher.isTeacher = true;

            DBConnection.DB.SaveChanges();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}