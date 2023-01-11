namespace UniversitySystem
{
    partial class LessonUpdateForm
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
            this.timeUpDown = new System.Windows.Forms.NumericUpDown();
            this.durationUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.weekDayInput = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.subjectNameInput = new System.Windows.Forms.ComboBox();
            this.teacherInput = new System.Windows.Forms.ComboBox();
            this.typeInput = new System.Windows.Forms.ComboBox();
            this.classroomInput = new System.Windows.Forms.ComboBox();
            this.studentGroupInput = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // timeUpDown
            // 
            this.timeUpDown.Location = new System.Drawing.Point(110, 68);
            this.timeUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.timeUpDown.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.timeUpDown.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.timeUpDown.Name = "timeUpDown";
            this.timeUpDown.Size = new System.Drawing.Size(165, 20);
            this.timeUpDown.TabIndex = 45;
            this.timeUpDown.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.timeUpDown.ValueChanged += new System.EventHandler(this.timeUpDown_ValueChanged);
            // 
            // durationUpDown
            // 
            this.durationUpDown.Location = new System.Drawing.Point(110, 91);
            this.durationUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.durationUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.durationUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.durationUpDown.Name = "durationUpDown";
            this.durationUpDown.Size = new System.Drawing.Size(165, 20);
            this.durationUpDown.TabIndex = 44;
            this.durationUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Teacher:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Duration:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Time:";
            // 
            // weekDayInput
            // 
            this.weekDayInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weekDayInput.FormattingEnabled = true;
            this.weekDayInput.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.weekDayInput.Location = new System.Drawing.Point(110, 43);
            this.weekDayInput.Name = "weekDayInput";
            this.weekDayInput.Size = new System.Drawing.Size(166, 21);
            this.weekDayInput.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Classroom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Subject:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Week Day:";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(29, 240);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 32;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(200, 240);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 31;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // subjectNameInput
            // 
            this.subjectNameInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectNameInput.FormattingEnabled = true;
            this.subjectNameInput.Location = new System.Drawing.Point(110, 17);
            this.subjectNameInput.Name = "subjectNameInput";
            this.subjectNameInput.Size = new System.Drawing.Size(166, 21);
            this.subjectNameInput.TabIndex = 47;
            // 
            // teacherInput
            // 
            this.teacherInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherInput.FormattingEnabled = true;
            this.teacherInput.Location = new System.Drawing.Point(110, 115);
            this.teacherInput.Name = "teacherInput";
            this.teacherInput.Size = new System.Drawing.Size(166, 21);
            this.teacherInput.TabIndex = 48;
            // 
            // typeInput
            // 
            this.typeInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeInput.FormattingEnabled = true;
            this.typeInput.Items.AddRange(new object[] {
            "Lecture",
            "Excercise"});
            this.typeInput.Location = new System.Drawing.Point(110, 141);
            this.typeInput.Name = "typeInput";
            this.typeInput.Size = new System.Drawing.Size(166, 21);
            this.typeInput.TabIndex = 49;
            // 
            // classroomInput
            // 
            this.classroomInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classroomInput.FormattingEnabled = true;
            this.classroomInput.Location = new System.Drawing.Point(110, 167);
            this.classroomInput.Name = "classroomInput";
            this.classroomInput.Size = new System.Drawing.Size(166, 21);
            this.classroomInput.TabIndex = 50;
            // 
            // studentGroupInput
            // 
            this.studentGroupInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentGroupInput.FormattingEnabled = true;
            this.studentGroupInput.Location = new System.Drawing.Point(110, 193);
            this.studentGroupInput.Name = "studentGroupInput";
            this.studentGroupInput.Size = new System.Drawing.Size(166, 21);
            this.studentGroupInput.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Student Group:";
            // 
            // LessonUpdateForm
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.studentGroupInput);
            this.Controls.Add(this.classroomInput);
            this.Controls.Add(this.typeInput);
            this.Controls.Add(this.teacherInput);
            this.Controls.Add(this.subjectNameInput);
            this.Controls.Add(this.timeUpDown);
            this.Controls.Add(this.durationUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.weekDayInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LessonUpdateForm";
            this.Text = "Update Lesson";
            ((System.ComponentModel.ISupportInitialize)(this.timeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown timeUpDown;
        private System.Windows.Forms.NumericUpDown durationUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox weekDayInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.ComboBox subjectNameInput;
        private System.Windows.Forms.ComboBox teacherInput;
        private System.Windows.Forms.ComboBox typeInput;
        private System.Windows.Forms.ComboBox classroomInput;
        private System.Windows.Forms.ComboBox studentGroupInput;
        private System.Windows.Forms.Label label8;
    }
}