namespace university
{
    partial class StudentsChangePassword
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
            mobileNumberLabel = new Label();
            mobileNumberTextBox = new TextBox();
            newPasswordLabel = new Label();
            newPasswordTextBox = new TextBox();
            confirmNewPasswordLabel = new Label();
            confirmNewPasswordTextBox = new TextBox();
            changePasswordButton = new Button();
            SuspendLayout();
            // 
            // mobileNumberLabel
            // 
            mobileNumberLabel.AutoSize = true;
            mobileNumberLabel.Location = new Point(12, 27);
            mobileNumberLabel.Name = "mobileNumberLabel";
            mobileNumberLabel.Size = new Size(117, 20);
            mobileNumberLabel.TabIndex = 0;
            mobileNumberLabel.Text = "MobileNumber :";
            // 
            // mobileNumberTextBox
            // 
            mobileNumberTextBox.Location = new Point(135, 24);
            mobileNumberTextBox.Name = "mobileNumberTextBox";
            mobileNumberTextBox.Size = new Size(189, 27);
            mobileNumberTextBox.TabIndex = 1;
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Location = new Point(12, 91);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(115, 20);
            newPasswordLabel.TabIndex = 2;
            newPasswordLabel.Text = "New Password : ";
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Location = new Point(135, 88);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.Size = new Size(191, 27);
            newPasswordTextBox.TabIndex = 3;
            newPasswordTextBox.TextChanged += newPasswordTextBox_TextChanged;
            // 
            // confirmNewPasswordLabel
            // 
            confirmNewPasswordLabel.AutoSize = true;
            confirmNewPasswordLabel.Location = new Point(12, 149);
            confirmNewPasswordLabel.Name = "confirmNewPasswordLabel";
            confirmNewPasswordLabel.Size = new Size(168, 20);
            confirmNewPasswordLabel.TabIndex = 4;
            confirmNewPasswordLabel.Text = "Confirm New Password :";
            // 
            // confirmNewPasswordTextBox
            // 
            confirmNewPasswordTextBox.Location = new Point(199, 146);
            confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
            confirmNewPasswordTextBox.Size = new Size(125, 27);
            confirmNewPasswordTextBox.TabIndex = 5;
            // 
            // changePasswordButton
            // 
            changePasswordButton.Location = new Point(12, 194);
            changePasswordButton.Name = "changePasswordButton";
            changePasswordButton.Size = new Size(314, 61);
            changePasswordButton.TabIndex = 6;
            changePasswordButton.Text = "Change Password";
            changePasswordButton.UseVisualStyleBackColor = true;
            changePasswordButton.Click += changePasswordButton_Click;
            // 
            // StudentsChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 280);
            Controls.Add(changePasswordButton);
            Controls.Add(confirmNewPasswordTextBox);
            Controls.Add(confirmNewPasswordLabel);
            Controls.Add(newPasswordTextBox);
            Controls.Add(newPasswordLabel);
            Controls.Add(mobileNumberTextBox);
            Controls.Add(mobileNumberLabel);
            Name = "StudentsChangePassword";
            Text = "StudentsChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mobileNumberLabel;
        private TextBox mobileNumberTextBox;
        private Label newPasswordLabel;
        private TextBox newPasswordTextBox;
        private Label confirmNewPasswordLabel;
        private TextBox confirmNewPasswordTextBox;
        private Button changePasswordButton;
    }
}