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
            this.lvwCharacters = new System.Windows.Forms.ListView();
            this.imgListCharacter = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnClearAll = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwCharacters
            // 
            this.lvwCharacters.HideSelection = false;
            this.lvwCharacters.LargeImageList = this.imgListCharacter;
            this.lvwCharacters.Location = new System.Drawing.Point(0, 28);
            this.lvwCharacters.MultiSelect = false;
            this.lvwCharacters.Name = "lvwCharacters";
            this.lvwCharacters.Size = new System.Drawing.Size(308, 261);
            this.lvwCharacters.TabIndex = 0;
            this.lvwCharacters.UseCompatibleStateImageBehavior = false;
            this.lvwCharacters.SelectedIndexChanged += new System.EventHandler(this.LvwCharacters_SelectedIndexChanged);
            // 
            // imgListCharacter
            // 
            this.imgListCharacter.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListCharacter.ImageStream")));
            this.imgListCharacter.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListCharacter.Images.SetKeyName(0, "pikachu.png");
            this.imgListCharacter.Images.SetKeyName(1, "charmander.png");
            this.imgListCharacter.Images.SetKeyName(2, "squirtle.png");
            this.imgListCharacter.Images.SetKeyName(3, "bulbasaur.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClearAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(308, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Image = global::SkylarValerio_CE04.Properties.Resources.red_x;
            this.btnClearAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(71, 22);
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // ListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 287);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lvwCharacters);
            this.Name = "ListViewForm";
            this.Text = "ListViewForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwCharacters;
        private System.Windows.Forms.ImageList imgListCharacter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnClearAll;
    }
}