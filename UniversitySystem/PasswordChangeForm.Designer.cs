namespace UniversitySystem.Teacher
{
    partial class PasswordChangeForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newPwdInput1 = new System.Windows.Forms.TextBox();
            this.newPwdInput2 = new System.Windows.Forms.TextBox();
            this.oldPwdInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(194, 109);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(59, 109);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Repeat New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Old Password:";
            // 
            // newPwdInput1
            // 
            this.newPwdInput1.Location = new System.Drawing.Point(137, 38);
            this.newPwdInput1.Name = "newPwdInput1";
            this.newPwdInput1.Size = new System.Drawing.Size(144, 20);
            this.newPwdInput1.TabIndex = 1;
            this.newPwdInput1.UseSystemPasswordChar = true;
            // 
            // newPwdInput2
            // 
            this.newPwdInput2.Location = new System.Drawing.Point(137, 64);
            this.newPwdInput2.Name = "newPwdInput2";
            this.newPwdInput2.Size = new System.Drawing.Size(144, 20);
            this.newPwdInput2.TabIndex = 2;
            this.newPwdInput2.UseSystemPasswordChar = true;
            // 
            // oldPwdInput
            // 
            this.oldPwdInput.Location = new System.Drawing.Point(137, 12);
            this.oldPwdInput.Name = "oldPwdInput";
            this.oldPwdInput.Size = new System.Drawing.Size(144, 20);
            this.oldPwdInput.TabIndex = 0;
            this.oldPwdInput.UseSystemPasswordChar = true;
            // 
            // PasswordChangeForm
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(343, 151);
            this.Controls.Add(this.oldPwdInput);
            this.Controls.Add(this.newPwdInput2);
            this.Controls.Add(this.newPwdInput1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Name = "PasswordChangeForm";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPwdInput1;
        private System.Windows.Forms.TextBox newPwdInput2;
        private System.Windows.Forms.TextBox oldPwdInput;
    }
}