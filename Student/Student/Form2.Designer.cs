namespace Student
{
    partial class students
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
            loginFirstNamStudentsLabel = new Label();
            lastNameStudentsLabel = new Label();
            loginFirstNameStudentsTextBox = new TextBox();
            loginLastNameStudentsTextBox = new TextBox();
            loginStudentsButton = new Button();
            nationalCodeStudentsTextBox = new TextBox();
            loginNationalCodeStudentsLabel = new Label();
            SuspendLayout();
            // 
            // loginFirstNamStudentsLabel
            // 
            loginFirstNamStudentsLabel.AutoSize = true;
            loginFirstNamStudentsLabel.Location = new Point(40, 94);
            loginFirstNamStudentsLabel.Name = "loginFirstNamStudentsLabel";
            loginFirstNamStudentsLabel.Size = new Size(72, 20);
            loginFirstNamStudentsLabel.TabIndex = 0;
            loginFirstNamStudentsLabel.Text = "FrstName";
            // 
            // lastNameStudentsLabel
            // 
            lastNameStudentsLabel.AutoSize = true;
            lastNameStudentsLabel.Location = new Point(40, 143);
            lastNameStudentsLabel.Name = "lastNameStudentsLabel";
            lastNameStudentsLabel.Size = new Size(75, 20);
            lastNameStudentsLabel.TabIndex = 1;
            lastNameStudentsLabel.Text = "LastName";
            // 
            // loginFirstNameStudentsTextBox
            // 
            loginFirstNameStudentsTextBox.Location = new Point(152, 91);
            loginFirstNameStudentsTextBox.Name = "loginFirstNameStudentsTextBox";
            loginFirstNameStudentsTextBox.Size = new Size(169, 27);
            loginFirstNameStudentsTextBox.TabIndex = 2;
            // 
            // loginLastNameStudentsTextBox
            // 
            loginLastNameStudentsTextBox.Location = new Point(152, 140);
            loginLastNameStudentsTextBox.Name = "loginLastNameStudentsTextBox";
            loginLastNameStudentsTextBox.Size = new Size(169, 27);
            loginLastNameStudentsTextBox.TabIndex = 3;
            // 
            // loginStudentsButton
            // 
            loginStudentsButton.Location = new Point(361, 127);
            loginStudentsButton.Name = "loginStudentsButton";
            loginStudentsButton.Size = new Size(299, 53);
            loginStudentsButton.TabIndex = 4;
            loginStudentsButton.Text = "Login";
            loginStudentsButton.UseVisualStyleBackColor = true;
            // 
            // nationalCodeStudentsTextBox
            // 
            nationalCodeStudentsTextBox.Location = new Point(152, 188);
            nationalCodeStudentsTextBox.Name = "nationalCodeStudentsTextBox";
            nationalCodeStudentsTextBox.Size = new Size(169, 27);
            nationalCodeStudentsTextBox.TabIndex = 5;
            // 
            // loginNationalCodeStudentsLabel
            // 
            loginNationalCodeStudentsLabel.AutoSize = true;
            loginNationalCodeStudentsLabel.Location = new Point(40, 191);
            loginNationalCodeStudentsLabel.Name = "loginNationalCodeStudentsLabel";
            loginNationalCodeStudentsLabel.Size = new Size(101, 20);
            loginNationalCodeStudentsLabel.TabIndex = 6;
            loginNationalCodeStudentsLabel.Text = "NationalCode";
            // 
            // students
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 312);
            Controls.Add(loginNationalCodeStudentsLabel);
            Controls.Add(nationalCodeStudentsTextBox);
            Controls.Add(loginStudentsButton);
            Controls.Add(loginLastNameStudentsTextBox);
            Controls.Add(loginFirstNameStudentsTextBox);
            Controls.Add(lastNameStudentsLabel);
            Controls.Add(loginFirstNamStudentsLabel);
            Name = "students";
            Text = "Students";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginFirstNamStudentsLabel;
        private Label lastNameStudentsLabel;
        private TextBox loginFirstNameStudentsTextBox;
        private TextBox loginLastNameStudentsTextBox;
        private Button loginStudentsButton;
        private TextBox nationalCodeStudentsTextBox;
        private Label loginNationalCodeStudentsLabel;
    }
}