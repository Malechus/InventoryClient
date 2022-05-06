namespace InventoryClient.Home.Kelly
{
    partial class FormMain
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scannerGroupBox = new System.Windows.Forms.GroupBox();
            this.barcodeSearchButton = new System.Windows.Forms.Button();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.itemGroupBox = new System.Windows.Forms.GroupBox();
            this.recordButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descRichTextBox = new System.Windows.Forms.RichTextBox();
            this.msrpTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.mfrTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.locationGroupBox = new System.Windows.Forms.GroupBox();
            this.garageLocationRadioButton = new System.Windows.Forms.RadioButton();
            this.basementLocationRadioButton = new System.Windows.Forms.RadioButton();
            this.kitchenLocationRadioButton = new System.Windows.Forms.RadioButton();
            this.modeGroupBox = new System.Windows.Forms.GroupBox();
            this.recordModeRadioButton = new System.Windows.Forms.RadioButton();
            this.reviewModeRadioButton = new System.Windows.Forms.RadioButton();
            this.menuStrip.SuspendLayout();
            this.scannerGroupBox.SuspendLayout();
            this.itemGroupBox.SuspendLayout();
            this.locationGroupBox.SuspendLayout();
            this.modeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // scannerGroupBox
            // 
            this.scannerGroupBox.Controls.Add(this.barcodeSearchButton);
            this.scannerGroupBox.Controls.Add(this.barcodeTextBox);
            this.scannerGroupBox.Location = new System.Drawing.Point(0, 24);
            this.scannerGroupBox.Name = "scannerGroupBox";
            this.scannerGroupBox.Size = new System.Drawing.Size(400, 56);
            this.scannerGroupBox.TabIndex = 1;
            this.scannerGroupBox.TabStop = false;
            // 
            // barcodeSearchButton
            // 
            this.barcodeSearchButton.FlatAppearance.BorderSize = 0;
            this.barcodeSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.barcodeSearchButton.Location = new System.Drawing.Point(316, 20);
            this.barcodeSearchButton.Name = "barcodeSearchButton";
            this.barcodeSearchButton.Size = new System.Drawing.Size(72, 23);
            this.barcodeSearchButton.TabIndex = 1;
            this.barcodeSearchButton.Text = "Search";
            this.barcodeSearchButton.UseVisualStyleBackColor = true;
            this.barcodeSearchButton.Click += new System.EventHandler(this.barcodeSearchButton_Click);
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.barcodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barcodeTextBox.Location = new System.Drawing.Point(12, 20);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(296, 23);
            this.barcodeTextBox.TabIndex = 0;
            this.barcodeTextBox.Enter += new System.EventHandler(this.barcodeTextBox_Enter);
            // 
            // itemGroupBox
            // 
            this.itemGroupBox.Controls.Add(this.recordButton);
            this.itemGroupBox.Controls.Add(this.label5);
            this.itemGroupBox.Controls.Add(this.label4);
            this.itemGroupBox.Controls.Add(this.label3);
            this.itemGroupBox.Controls.Add(this.label2);
            this.itemGroupBox.Controls.Add(this.label1);
            this.itemGroupBox.Controls.Add(this.descRichTextBox);
            this.itemGroupBox.Controls.Add(this.msrpTextBox);
            this.itemGroupBox.Controls.Add(this.brandTextBox);
            this.itemGroupBox.Controls.Add(this.mfrTextBox);
            this.itemGroupBox.Controls.Add(this.titleTextBox);
            this.itemGroupBox.Location = new System.Drawing.Point(0, 80);
            this.itemGroupBox.Name = "itemGroupBox";
            this.itemGroupBox.Size = new System.Drawing.Size(544, 472);
            this.itemGroupBox.TabIndex = 2;
            this.itemGroupBox.TabStop = false;
            this.itemGroupBox.Text = "Item Details";
            // 
            // recordButton
            // 
            this.recordButton.FlatAppearance.BorderSize = 0;
            this.recordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordButton.Location = new System.Drawing.Point(236, 421);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(72, 23);
            this.recordButton.TabIndex = 3;
            this.recordButton.Text = "Record";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Manufacturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "MSRP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Description";
            // 
            // descRichTextBox
            // 
            this.descRichTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.descRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descRichTextBox.Location = new System.Drawing.Point(8, 232);
            this.descRichTextBox.Name = "descRichTextBox";
            this.descRichTextBox.ReadOnly = true;
            this.descRichTextBox.Size = new System.Drawing.Size(512, 168);
            this.descRichTextBox.TabIndex = 5;
            this.descRichTextBox.Text = "";
            // 
            // msrpTextBox
            // 
            this.msrpTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.msrpTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msrpTextBox.Location = new System.Drawing.Point(8, 184);
            this.msrpTextBox.Name = "msrpTextBox";
            this.msrpTextBox.ReadOnly = true;
            this.msrpTextBox.Size = new System.Drawing.Size(512, 23);
            this.msrpTextBox.TabIndex = 4;
            // 
            // brandTextBox
            // 
            this.brandTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.brandTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brandTextBox.Location = new System.Drawing.Point(8, 88);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.ReadOnly = true;
            this.brandTextBox.Size = new System.Drawing.Size(512, 23);
            this.brandTextBox.TabIndex = 3;
            // 
            // mfrTextBox
            // 
            this.mfrTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.mfrTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mfrTextBox.Location = new System.Drawing.Point(8, 136);
            this.mfrTextBox.Name = "mfrTextBox";
            this.mfrTextBox.ReadOnly = true;
            this.mfrTextBox.Size = new System.Drawing.Size(512, 23);
            this.mfrTextBox.TabIndex = 2;
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleTextBox.Location = new System.Drawing.Point(8, 40);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(512, 23);
            this.titleTextBox.TabIndex = 0;
            // 
            // locationGroupBox
            // 
            this.locationGroupBox.Controls.Add(this.garageLocationRadioButton);
            this.locationGroupBox.Controls.Add(this.basementLocationRadioButton);
            this.locationGroupBox.Controls.Add(this.kitchenLocationRadioButton);
            this.locationGroupBox.Location = new System.Drawing.Point(584, 43);
            this.locationGroupBox.Name = "locationGroupBox";
            this.locationGroupBox.Size = new System.Drawing.Size(200, 100);
            this.locationGroupBox.TabIndex = 3;
            this.locationGroupBox.TabStop = false;
            this.locationGroupBox.Text = "Location";
            // 
            // garageLocationRadioButton
            // 
            this.garageLocationRadioButton.AutoSize = true;
            this.garageLocationRadioButton.Location = new System.Drawing.Point(6, 72);
            this.garageLocationRadioButton.Name = "garageLocationRadioButton";
            this.garageLocationRadioButton.Size = new System.Drawing.Size(62, 19);
            this.garageLocationRadioButton.TabIndex = 2;
            this.garageLocationRadioButton.Text = "Garage";
            this.garageLocationRadioButton.UseVisualStyleBackColor = true;
            // 
            // basementLocationRadioButton
            // 
            this.basementLocationRadioButton.AutoSize = true;
            this.basementLocationRadioButton.Location = new System.Drawing.Point(6, 47);
            this.basementLocationRadioButton.Name = "basementLocationRadioButton";
            this.basementLocationRadioButton.Size = new System.Drawing.Size(77, 19);
            this.basementLocationRadioButton.TabIndex = 1;
            this.basementLocationRadioButton.Text = "Basement";
            this.basementLocationRadioButton.UseVisualStyleBackColor = true;
            // 
            // kitchenLocationRadioButton
            // 
            this.kitchenLocationRadioButton.AutoSize = true;
            this.kitchenLocationRadioButton.Checked = true;
            this.kitchenLocationRadioButton.Location = new System.Drawing.Point(6, 22);
            this.kitchenLocationRadioButton.Name = "kitchenLocationRadioButton";
            this.kitchenLocationRadioButton.Size = new System.Drawing.Size(65, 19);
            this.kitchenLocationRadioButton.TabIndex = 0;
            this.kitchenLocationRadioButton.TabStop = true;
            this.kitchenLocationRadioButton.Text = "Kitchen";
            this.kitchenLocationRadioButton.UseVisualStyleBackColor = true;
            // 
            // modeGroupBox
            // 
            this.modeGroupBox.Controls.Add(this.recordModeRadioButton);
            this.modeGroupBox.Controls.Add(this.reviewModeRadioButton);
            this.modeGroupBox.Location = new System.Drawing.Point(584, 150);
            this.modeGroupBox.Name = "modeGroupBox";
            this.modeGroupBox.Size = new System.Drawing.Size(200, 100);
            this.modeGroupBox.TabIndex = 4;
            this.modeGroupBox.TabStop = false;
            this.modeGroupBox.Text = "Mode";
            // 
            // recordModeRadioButton
            // 
            this.recordModeRadioButton.AutoSize = true;
            this.recordModeRadioButton.Location = new System.Drawing.Point(6, 47);
            this.recordModeRadioButton.Name = "recordModeRadioButton";
            this.recordModeRadioButton.Size = new System.Drawing.Size(96, 19);
            this.recordModeRadioButton.TabIndex = 1;
            this.recordModeRadioButton.Text = "Record Mode";
            this.recordModeRadioButton.UseVisualStyleBackColor = true;
            // 
            // reviewModeRadioButton
            // 
            this.reviewModeRadioButton.AutoSize = true;
            this.reviewModeRadioButton.Checked = true;
            this.reviewModeRadioButton.Location = new System.Drawing.Point(6, 22);
            this.reviewModeRadioButton.Name = "reviewModeRadioButton";
            this.reviewModeRadioButton.Size = new System.Drawing.Size(96, 19);
            this.reviewModeRadioButton.TabIndex = 0;
            this.reviewModeRadioButton.TabStop = true;
            this.reviewModeRadioButton.Text = "Review Mode";
            this.reviewModeRadioButton.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.modeGroupBox);
            this.Controls.Add(this.locationGroupBox);
            this.Controls.Add(this.itemGroupBox);
            this.Controls.Add(this.scannerGroupBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "Inventory Management";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.scannerGroupBox.ResumeLayout(false);
            this.scannerGroupBox.PerformLayout();
            this.itemGroupBox.ResumeLayout(false);
            this.itemGroupBox.PerformLayout();
            this.locationGroupBox.ResumeLayout(false);
            this.locationGroupBox.PerformLayout();
            this.modeGroupBox.ResumeLayout(false);
            this.modeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox scannerGroupBox;
        private System.Windows.Forms.Button barcodeSearchButton;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.GroupBox itemGroupBox;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox descRichTextBox;
        private System.Windows.Forms.TextBox msrpTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox mfrTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.GroupBox locationGroupBox;
        private System.Windows.Forms.RadioButton garageLocationRadioButton;
        private System.Windows.Forms.RadioButton basementLocationRadioButton;
        private System.Windows.Forms.RadioButton kitchenLocationRadioButton;
        private System.Windows.Forms.GroupBox modeGroupBox;
        private System.Windows.Forms.RadioButton recordModeRadioButton;
        private System.Windows.Forms.RadioButton reviewModeRadioButton;
    }
}