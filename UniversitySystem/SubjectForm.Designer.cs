namespace UniversitySystem
{
    partial class SubjectForm
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
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.facultyInput = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.semesterUpDown = new System.Windows.Forms.NumericUpDown();
            this.creditsUpDown = new System.Windows.Forms.NumericUpDown();
            this.lecturesUpDown = new System.Windows.Forms.NumericUpDown();
            this.exercisesUpDown = new System.Windows.Forms.NumericUpDown();
            this.shortcutInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.semesterUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(105, 19);
            this.nameInput.Margin = new System.Windows.Forms.Padding(4);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(220, 22);
            this.nameInput.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Faculty:";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(53, 266);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(225, 266);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 28);
            this.confirmButton.TabIndex = 8;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // facultyInput
            // 
            this.facultyInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyInput.FormattingEnabled = true;
            this.facultyInput.Location = new System.Drawing.Point(105, 47);
            this.facultyInput.Margin = new System.Windows.Forms.Padding(4);
            this.facultyInput.Name = "facultyInput";
            this.facultyInput.Size = new System.Drawing.Size(220, 24);
            this.facultyInput.TabIndex = 21;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(105, 191);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(220, 22);
            this.descriptionTextBox.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Excercises:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Lectures:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Credits:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 164);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Semester:";
            // 
            // semesterUpDown
            // 
            this.semesterUpDown.Location = new System.Drawing.Point(105, 162);
            this.semesterUpDown.Name = "semesterUpDown";
            this.semesterUpDown.Size = new System.Drawing.Size(220, 22);
            this.semesterUpDown.TabIndex = 27;
            // 
            // creditsUpDown
            // 
            this.creditsUpDown.Location = new System.Drawing.Point(105, 134);
            this.creditsUpDown.Name = "creditsUpDown";
            this.creditsUpDown.Size = new System.Drawing.Size(220, 22);
            this.creditsUpDown.TabIndex = 28;
            // 
            // lecturesUpDown
            // 
            this.lecturesUpDown.Location = new System.Drawing.Point(105, 106);
            this.lecturesUpDown.Name = "lecturesUpDown";
            this.lecturesUpDown.Size = new System.Drawing.Size(220, 22);
            this.lecturesUpDown.TabIndex = 29;
            // 
            // exercisesUpDown
            // 
            this.exercisesUpDown.Location = new System.Drawing.Point(105, 78);
            this.exercisesUpDown.Name = "exercisesUpDown";
            this.exercisesUpDown.Size = new System.Drawing.Size(220, 22);
            this.exercisesUpDown.TabIndex = 30;
            // 
            // shortcutInput
            // 
            this.shortcutInput.Location = new System.Drawing.Point(105, 221);
            this.shortcutInput.Margin = new System.Windows.Forms.Padding(4);
            this.shortcutInput.Name = "shortcutInput";
            this.shortcutInput.Size = new System.Drawing.Size(220, 22);
            this.shortcutInput.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 224);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Shortcut:";
            // 
            // SubjectForm
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(445, 319);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.shortcutInput);
            this.Controls.Add(this.exercisesUpDown);
            this.Controls.Add(this.lecturesUpDown);
            this.Controls.Add(this.creditsUpDown);
            this.Controls.Add(this.semesterUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.facultyInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Name = "SubjectForm";
            this.Text = "SubjectForm";
            ((System.ComponentModel.ISupportInitialize)(this.semesterUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox facultyInput;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown semesterUpDown;
        private System.Windows.Forms.NumericUpDown creditsUpDown;
        private System.Windows.Forms.NumericUpDown lecturesUpDown;
        private System.Windows.Forms.NumericUpDown exercisesUpDown;
        private System.Windows.Forms.TextBox shortcutInput;
        private System.Windows.Forms.Label label8;
    }
}