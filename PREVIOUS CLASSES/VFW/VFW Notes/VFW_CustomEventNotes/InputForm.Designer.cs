namespace VFW_CustomEventNotes
{
    partial class InputForm
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
            this.gboxInputForm = new System.Windows.Forms.GroupBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnCloseAndCopy = new System.Windows.Forms.Button();
            this.gboxInputForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxInputForm
            // 
            this.gboxInputForm.Controls.Add(this.btnCloseAndCopy);
            this.gboxInputForm.Controls.Add(this.txtAge);
            this.gboxInputForm.Controls.Add(this.lblAge);
            this.gboxInputForm.Controls.Add(this.txtLastName);
            this.gboxInputForm.Controls.Add(this.lblLastName);
            this.gboxInputForm.Controls.Add(this.txtFirstName);
            this.gboxInputForm.Controls.Add(this.lblFirstName);
            this.gboxInputForm.Location = new System.Drawing.Point(12, 12);
            this.gboxInputForm.Name = "gboxInputForm";
            this.gboxInputForm.Size = new System.Drawing.Size(308, 236);
            this.gboxInputForm.TabIndex = 1;
            this.gboxInputForm.TabStop = false;
            this.gboxInputForm.Text = "Data Input";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(90, 123);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(79, 20);
            this.txtAge.TabIndex = 5;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(24, 126);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(90, 84);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(179, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(24, 87);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(90, 44);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(179, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(24, 47);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // btnCloseAndCopy
            // 
            this.btnCloseAndCopy.Location = new System.Drawing.Point(73, 171);
            this.btnCloseAndCopy.Name = "btnCloseAndCopy";
            this.btnCloseAndCopy.Size = new System.Drawing.Size(177, 42);
            this.btnCloseAndCopy.TabIndex = 7;
            this.btnCloseAndCopy.Text = "Close and Copy";
            this.btnCloseAndCopy.UseVisualStyleBackColor = true;
            this.btnCloseAndCopy.Click += new System.EventHandler(this.BtnCloseAndCopy_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.gboxInputForm);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InputForm_FormClosed);
            this.gboxInputForm.ResumeLayout(false);
            this.gboxInputForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxInputForm;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnCloseAndCopy;
    }
}