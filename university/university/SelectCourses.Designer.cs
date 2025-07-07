namespace university
{
    partial class SelectCourses
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
            majorGroupComboBox = new ComboBox();
            courseTypeComboBox = new ComboBox();
            searchCurseButton = new Button();
            coursesDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)coursesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // majorGroupComboBox
            // 
            majorGroupComboBox.FormattingEnabled = true;
            majorGroupComboBox.Location = new Point(12, 29);
            majorGroupComboBox.Name = "majorGroupComboBox";
            majorGroupComboBox.Size = new Size(236, 28);
            majorGroupComboBox.TabIndex = 0;
            majorGroupComboBox.Text = "Major Group";
            // 
            // courseTypeComboBox
            // 
            courseTypeComboBox.FormattingEnabled = true;
            courseTypeComboBox.Location = new Point(283, 29);
            courseTypeComboBox.Name = "courseTypeComboBox";
            courseTypeComboBox.Size = new Size(221, 28);
            courseTypeComboBox.TabIndex = 1;
            courseTypeComboBox.Text = "Course Type";
            // 
            // searchCurseButton
            // 
            searchCurseButton.Location = new Point(541, 29);
            searchCurseButton.Name = "searchCurseButton";
            searchCurseButton.Size = new Size(247, 29);
            searchCurseButton.TabIndex = 2;
            searchCurseButton.Text = "Search";
            searchCurseButton.UseVisualStyleBackColor = true;
            searchCurseButton.Click += searchCurseButton_Click;
            // 
            // coursesDataGridView
            // 
            coursesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coursesDataGridView.Location = new Point(12, 85);
            coursesDataGridView.Name = "coursesDataGridView";
            coursesDataGridView.RowHeadersWidth = 51;
            coursesDataGridView.Size = new Size(776, 353);
            coursesDataGridView.TabIndex = 3;
            // 
            // SelectCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(coursesDataGridView);
            Controls.Add(searchCurseButton);
            Controls.Add(courseTypeComboBox);
            Controls.Add(majorGroupComboBox);
            Name = "SelectCourses";
            Text = "SelectCourse";
            ((System.ComponentModel.ISupportInitialize)coursesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox majorGroupComboBox;
        private ComboBox courseTypeComboBox;
        private Button searchCurseButton;
        private DataGridView coursesDataGridView;
    }
}