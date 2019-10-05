namespace VFW_Day4Notes
{
    partial class ListBoxForm
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
            this.SuspendLayout();
            // 
            // ListBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 285);
            this.Location = new System.Drawing.Point(700, 0);
            this.Name = "ListBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ListBoxForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListBoxForm_FormClosed);
            this.Load += new System.EventHandler(this.ListBoxForm_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxForm_MouseDoubleClick);
            this.ResumeLayout(false);

        }

        #endregion
    }
}