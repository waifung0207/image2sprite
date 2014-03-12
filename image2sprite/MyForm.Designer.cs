namespace image2sprite
{
    partial class MyForm
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
            this.makeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputDir = new System.Windows.Forms.TextBox();
            this.outputDir = new System.Windows.Forms.TextBox();
            this.numPicPerRow = new System.Windows.Forms.TextBox();
            this.browseInputButton = new System.Windows.Forms.Button();
            this.browseOutputButton = new System.Windows.Forms.Button();
            this.outputImageFormat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.outputImageName = new System.Windows.Forms.TextBox();
            this.inputFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.outputFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.colorKeyR = new System.Windows.Forms.TextBox();
            this.colorKeyG = new System.Windows.Forms.TextBox();
            this.colorKeyB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateColorButton = new System.Windows.Forms.Button();
            this.testColor = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupSprite = new System.Windows.Forms.GroupBox();
            this.spriteHeight = new System.Windows.Forms.TextBox();
            this.spriteWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioSprite2 = new System.Windows.Forms.RadioButton();
            this.radioSprite1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.outputImageQuality = new System.Windows.Forms.TextBox();
            this.imageQualityText = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.inputImageFormat = new System.Windows.Forms.ComboBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupSprite.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // makeButton
            // 
            this.makeButton.Location = new System.Drawing.Point(557, 219);
            this.makeButton.Name = "makeButton";
            this.makeButton.Size = new System.Drawing.Size(90, 65);
            this.makeButton.TabIndex = 0;
            this.makeButton.Text = "Make Sprite";
            this.makeButton.UseVisualStyleBackColor = true;
            this.makeButton.Click += new System.EventHandler(this.makeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output Folder:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of pictures per row: ";
            // 
            // inputDir
            // 
            this.inputDir.Enabled = false;
            this.inputDir.Location = new System.Drawing.Point(85, 34);
            this.inputDir.Name = "inputDir";
            this.inputDir.Size = new System.Drawing.Size(248, 20);
            this.inputDir.TabIndex = 4;
            this.inputDir.Text = "C:\\";
            // 
            // outputDir
            // 
            this.outputDir.Enabled = false;
            this.outputDir.Location = new System.Drawing.Point(84, 73);
            this.outputDir.Name = "outputDir";
            this.outputDir.Size = new System.Drawing.Size(329, 20);
            this.outputDir.TabIndex = 5;
            this.outputDir.Text = "C:\\";
            // 
            // numPicPerRow
            // 
            this.numPicPerRow.Location = new System.Drawing.Point(161, 27);
            this.numPicPerRow.Name = "numPicPerRow";
            this.numPicPerRow.Size = new System.Drawing.Size(128, 20);
            this.numPicPerRow.TabIndex = 6;
            this.numPicPerRow.Text = "5";
            // 
            // browseInputButton
            // 
            this.browseInputButton.Location = new System.Drawing.Point(421, 32);
            this.browseInputButton.Name = "browseInputButton";
            this.browseInputButton.Size = new System.Drawing.Size(75, 25);
            this.browseInputButton.TabIndex = 7;
            this.browseInputButton.Text = "Browse";
            this.browseInputButton.UseVisualStyleBackColor = true;
            this.browseInputButton.Click += new System.EventHandler(this.browseInputButton_Click);
            // 
            // browseOutputButton
            // 
            this.browseOutputButton.Location = new System.Drawing.Point(421, 70);
            this.browseOutputButton.Name = "browseOutputButton";
            this.browseOutputButton.Size = new System.Drawing.Size(75, 25);
            this.browseOutputButton.TabIndex = 9;
            this.browseOutputButton.Text = "Browse";
            this.browseOutputButton.UseVisualStyleBackColor = true;
            this.browseOutputButton.Click += new System.EventHandler(this.browseOutputButton_Click);
            // 
            // outputImageFormat
            // 
            this.outputImageFormat.FormattingEnabled = true;
            this.outputImageFormat.Items.AddRange(new object[] {
            "png",
            "jpg",
            "gif"});
            this.outputImageFormat.Location = new System.Drawing.Point(161, 89);
            this.outputImageFormat.Name = "outputImageFormat";
            this.outputImageFormat.Size = new System.Drawing.Size(128, 21);
            this.outputImageFormat.TabIndex = 10;
            this.outputImageFormat.SelectedIndexChanged += new System.EventHandler(this.outputImageFormat_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Output filename:";
            // 
            // outputImageName
            // 
            this.outputImageName.Location = new System.Drawing.Point(161, 59);
            this.outputImageName.Name = "outputImageName";
            this.outputImageName.Size = new System.Drawing.Size(128, 20);
            this.outputImageName.TabIndex = 13;
            this.outputImageName.Text = "newSprite";
            // 
            // inputFolderBrowserDialog
            // 
            this.inputFolderBrowserDialog.SelectedPath = "C:\\Documents and Settings\\Administrator\\桌面\\circle\\test";
            // 
            // outputFolderBrowserDialog
            // 
            this.outputFolderBrowserDialog.SelectedPath = "C:\\Documents and Settings\\Administrator\\桌面";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "R";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "G";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "B";
            // 
            // colorKeyR
            // 
            this.colorKeyR.Location = new System.Drawing.Point(35, 27);
            this.colorKeyR.Name = "colorKeyR";
            this.colorKeyR.Size = new System.Drawing.Size(31, 20);
            this.colorKeyR.TabIndex = 18;
            this.colorKeyR.Text = "238";
            // 
            // colorKeyG
            // 
            this.colorKeyG.Location = new System.Drawing.Point(35, 57);
            this.colorKeyG.Name = "colorKeyG";
            this.colorKeyG.Size = new System.Drawing.Size(31, 20);
            this.colorKeyG.TabIndex = 19;
            this.colorKeyG.Text = "100";
            // 
            // colorKeyB
            // 
            this.colorKeyB.Location = new System.Drawing.Point(35, 88);
            this.colorKeyB.Name = "colorKeyB";
            this.colorKeyB.Size = new System.Drawing.Size(31, 20);
            this.colorKeyB.TabIndex = 20;
            this.colorKeyB.Text = "238";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateColorButton);
            this.groupBox1.Controls.Add(this.testColor);
            this.groupBox1.Controls.Add(this.colorKeyB);
            this.groupBox1.Controls.Add(this.colorKeyG);
            this.groupBox1.Controls.Add(this.colorKeyR);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(540, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 126);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Key";
            // 
            // updateColorButton
            // 
            this.updateColorButton.Location = new System.Drawing.Point(76, 88);
            this.updateColorButton.Name = "updateColorButton";
            this.updateColorButton.Size = new System.Drawing.Size(50, 25);
            this.updateColorButton.TabIndex = 22;
            this.updateColorButton.Text = "Update";
            this.updateColorButton.UseVisualStyleBackColor = true;
            this.updateColorButton.Click += new System.EventHandler(this.updateColorButton_Click);
            // 
            // testColor
            // 
            this.testColor.Location = new System.Drawing.Point(76, 28);
            this.testColor.Name = "testColor";
            this.testColor.Size = new System.Drawing.Size(50, 51);
            this.testColor.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupSprite);
            this.groupBox2.Controls.Add(this.radioSprite2);
            this.groupBox2.Controls.Add(this.radioSprite1);
            this.groupBox2.Location = new System.Drawing.Point(356, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 154);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters for each sprite";
            // 
            // groupSprite
            // 
            this.groupSprite.Controls.Add(this.spriteHeight);
            this.groupSprite.Controls.Add(this.spriteWidth);
            this.groupSprite.Controls.Add(this.label6);
            this.groupSprite.Controls.Add(this.label4);
            this.groupSprite.Location = new System.Drawing.Point(43, 54);
            this.groupSprite.Name = "groupSprite";
            this.groupSprite.Size = new System.Drawing.Size(109, 80);
            this.groupSprite.TabIndex = 17;
            this.groupSprite.TabStop = false;
            this.groupSprite.Visible = false;
            // 
            // spriteHeight
            // 
            this.spriteHeight.Location = new System.Drawing.Point(57, 47);
            this.spriteHeight.Name = "spriteHeight";
            this.spriteHeight.Size = new System.Drawing.Size(42, 20);
            this.spriteHeight.TabIndex = 16;
            this.spriteHeight.Text = "240";
            // 
            // spriteWidth
            // 
            this.spriteWidth.Location = new System.Drawing.Point(57, 18);
            this.spriteWidth.Name = "spriteWidth";
            this.spriteWidth.Size = new System.Drawing.Size(42, 20);
            this.spriteWidth.TabIndex = 15;
            this.spriteWidth.Text = "320";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Height:";
            // 
            // radioSprite2
            // 
            this.radioSprite2.AutoSize = true;
            this.radioSprite2.Location = new System.Drawing.Point(90, 25);
            this.radioSprite2.Name = "radioSprite2";
            this.radioSprite2.Size = new System.Drawing.Size(60, 17);
            this.radioSprite2.TabIndex = 13;
            this.radioSprite2.TabStop = true;
            this.radioSprite2.Text = "Custom";
            this.radioSprite2.UseVisualStyleBackColor = true;
            this.radioSprite2.CheckedChanged += new System.EventHandler(this.radioSprite2_CheckedChanged);
            // 
            // radioSprite1
            // 
            this.radioSprite1.AutoSize = true;
            this.radioSprite1.Checked = true;
            this.radioSprite1.Location = new System.Drawing.Point(22, 25);
            this.radioSprite1.Name = "radioSprite1";
            this.radioSprite1.Size = new System.Drawing.Size(47, 17);
            this.radioSprite1.TabIndex = 12;
            this.radioSprite1.TabStop = true;
            this.radioSprite1.Text = "Auto";
            this.radioSprite1.UseVisualStyleBackColor = true;
            this.radioSprite1.CheckedChanged += new System.EventHandler(this.radioSprite1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.browseOutputButton);
            this.groupBox3.Controls.Add(this.browseInputButton);
            this.groupBox3.Controls.Add(this.outputDir);
            this.groupBox3.Controls.Add(this.inputDir);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.inputImageFormat);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(512, 126);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input and Output Folder";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.outputImageQuality);
            this.groupBox4.Controls.Add(this.imageQualityText);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.numPicPerRow);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.outputImageName);
            this.groupBox4.Controls.Add(this.outputImageFormat);
            this.groupBox4.Location = new System.Drawing.Point(12, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 154);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Basic Setting";
            // 
            // outputImageQuality
            // 
            this.outputImageQuality.Location = new System.Drawing.Point(161, 120);
            this.outputImageQuality.Name = "outputImageQuality";
            this.outputImageQuality.Size = new System.Drawing.Size(128, 20);
            this.outputImageQuality.TabIndex = 16;
            this.outputImageQuality.Text = "90";
            // 
            // imageQualityText
            // 
            this.imageQualityText.AutoSize = true;
            this.imageQualityText.Location = new System.Drawing.Point(18, 123);
            this.imageQualityText.Name = "imageQualityText";
            this.imageQualityText.Size = new System.Drawing.Size(74, 13);
            this.imageQualityText.TabIndex = 15;
            this.imageQualityText.Text = "Image Quality:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Output image format:";
            // 
            // inputImageFormat
            // 
            this.inputImageFormat.FormattingEnabled = true;
            this.inputImageFormat.Items.AddRange(new object[] {
            "png",
            "jpg",
            "gif"});
            this.inputImageFormat.Location = new System.Drawing.Point(342, 35);
            this.inputImageFormat.Name = "inputImageFormat";
            this.inputImageFormat.Size = new System.Drawing.Size(71, 21);
            this.inputImageFormat.TabIndex = 10;
            this.inputImageFormat.SelectedIndexChanged += new System.EventHandler(this.outputImageFormat_SelectedIndexChanged);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(689, 24);
            this.menu.TabIndex = 25;
            this.menu.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSettingToolStripMenuItem,
            this.loadSettingToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // saveSettingToolStripMenuItem
            // 
            this.saveSettingToolStripMenuItem.Name = "saveSettingToolStripMenuItem";
            this.saveSettingToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveSettingToolStripMenuItem.Text = "Save setting";
            this.saveSettingToolStripMenuItem.Click += new System.EventHandler(this.saveSettingToolStripMenuItem_Click);
            // 
            // loadSettingToolStripMenuItem
            // 
            this.loadSettingToolStripMenuItem.Name = "loadSettingToolStripMenuItem";
            this.loadSettingToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.loadSettingToolStripMenuItem.Text = "Load setting";
            this.loadSettingToolStripMenuItem.Click += new System.EventHandler(this.loadSettingToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(537, 309);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 26;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 351);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.makeButton);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyForm";
            this.Text = "image2sprite";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupSprite.ResumeLayout(false);
            this.groupSprite.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputDir;
        private System.Windows.Forms.TextBox outputDir;
        private System.Windows.Forms.TextBox numPicPerRow;
        private System.Windows.Forms.Button browseInputButton;
        private System.Windows.Forms.Button browseOutputButton;
        private System.Windows.Forms.ComboBox outputImageFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox outputImageName;
        private System.Windows.Forms.FolderBrowserDialog inputFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog outputFolderBrowserDialog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox colorKeyR;
        private System.Windows.Forms.TextBox colorKeyG;
        private System.Windows.Forms.TextBox colorKeyB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button updateColorButton;
        private System.Windows.Forms.Panel testColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioSprite2;
        private System.Windows.Forms.RadioButton radioSprite1;
        private System.Windows.Forms.TextBox spriteWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox spriteHeight;
        private System.Windows.Forms.GroupBox groupSprite;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox outputImageQuality;
        private System.Windows.Forms.Label imageQualityText;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSettingToolStripMenuItem;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox inputImageFormat;
    }
}

