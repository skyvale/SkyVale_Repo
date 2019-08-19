namespace SkylarValerio_CE02
{
    partial class ArtFight_2019
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
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxInfo = new System.Windows.Forms.GroupBox();
            this.btnNightmare = new System.Windows.Forms.Button();
            this.btnDream = new System.Windows.Forms.Button();
            this.lblTeamChoose = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comBoxPreferredMedium = new System.Windows.Forms.ComboBox();
            this.chkProfessionalArtist = new System.Windows.Forms.CheckBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.grpBoxLists = new System.Windows.Forms.GroupBox();
            this.btnRemoveFighter = new System.Windows.Forms.Button();
            this.btnSwitchToNightmare = new System.Windows.Forms.Button();
            this.btnSwitchToDream = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listTeamDream = new System.Windows.Forms.ListBox();
            this.listTeamNightmare = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpBoxInfo.SuspendLayout();
            this.grpBoxLists.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(876, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.statsToolStripMenuItem.Text = "Stats";
            this.statsToolStripMenuItem.Click += new System.EventHandler(this.StatsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(96, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // grpBoxInfo
            // 
            this.grpBoxInfo.Controls.Add(this.btnClear);
            this.grpBoxInfo.Controls.Add(this.btnNightmare);
            this.grpBoxInfo.Controls.Add(this.btnDream);
            this.grpBoxInfo.Controls.Add(this.lblTeamChoose);
            this.grpBoxInfo.Controls.Add(this.label3);
            this.grpBoxInfo.Controls.Add(this.comBoxPreferredMedium);
            this.grpBoxInfo.Controls.Add(this.chkProfessionalArtist);
            this.grpBoxInfo.Controls.Add(this.lblPassword);
            this.grpBoxInfo.Controls.Add(this.txtPassword);
            this.grpBoxInfo.Controls.Add(this.lblUsername);
            this.grpBoxInfo.Controls.Add(this.txtUserName);
            this.grpBoxInfo.Location = new System.Drawing.Point(15, 33);
            this.grpBoxInfo.Name = "grpBoxInfo";
            this.grpBoxInfo.Size = new System.Drawing.Size(274, 406);
            this.grpBoxInfo.TabIndex = 1;
            this.grpBoxInfo.TabStop = false;
            this.grpBoxInfo.Text = "Info";
            // 
            // btnNightmare
            // 
            this.btnNightmare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNightmare.Location = new System.Drawing.Point(87, 265);
            this.btnNightmare.Name = "btnNightmare";
            this.btnNightmare.Size = new System.Drawing.Size(103, 32);
            this.btnNightmare.TabIndex = 5;
            this.btnNightmare.Text = "Nightmare";
            this.btnNightmare.UseVisualStyleBackColor = true;
            this.btnNightmare.Click += new System.EventHandler(this.BtnNightmare_Click);
            // 
            // btnDream
            // 
            this.btnDream.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDream.Location = new System.Drawing.Point(87, 326);
            this.btnDream.Name = "btnDream";
            this.btnDream.Size = new System.Drawing.Size(103, 31);
            this.btnDream.TabIndex = 4;
            this.btnDream.Text = "Dream";
            this.btnDream.UseVisualStyleBackColor = true;
            this.btnDream.Click += new System.EventHandler(this.BtnDream_Click);
            // 
            // lblTeamChoose
            // 
            this.lblTeamChoose.AutoSize = true;
            this.lblTeamChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamChoose.Location = new System.Drawing.Point(56, 225);
            this.lblTeamChoose.Name = "lblTeamChoose";
            this.lblTeamChoose.Size = new System.Drawing.Size(169, 24);
            this.lblTeamChoose.TabIndex = 6;
            this.lblTeamChoose.Text = "Choose your team!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "What is your preferred medium?";
            // 
            // comBoxPreferredMedium
            // 
            this.comBoxPreferredMedium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxPreferredMedium.FormattingEnabled = true;
            this.comBoxPreferredMedium.Items.AddRange(new object[] {
            "Traditional",
            "Digital"});
            this.comBoxPreferredMedium.Location = new System.Drawing.Point(10, 186);
            this.comBoxPreferredMedium.Name = "comBoxPreferredMedium";
            this.comBoxPreferredMedium.Size = new System.Drawing.Size(180, 21);
            this.comBoxPreferredMedium.TabIndex = 3;
            // 
            // chkProfessionalArtist
            // 
            this.chkProfessionalArtist.AutoSize = true;
            this.chkProfessionalArtist.Location = new System.Drawing.Point(74, 119);
            this.chkProfessionalArtist.Name = "chkProfessionalArtist";
            this.chkProfessionalArtist.Size = new System.Drawing.Size(139, 17);
            this.chkProfessionalArtist.TabIndex = 2;
            this.chkProfessionalArtist.Text = "I am a professional artist";
            this.chkProfessionalArtist.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(7, 80);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(74, 77);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(190, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(7, 41);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(74, 38);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(190, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // grpBoxLists
            // 
            this.grpBoxLists.Controls.Add(this.btnRemoveFighter);
            this.grpBoxLists.Controls.Add(this.btnSwitchToNightmare);
            this.grpBoxLists.Controls.Add(this.btnSwitchToDream);
            this.grpBoxLists.Controls.Add(this.label2);
            this.grpBoxLists.Controls.Add(this.label1);
            this.grpBoxLists.Controls.Add(this.listTeamDream);
            this.grpBoxLists.Controls.Add(this.listTeamNightmare);
            this.grpBoxLists.Location = new System.Drawing.Point(300, 32);
            this.grpBoxLists.Name = "grpBoxLists";
            this.grpBoxLists.Size = new System.Drawing.Size(564, 406);
            this.grpBoxLists.TabIndex = 2;
            this.grpBoxLists.TabStop = false;
            this.grpBoxLists.Text = "Teams";
            // 
            // btnRemoveFighter
            // 
            this.btnRemoveFighter.Location = new System.Drawing.Point(213, 364);
            this.btnRemoveFighter.Name = "btnRemoveFighter";
            this.btnRemoveFighter.Size = new System.Drawing.Size(144, 23);
            this.btnRemoveFighter.TabIndex = 6;
            this.btnRemoveFighter.Text = "Remove Fighter";
            this.btnRemoveFighter.UseVisualStyleBackColor = true;
            this.btnRemoveFighter.Click += new System.EventHandler(this.BtnRemoveFighter_Click);
            // 
            // btnSwitchToNightmare
            // 
            this.btnSwitchToNightmare.Location = new System.Drawing.Point(264, 219);
            this.btnSwitchToNightmare.Name = "btnSwitchToNightmare";
            this.btnSwitchToNightmare.Size = new System.Drawing.Size(31, 28);
            this.btnSwitchToNightmare.TabIndex = 5;
            this.btnSwitchToNightmare.Text = "<";
            this.btnSwitchToNightmare.UseVisualStyleBackColor = true;
            this.btnSwitchToNightmare.Click += new System.EventHandler(this.BtnSwitchToNightmare_Click);
            // 
            // btnSwitchToDream
            // 
            this.btnSwitchToDream.Location = new System.Drawing.Point(264, 171);
            this.btnSwitchToDream.Name = "btnSwitchToDream";
            this.btnSwitchToDream.Size = new System.Drawing.Size(31, 28);
            this.btnSwitchToDream.TabIndex = 4;
            this.btnSwitchToDream.Text = ">";
            this.btnSwitchToDream.UseVisualStyleBackColor = true;
            this.btnSwitchToDream.Click += new System.EventHandler(this.BtnSwitchToDream_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dream";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nightmare";
            // 
            // listTeamDream
            // 
            this.listTeamDream.FormattingEnabled = true;
            this.listTeamDream.Location = new System.Drawing.Point(319, 68);
            this.listTeamDream.Name = "listTeamDream";
            this.listTeamDream.Size = new System.Drawing.Size(219, 290);
            this.listTeamDream.TabIndex = 1;
            this.listTeamDream.SelectedIndexChanged += new System.EventHandler(this.listTeamDream_SelectedIndexChanged);
            // 
            // listTeamNightmare
            // 
            this.listTeamNightmare.FormattingEnabled = true;
            this.listTeamNightmare.Location = new System.Drawing.Point(23, 68);
            this.listTeamNightmare.Name = "listTeamNightmare";
            this.listTeamNightmare.Size = new System.Drawing.Size(219, 290);
            this.listTeamNightmare.TabIndex = 0;
            this.listTeamNightmare.SelectedIndexChanged += new System.EventHandler(this.listTeamNightmare_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(203, 379);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(61, 21);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // ArtFight_2019
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 460);
            this.Controls.Add(this.grpBoxLists);
            this.Controls.Add(this.grpBoxInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ArtFight_2019";
            this.Text = "Art Fight 2019";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBoxInfo.ResumeLayout(false);
            this.grpBoxInfo.PerformLayout();
            this.grpBoxLists.ResumeLayout(false);
            this.grpBoxLists.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBoxInfo;
        private System.Windows.Forms.GroupBox grpBoxLists;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listTeamDream;
        private System.Windows.Forms.ListBox listTeamNightmare;
        private System.Windows.Forms.Button btnNightmare;
        private System.Windows.Forms.Button btnDream;
        private System.Windows.Forms.Label lblTeamChoose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBoxPreferredMedium;
        private System.Windows.Forms.CheckBox chkProfessionalArtist;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnSwitchToNightmare;
        private System.Windows.Forms.Button btnSwitchToDream;
        private System.Windows.Forms.Button btnRemoveFighter;
        private System.Windows.Forms.Button btnClear;
    }
}

