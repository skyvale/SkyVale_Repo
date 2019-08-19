namespace SkylarValerio_CE04
{
    partial class MainForm
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
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNumOfWindows = new System.Windows.Forms.Label();
            this.txtWindows = new System.Windows.Forms.TextBox();
            this.txtObjects = new System.Windows.Forms.TextBox();
            this.lblNumOfObjects = new System.Windows.Forms.Label();
            this.btnOpenInputForm = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.listToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(247, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.listToolStripMenuItem.Text = "List";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayToolStripMenuItem.Text = "Display";
            this.displayToolStripMenuItem.Click += new System.EventHandler(this.DisplayToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // lblNumOfWindows
            // 
            this.lblNumOfWindows.AutoSize = true;
            this.lblNumOfWindows.Location = new System.Drawing.Point(13, 60);
            this.lblNumOfWindows.Name = "lblNumOfWindows";
            this.lblNumOfWindows.Size = new System.Drawing.Size(106, 13);
            this.lblNumOfWindows.TabIndex = 1;
            this.lblNumOfWindows.Text = "Number of Windows:";
            // 
            // txtWindows
            // 
            this.txtWindows.Location = new System.Drawing.Point(135, 57);
            this.txtWindows.Name = "txtWindows";
            this.txtWindows.ReadOnly = true;
            this.txtWindows.Size = new System.Drawing.Size(87, 20);
            this.txtWindows.TabIndex = 2;
            // 
            // txtObjects
            // 
            this.txtObjects.Location = new System.Drawing.Point(135, 97);
            this.txtObjects.Name = "txtObjects";
            this.txtObjects.ReadOnly = true;
            this.txtObjects.Size = new System.Drawing.Size(87, 20);
            this.txtObjects.TabIndex = 4;
            // 
            // lblNumOfObjects
            // 
            this.lblNumOfObjects.AutoSize = true;
            this.lblNumOfObjects.Location = new System.Drawing.Point(13, 100);
            this.lblNumOfObjects.Name = "lblNumOfObjects";
            this.lblNumOfObjects.Size = new System.Drawing.Size(98, 13);
            this.lblNumOfObjects.TabIndex = 3;
            this.lblNumOfObjects.Text = "Number of Objects:";
            // 
            // btnOpenInputForm
            // 
            this.btnOpenInputForm.Location = new System.Drawing.Point(49, 138);
            this.btnOpenInputForm.Name = "btnOpenInputForm";
            this.btnOpenInputForm.Size = new System.Drawing.Size(158, 29);
            this.btnOpenInputForm.TabIndex = 5;
            this.btnOpenInputForm.Text = "Open Input Form";
            this.btnOpenInputForm.UseVisualStyleBackColor = true;
            this.btnOpenInputForm.Click += new System.EventHandler(this.BtnOpenInputForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 189);
            this.Controls.Add(this.btnOpenInputForm);
            this.Controls.Add(this.txtObjects);
            this.Controls.Add(this.lblNumOfObjects);
            this.Controls.Add(this.txtWindows);
            this.Controls.Add(this.lblNumOfWindows);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Label lblNumOfWindows;
        private System.Windows.Forms.TextBox txtWindows;
        private System.Windows.Forms.TextBox txtObjects;
        private System.Windows.Forms.Label lblNumOfObjects;
        private System.Windows.Forms.Button btnOpenInputForm;
    }
}

