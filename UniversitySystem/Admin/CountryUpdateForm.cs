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
    public partial class CountryUpdateForm : Form
    {
        private Country country;
        public CountryUpdateForm(int? countryId)
        {
            if (countryId == null)
            {
                this.country = null;
            }
            else
            {
                this.country = DBConnection.DB.Countries.Find(countryId);
            }

            InitializeComponent();
            InitializeFields();
        }

        private void InitializeFields()
        {
            if (this.country == null) return;
            NameInput.Text = this.country.name;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (this.country == null)
            {
                this.country = new Country();
                DBConnection.DB.Countries.Add(this.country);
            }

            this.country.name = NameInput.Text;

            DBConnection.DB.SaveChanges();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
