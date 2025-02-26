namespace Student
{
    partial class Form1
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
            loginFirstNameLabel = new Label();
            loginLastNameLabel = new Label();
            loginFirstNameTextBox = new TextBox();
            loginLastNameTextBox = new TextBox();
            loginButton = new Button();
            showLabel = new Label();
            showerorLabel = new Label();
            showRegisterLabel = new Label();
            studentRoleCheckBox = new CheckBox();
            masterRolecheckBox = new CheckBox();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(48, 166);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(76, 20);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "FirstName";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(48, 208);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(75, 20);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "LastName";
            lastNameLabel.Click += label1_Click;
            // 
            // nationalCodeLabel
            // 
            nationalCodeLabel.AutoSize = true;
            nationalCodeLabel.Location = new Point(48, 253);
            nationalCodeLabel.Name = "nationalCodeLabel";
            nationalCodeLabel.Size = new Size(101, 20);
            nationalCodeLabel.TabIndex = 2;
            nationalCodeLabel.Text = "NationalCode";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(159, 163);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(181, 27);
            firstNameTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(159, 204);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(181, 27);
            lastNameTextBox.TabIndex = 4;
            // 
            // nationalCodeTextBox
            // 
            nationalCodeTextBox.Location = new Point(159, 249);
            nationalCodeTextBox.Name = "nationalCodeTextBox";
            nationalCodeTextBox.Size = new Size(181, 27);
            nationalCodeTextBox.TabIndex = 5;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(396, 204);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(291, 39);
            registerButton.TabIndex = 6;
            registerButton.Text = "Sighn Up";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // loginFirstNameLabel
            // 
            loginFirstNameLabel.AutoSize = true;
            loginFirstNameLabel.Location = new Point(48, 339);
            loginFirstNameLabel.Name = "loginFirstNameLabel";
            loginFirstNameLabel.Size = new Size(76, 20);
            loginFirstNameLabel.TabIndex = 7;
            loginFirstNameLabel.Text = "FirstName";
            // 
            // loginLastNameLabel
            // 
            loginLastNameLabel.AutoSize = true;
            loginLastNameLabel.Location = new Point(49, 384);
            loginLastNameLabel.Name = "loginLastNameLabel";
            loginLastNameLabel.Size = new Size(75, 20);
            loginLastNameLabel.TabIndex = 8;
            loginLastNameLabel.Text = "LastName";
            // 
            // loginFirstNameTextBox
            // 
            loginFirstNameTextBox.Location = new Point(159, 336);
            loginFirstNameTextBox.Name = "loginFirstNameTextBox";
            loginFirstNameTextBox.Size = new Size(181, 27);
            loginFirstNameTextBox.TabIndex = 9;
            // 
            // loginLastNameTextBox
            // 
            loginLastNameTextBox.Location = new Point(159, 381);
            loginLastNameTextBox.Name = "loginLastNameTextBox";
            loginLastNameTextBox.Size = new Size(181, 27);
            loginLastNameTextBox.TabIndex = 10;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(396, 354);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(291, 39);
            loginButton.TabIndex = 11;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // showLabel
            // 
            showLabel.AutoSize = true;
            showLabel.Location = new Point(532, 415);
            showLabel.Name = "showLabel";
            showLabel.Size = new Size(9, 20);
            showLabel.TabIndex = 12;
            showLabel.Text = "\r\n";
            // 
            // showerorLabel
            // 
            showerorLabel.AutoSize = true;
            showerorLabel.Location = new Point(532, 435);
            showerorLabel.Name = "showerorLabel";
            showerorLabel.Size = new Size(0, 20);
            showerorLabel.TabIndex = 13;
            // 
            // showRegisterLabel
            // 
            showRegisterLabel.AutoSize = true;
            showRegisterLabel.Location = new Point(541, 255);
            showRegisterLabel.Name = "showRegisterLabel";
            showRegisterLabel.Size = new Size(0, 20);
            showRegisterLabel.TabIndex = 14;
            // 
            // studentRoleCheckBox
            // 
            studentRoleCheckBox.AutoSize = true;
            studentRoleCheckBox.Location = new Point(48, 43);
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
            masterRolecheckBox.Location = new Point(48, 73);
            masterRolecheckBox.Name = "masterRolecheckBox";
            masterRolecheckBox.Size = new Size(76, 24);
            masterRolecheckBox.TabIndex = 16;
            masterRolecheckBox.Text = "Master";
            masterRolecheckBox.UseVisualStyleBackColor = true;
            masterRolecheckBox.CheckedChanged += masterRolecheckBox_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 505);
            Controls.Add(masterRolecheckBox);
            Controls.Add(studentRoleCheckBox);
            Controls.Add(showRegisterLabel);
            Controls.Add(showerorLabel);
            Controls.Add(showLabel);
            Controls.Add(loginButton);
            Controls.Add(loginLastNameTextBox);
            Controls.Add(loginFirstNameTextBox);
            Controls.Add(loginLastNameLabel);
            Controls.Add(loginFirstNameLabel);
            Controls.Add(registerButton);
            Controls.Add(nationalCodeTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(nationalCodeLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Name = "Form1";
            Text = "Form1";
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
        private Label loginFirstNameLabel;
        private Label loginLastNameLabel;
        private TextBox loginFirstNameTextBox;
        private TextBox loginLastNameTextBox;
        private Button loginButton;
        private Label showLabel;
        private Label showerorLabel;
        private Label showRegisterLabel;
        private CheckBox studentRoleCheckBox;
        private CheckBox masterRolecheckBox;
    }
}
