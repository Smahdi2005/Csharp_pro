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
            button1 = new Button();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(41, 36);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(76, 20);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "FirstName";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(41, 78);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(75, 20);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "LastName";
            lastNameLabel.Click += label1_Click;
            // 
            // nationalCodeLabel
            // 
            nationalCodeLabel.AutoSize = true;
            nationalCodeLabel.Location = new Point(41, 123);
            nationalCodeLabel.Name = "nationalCodeLabel";
            nationalCodeLabel.Size = new Size(101, 20);
            nationalCodeLabel.TabIndex = 2;
            nationalCodeLabel.Text = "NationalCode";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(151, 34);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(181, 27);
            firstNameTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(151, 75);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(181, 27);
            lastNameTextBox.TabIndex = 4;
            // 
            // nationalCodeTextBox
            // 
            nationalCodeTextBox.Location = new Point(151, 120);
            nationalCodeTextBox.Name = "nationalCodeTextBox";
            nationalCodeTextBox.Size = new Size(181, 27);
            nationalCodeTextBox.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(388, 69);
            button1.Name = "button1";
            button1.Size = new Size(291, 39);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(nationalCodeTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(nationalCodeLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Name = "Form1";
            Text = "Form1";
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
        private Button button1;
    }
}
