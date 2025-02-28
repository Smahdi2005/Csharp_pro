namespace Student
{
    partial class MasterForm
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
            firstNameMastersLabel = new Label();
            lastNameMastersLabel = new Label();
            loginfirsnameMastersTextBox = new TextBox();
            loginlastNameMastersTextBox = new TextBox();
            loginMastersButton = new Button();
            nationalCodeMasterTextBox = new TextBox();
            nationalCodeMasterLabel = new Label();
            SuspendLayout();
            // 
            // firstNameMastersLabel
            // 
            firstNameMastersLabel.AutoSize = true;
            firstNameMastersLabel.Location = new Point(39, 75);
            firstNameMastersLabel.Name = "firstNameMastersLabel";
            firstNameMastersLabel.Size = new Size(76, 20);
            firstNameMastersLabel.TabIndex = 0;
            firstNameMastersLabel.Text = "FirstName";
            // 
            // lastNameMastersLabel
            // 
            lastNameMastersLabel.AutoSize = true;
            lastNameMastersLabel.Location = new Point(40, 131);
            lastNameMastersLabel.Name = "lastNameMastersLabel";
            lastNameMastersLabel.Size = new Size(75, 20);
            lastNameMastersLabel.TabIndex = 1;
            lastNameMastersLabel.Text = "LastName";
            // 
            // loginfirsnameMastersTextBox
            // 
            loginfirsnameMastersTextBox.Location = new Point(143, 72);
            loginfirsnameMastersTextBox.Name = "loginfirsnameMastersTextBox";
            loginfirsnameMastersTextBox.Size = new Size(189, 27);
            loginfirsnameMastersTextBox.TabIndex = 2;
            // 
            // loginlastNameMastersTextBox
            // 
            loginlastNameMastersTextBox.Location = new Point(143, 128);
            loginlastNameMastersTextBox.Name = "loginlastNameMastersTextBox";
            loginlastNameMastersTextBox.Size = new Size(189, 27);
            loginlastNameMastersTextBox.TabIndex = 3;
            // 
            // loginMastersButton
            // 
            loginMastersButton.Location = new Point(382, 89);
            loginMastersButton.Name = "loginMastersButton";
            loginMastersButton.Size = new Size(247, 51);
            loginMastersButton.TabIndex = 4;
            loginMastersButton.Text = "Login";
            loginMastersButton.UseVisualStyleBackColor = true;
            loginMastersButton.Click += loginMastersButton_Click;
            // 
            // nationalCodeMasterTextBox
            // 
            nationalCodeMasterTextBox.Location = new Point(142, 185);
            nationalCodeMasterTextBox.Name = "nationalCodeMasterTextBox";
            nationalCodeMasterTextBox.Size = new Size(190, 27);
            nationalCodeMasterTextBox.TabIndex = 5;
            // 
            // nationalCodeMasterLabel
            // 
            nationalCodeMasterLabel.AutoSize = true;
            nationalCodeMasterLabel.Location = new Point(40, 188);
            nationalCodeMasterLabel.Name = "nationalCodeMasterLabel";
            nationalCodeMasterLabel.Size = new Size(101, 20);
            nationalCodeMasterLabel.TabIndex = 6;
            nationalCodeMasterLabel.Text = "NationalCode";
            // 
            // MasterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 307);
            Controls.Add(nationalCodeMasterLabel);
            Controls.Add(nationalCodeMasterTextBox);
            Controls.Add(loginMastersButton);
            Controls.Add(loginlastNameMastersTextBox);
            Controls.Add(loginfirsnameMastersTextBox);
            Controls.Add(lastNameMastersLabel);
            Controls.Add(firstNameMastersLabel);
            Name = "MasterForm";
            Text = "Masters";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameMastersLabel;
        private Label lastNameMastersLabel;
        private TextBox loginfirsnameMastersTextBox;
        private TextBox loginlastNameMastersTextBox;
        private Button loginMastersButton;
        private TextBox nationalCodeMasterTextBox;
        private Label nationalCodeMasterLabel;
    }
}