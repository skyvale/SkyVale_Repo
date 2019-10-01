namespace SkylarValerio_CE01
{
    partial class usersForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.userInputsGroupBox = new System.Windows.Forms.GroupBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.studentCheckbox = new System.Windows.Forms.CheckBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip.SuspendLayout();
            this.userInputsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuButton});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(426, 40);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenuButton
            // 
            this.fileMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMenuButton,
            this.saveMenuButton,
            this.exitMenuButton});
            this.fileMenuButton.Name = "fileMenuButton";
            this.fileMenuButton.Size = new System.Drawing.Size(64, 36);
            this.fileMenuButton.Text = "File";
            // 
            // loadMenuButton
            // 
            this.loadMenuButton.Name = "loadMenuButton";
            this.loadMenuButton.Size = new System.Drawing.Size(165, 38);
            this.loadMenuButton.Text = "Load";
            this.loadMenuButton.Click += new System.EventHandler(this.loadMenuButton_Click);
            // 
            // saveMenuButton
            // 
            this.saveMenuButton.Name = "saveMenuButton";
            this.saveMenuButton.Size = new System.Drawing.Size(165, 38);
            this.saveMenuButton.Text = "Save";
            this.saveMenuButton.Click += new System.EventHandler(this.saveMenuButton_Click);
            // 
            // exitMenuButton
            // 
            this.exitMenuButton.Name = "exitMenuButton";
            this.exitMenuButton.Size = new System.Drawing.Size(165, 38);
            this.exitMenuButton.Text = "Exit";
            this.exitMenuButton.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // userInputsGroupBox
            // 
            this.userInputsGroupBox.Controls.Add(this.genderComboBox);
            this.userInputsGroupBox.Controls.Add(this.resetButton);
            this.userInputsGroupBox.Controls.Add(this.studentCheckbox);
            this.userInputsGroupBox.Controls.Add(this.genderLabel);
            this.userInputsGroupBox.Controls.Add(this.passwordLabel);
            this.userInputsGroupBox.Controls.Add(this.passwordTextBox);
            this.userInputsGroupBox.Controls.Add(this.usernameLabel);
            this.userInputsGroupBox.Controls.Add(this.usernameTextBox);
            this.userInputsGroupBox.Location = new System.Drawing.Point(13, 44);
            this.userInputsGroupBox.Name = "userInputsGroupBox";
            this.userInputsGroupBox.Size = new System.Drawing.Size(400, 472);
            this.userInputsGroupBox.TabIndex = 1;
            this.userInputsGroupBox.TabStop = false;
            this.userInputsGroupBox.Text = "User Inputs";
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(143, 279);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(202, 33);
            this.genderComboBox.TabIndex = 3;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(270, 400);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(104, 43);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // studentCheckbox
            // 
            this.studentCheckbox.AutoSize = true;
            this.studentCheckbox.Location = new System.Drawing.Point(143, 115);
            this.studentCheckbox.Name = "studentCheckbox";
            this.studentCheckbox.Size = new System.Drawing.Size(130, 29);
            this.studentCheckbox.TabIndex = 1;
            this.studentCheckbox.Text = "Student?";
            this.studentCheckbox.UseVisualStyleBackColor = true;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(20, 282);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(83, 25);
            this.genderLabel.TabIndex = 5;
            this.genderLabel.Text = "Gender";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(20, 193);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(106, 25);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(143, 187);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(202, 31);
            this.passwordTextBox.TabIndex = 2;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(20, 73);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(110, 25);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(143, 67);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(202, 31);
            this.usernameTextBox.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // usersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 534);
            this.Controls.Add(this.userInputsGroupBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "usersForm";
            this.Text = "Users Form";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.userInputsGroupBox.ResumeLayout(false);
            this.userInputsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuButton;
        private System.Windows.Forms.ToolStripMenuItem loadMenuButton;
        private System.Windows.Forms.ToolStripMenuItem saveMenuButton;
        private System.Windows.Forms.ToolStripMenuItem exitMenuButton;
        private System.Windows.Forms.GroupBox userInputsGroupBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.CheckBox studentCheckbox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ComboBox genderComboBox;
    }
}

