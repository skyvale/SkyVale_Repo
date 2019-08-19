namespace SkylarValerio_CE02
{
    partial class FighterCount
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
            this.lblNightmareCount = new System.Windows.Forms.Label();
            this.lblDreamCount = new System.Windows.Forms.Label();
            this.txtNumNightmare = new System.Windows.Forms.TextBox();
            this.txtNumDream = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNightmareCount
            // 
            this.lblNightmareCount.AutoSize = true;
            this.lblNightmareCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNightmareCount.Location = new System.Drawing.Point(12, 22);
            this.lblNightmareCount.Name = "lblNightmareCount";
            this.lblNightmareCount.Size = new System.Drawing.Size(223, 25);
            this.lblNightmareCount.TabIndex = 0;
            this.lblNightmareCount.Text = "Fighters in Nightmare:";
            // 
            // lblDreamCount
            // 
            this.lblDreamCount.AutoSize = true;
            this.lblDreamCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDreamCount.Location = new System.Drawing.Point(12, 73);
            this.lblDreamCount.Name = "lblDreamCount";
            this.lblDreamCount.Size = new System.Drawing.Size(188, 25);
            this.lblDreamCount.TabIndex = 1;
            this.lblDreamCount.Text = "Fighters in Dream:";
            // 
            // txtNumNightmare
            // 
            this.txtNumNightmare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumNightmare.Location = new System.Drawing.Point(241, 16);
            this.txtNumNightmare.Name = "txtNumNightmare";
            this.txtNumNightmare.ReadOnly = true;
            this.txtNumNightmare.Size = new System.Drawing.Size(66, 31);
            this.txtNumNightmare.TabIndex = 2;
            this.txtNumNightmare.TabStop = false;
            // 
            // txtNumDream
            // 
            this.txtNumDream.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDream.Location = new System.Drawing.Point(241, 70);
            this.txtNumDream.Name = "txtNumDream";
            this.txtNumDream.ReadOnly = true;
            this.txtNumDream.Size = new System.Drawing.Size(66, 31);
            this.txtNumDream.TabIndex = 3;
            this.txtNumDream.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(157, 127);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 30);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // FighterCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 181);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNumDream);
            this.Controls.Add(this.txtNumNightmare);
            this.Controls.Add(this.lblDreamCount);
            this.Controls.Add(this.lblNightmareCount);
            this.Name = "FighterCount";
            this.Text = "FighterCount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNightmareCount;
        private System.Windows.Forms.Label lblDreamCount;
        private System.Windows.Forms.TextBox txtNumNightmare;
        private System.Windows.Forms.TextBox txtNumDream;
        private System.Windows.Forms.Button btnOK;
    }
}