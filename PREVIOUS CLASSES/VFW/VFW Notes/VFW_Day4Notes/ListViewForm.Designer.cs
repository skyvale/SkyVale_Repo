namespace VFW_Day4Notes
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
            this.lvwCharacters = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lvwCharacters
            // 
            this.lvwCharacters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwCharacters.HideSelection = false;
            this.lvwCharacters.LargeImageList = this.imageList1;
            this.lvwCharacters.Location = new System.Drawing.Point(0, 0);
            this.lvwCharacters.Name = "lvwCharacters";
            this.lvwCharacters.Size = new System.Drawing.Size(269, 327);
            this.lvwCharacters.TabIndex = 0;
            this.lvwCharacters.UseCompatibleStateImageBehavior = false;
            this.lvwCharacters.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvwCharacters_MouseDoubleClick);
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
            // ListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 327);
            this.Controls.Add(this.lvwCharacters);
            this.Location = new System.Drawing.Point(350, 0);
            this.Name = "ListViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ListViewForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListViewForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwCharacters;
        private System.Windows.Forms.ImageList imageList1;
    }
}