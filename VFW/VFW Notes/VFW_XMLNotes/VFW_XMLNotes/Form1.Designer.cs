namespace VFW_XMLNotes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comStock = new System.Windows.Forms.ComboBox();
            this.btnGetStockData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numLastPrice = new System.Windows.Forms.NumericUpDown();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.radJSON = new System.Windows.Forms.RadioButton();
            this.radXML = new System.Windows.Forms.RadioButton();
            this.numOpen = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.saveAsXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLastPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsXMLToolStripMenuItem,
            this.loadXMLToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numOpen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radXML);
            this.groupBox1.Controls.Add(this.radJSON);
            this.groupBox1.Controls.Add(this.txtDebug);
            this.groupBox1.Controls.Add(this.numLastPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnGetStockData);
            this.groupBox1.Controls.Add(this.comStock);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 646);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select a stock:";
            // 
            // comStock
            // 
            this.comStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comStock.FormattingEnabled = true;
            this.comStock.Items.AddRange(new object[] {
            "FB",
            "AMZN",
            "APPL",
            "NFLX",
            "GOOG"});
            this.comStock.Location = new System.Drawing.Point(293, 83);
            this.comStock.Name = "comStock";
            this.comStock.Size = new System.Drawing.Size(285, 33);
            this.comStock.TabIndex = 1;
            // 
            // btnGetStockData
            // 
            this.btnGetStockData.Location = new System.Drawing.Point(167, 239);
            this.btnGetStockData.Name = "btnGetStockData";
            this.btnGetStockData.Size = new System.Drawing.Size(271, 63);
            this.btnGetStockData.TabIndex = 2;
            this.btnGetStockData.Text = "Get Stock Data";
            this.btnGetStockData.UseVisualStyleBackColor = true;
            this.btnGetStockData.Click += new System.EventHandler(this.btnGetStockData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Price:";
            // 
            // numLastPrice
            // 
            this.numLastPrice.DecimalPlaces = 2;
            this.numLastPrice.Location = new System.Drawing.Point(191, 374);
            this.numLastPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numLastPrice.Name = "numLastPrice";
            this.numLastPrice.ReadOnly = true;
            this.numLastPrice.Size = new System.Drawing.Size(178, 31);
            this.numLastPrice.TabIndex = 4;
            this.numLastPrice.TabStop = false;
            // 
            // txtDebug
            // 
            this.txtDebug.Location = new System.Drawing.Point(7, 609);
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.ReadOnly = true;
            this.txtDebug.Size = new System.Drawing.Size(589, 31);
            this.txtDebug.TabIndex = 5;
            this.txtDebug.Text = "Debug";
            // 
            // radJSON
            // 
            this.radJSON.AutoSize = true;
            this.radJSON.Location = new System.Drawing.Point(191, 173);
            this.radJSON.Name = "radJSON";
            this.radJSON.Size = new System.Drawing.Size(99, 29);
            this.radJSON.TabIndex = 6;
            this.radJSON.TabStop = true;
            this.radJSON.Text = "JSON";
            this.radJSON.UseVisualStyleBackColor = true;
            // 
            // radXML
            // 
            this.radXML.AutoSize = true;
            this.radXML.Location = new System.Drawing.Point(327, 173);
            this.radXML.Name = "radXML";
            this.radXML.Size = new System.Drawing.Size(87, 29);
            this.radXML.TabIndex = 7;
            this.radXML.TabStop = true;
            this.radXML.Text = "XML";
            this.radXML.UseVisualStyleBackColor = true;
            // 
            // numOpen
            // 
            this.numOpen.DecimalPlaces = 2;
            this.numOpen.Location = new System.Drawing.Point(191, 452);
            this.numOpen.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numOpen.Name = "numOpen";
            this.numOpen.ReadOnly = true;
            this.numOpen.Size = new System.Drawing.Size(178, 31);
            this.numOpen.TabIndex = 9;
            this.numOpen.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Open:";
            // 
            // saveAsXMLToolStripMenuItem
            // 
            this.saveAsXMLToolStripMenuItem.Name = "saveAsXMLToolStripMenuItem";
            this.saveAsXMLToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.saveAsXMLToolStripMenuItem.Text = "Save as XML";
            this.saveAsXMLToolStripMenuItem.Click += new System.EventHandler(this.saveAsXMLToolStripMenuItem_Click);
            // 
            // loadXMLToolStripMenuItem
            // 
            this.loadXMLToolStripMenuItem.Name = "loadXMLToolStripMenuItem";
            this.loadXMLToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.loadXMLToolStripMenuItem.Text = "Load XML";
            this.loadXMLToolStripMenuItem.Click += new System.EventHandler(this.loadXMLToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(321, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 702);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLastPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetStockData;
        private System.Windows.Forms.ComboBox comStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numLastPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.RadioButton radXML;
        private System.Windows.Forms.RadioButton radJSON;
        private System.Windows.Forms.NumericUpDown numOpen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem saveAsXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

