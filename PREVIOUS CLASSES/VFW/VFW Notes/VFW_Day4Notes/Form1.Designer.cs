namespace VFW_Day4Notes
{
    partial class DataEntryForm
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
            this.grpBoxInformation = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.chkImmortal = new System.Windows.Forms.CheckBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.grpBoxInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxInformation
            // 
            this.grpBoxInformation.Controls.Add(this.cmbClass);
            this.grpBoxInformation.Controls.Add(this.cmbGender);
            this.grpBoxInformation.Controls.Add(this.numAge);
            this.grpBoxInformation.Controls.Add(this.btnClear);
            this.grpBoxInformation.Controls.Add(this.btnAdd);
            this.grpBoxInformation.Controls.Add(this.lblClass);
            this.grpBoxInformation.Controls.Add(this.chkImmortal);
            this.grpBoxInformation.Controls.Add(this.lblGender);
            this.grpBoxInformation.Controls.Add(this.lblAge);
            this.grpBoxInformation.Controls.Add(this.txtName);
            this.grpBoxInformation.Controls.Add(this.lblName);
            this.grpBoxInformation.Location = new System.Drawing.Point(13, 13);
            this.grpBoxInformation.Name = "grpBoxInformation";
            this.grpBoxInformation.Size = new System.Drawing.Size(257, 273);
            this.grpBoxInformation.TabIndex = 0;
            this.grpBoxInformation.TabStop = false;
            this.grpBoxInformation.Text = "Character Information";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(25, 70);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(25, 106);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender:";
            // 
            // chkImmortal
            // 
            this.chkImmortal.AutoSize = true;
            this.chkImmortal.Location = new System.Drawing.Point(147, 138);
            this.chkImmortal.Name = "chkImmortal";
            this.chkImmortal.Size = new System.Drawing.Size(71, 17);
            this.chkImmortal.TabIndex = 6;
            this.chkImmortal.Text = "Immortal?";
            this.chkImmortal.UseVisualStyleBackColor = true;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(25, 178);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(35, 13);
            this.lblClass.TabIndex = 7;
            this.lblClass.Text = "Class:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 38);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(136, 219);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 38);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(136, 68);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(87, 20);
            this.numAge.TabIndex = 11;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(121, 106);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(102, 21);
            this.cmbGender.TabIndex = 12;
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "Warrior",
            "Rogue",
            "Mage",
            "Priest"});
            this.cmbClass.Location = new System.Drawing.Point(102, 175);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(121, 21);
            this.cmbClass.TabIndex = 13;
            // 
            // DataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 303);
            this.Controls.Add(this.grpBoxInformation);
            this.Name = "DataEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.grpBoxInformation.ResumeLayout(false);
            this.grpBoxInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxInformation;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.CheckBox chkImmortal;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ComboBox cmbGender;
    }
}

