namespace SkylarValerio_CE07
{
    partial class Form1
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxStocks = new System.Windows.Forms.ListBox();
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.numLowPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numHighPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numOpeningPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numLastPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.btnSaveList = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.groupBoxInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLowPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHighPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpeningPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLastPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFile});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(934, 44);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripFile
            // 
            this.toolStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnLoad,
            this.btnSave,
            this.toolStripSeparator,
            this.btnExit});
            this.toolStripFile.Name = "toolStripFile";
            this.toolStripFile.Size = new System.Drawing.Size(64, 36);
            this.toolStripFile.Text = "File";
            // 
            // btnNew
            // 
            this.btnNew.Name = "btnNew";
            this.btnNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnNew.Size = new System.Drawing.Size(248, 38);
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.btnLoad.Size = new System.Drawing.Size(248, 38);
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSave.Size = new System.Drawing.Size(248, 38);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(245, 6);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.btnExit.Size = new System.Drawing.Size(248, 38);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // listBoxStocks
            // 
            this.listBoxStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxStocks.FormattingEnabled = true;
            this.listBoxStocks.ItemHeight = 37;
            this.listBoxStocks.Items.AddRange(new object[] {
            "Facebook",
            "Amazon",
            "Apple",
            "Netflix",
            "Google"});
            this.listBoxStocks.Location = new System.Drawing.Point(476, 150);
            this.listBoxStocks.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxStocks.Name = "listBoxStocks";
            this.listBoxStocks.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxStocks.Size = new System.Drawing.Size(430, 300);
            this.listBoxStocks.TabIndex = 1;
            this.listBoxStocks.SelectedIndexChanged += new System.EventHandler(this.ListBoxStocks_SelectedIndexChanged);
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.Controls.Add(this.btnNext);
            this.groupBoxInformation.Controls.Add(this.btnBack);
            this.groupBoxInformation.Controls.Add(this.numLowPrice);
            this.groupBoxInformation.Controls.Add(this.label6);
            this.groupBoxInformation.Controls.Add(this.numHighPrice);
            this.groupBoxInformation.Controls.Add(this.label5);
            this.groupBoxInformation.Controls.Add(this.numOpeningPrice);
            this.groupBoxInformation.Controls.Add(this.label4);
            this.groupBoxInformation.Controls.Add(this.numLastPrice);
            this.groupBoxInformation.Controls.Add(this.label3);
            this.groupBoxInformation.Controls.Add(this.txtName);
            this.groupBoxInformation.Controls.Add(this.label1);
            this.groupBoxInformation.Location = new System.Drawing.Point(24, 73);
            this.groupBoxInformation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxInformation.Size = new System.Drawing.Size(432, 508);
            this.groupBoxInformation.TabIndex = 2;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "Information";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(236, 433);
            this.btnNext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 44);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(56, 433);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 44);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // numLowPrice
            // 
            this.numLowPrice.DecimalPlaces = 2;
            this.numLowPrice.Location = new System.Drawing.Point(200, 365);
            this.numLowPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numLowPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numLowPrice.Name = "numLowPrice";
            this.numLowPrice.ReadOnly = true;
            this.numLowPrice.Size = new System.Drawing.Size(206, 31);
            this.numLowPrice.TabIndex = 9;
            this.numLowPrice.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 369);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Low Price:";
            // 
            // numHighPrice
            // 
            this.numHighPrice.DecimalPlaces = 2;
            this.numHighPrice.Location = new System.Drawing.Point(200, 290);
            this.numHighPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numHighPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numHighPrice.Name = "numHighPrice";
            this.numHighPrice.ReadOnly = true;
            this.numHighPrice.Size = new System.Drawing.Size(206, 31);
            this.numHighPrice.TabIndex = 7;
            this.numHighPrice.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 294);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "High Price:";
            // 
            // numOpeningPrice
            // 
            this.numOpeningPrice.DecimalPlaces = 2;
            this.numOpeningPrice.Location = new System.Drawing.Point(200, 215);
            this.numOpeningPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numOpeningPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numOpeningPrice.Name = "numOpeningPrice";
            this.numOpeningPrice.ReadOnly = true;
            this.numOpeningPrice.Size = new System.Drawing.Size(206, 31);
            this.numOpeningPrice.TabIndex = 5;
            this.numOpeningPrice.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Opening Price:";
            // 
            // numLastPrice
            // 
            this.numLastPrice.DecimalPlaces = 2;
            this.numLastPrice.Location = new System.Drawing.Point(200, 140);
            this.numLastPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numLastPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numLastPrice.Name = "numLastPrice";
            this.numLastPrice.ReadOnly = true;
            this.numLastPrice.Size = new System.Drawing.Size(206, 31);
            this.numLastPrice.TabIndex = 3;
            this.numLastPrice.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Price:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 65);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(272, 31);
            this.txtName.TabIndex = 1;
            this.txtName.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(470, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose stock(s) for information:";
            // 
            // txtDebug
            // 
            this.txtDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.txtDebug.Location = new System.Drawing.Point(26, 594);
            this.txtDebug.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.Size = new System.Drawing.Size(880, 26);
            this.txtDebug.TabIndex = 4;
            // 
            // btnSaveList
            // 
            this.btnSaveList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSaveList.Location = new System.Drawing.Point(574, 490);
            this.btnSaveList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSaveList.Name = "btnSaveList";
            this.btnSaveList.Size = new System.Drawing.Size(236, 75);
            this.btnSaveList.TabIndex = 5;
            this.btnSaveList.Text = "Save List";
            this.btnSaveList.UseVisualStyleBackColor = true;
            this.btnSaveList.Click += new System.EventHandler(this.BtnSaveList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 656);
            this.Controls.Add(this.btnSaveList);
            this.Controls.Add(this.txtDebug);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxInformation);
            this.Controls.Add(this.listBoxStocks);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLowPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHighPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpeningPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLastPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripFile;
        private System.Windows.Forms.ToolStripMenuItem btnNew;
        private System.Windows.Forms.ToolStripMenuItem btnLoad;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ListBox listBoxStocks;
        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NumericUpDown numLowPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numHighPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numOpeningPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numLastPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.Button btnSaveList;
    }
}

