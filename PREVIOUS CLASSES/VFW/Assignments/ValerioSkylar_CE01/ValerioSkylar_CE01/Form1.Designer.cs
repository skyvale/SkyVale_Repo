namespace ValerioSkylar_CE01
{
    partial class Form1
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.radButMale = new System.Windows.Forms.RadioButton();
            this.radButFemale = new System.Windows.Forms.RadioButton();
            this.chkBoxEvil = new System.Windows.Forms.CheckBox();
            this.clrButton = new System.Windows.Forms.Button();
            this.comBoxSpecies = new System.Windows.Forms.ComboBox();
            this.menuStrip.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(546, 40);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnLoad,
            this.toolStripSeparator1,
            this.btnExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(324, 38);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(324, 38);
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(324, 38);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(321, 6);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.comBoxSpecies);
            this.groupBox.Controls.Add(this.clrButton);
            this.groupBox.Controls.Add(this.chkBoxEvil);
            this.groupBox.Controls.Add(this.radButFemale);
            this.groupBox.Controls.Add(this.radButMale);
            this.groupBox.Controls.Add(this.lblGender);
            this.groupBox.Controls.Add(this.lblSpecies);
            this.groupBox.Controls.Add(this.txtName);
            this.groupBox.Controls.Add(this.lblName);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 40);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(546, 358);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 31);
            this.txtName.TabIndex = 1;
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(48, 114);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(95, 25);
            this.lblSpecies.TabIndex = 2;
            this.lblSpecies.Text = "Species:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(48, 189);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(89, 25);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender:";
            // 
            // radButMale
            // 
            this.radButMale.AutoSize = true;
            this.radButMale.Location = new System.Drawing.Point(146, 189);
            this.radButMale.Name = "radButMale";
            this.radButMale.Size = new System.Drawing.Size(90, 29);
            this.radButMale.TabIndex = 3;
            this.radButMale.TabStop = true;
            this.radButMale.Text = "Male";
            this.radButMale.UseVisualStyleBackColor = true;
            // 
            // radButFemale
            // 
            this.radButFemale.AutoSize = true;
            this.radButFemale.Location = new System.Drawing.Point(260, 189);
            this.radButFemale.Name = "radButFemale";
            this.radButFemale.Size = new System.Drawing.Size(114, 29);
            this.radButFemale.TabIndex = 4;
            this.radButFemale.TabStop = true;
            this.radButFemale.Text = "Female";
            this.radButFemale.UseVisualStyleBackColor = true;
            // 
            // chkBoxEvil
            // 
            this.chkBoxEvil.AutoSize = true;
            this.chkBoxEvil.Location = new System.Drawing.Point(146, 264);
            this.chkBoxEvil.Name = "chkBoxEvil";
            this.chkBoxEvil.Size = new System.Drawing.Size(175, 29);
            this.chkBoxEvil.TabIndex = 5;
            this.chkBoxEvil.Text = "Are they evil?";
            this.chkBoxEvil.UseVisualStyleBackColor = true;
            // 
            // clrButton
            // 
            this.clrButton.Location = new System.Drawing.Point(412, 288);
            this.clrButton.Name = "clrButton";
            this.clrButton.Size = new System.Drawing.Size(113, 42);
            this.clrButton.TabIndex = 6;
            this.clrButton.Text = "Clear";
            this.clrButton.UseVisualStyleBackColor = true;
            this.clrButton.Click += new System.EventHandler(this.clrButton_Click);
            // 
            // comBoxSpecies
            // 
            this.comBoxSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSpecies.FormattingEnabled = true;
            this.comBoxSpecies.Items.AddRange(new object[] {
            "Human",
            "Demon",
            "Angel"});
            this.comBoxSpecies.Location = new System.Drawing.Point(150, 114);
            this.comBoxSpecies.Name = "comBoxSpecies";
            this.comBoxSpecies.Size = new System.Drawing.Size(228, 33);
            this.comBoxSpecies.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 398);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.menuStrip);
            this.Name = "Form1";
            this.Text = "Character Creator";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button clrButton;
        private System.Windows.Forms.CheckBox chkBoxEvil;
        private System.Windows.Forms.RadioButton radButFemale;
        private System.Windows.Forms.RadioButton radButMale;
        private System.Windows.Forms.ComboBox comBoxSpecies;
    }
}

