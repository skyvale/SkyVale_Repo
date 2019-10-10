namespace VFW_FancyCustomEvents
{
    partial class SelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdWarrior = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rdMage = new System.Windows.Forms.RadioButton();
            this.rdRogue = new System.Windows.Forms.RadioButton();
            this.rdPriest = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdPriest);
            this.groupBox1.Controls.Add(this.rdRogue);
            this.groupBox1.Controls.Add(this.rdMage);
            this.groupBox1.Controls.Add(this.rdWarrior);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 382);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Class";
            // 
            // rdWarrior
            // 
            this.rdWarrior.AutoSize = true;
            this.rdWarrior.ImageIndex = 0;
            this.rdWarrior.ImageList = this.imageList1;
            this.rdWarrior.Location = new System.Drawing.Point(59, 181);
            this.rdWarrior.Name = "rdWarrior";
            this.rdWarrior.Padding = new System.Windows.Forms.Padding(6);
            this.rdWarrior.Size = new System.Drawing.Size(157, 44);
            this.rdWarrior.TabIndex = 0;
            this.rdWarrior.TabStop = true;
            this.rdWarrior.Text = "Warrior";
            this.rdWarrior.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rdWarrior.UseVisualStyleBackColor = true;
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
            // rdMage
            // 
            this.rdMage.AutoSize = true;
            this.rdMage.ImageIndex = 2;
            this.rdMage.ImageList = this.imageList1;
            this.rdMage.Location = new System.Drawing.Point(59, 275);
            this.rdMage.Name = "rdMage";
            this.rdMage.Padding = new System.Windows.Forms.Padding(6);
            this.rdMage.Size = new System.Drawing.Size(141, 44);
            this.rdMage.TabIndex = 1;
            this.rdMage.TabStop = true;
            this.rdMage.Text = "Mage";
            this.rdMage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rdMage.UseVisualStyleBackColor = true;
            // 
            // rdRogue
            // 
            this.rdRogue.AutoSize = true;
            this.rdRogue.ImageIndex = 1;
            this.rdRogue.ImageList = this.imageList1;
            this.rdRogue.Location = new System.Drawing.Point(274, 181);
            this.rdRogue.Name = "rdRogue";
            this.rdRogue.Padding = new System.Windows.Forms.Padding(6);
            this.rdRogue.Size = new System.Drawing.Size(150, 44);
            this.rdRogue.TabIndex = 2;
            this.rdRogue.TabStop = true;
            this.rdRogue.Text = "Rogue";
            this.rdRogue.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rdRogue.UseVisualStyleBackColor = true;
            // 
            // rdPriest
            // 
            this.rdPriest.AutoSize = true;
            this.rdPriest.ImageIndex = 3;
            this.rdPriest.ImageList = this.imageList1;
            this.rdPriest.Location = new System.Drawing.Point(274, 275);
            this.rdPriest.Name = "rdPriest";
            this.rdPriest.Padding = new System.Windows.Forms.Padding(6);
            this.rdPriest.Size = new System.Drawing.Size(142, 44);
            this.rdPriest.TabIndex = 3;
            this.rdPriest.TabStop = true;
            this.rdPriest.Text = "Priest";
            this.rdPriest.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rdPriest.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(177, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 31);
            this.txtName.TabIndex = 5;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 382);
            this.Controls.Add(this.groupBox1);
            this.Name = "SelectionForm";
            this.Text = "SelectionForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectionForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdWarrior;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RadioButton rdPriest;
        private System.Windows.Forms.RadioButton rdRogue;
        private System.Windows.Forms.RadioButton rdMage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
    }
}