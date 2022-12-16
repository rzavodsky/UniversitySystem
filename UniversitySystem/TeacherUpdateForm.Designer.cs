namespace UniversitySystem
{
    partial class TeacherUpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.facultyInput = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.genderInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.countryInput = new System.Windows.Forms.ComboBox();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.birthDateInput = new System.Windows.Forms.DateTimePicker();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Faculty:";
            // 
            // facultyInput
            // 
            this.facultyInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyInput.FormattingEnabled = true;
            this.facultyInput.Location = new System.Drawing.Point(95, 89);
            this.facultyInput.Name = "facultyInput";
            this.facultyInput.Size = new System.Drawing.Size(146, 21);
            this.facultyInput.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Gender:";
            // 
            // genderInput
            // 
            this.genderInput.Location = new System.Drawing.Point(332, 11);
            this.genderInput.Name = "genderInput";
            this.genderInput.Size = new System.Drawing.Size(140, 20);
            this.genderInput.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "City:";
            // 
            // cityInput
            // 
            this.cityInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityInput.FormattingEnabled = true;
            this.cityInput.Location = new System.Drawing.Point(332, 63);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(140, 21);
            this.cityInput.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Country:";
            // 
            // countryInput
            // 
            this.countryInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryInput.FormattingEnabled = true;
            this.countryInput.Location = new System.Drawing.Point(332, 36);
            this.countryInput.Name = "countryInput";
            this.countryInput.Size = new System.Drawing.Size(140, 21);
            this.countryInput.TabIndex = 24;
            this.countryInput.SelectedIndexChanged += new System.EventHandler(this.countryInput_SelectedIndexChanged);
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(95, 11);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(146, 20);
            this.firstNameInput.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Birth Date:";
            // 
            // birthDateInput
            // 
            this.birthDateInput.Location = new System.Drawing.Point(95, 63);
            this.birthDateInput.Name = "birthDateInput";
            this.birthDateInput.Size = new System.Drawing.Size(146, 20);
            this.birthDateInput.TabIndex = 22;
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(95, 37);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(146, 20);
            this.lastNameInput.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Last Name:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(140, 130);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(263, 130);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 16;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // TeacherUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 206);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.facultyInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.genderInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.countryInput);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.birthDateInput);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TeacherUpdateForm";
            this.Text = "TeacherUpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox facultyInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox genderInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cityInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox countryInput;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker birthDateInput;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
    }
}