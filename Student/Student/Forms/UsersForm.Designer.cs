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
            usersFirstNameTextBox = new TextBox();
            usersLastNameTextBox = new TextBox();
            usersNationalCodeTextBox = new TextBox();
            registerButton = new Button();
            usersRoleTextBox = new TextBox();
            userRoleLabel = new Label();
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
            // usersFirstNameTextBox
            // 
            usersFirstNameTextBox.Location = new Point(140, 47);
            usersFirstNameTextBox.Name = "usersFirstNameTextBox";
            usersFirstNameTextBox.Size = new Size(181, 27);
            usersFirstNameTextBox.TabIndex = 3;
            // 
            // usersLastNameTextBox
            // 
            usersLastNameTextBox.Location = new Point(140, 88);
            usersLastNameTextBox.Name = "usersLastNameTextBox";
            usersLastNameTextBox.Size = new Size(181, 27);
            usersLastNameTextBox.TabIndex = 4;
            // 
            // usersNationalCodeTextBox
            // 
            usersNationalCodeTextBox.Location = new Point(140, 133);
            usersNationalCodeTextBox.Name = "usersNationalCodeTextBox";
            usersNationalCodeTextBox.Size = new Size(181, 27);
            usersNationalCodeTextBox.TabIndex = 5;
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
            // usersRoleTextBox
            // 
            usersRoleTextBox.Location = new Point(140, 184);
            usersRoleTextBox.Name = "usersRoleTextBox";
            usersRoleTextBox.Size = new Size(181, 27);
            usersRoleTextBox.TabIndex = 7;
            // 
            // userRoleLabel
            // 
            userRoleLabel.AutoSize = true;
            userRoleLabel.Location = new Point(29, 187);
            userRoleLabel.Name = "userRoleLabel";
            userRoleLabel.Size = new Size(39, 20);
            userRoleLabel.TabIndex = 8;
            userRoleLabel.Text = "Role";
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 382);
            Controls.Add(userRoleLabel);
            Controls.Add(usersRoleTextBox);
            Controls.Add(registerButton);
            Controls.Add(usersNationalCodeTextBox);
            Controls.Add(usersLastNameTextBox);
            Controls.Add(usersFirstNameTextBox);
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
        private TextBox usersFirstNameTextBox;
        private TextBox usersLastNameTextBox;
        private TextBox usersNationalCodeTextBox;
        private Button registerButton;
        private TextBox usersRoleTextBox;
        private Label userRoleLabel;
    }
}
