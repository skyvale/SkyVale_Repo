namespace SkylarValerio_CE04
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClearForm1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddCharacter = new System.Windows.Forms.Button();
            this.txtObjectsCreated = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWindowsOpen = new System.Windows.Forms.TextBox();
            this.lbWindowsOpen = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.listToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDisplay,
            this.btnClearForm1});
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(62, 38);
            this.listToolStripMenuItem.Text = "List";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(324, 38);
            this.btnDisplay.Text = "Display";
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnClearForm1
            // 
            this.btnClearForm1.Name = "btnClearForm1";
            this.btnClearForm1.Size = new System.Drawing.Size(324, 38);
            this.btnClearForm1.Text = "Clear";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddCharacter);
            this.groupBox1.Controls.Add(this.txtObjectsCreated);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtWindowsOpen);
            this.groupBox1.Controls.Add(this.lbWindowsOpen);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 320);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnAddCharacter
            // 
            this.btnAddCharacter.Location = new System.Drawing.Point(145, 234);
            this.btnAddCharacter.Name = "btnAddCharacter";
            this.btnAddCharacter.Size = new System.Drawing.Size(192, 62);
            this.btnAddCharacter.TabIndex = 4;
            this.btnAddCharacter.Text = "Add Character";
            this.btnAddCharacter.UseVisualStyleBackColor = true;
            this.btnAddCharacter.Click += new System.EventHandler(this.btnAddCharacter_Click);
            // 
            // txtObjectsCreated
            // 
            this.txtObjectsCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtObjectsCreated.Location = new System.Drawing.Point(319, 135);
            this.txtObjectsCreated.Name = "txtObjectsCreated";
            this.txtObjectsCreated.ReadOnly = true;
            this.txtObjectsCreated.Size = new System.Drawing.Size(100, 56);
            this.txtObjectsCreated.TabIndex = 3;
            this.txtObjectsCreated.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(45, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Characters Created";
            // 
            // txtWindowsOpen
            // 
            this.txtWindowsOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtWindowsOpen.Location = new System.Drawing.Point(319, 42);
            this.txtWindowsOpen.Name = "txtWindowsOpen";
            this.txtWindowsOpen.ReadOnly = true;
            this.txtWindowsOpen.Size = new System.Drawing.Size(100, 56);
            this.txtWindowsOpen.TabIndex = 1;
            this.txtWindowsOpen.TabStop = false;
            // 
            // lbWindowsOpen
            // 
            this.lbWindowsOpen.AutoSize = true;
            this.lbWindowsOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbWindowsOpen.Location = new System.Drawing.Point(45, 60);
            this.lbWindowsOpen.Name = "lbWindowsOpen";
            this.lbWindowsOpen.Size = new System.Drawing.Size(197, 31);
            this.lbWindowsOpen.TabIndex = 0;
            this.lbWindowsOpen.Text = "Windows Open";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnDisplay;
        private System.Windows.Forms.ToolStripMenuItem btnClearForm1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtObjectsCreated;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWindowsOpen;
        private System.Windows.Forms.Label lbWindowsOpen;
        private System.Windows.Forms.Button btnAddCharacter;
    }
}

