namespace ValerioSkylar_CE09
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
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butEnd = new System.Windows.Forms.Button();
            this.butStart = new System.Windows.Forms.Button();
            this.butNext = new System.Windows.Forms.Button();
            this.butBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numRetailPrice = new System.Windows.Forms.NumericUpDown();
            this.lbReleaseDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRetailPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.toolStripSeparator1,
            this.btnExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSave.Size = new System.Drawing.Size(324, 38);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.btnExit.Size = new System.Drawing.Size(245, 38);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.butEnd);
            this.groupBox1.Controls.Add(this.butStart);
            this.groupBox1.Controls.Add(this.butNext);
            this.groupBox1.Controls.Add(this.butBack);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numRetailPrice);
            this.groupBox1.Controls.Add(this.lbReleaseDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtStudio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 641);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // butEnd
            // 
            this.butEnd.Location = new System.Drawing.Point(342, 564);
            this.butEnd.Name = "butEnd";
            this.butEnd.Size = new System.Drawing.Size(259, 61);
            this.butEnd.TabIndex = 11;
            this.butEnd.Text = "End";
            this.butEnd.UseVisualStyleBackColor = true;
            this.butEnd.Click += new System.EventHandler(this.butEnd_Click);
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(52, 564);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(259, 61);
            this.butStart.TabIndex = 10;
            this.butStart.Text = "Start";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // butNext
            // 
            this.butNext.Location = new System.Drawing.Point(342, 467);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(259, 61);
            this.butNext.TabIndex = 9;
            this.butNext.Text = "Next";
            this.butNext.UseVisualStyleBackColor = true;
            this.butNext.Click += new System.EventHandler(this.butNext_Click);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(52, 467);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(259, 61);
            this.butBack.TabIndex = 8;
            this.butBack.Text = "Back";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Retail Price:";
            // 
            // numRetailPrice
            // 
            this.numRetailPrice.DecimalPlaces = 2;
            this.numRetailPrice.Location = new System.Drawing.Point(258, 350);
            this.numRetailPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRetailPrice.Name = "numRetailPrice";
            this.numRetailPrice.ReadOnly = true;
            this.numRetailPrice.Size = new System.Drawing.Size(178, 31);
            this.numRetailPrice.TabIndex = 6;
            this.numRetailPrice.TabStop = false;
            // 
            // lbReleaseDate
            // 
            this.lbReleaseDate.AutoSize = true;
            this.lbReleaseDate.Location = new System.Drawing.Point(226, 256);
            this.lbReleaseDate.Name = "lbReleaseDate";
            this.lbReleaseDate.Size = new System.Drawing.Size(26, 25);
            this.lbReleaseDate.TabIndex = 5;
            this.lbReleaseDate.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Release Date:";
            // 
            // txtStudio
            // 
            this.txtStudio.Location = new System.Drawing.Point(167, 153);
            this.txtStudio.Name = "txtStudio";
            this.txtStudio.ReadOnly = true;
            this.txtStudio.Size = new System.Drawing.Size(434, 31);
            this.txtStudio.TabIndex = 3;
            this.txtStudio.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Studio:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(167, 64);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(434, 31);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 696);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Connectivity";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRetailPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStudio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbReleaseDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numRetailPrice;
        private System.Windows.Forms.Button butEnd;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Button butNext;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Label label4;
    }
}

