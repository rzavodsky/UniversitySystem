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
    public partial class DegreeTypeUpdateForm : Form
    {
        private DegreeType degreeType;
        public DegreeTypeUpdateForm(int? degreeTypeId)
        {
            if (degreeTypeId != null)
            {
                this.degreeType = DBConnection.DB.DegreeTypes.Find(degreeTypeId);
            }

            InitializeComponent();
            InitializeFields();
        }

        private void InitializeFields()
        {
            if (this.degreeType == null) return;

            nameInput.Text = this.degreeType.name;
            durationUpDown.Value = this.degreeType.length;
            creditsUpDown.Value = this.degreeType.requiredCredits;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (this.degreeType == null)
            {
                this.degreeType = new DegreeType();
                DBConnection.DB.DegreeTypes.Add(this.degreeType);
            }

            this.degreeType.name = nameInput.Text;
            this.degreeType.requiredCredits = (int)creditsUpDown.Value;
            this.degreeType.length = (int)durationUpDown.Value;

            DBConnection.DB.SaveChanges();
            this.Close();
        }
    }
}
