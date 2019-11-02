namespace SkylarValerio_CE04
{
    partial class ListViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListViewForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnListViewClear = new System.Windows.Forms.ToolStripButton();
            this.listViewCharacters = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnListViewClear});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.toolStrip1.Size = new System.Drawing.Size(262, 45);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnListViewClear
            // 
            this.btnListViewClear.Image = ((System.Drawing.Image)(resources.GetObject("btnListViewClear.Image")));
            this.btnListViewClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListViewClear.Name = "btnListViewClear";
            this.btnListViewClear.Padding = new System.Windows.Forms.Padding(3);
            this.btnListViewClear.Size = new System.Drawing.Size(76, 42);
            this.btnListViewClear.Text = "Clear";
            this.btnListViewClear.Click += new System.EventHandler(this.btnListViewClear_Click);
            // 
            // listViewCharacters
            // 
            this.listViewCharacters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCharacters.HideSelection = false;
            this.listViewCharacters.LargeImageList = this.imageList1;
            this.listViewCharacters.Location = new System.Drawing.Point(2, 15);
            this.listViewCharacters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewCharacters.Name = "listViewCharacters";
            this.listViewCharacters.Size = new System.Drawing.Size(240, 236);
            this.listViewCharacters.SmallImageList = this.imageList1;
            this.listViewCharacters.TabIndex = 1;
            this.listViewCharacters.UseCompatibleStateImageBehavior = false;
            this.listViewCharacters.View = System.Windows.Forms.View.SmallIcon;
            this.listViewCharacters.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewCharacters_MouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pikachu.png");
            this.imageList1.Images.SetKeyName(1, "bulbasaur.png");
            this.imageList1.Images.SetKeyName(2, "charmander.png");
            this.imageList1.Images.SetKeyName(3, "squirtle.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewCharacters);
            this.groupBox1.Location = new System.Drawing.Point(11, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(244, 253);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // ListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 306);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character List";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnListViewClear;
        private System.Windows.Forms.ListView listViewCharacters;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}