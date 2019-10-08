namespace VFW_ListViewNotes
{
    partial class ListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListView));
            this.listViewParty = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listViewParty
            // 
            this.listViewParty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewParty.LargeImageList = this.imageList1;
            this.listViewParty.Location = new System.Drawing.Point(0, 0);
            this.listViewParty.Name = "listViewParty";
            this.listViewParty.Size = new System.Drawing.Size(474, 586);
            this.listViewParty.TabIndex = 0;
            this.listViewParty.UseCompatibleStateImageBehavior = false;
            this.listViewParty.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "warrior.png");
            this.imageList1.Images.SetKeyName(1, "rogue.png");
            this.imageList1.Images.SetKeyName(2, "mage.png");
            this.imageList1.Images.SetKeyName(3, "priest.png");
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 586);
            this.Controls.Add(this.listViewParty);
            this.Name = "ListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListView_FormClosed);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseDoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewParty;
        private System.Windows.Forms.ImageList imageList1;
    }
}