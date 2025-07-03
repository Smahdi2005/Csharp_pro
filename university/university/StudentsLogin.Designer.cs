namespace university
{
    partial class StudentsLogin
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
            loginButton = new Button();
            passwordTextBox = new TextBox();
            userNameTextBox = new TextBox();
            passwordLabel = new Label();
            userNameLabel = new Label();
            changePasswordButton = new Button();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(22, 117);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(280, 52);
            loginButton.TabIndex = 9;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(114, 74);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(188, 27);
            passwordTextBox.TabIndex = 8;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(114, 22);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(188, 27);
            userNameTextBox.TabIndex = 7;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(22, 77);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Password";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(22, 22);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(78, 20);
            userNameLabel.TabIndex = 5;
            userNameLabel.Text = "UserName";
            // 
            // changePasswordButton
            // 
            changePasswordButton.Location = new Point(22, 189);
            changePasswordButton.Name = "changePasswordButton";
            changePasswordButton.Size = new Size(280, 52);
            changePasswordButton.TabIndex = 10;
            changePasswordButton.Text = "Change Password";
            changePasswordButton.UseVisualStyleBackColor = true;
            changePasswordButton.Click += changePasswordButton_Click;
            // 
            // StudentsLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 253);
            Controls.Add(changePasswordButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Name = "StudentsLogin";
            Text = "StudentsLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private TextBox passwordTextBox;
        private TextBox userNameTextBox;
        private Label passwordLabel;
        private Label userNameLabel;
        private Button changePasswordButton;
    }
}