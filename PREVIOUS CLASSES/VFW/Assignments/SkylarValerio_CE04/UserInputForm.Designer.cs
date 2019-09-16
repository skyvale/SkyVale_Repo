namespace SkylarValerio_CE04
{
    partial class UserInputForm
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
            this.toolStripUserInputForm = new System.Windows.Forms.ToolStrip();
            this.btnAddToList = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbStarterPokemon = new System.Windows.Forms.ComboBox();
            this.lblStarter = new System.Windows.Forms.Label();
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.toolStripUserInputForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripUserInputForm
            // 
            this.toolStripUserInputForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddToList,
            this.toolStripSeparator1,
            this.btnClear});
            this.toolStripUserInputForm.Location = new System.Drawing.Point(0, 0);
            this.toolStripUserInputForm.Name = "toolStripUserInputForm";
            this.toolStripUserInputForm.Size = new System.Drawing.Size(343, 25);
            this.toolStripUserInputForm.TabIndex = 0;
            this.toolStripUserInputForm.Text = "toolStrip1";
            // 
            // btnAddToList
            // 
            this.btnAddToList.Image = global::SkylarValerio_CE04.Properties.Resources.plus_icon;
            this.btnAddToList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(85, 22);
            this.btnAddToList.Text = "Add To List";
            this.btnAddToList.Click += new System.EventHandler(this.BtnAddToList_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::SkylarValerio_CE04.Properties.Resources.red_x;
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 22);
            this.btnClear.Text = "Clear All";
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbStarterPokemon);
            this.groupBox1.Controls.Add(this.lblStarter);
            this.groupBox1.Controls.Add(this.cmbRegion);
            this.groupBox1.Controls.Add(this.lblRegion);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 211);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // cmbStarterPokemon
            // 
            this.cmbStarterPokemon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStarterPokemon.FormattingEnabled = true;
            this.cmbStarterPokemon.Items.AddRange(new object[] {
            "Pikachu",
            "Charmander",
            "Squirtle",
            "Bulbasaur"});
            this.cmbStarterPokemon.Location = new System.Drawing.Point(185, 163);
            this.cmbStarterPokemon.Name = "cmbStarterPokemon";
            this.cmbStarterPokemon.Size = new System.Drawing.Size(112, 21);
            this.cmbStarterPokemon.TabIndex = 7;
            // 
            // lblStarter
            // 
            this.lblStarter.AutoSize = true;
            this.lblStarter.Location = new System.Drawing.Point(11, 166);
            this.lblStarter.Name = "lblStarter";
            this.lblStarter.Size = new System.Drawing.Size(137, 13);
            this.lblStarter.TabIndex = 6;
            this.lblStarter.Text = "Choose a Starter Pokemon:";
            // 
            // cmbRegion
            // 
            this.cmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Items.AddRange(new object[] {
            "Kanto",
            "Johto",
            "Hoenn",
            "Sinnoh",
            "Unova",
            "Kalos",
            "Alola",
            "Galar"});
            this.cmbRegion.Location = new System.Drawing.Point(185, 122);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(112, 21);
            this.cmbRegion.TabIndex = 5;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(11, 125);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(132, 13);
            this.lblRegion.TabIndex = 4;
            this.lblRegion.Text = "What region are you from?";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Boy",
            "Girl"});
            this.cmbGender.Location = new System.Drawing.Point(168, 79);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(129, 21);
            this.cmbGender.TabIndex = 3;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(11, 82);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(115, 13);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Are you a boy or a girl?";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "What is your name?";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(149, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 20);
            this.txtName.TabIndex = 0;
            // 
            // UserInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 251);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripUserInputForm);
            this.Name = "UserInputForm";
            this.Text = "Welcome to the World of Pokemon!";
            this.toolStripUserInputForm.ResumeLayout(false);
            this.toolStripUserInputForm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripUserInputForm;
        private System.Windows.Forms.ToolStripButton btnAddToList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbStarterPokemon;
        private System.Windows.Forms.Label lblStarter;
        private System.Windows.Forms.ComboBox cmbRegion;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
    }
}