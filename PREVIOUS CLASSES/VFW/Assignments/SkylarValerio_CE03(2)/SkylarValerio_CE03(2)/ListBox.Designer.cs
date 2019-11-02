namespace SkylarValerio_CE03_2_
{
    partial class ListBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBox));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripClearAll = new System.Windows.Forms.ToolStripButton();
            this.groupBoxListBox = new System.Windows.Forms.GroupBox();
            this.listBoxCharacters = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.groupBoxListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripClearAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.toolStrip1.Size = new System.Drawing.Size(228, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripClearAll
            // 
            this.toolStripClearAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripClearAll.Image")));
            this.toolStripClearAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripClearAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripClearAll.Name = "toolStripClearAll";
            this.toolStripClearAll.Size = new System.Drawing.Size(71, 22);
            this.toolStripClearAll.Text = "Clear All";
            this.toolStripClearAll.Click += new System.EventHandler(this.ToolStripClearAll_Click);
            // 
            // groupBoxListBox
            // 
            this.groupBoxListBox.Controls.Add(this.listBoxCharacters);
            this.groupBoxListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxListBox.Location = new System.Drawing.Point(0, 25);
            this.groupBoxListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxListBox.Name = "groupBoxListBox";
            this.groupBoxListBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxListBox.Size = new System.Drawing.Size(228, 283);
            this.groupBoxListBox.TabIndex = 2;
            this.groupBoxListBox.TabStop = false;
            // 
            // listBoxCharacters
            // 
            this.listBoxCharacters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCharacters.FormattingEnabled = true;
            this.listBoxCharacters.Location = new System.Drawing.Point(2, 15);
            this.listBoxCharacters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxCharacters.Name = "listBoxCharacters";
            this.listBoxCharacters.Size = new System.Drawing.Size(224, 266);
            this.listBoxCharacters.TabIndex = 0;
            this.listBoxCharacters.TabStop = false;
            this.listBoxCharacters.SelectedIndexChanged += new System.EventHandler(this.ListBoxCharacters_SelectedIndexChanged);
            // 
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 308);
            this.Controls.Add(this.groupBoxListBox);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListBox";
            this.Text = "ListBox";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListBox_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxListBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripClearAll;
        private System.Windows.Forms.GroupBox groupBoxListBox;
        private System.Windows.Forms.ListBox listBoxCharacters;
    }
}