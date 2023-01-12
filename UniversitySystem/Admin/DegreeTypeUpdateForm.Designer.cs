namespace UniversitySystem
{
    partial class DegreeTypeUpdateForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.durationUpDown = new System.Windows.Forms.NumericUpDown();
            this.creditsUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.durationUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Credits required:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Duration (semester):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name:";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(112, 18);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(157, 20);
            this.nameInput.TabIndex = 12;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(193, 114);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 9;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(29, 114);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // durationUpDown
            // 
            this.durationUpDown.Location = new System.Drawing.Point(112, 45);
            this.durationUpDown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.durationUpDown.Name = "durationUpDown";
            this.durationUpDown.Size = new System.Drawing.Size(156, 20);
            this.durationUpDown.TabIndex = 18;
            // 
            // creditsUpDown
            // 
            this.creditsUpDown.Location = new System.Drawing.Point(111, 70);
            this.creditsUpDown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.creditsUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.creditsUpDown.Name = "creditsUpDown";
            this.creditsUpDown.Size = new System.Drawing.Size(156, 20);
            this.creditsUpDown.TabIndex = 19;
            // 
            // DegreeTypeUpdateForm
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(310, 164);
            this.Controls.Add(this.creditsUpDown);
            this.Controls.Add(this.durationUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "DegreeTypeUpdateForm";
            this.Text = "Update Degree Type";
            ((System.ComponentModel.ISupportInitialize)(this.durationUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown durationUpDown;
        private System.Windows.Forms.NumericUpDown creditsUpDown;
    }
}