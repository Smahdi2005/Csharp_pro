namespace university
{
    partial class Login
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
            userNameLabel = new Label();
            passwordLabel = new Label();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(12, 27);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(78, 20);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "UserName";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(12, 82);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(104, 27);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(188, 27);
            userNameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(104, 79);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(188, 27);
            passwordTextBox.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(12, 122);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(280, 52);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 192);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameLabel;
        private Label passwordLabel;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
    }
}
