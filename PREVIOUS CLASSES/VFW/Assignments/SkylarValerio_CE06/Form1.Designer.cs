namespace SkylarValerio_CE06
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLeg = new System.Windows.Forms.TabPage();
            this.tabPageTotal = new System.Windows.Forms.TabPage();
            this.groupBoxLeg = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comDirection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numMiles = new System.Windows.Forms.NumericUpDown();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLegs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageLeg.SuspendLayout();
            this.tabPageTotal.SuspendLayout();
            this.groupBoxLeg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(469, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.toolStripSeparator1,
            this.btnExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnNew
            // 
            this.btnNew.Name = "btnNew";
            this.btnNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnNew.Size = new System.Drawing.Size(180, 22);
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLeg);
            this.tabControl1.Controls.Add(this.tabPageTotal);
            this.tabControl1.Location = new System.Drawing.Point(1, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(230, 250);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageLeg
            // 
            this.tabPageLeg.Controls.Add(this.btnAdd);
            this.tabPageLeg.Controls.Add(this.groupBoxLeg);
            this.tabPageLeg.Location = new System.Drawing.Point(4, 22);
            this.tabPageLeg.Name = "tabPageLeg";
            this.tabPageLeg.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLeg.Size = new System.Drawing.Size(222, 224);
            this.tabPageLeg.TabIndex = 0;
            this.tabPageLeg.Text = "Leg";
            this.tabPageLeg.UseVisualStyleBackColor = true;
            // 
            // tabPageTotal
            // 
            this.tabPageTotal.Controls.Add(this.txtLegs);
            this.tabPageTotal.Controls.Add(this.label7);
            this.tabPageTotal.Controls.Add(this.txtHours);
            this.tabPageTotal.Controls.Add(this.label6);
            this.tabPageTotal.Controls.Add(this.txtMiles);
            this.tabPageTotal.Controls.Add(this.label5);
            this.tabPageTotal.Location = new System.Drawing.Point(4, 22);
            this.tabPageTotal.Name = "tabPageTotal";
            this.tabPageTotal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTotal.Size = new System.Drawing.Size(222, 224);
            this.tabPageTotal.TabIndex = 1;
            this.tabPageTotal.Text = "Total";
            this.tabPageTotal.UseVisualStyleBackColor = true;
            // 
            // groupBoxLeg
            // 
            this.groupBoxLeg.Controls.Add(this.txtMode);
            this.groupBoxLeg.Controls.Add(this.label4);
            this.groupBoxLeg.Controls.Add(this.numHours);
            this.groupBoxLeg.Controls.Add(this.label3);
            this.groupBoxLeg.Controls.Add(this.numMiles);
            this.groupBoxLeg.Controls.Add(this.label2);
            this.groupBoxLeg.Controls.Add(this.comDirection);
            this.groupBoxLeg.Controls.Add(this.label1);
            this.groupBoxLeg.Location = new System.Drawing.Point(17, 16);
            this.groupBoxLeg.Name = "groupBoxLeg";
            this.groupBoxLeg.Size = new System.Drawing.Size(188, 153);
            this.groupBoxLeg.TabIndex = 0;
            this.groupBoxLeg.TabStop = false;
            this.groupBoxLeg.Text = "Leg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Direction";
            // 
            // comDirection
            // 
            this.comDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comDirection.FormattingEnabled = true;
            this.comDirection.Items.AddRange(new object[] {
            "--",
            "North",
            "East",
            "South",
            "West"});
            this.comDirection.Location = new System.Drawing.Point(70, 28);
            this.comDirection.Name = "comDirection";
            this.comDirection.Size = new System.Drawing.Size(88, 21);
            this.comDirection.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Miles";
            // 
            // numMiles
            // 
            this.numMiles.DecimalPlaces = 2;
            this.numMiles.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numMiles.Location = new System.Drawing.Point(70, 55);
            this.numMiles.Name = "numMiles";
            this.numMiles.Size = new System.Drawing.Size(88, 20);
            this.numMiles.TabIndex = 2;
            // 
            // numHours
            // 
            this.numHours.DecimalPlaces = 2;
            this.numHours.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numHours.Location = new System.Drawing.Point(70, 81);
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(88, 20);
            this.numHours.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mode";
            // 
            // txtMode
            // 
            this.txtMode.Location = new System.Drawing.Point(70, 110);
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(88, 20);
            this.txtMode.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(55, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 24);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Miles";
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(58, 15);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.ReadOnly = true;
            this.txtMiles.Size = new System.Drawing.Size(66, 20);
            this.txtMiles.TabIndex = 1;
            this.txtMiles.TabStop = false;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(58, 41);
            this.txtHours.Name = "txtHours";
            this.txtHours.ReadOnly = true;
            this.txtHours.Size = new System.Drawing.Size(66, 20);
            this.txtHours.TabIndex = 3;
            this.txtHours.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Hours";
            // 
            // txtLegs
            // 
            this.txtLegs.Location = new System.Drawing.Point(58, 67);
            this.txtLegs.Name = "txtLegs";
            this.txtLegs.ReadOnly = true;
            this.txtLegs.Size = new System.Drawing.Size(66, 20);
            this.txtLegs.TabIndex = 5;
            this.txtLegs.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Legs";
            // 
            // treeView
            // 
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList1;
            this.treeView.Location = new System.Drawing.Point(237, 28);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageKey = "select.png";
            this.treeView.Size = new System.Drawing.Size(228, 250);
            this.treeView.StateImageList = this.imageList1;
            this.treeView.TabIndex = 2;
            this.treeView.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "select.png");
            this.imageList1.Images.SetKeyName(1, "up.png");
            this.imageList1.Images.SetKeyName(2, "east.png");
            this.imageList1.Images.SetKeyName(3, "down.png");
            this.imageList1.Images.SetKeyName(4, "west.png");
            this.imageList1.Images.SetKeyName(5, "hours.png");
            this.imageList1.Images.SetKeyName(6, "miles.png");
            this.imageList1.Images.SetKeyName(7, "mode.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 284);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Planner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageLeg.ResumeLayout(false);
            this.tabPageTotal.ResumeLayout(false);
            this.tabPageTotal.PerformLayout();
            this.groupBoxLeg.ResumeLayout(false);
            this.groupBoxLeg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLeg;
        private System.Windows.Forms.GroupBox groupBoxLeg;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comDirection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageTotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtLegs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ImageList imageList1;
    }
}

