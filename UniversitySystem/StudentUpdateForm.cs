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
    public partial class StudentUpdateForm : Form
    {
        private Person student;
        public StudentUpdateForm(int? studentId)
        {
            if (studentId == null)
            {
                this.student = null;
            } else
            {
                this.student = DBConnection.DB.People.Find(studentId);
            }
            InitializeComponent();
            InitializeCountryDropDown();
            InitializeCityDropDown();
            InitializeStudGroupDropDown();
            InitializeFields();
        }

        private void InitializeFields()
        {
            if (this.student == null) return;

            firstNameInput.Text = this.student.firstName;
            lastNameInput.Text = this.student.lastName;
            birthDateInput.Value = this.student.birthDate;
            genderInput.Text = this.student.gender;
            countryInput.SelectedItem = this.student.City1.Country1;
            cityInput.SelectedItem = this.student.City1;
            studGroupInput.SelectedItem = this.student.StudentGroup1;
        }

        private void InitializeStudGroupDropDown()
        {
            studGroupInput.DisplayMember = "name";
            studGroupInput.DataSource = DBConnection.DB.StudentGroups.ToList();
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
            if (this.student == null)
            {
                this.student = new Person();
                DBConnection.DB.People.Add(this.student);
            }
            
            this.student.firstName = firstNameInput.Text;
            this.student.lastName = lastNameInput.Text;
            this.student.birthDate = birthDateInput.Value;
            this.student.gender = genderInput.Text;
            this.student.City1 = (City)cityInput.SelectedItem;
            if (this.student.studentCredits == null)
            {
                this.student.studentCredits = 0;
            }
            if (this.student.loginUsername == null)
            {
                var sameNamedPeople = from p in DBConnection.DB.People
                                      where p.lastName.ToLower() == this.student.lastName.ToLower()
                                      select p;
                this.student.loginUsername = this.student.lastName.ToLower() + (sameNamedPeople.Count() + 1);
            }

            if (this.student.loginPassword == null)
            {
                this.student.loginPassword = "password";

            }

            this.student.StudentGroup1 = (StudentGroup)studGroupInput.SelectedItem;
            this.student.isTeacher = false;

            DBConnection.DB.SaveChanges();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
