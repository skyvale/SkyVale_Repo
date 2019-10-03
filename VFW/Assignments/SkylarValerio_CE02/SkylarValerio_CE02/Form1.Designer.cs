namespace SkylarValerio_CE02
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.listBoxGood = new System.Windows.Forms.ListBox();
            this.listBoxEvil = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblClan = new System.Windows.Forms.Label();
            this.cmBoxClan = new System.Windows.Forms.ComboBox();
            this.cmBoxRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.rdButtMale = new System.Windows.Forms.RadioButton();
            this.rdButtFemale = new System.Windows.Forms.RadioButton();
            this.chkFormer = new System.Windows.Forms.CheckBox();
            this.btnGood = new System.Windows.Forms.Button();
            this.btnEvil = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblGood = new System.Windows.Forms.Label();
            this.lblEvil = new System.Windows.Forms.Label();
            this.btnEviltoGood = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.statsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1774, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(321, 6);
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem});
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.statsToolStripMenuItem.Text = "Stats";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.btnClear);
            this.groupBoxInfo.Controls.Add(this.btnEvil);
            this.groupBoxInfo.Controls.Add(this.btnGood);
            this.groupBoxInfo.Controls.Add(this.chkFormer);
            this.groupBoxInfo.Controls.Add(this.rdButtFemale);
            this.groupBoxInfo.Controls.Add(this.rdButtMale);
            this.groupBoxInfo.Controls.Add(this.lblGender);
            this.groupBoxInfo.Controls.Add(this.cmBoxRole);
            this.groupBoxInfo.Controls.Add(this.lblRole);
            this.groupBoxInfo.Controls.Add(this.cmBoxClan);
            this.groupBoxInfo.Controls.Add(this.lblClan);
            this.groupBoxInfo.Controls.Add(this.txtName);
            this.groupBoxInfo.Controls.Add(this.lblName);
            this.groupBoxInfo.Location = new System.Drawing.Point(13, 53);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(584, 692);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Information";
            // 
            // listBoxGood
            // 
            this.listBoxGood.FormattingEnabled = true;
            this.listBoxGood.ItemHeight = 25;
            this.listBoxGood.Location = new System.Drawing.Point(619, 116);
            this.listBoxGood.Name = "listBoxGood";
            this.listBoxGood.Size = new System.Drawing.Size(506, 629);
            this.listBoxGood.TabIndex = 2;
            this.listBoxGood.TabStop = false;
            this.listBoxGood.Click += new System.EventHandler(this.listBoxGood_Click);
            // 
            // listBoxEvil
            // 
            this.listBoxEvil.FormattingEnabled = true;
            this.listBoxEvil.ItemHeight = 25;
            this.listBoxEvil.Location = new System.Drawing.Point(1247, 116);
            this.listBoxEvil.Name = "listBoxEvil";
            this.listBoxEvil.Size = new System.Drawing.Size(506, 629);
            this.listBoxEvil.TabIndex = 3;
            this.listBoxEvil.TabStop = false;
            this.listBoxEvil.Click += new System.EventHandler(this.listBoxEvil_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(40, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(154, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(276, 31);
            this.txtName.TabIndex = 1;
            // 
            // lblClan
            // 
            this.lblClan.AutoSize = true;
            this.lblClan.Location = new System.Drawing.Point(40, 206);
            this.lblClan.Name = "lblClan";
            this.lblClan.Size = new System.Drawing.Size(62, 25);
            this.lblClan.TabIndex = 2;
            this.lblClan.Text = "Clan:";
            // 
            // cmBoxClan
            // 
            this.cmBoxClan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxClan.FormattingEnabled = true;
            this.cmBoxClan.Items.AddRange(new object[] {
            "Thunderclan",
            "Riverclan",
            "Windclan",
            "Shadowclan"});
            this.cmBoxClan.Location = new System.Drawing.Point(154, 203);
            this.cmBoxClan.Name = "cmBoxClan";
            this.cmBoxClan.Size = new System.Drawing.Size(276, 33);
            this.cmBoxClan.TabIndex = 4;
            // 
            // cmBoxRole
            // 
            this.cmBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxRole.FormattingEnabled = true;
            this.cmBoxRole.Items.AddRange(new object[] {
            "Leader",
            "Deputy",
            "Medicine Cat",
            "Warrior",
            "Apprentice",
            "Queen",
            "Kit"});
            this.cmBoxRole.Location = new System.Drawing.Point(154, 284);
            this.cmBoxRole.Name = "cmBoxRole";
            this.cmBoxRole.Size = new System.Drawing.Size(276, 33);
            this.cmBoxRole.TabIndex = 5;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(40, 287);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(62, 25);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "Role:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(40, 133);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(89, 25);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender:";
            // 
            // rdButtMale
            // 
            this.rdButtMale.AutoSize = true;
            this.rdButtMale.Location = new System.Drawing.Point(154, 133);
            this.rdButtMale.Name = "rdButtMale";
            this.rdButtMale.Size = new System.Drawing.Size(90, 29);
            this.rdButtMale.TabIndex = 2;
            this.rdButtMale.TabStop = true;
            this.rdButtMale.Text = "Male";
            this.rdButtMale.UseVisualStyleBackColor = true;
            // 
            // rdButtFemale
            // 
            this.rdButtFemale.AutoSize = true;
            this.rdButtFemale.Location = new System.Drawing.Point(281, 133);
            this.rdButtFemale.Name = "rdButtFemale";
            this.rdButtFemale.Size = new System.Drawing.Size(114, 29);
            this.rdButtFemale.TabIndex = 3;
            this.rdButtFemale.TabStop = true;
            this.rdButtFemale.Text = "Female";
            this.rdButtFemale.UseVisualStyleBackColor = true;
            // 
            // chkFormer
            // 
            this.chkFormer.AutoSize = true;
            this.chkFormer.Location = new System.Drawing.Point(154, 371);
            this.chkFormer.Name = "chkFormer";
            this.chkFormer.Size = new System.Drawing.Size(296, 29);
            this.chkFormer.TabIndex = 6;
            this.chkFormer.Text = "Former Rogue or Kittypet?";
            this.chkFormer.UseVisualStyleBackColor = true;
            // 
            // btnGood
            // 
            this.btnGood.Location = new System.Drawing.Point(154, 451);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(276, 54);
            this.btnGood.TabIndex = 7;
            this.btnGood.Text = "Good";
            this.btnGood.UseVisualStyleBackColor = true;
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // btnEvil
            // 
            this.btnEvil.Location = new System.Drawing.Point(154, 551);
            this.btnEvil.Name = "btnEvil";
            this.btnEvil.Size = new System.Drawing.Size(276, 54);
            this.btnEvil.TabIndex = 8;
            this.btnEvil.Text = "Evil";
            this.btnEvil.UseVisualStyleBackColor = true;
            this.btnEvil.Click += new System.EventHandler(this.btnEvil_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(468, 629);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 47);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblGood
            // 
            this.lblGood.AutoSize = true;
            this.lblGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGood.Location = new System.Drawing.Point(817, 64);
            this.lblGood.Name = "lblGood";
            this.lblGood.Size = new System.Drawing.Size(96, 37);
            this.lblGood.TabIndex = 4;
            this.lblGood.Text = "Good";
            // 
            // lblEvil
            // 
            this.lblEvil.AutoSize = true;
            this.lblEvil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEvil.Location = new System.Drawing.Point(1461, 64);
            this.lblEvil.Name = "lblEvil";
            this.lblEvil.Size = new System.Drawing.Size(67, 37);
            this.lblEvil.TabIndex = 5;
            this.lblEvil.Text = "Evil";
            // 
            // btnEviltoGood
            // 
            this.btnEviltoGood.Location = new System.Drawing.Point(1151, 392);
            this.btnEviltoGood.Name = "btnEviltoGood";
            this.btnEviltoGood.Size = new System.Drawing.Size(75, 48);
            this.btnEviltoGood.TabIndex = 10;
            this.btnEviltoGood.Text = "<>";
            this.btnEviltoGood.UseVisualStyleBackColor = true;
            this.btnEviltoGood.Click += new System.EventHandler(this.btnEviltoGood_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1151, 683);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 46);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Del";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 768);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEviltoGood);
            this.Controls.Add(this.lblEvil);
            this.Controls.Add(this.lblGood);
            this.Controls.Add(this.listBoxEvil);
            this.Controls.Add(this.listBoxGood);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warriors";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEvil;
        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.CheckBox chkFormer;
        private System.Windows.Forms.RadioButton rdButtFemale;
        private System.Windows.Forms.RadioButton rdButtMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmBoxRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmBoxClan;
        private System.Windows.Forms.Label lblClan;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox listBoxGood;
        private System.Windows.Forms.ListBox listBoxEvil;
        private System.Windows.Forms.Label lblGood;
        private System.Windows.Forms.Label lblEvil;
        private System.Windows.Forms.Button btnEviltoGood;
        private System.Windows.Forms.Button btnDelete;
    }
}

