namespace UniversitySystem.Teacher
{
    partial class StudentListForm
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
            this.studentList = new System.Windows.Forms.DataGridView();
            this.gradeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentList)).BeginInit();
            this.SuspendLayout();
            // 
            // studentList
            // 
            this.studentList.AllowUserToAddRows = false;
            this.studentList.AllowUserToDeleteRows = false;
            this.studentList.AllowUserToResizeRows = false;
            this.studentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentList.Location = new System.Drawing.Point(12, 38);
            this.studentList.MultiSelect = false;
            this.studentList.Name = "studentList";
            this.studentList.ReadOnly = true;
            this.studentList.RowHeadersVisible = false;
            this.studentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentList.Size = new System.Drawing.Size(675, 209);
            this.studentList.TabIndex = 0;
            // 
            // gradeButton
            // 
            this.gradeButton.Location = new System.Drawing.Point(543, 9);
            this.gradeButton.Name = "gradeButton";
            this.gradeButton.Size = new System.Drawing.Size(144, 23);
            this.gradeButton.TabIndex = 1;
            this.gradeButton.Text = "Change Grade";
            this.gradeButton.UseVisualStyleBackColor = true;
            this.gradeButton.Click += new System.EventHandler(this.gradeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(62, 12);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(137, 20);
            this.searchInput.TabIndex = 3;
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 266);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gradeButton);
            this.Controls.Add(this.studentList);
            this.Name = "StudentListForm";
            this.Text = "Student List";
            ((System.ComponentModel.ISupportInitialize)(this.studentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentList;
        private System.Windows.Forms.Button gradeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchInput;
    }
}