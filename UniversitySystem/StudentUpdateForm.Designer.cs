namespace UniversitySystem
{
    partial class StudentUpdateForm
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.birthDateInput = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.countryInput = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.ComboBox();
            this.genderInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.studGroupInput = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(263, 132);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(140, 132);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name:";
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(95, 12);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(146, 20);
            this.firstNameInput.TabIndex = 3;
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(95, 38);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(146, 20);
            this.lastNameInput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name:";
            // 
            // birthDateInput
            // 
            this.birthDateInput.Location = new System.Drawing.Point(95, 64);
            this.birthDateInput.Name = "birthDateInput";
            this.birthDateInput.Size = new System.Drawing.Size(146, 20);
            this.birthDateInput.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Birth Date:";
            // 
            // countryInput
            // 
            this.countryInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryInput.FormattingEnabled = true;
            this.countryInput.Location = new System.Drawing.Point(332, 37);
            this.countryInput.Name = "countryInput";
            this.countryInput.Size = new System.Drawing.Size(140, 21);
            this.countryInput.TabIndex = 8;
            this.countryInput.SelectedIndexChanged += new System.EventHandler(this.countryInput_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Country:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "City:";
            // 
            // cityInput
            // 
            this.cityInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityInput.FormattingEnabled = true;
            this.cityInput.Location = new System.Drawing.Point(332, 64);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(140, 21);
            this.cityInput.TabIndex = 10;
            // 
            // genderInput
            // 
            this.genderInput.Location = new System.Drawing.Point(332, 12);
            this.genderInput.Name = "genderInput";
            this.genderInput.Size = new System.Drawing.Size(140, 20);
            this.genderInput.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Gender:";
            // 
            // studGroupInput
            // 
            this.studGroupInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studGroupInput.FormattingEnabled = true;
            this.studGroupInput.Location = new System.Drawing.Point(95, 90);
            this.studGroupInput.Name = "studGroupInput";
            this.studGroupInput.Size = new System.Drawing.Size(146, 21);
            this.studGroupInput.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Student Group:";
            // 
            // StudentUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 167);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.studGroupInput);
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
            this.Name = "StudentUpdateForm";
            this.Text = "Change Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker birthDateInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox countryInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cityInput;
        private System.Windows.Forms.TextBox genderInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox studGroupInput;
        private System.Windows.Forms.Label label7;
    }
}