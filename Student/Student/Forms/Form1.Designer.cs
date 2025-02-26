namespace Student
{
    partial class Users
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            nationalCodeLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            nationalCodeTextBox = new TextBox();
            registerButton = new Button();
            studentRoleCheckBox = new CheckBox();
            masterRolecheckBox = new CheckBox();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(29, 50);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(76, 20);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "FirstName";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(29, 92);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(75, 20);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "LastName";
            lastNameLabel.Click += label1_Click;
            // 
            // nationalCodeLabel
            // 
            nationalCodeLabel.AutoSize = true;
            nationalCodeLabel.Location = new Point(29, 137);
            nationalCodeLabel.Name = "nationalCodeLabel";
            nationalCodeLabel.Size = new Size(101, 20);
            nationalCodeLabel.TabIndex = 2;
            nationalCodeLabel.Text = "NationalCode";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(140, 47);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(181, 27);
            firstNameTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(140, 88);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(181, 27);
            lastNameTextBox.TabIndex = 4;
            // 
            // nationalCodeTextBox
            // 
            nationalCodeTextBox.Location = new Point(140, 133);
            nationalCodeTextBox.Name = "nationalCodeTextBox";
            nationalCodeTextBox.Size = new Size(181, 27);
            nationalCodeTextBox.TabIndex = 5;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(358, 127);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(291, 39);
            registerButton.TabIndex = 6;
            registerButton.Text = "Sighn Up";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // studentRoleCheckBox
            // 
            studentRoleCheckBox.AutoSize = true;
            studentRoleCheckBox.Location = new Point(396, 50);
            studentRoleCheckBox.Name = "studentRoleCheckBox";
            studentRoleCheckBox.Size = new Size(82, 24);
            studentRoleCheckBox.TabIndex = 15;
            studentRoleCheckBox.Text = "Student";
            studentRoleCheckBox.UseVisualStyleBackColor = true;
            studentRoleCheckBox.CheckedChanged += studentRoleCheckBox_CheckedChanged;
            // 
            // masterRolecheckBox
            // 
            masterRolecheckBox.AutoSize = true;
            masterRolecheckBox.Location = new Point(396, 80);
            masterRolecheckBox.Name = "masterRolecheckBox";
            masterRolecheckBox.Size = new Size(76, 24);
            masterRolecheckBox.TabIndex = 16;
            masterRolecheckBox.Text = "Master";
            masterRolecheckBox.UseVisualStyleBackColor = true;
            masterRolecheckBox.CheckedChanged += masterRolecheckBox_CheckedChanged;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 382);
            Controls.Add(masterRolecheckBox);
            Controls.Add(studentRoleCheckBox);
            Controls.Add(registerButton);
            Controls.Add(nationalCodeTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(nationalCodeLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Name = "Users";
            Text = "Users";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label nationalCodeLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox nationalCodeTextBox;
        private Button registerButton;
        private CheckBox studentRoleCheckBox;
        private CheckBox masterRolecheckBox;
    }
}
