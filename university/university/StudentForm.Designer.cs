namespace university
{
    partial class StudentForm
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
            menuStrip1 = new MenuStrip();
            registerStudentsLessonsToolStripMenuItem = new ToolStripMenuItem();
            selectCoursesToolStripMenuItem = new ToolStripMenuItem();
            addCoursesToolStripMenuItem = new ToolStripMenuItem();
            deleteCoursesToolStripMenuItem = new ToolStripMenuItem();
            semesterStatueToolStripMenuItem = new ToolStripMenuItem();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            label1 = new Label();
            nationalCodeTextBox = new TextBox();
            studentCodeLabel = new Label();
            studentCodeTextBox = new TextBox();
            label2 = new Label();
            majorTextBox = new TextBox();
            termStatueToolStripMenuItem = new ToolStripMenuItem();
            reportCardToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { registerStudentsLessonsToolStripMenuItem, termStatueToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // registerStudentsLessonsToolStripMenuItem
            // 
            registerStudentsLessonsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectCoursesToolStripMenuItem, addCoursesToolStripMenuItem, deleteCoursesToolStripMenuItem, semesterStatueToolStripMenuItem });
            registerStudentsLessonsToolStripMenuItem.Name = "registerStudentsLessonsToolStripMenuItem";
            registerStudentsLessonsToolStripMenuItem.Size = new Size(192, 24);
            registerStudentsLessonsToolStripMenuItem.Text = "Register Student's lessons";
            // 
            // selectCoursesToolStripMenuItem
            // 
            selectCoursesToolStripMenuItem.Name = "selectCoursesToolStripMenuItem";
            selectCoursesToolStripMenuItem.Size = new Size(224, 26);
            selectCoursesToolStripMenuItem.Text = "Select Courses";
            selectCoursesToolStripMenuItem.Click += selectCoursesToolStripMenuItem_Click;
            // 
            // addCoursesToolStripMenuItem
            // 
            addCoursesToolStripMenuItem.Name = "addCoursesToolStripMenuItem";
            addCoursesToolStripMenuItem.Size = new Size(224, 26);
            addCoursesToolStripMenuItem.Text = "Add Courses";
            addCoursesToolStripMenuItem.Click += addCoursesToolStripMenuItem_Click;
            // 
            // deleteCoursesToolStripMenuItem
            // 
            deleteCoursesToolStripMenuItem.Name = "deleteCoursesToolStripMenuItem";
            deleteCoursesToolStripMenuItem.Size = new Size(224, 26);
            deleteCoursesToolStripMenuItem.Text = "Delete Courses";
            // 
            // semesterStatueToolStripMenuItem
            // 
            semesterStatueToolStripMenuItem.Name = "semesterStatueToolStripMenuItem";
            semesterStatueToolStripMenuItem.Size = new Size(224, 26);
            semesterStatueToolStripMenuItem.Text = "Semester Statue";
            semesterStatueToolStripMenuItem.Click += semesterStatueToolStripMenuItem_Click;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(26, 68);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(83, 20);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "FirstName :";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(263, 68);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(82, 20);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "LastName :";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(115, 65);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.ReadOnly = true;
            firstNameTextBox.Size = new Size(125, 27);
            firstNameTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(351, 65);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.ReadOnly = true;
            lastNameTextBox.Size = new Size(125, 27);
            lastNameTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(504, 68);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 5;
            label1.Text = "NationalCode :";
            // 
            // nationalCodeTextBox
            // 
            nationalCodeTextBox.Location = new Point(614, 65);
            nationalCodeTextBox.Name = "nationalCodeTextBox";
            nationalCodeTextBox.ReadOnly = true;
            nationalCodeTextBox.Size = new Size(125, 27);
            nationalCodeTextBox.TabIndex = 6;
            // 
            // studentCodeLabel
            // 
            studentCodeLabel.AutoSize = true;
            studentCodeLabel.Location = new Point(26, 128);
            studentCodeLabel.Name = "studentCodeLabel";
            studentCodeLabel.Size = new Size(102, 20);
            studentCodeLabel.TabIndex = 7;
            studentCodeLabel.Text = "StudentCode :";
            // 
            // studentCodeTextBox
            // 
            studentCodeTextBox.Location = new Point(133, 125);
            studentCodeTextBox.Name = "studentCodeTextBox";
            studentCodeTextBox.ReadOnly = true;
            studentCodeTextBox.Size = new Size(125, 27);
            studentCodeTextBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 128);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 9;
            label2.Text = "Major :";
            // 
            // majorTextBox
            // 
            majorTextBox.Location = new Point(345, 125);
            majorTextBox.Name = "majorTextBox";
            majorTextBox.ReadOnly = true;
            majorTextBox.Size = new Size(125, 27);
            majorTextBox.TabIndex = 10;
            // 
            // termStatueToolStripMenuItem
            // 
            termStatueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reportCardToolStripMenuItem });
            termStatueToolStripMenuItem.Name = "termStatueToolStripMenuItem";
            termStatueToolStripMenuItem.Size = new Size(102, 24);
            termStatueToolStripMenuItem.Text = "Term Statue";
            // 
            // reportCardToolStripMenuItem
            // 
            reportCardToolStripMenuItem.Name = "reportCardToolStripMenuItem";
            reportCardToolStripMenuItem.Size = new Size(224, 26);
            reportCardToolStripMenuItem.Text = "Report Card";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(majorTextBox);
            Controls.Add(label2);
            Controls.Add(studentCodeTextBox);
            Controls.Add(studentCodeLabel);
            Controls.Add(nationalCodeTextBox);
            Controls.Add(label1);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(menuStrip1);
            Name = "StudentForm";
            Text = "StudentForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem registerStudentsLessonsToolStripMenuItem;
        private ToolStripMenuItem selectCoursesToolStripMenuItem;
        private ToolStripMenuItem addCoursesToolStripMenuItem;
        private ToolStripMenuItem deleteCoursesToolStripMenuItem;
        private ToolStripMenuItem semesterStatueToolStripMenuItem;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Label label1;
        private TextBox nationalCodeTextBox;
        private Label studentCodeLabel;
        private TextBox studentCodeTextBox;
        private Label label2;
        private TextBox majorTextBox;
        private ToolStripMenuItem termStatueToolStripMenuItem;
        private ToolStripMenuItem reportCardToolStripMenuItem;
    }
}