namespace SkylarValerio_CE02
{
    partial class Display
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
            this.lblGoodCount = new System.Windows.Forms.Label();
            this.txtGoodCount = new System.Windows.Forms.TextBox();
            this.txtEvilCount = new System.Windows.Forms.TextBox();
            this.lblEvilCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGoodCount
            // 
            this.lblGoodCount.AutoSize = true;
            this.lblGoodCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGoodCount.Location = new System.Drawing.Point(18, 24);
            this.lblGoodCount.Name = "lblGoodCount";
            this.lblGoodCount.Size = new System.Drawing.Size(53, 20);
            this.lblGoodCount.TabIndex = 0;
            this.lblGoodCount.Text = "Good:";
            // 
            // txtGoodCount
            // 
            this.txtGoodCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGoodCount.Location = new System.Drawing.Point(77, 21);
            this.txtGoodCount.Name = "txtGoodCount";
            this.txtGoodCount.ReadOnly = true;
            this.txtGoodCount.Size = new System.Drawing.Size(45, 26);
            this.txtGoodCount.TabIndex = 1;
            this.txtGoodCount.TabStop = false;
            // 
            // txtEvilCount
            // 
            this.txtEvilCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEvilCount.Location = new System.Drawing.Point(77, 65);
            this.txtEvilCount.Name = "txtEvilCount";
            this.txtEvilCount.ReadOnly = true;
            this.txtEvilCount.Size = new System.Drawing.Size(45, 26);
            this.txtEvilCount.TabIndex = 3;
            this.txtEvilCount.TabStop = false;
            // 
            // lblEvilCount
            // 
            this.lblEvilCount.AutoSize = true;
            this.lblEvilCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEvilCount.Location = new System.Drawing.Point(18, 68);
            this.lblEvilCount.Name = "lblEvilCount";
            this.lblEvilCount.Size = new System.Drawing.Size(37, 20);
            this.lblEvilCount.TabIndex = 2;
            this.lblEvilCount.Text = "Evil:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(31, 112);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(143, 153);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtEvilCount);
            this.Controls.Add(this.lblEvilCount);
            this.Controls.Add(this.txtGoodCount);
            this.Controls.Add(this.lblGoodCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Display";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGoodCount;
        private System.Windows.Forms.TextBox txtGoodCount;
        private System.Windows.Forms.TextBox txtEvilCount;
        private System.Windows.Forms.Label lblEvilCount;
        private System.Windows.Forms.Button btnClose;
    }
}