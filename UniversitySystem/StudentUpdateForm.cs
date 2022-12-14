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
        public StudentUpdateForm()
        {
            InitializeComponent();
            InitializeCountryDropDown();
            InitializeCityDropDown();
            InitializeStudGroupDropDown();
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
            var person = new Person();
            person.firstName = firstNameInput.Text;
            person.lastName = lastNameInput.Text;
            person.studentCredits = 0;
            person.birthDate = birthDateInput.Value;
            person.gender = genderInput.Text;
            person.City1 = (City)cityInput.SelectedItem;
            var sameNamedPeople = from p in DBConnection.DB.People
                                  where p.lastName.ToLower() == person.lastName.ToLower()
                                  select p;
            person.loginUsername = person.lastName.ToLower() + (sameNamedPeople.Count() + 1);
            person.loginPassword = "password";

            person.StudentGroup1 = (StudentGroup)studGroupInput.SelectedItem;
            person.isTeacher = false;
            DBConnection.DB.People.Add(person);
            DBConnection.DB.SaveChanges();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
