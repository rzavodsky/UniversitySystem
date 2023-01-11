namespace UniversitySystem
{
    partial class TeacherMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.facultyLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.timeTable = new System.Windows.Forms.DataGridView();
            this.subjectList = new System.Windows.Forms.DataGridView();
            this.studentListButton = new System.Windows.Forms.Button();
            this.passwordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(74, 9);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Faculty:";
            // 
            // facultyLabel
            // 
            this.facultyLabel.AutoSize = true;
            this.facultyLabel.Location = new System.Drawing.Point(74, 31);
            this.facultyLabel.Name = "facultyLabel";
            this.facultyLabel.Size = new System.Drawing.Size(64, 13);
            this.facultyLabel.TabIndex = 3;
            this.facultyLabel.Text = "facultyLabel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(74, 53);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(35, 13);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "label6";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(74, 75);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(41, 13);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "idLabel";
            // 
            // timeTable
            // 
            this.timeTable.AllowUserToAddRows = false;
            this.timeTable.AllowUserToDeleteRows = false;
            this.timeTable.AllowUserToResizeColumns = false;
            this.timeTable.AllowUserToResizeRows = false;
            this.timeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.timeTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.timeTable.Location = new System.Drawing.Point(197, 12);
            this.timeTable.MultiSelect = false;
            this.timeTable.Name = "timeTable";
            this.timeTable.ReadOnly = true;
            this.timeTable.RowHeadersVisible = false;
            this.timeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.timeTable.ShowCellErrors = false;
            this.timeTable.ShowEditingIcon = false;
            this.timeTable.ShowRowErrors = false;
            this.timeTable.Size = new System.Drawing.Size(665, 241);
            this.timeTable.TabIndex = 8;
            // 
            // subjectList
            // 
            this.subjectList.AllowUserToAddRows = false;
            this.subjectList.AllowUserToDeleteRows = false;
            this.subjectList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.subjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectList.Location = new System.Drawing.Point(197, 259);
            this.subjectList.MultiSelect = false;
            this.subjectList.Name = "subjectList";
            this.subjectList.ReadOnly = true;
            this.subjectList.RowHeadersVisible = false;
            this.subjectList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectList.ShowCellErrors = false;
            this.subjectList.ShowCellToolTips = false;
            this.subjectList.ShowEditingIcon = false;
            this.subjectList.ShowRowErrors = false;
            this.subjectList.Size = new System.Drawing.Size(665, 211);
            this.subjectList.TabIndex = 9;
            // 
            // studentListButton
            // 
            this.studentListButton.Location = new System.Drawing.Point(12, 259);
            this.studentListButton.Name = "studentListButton";
            this.studentListButton.Size = new System.Drawing.Size(170, 23);
            this.studentListButton.TabIndex = 10;
            this.studentListButton.Text = "Show Student List";
            this.studentListButton.UseVisualStyleBackColor = true;
            this.studentListButton.Click += new System.EventHandler(this.studentListButton_Click);
            // 
            // passwordButton
            // 
            this.passwordButton.Location = new System.Drawing.Point(12, 109);
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.Size = new System.Drawing.Size(170, 23);
            this.passwordButton.TabIndex = 11;
            this.passwordButton.Text = "Change Password";
            this.passwordButton.UseVisualStyleBackColor = true;
            this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
            // 
            // TeacherMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 482);
            this.Controls.Add(this.passwordButton);
            this.Controls.Add(this.studentListButton);
            this.Controls.Add(this.subjectList);
            this.Controls.Add(this.timeTable);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.facultyLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TeacherMenu";
            this.Text = "TeacherMenu";
            ((System.ComponentModel.ISupportInitialize)(this.timeTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label facultyLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.DataGridView timeTable;
        private System.Windows.Forms.DataGridView subjectList;
        private System.Windows.Forms.Button studentListButton;
        private System.Windows.Forms.Button passwordButton;
    }
}