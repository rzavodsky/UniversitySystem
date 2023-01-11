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
    public partial class CityUpdateForm : Form
    
    {
     private City city;
        public CityUpdateForm(int? cityId)
        {
            if (cityId == null)
            {
                this.city = null;
            }
            else
            {
                this.city = DBConnection.DB.Cities.Find(cityId);
            }
            InitializeComponent();
            InitializeCountryDropDown();
            InitializeFields();
        }
        private void InitializeFields()
        {
            if (this.city == null) return;
            cityNameInput.Text = this.city.name;
            countryInput.SelectedItem = this.city.Country1;
        }
       
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         private void InitializeCountryDropDown()
        {
            countryInput.DisplayMember = "name";
            countryInput.DataSource = DBConnection.DB.Countries.ToList();
        }

        private void confirmButton_Click_1(object sender, EventArgs e)
        {
            if (this.city == null)
            {
                this.city = new City();
                DBConnection.DB.Cities.Add(this.city);
            }

            this.city.name = cityNameInput.Text;
            this.city.Country1 = (Country)countryInput.SelectedItem;

            DBConnection.DB.SaveChanges();
            this.Close();
        }
    }
}
