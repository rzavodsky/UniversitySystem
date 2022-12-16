namespace UniversitySystem
{
    partial class ProgrammeUpdateForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.facultyInput = new System.Windows.Forms.ComboBox();
            this.degreeTypeInput = new System.Windows.Forms.ComboBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(48, 106);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(216, 106);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 1;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // facultyInput
            // 
            this.facultyInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyInput.FormattingEnabled = true;
            this.facultyInput.Location = new System.Drawing.Point(119, 38);
            this.facultyInput.Name = "facultyInput";
            this.facultyInput.Size = new System.Drawing.Size(157, 21);
            this.facultyInput.TabIndex = 2;
            // 
            // degreeTypeInput
            // 
            this.degreeTypeInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.degreeTypeInput.FormattingEnabled = true;
            this.degreeTypeInput.Location = new System.Drawing.Point(119, 65);
            this.degreeTypeInput.Name = "degreeTypeInput";
            this.degreeTypeInput.Size = new System.Drawing.Size(157, 21);
            this.degreeTypeInput.TabIndex = 3;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(119, 12);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(157, 20);
            this.nameInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Faculty:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Degree Type:";
            // 
            // ProgrammeUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 149);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.degreeTypeInput);
            this.Controls.Add(this.facultyInput);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "ProgrammeUpdateForm";
            this.Text = "Update Programme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.ComboBox facultyInput;
        private System.Windows.Forms.ComboBox degreeTypeInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}