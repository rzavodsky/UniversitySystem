namespace UniversitySystem.Student
{
    partial class SubjectListForm
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
            this.subjectList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shortcut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.subjectList)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectList
            // 
            this.subjectList.AllowUserToAddRows = false;
            this.subjectList.AllowUserToDeleteRows = false;
            this.subjectList.AllowUserToResizeRows = false;
            this.subjectList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.subjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Namee,
            this.Shortcut,
            this.Semester,
            this.Credits});
            this.subjectList.Location = new System.Drawing.Point(12, 38);
            this.subjectList.Name = "subjectList";
            this.subjectList.ReadOnly = true;
            this.subjectList.RowHeadersVisible = false;
            this.subjectList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectList.Size = new System.Drawing.Size(626, 334);
            this.subjectList.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Namee
            // 
            this.Namee.HeaderText = "Name";
            this.Namee.Name = "Namee";
            // 
            // Shortcut
            // 
            this.Shortcut.HeaderText = "Shortcut";
            this.Shortcut.Name = "Shortcut";
            // 
            // Semester
            // 
            this.Semester.HeaderText = "Semester";
            this.Semester.Name = "Semester";
            // 
            // Credits
            // 
            this.Credits.HeaderText = "Credits";
            this.Credits.Name = "Credits";
            // 
            // infoButton
            // 
            this.infoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.infoButton.Location = new System.Drawing.Point(519, 12);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(119, 23);
            this.infoButton.TabIndex = 1;
            this.infoButton.Text = "See Subject Info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(63, 12);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(100, 20);
            this.searchInput.TabIndex = 3;
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
            // 
            // SubjectListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 384);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.subjectList);
            this.Name = "SubjectListForm";
            this.Text = "Subject List";
            ((System.ComponentModel.ISupportInitialize)(this.subjectList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView subjectList;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shortcut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credits;
    }
}