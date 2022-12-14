namespace UniversitySystem
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
            this.listGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listGridView
            // 
            this.listGridView.AllowUserToAddRows = false;
            this.listGridView.AllowUserToDeleteRows = false;
            this.listGridView.AllowUserToResizeColumns = false;
            this.listGridView.AllowUserToResizeRows = false;
            this.listGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listGridView.Location = new System.Drawing.Point(12, 32);
            this.listGridView.MultiSelect = false;
            this.listGridView.Name = "listGridView";
            this.listGridView.ReadOnly = true;
            this.listGridView.RowHeadersVisible = false;
            this.listGridView.RowTemplate.ReadOnly = true;
            this.listGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listGridView.Size = new System.Drawing.Size(776, 406);
            this.listGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search:";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(62, 6);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 20);
            this.searchBox.TabIndex = 2;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(713, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add Student";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listGridView);
            this.Name = "StudentListForm";
            this.Text = "University Student List";
            ((System.ComponentModel.ISupportInitialize)(this.listGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button addButton;
    }
}