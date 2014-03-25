using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace image2sprite
{
    public partial class MyForm : Form
    {
        private App mApp;

        /**
         * constructor
         */
        public MyForm()
        {
            InitializeComponent();

            mApp = new App();
            this.setFormValues();
        }

        /**
         * Set default form values when application starts
         */
        private void setFormValues()
        {
            // assign setting values to input fields
            outputImageName.Text    = mApp.getSettings(ConfigFields.OutputImageName);
            outputImageQuality.Text = mApp.getSettings(ConfigFields.OutputImageQuality);
            numPicPerRow.Text       = mApp.getSettings(ConfigFields.NumPicPerRow);
            spriteWidth.Text        = mApp.getSettings(ConfigFields.SpriteWidth);
            spriteHeight.Text       = mApp.getSettings(ConfigFields.SpriteHeight);

            // update input and output directory
            inputDir.Text           = mApp.getSettings(ConfigFields.InputDir);
            inputImageFormat.Text   = mApp.getSettings(ConfigFields.InputImageFormat);
            outputDir.Text          = mApp.getSettings(ConfigFields.OutputDir);
            String curr_dir = Directory.GetCurrentDirectory();
            if (inputDir.Text == "")
                inputDir.Text = curr_dir;
            if (outputDir.Text == "")
                outputDir.Text = curr_dir;

            // update sprite params fields
            bool sprite_auto = bool.Parse(mApp.getSettings(ConfigFields.SpriteAuto));
            if (sprite_auto)
            {
                radioSprite1.Checked = true;
                radioSprite2.Checked = false;
                groupSprite.Visible = false;
            }
            else
            {
                radioSprite1.Checked = false;
                radioSprite2.Checked = true;
                groupSprite.Visible = true;
            }

            // update color key fields
            enableColorKeyCheckbox.Checked = bool.Parse(mApp.getSettings(ConfigFields.EnableColorKey));
            colorKeyR.Text = mApp.getSettings(ConfigFields.ColorKeyR);
            colorKeyG.Text = mApp.getSettings(ConfigFields.ColorKeyG);
            colorKeyB.Text = mApp.getSettings(ConfigFields.ColorKeyB);
            this.updateColorKey();

            // update other non-text fields
            outputImageFormat.SelectedItem = mApp.getSettings(ConfigFields.OutputImageFormat);
        }

        /**
         * Update App settings (i.e. put field values to App class)
         */
        private void updateAppSettings()
        {
            // input and output directories
            mApp.updateSettings(ConfigFields.InputDir, inputDir.Text);
            mApp.updateSettings(ConfigFields.InputImageFormat, inputImageFormat.Text);
            mApp.updateSettings(ConfigFields.OutputDir, outputDir.Text);

            // new image parameters
            mApp.updateSettings(ConfigFields.NumPicPerRow, numPicPerRow.Text);
            mApp.updateSettings(ConfigFields.OutputImageName, outputImageName.Text);
            mApp.updateSettings(ConfigFields.OutputImageFormat, outputImageFormat.Text);
            mApp.updateSettings(ConfigFields.OutputImageQuality, outputImageQuality.Text);

            // color key
            mApp.updateColorKey(enableColorKeyCheckbox.Checked, colorKeyR.Text, colorKeyG.Text, colorKeyB.Text);

            // parameters of each sprite
            mApp.updateSpriteParams(radioSprite1.Checked, spriteWidth.Text, spriteHeight.Text);
        }

        /**
         * Check if the input R,G,B values are correct
         */
        private bool validateColorValue(int r, int g, int b)
        {
            if (r < 0 || r > 255 || g < 0 || g > 255 || b < 0 || g > 255)
                return false;
            else
                return true;
        }

        /**
         * Update color key
         */
        private bool updateColorKey()
        {
            try
            {
                int r = int.Parse(colorKeyR.Text);
                int g = int.Parse(colorKeyG.Text);
                int b = int.Parse(colorKeyB.Text);

                if (this.validateColorValue(r, g, b) == true)
                {
                    // reload color field
                    Color tmp_color = Color.FromArgb(r, g, b);
                    testColor.BackColor = tmp_color;
                    return true;
                }
                
                // failed validation of RGB values
                return false;
            }
            catch
            {
                // other error (e.g. cannot parse text values to int)
                return false;
            }
        }


        #region Button Events

        /**
         * Click event on Input Folder button
         */
        private void browseInputButton_Click(object sender, EventArgs e)
        {
            // default path
            String curr_dir = Directory.GetCurrentDirectory();
            inputFolderBrowserDialog.SelectedPath = inputDir.Text;

            if (inputFolderBrowserDialog.ShowDialog() == DialogResult.OK)
                inputDir.Text = inputFolderBrowserDialog.SelectedPath.ToString();
        }

        /**
         * Click event on Output Folder button
         */
        private void browseOutputButton_Click(object sender, EventArgs e)
        {
            // default path
            String curr_dir = Directory.GetCurrentDirectory();
            inputFolderBrowserDialog.SelectedPath = inputDir.Text;

            if (outputFolderBrowserDialog.ShowDialog() == DialogResult.OK)
                outputDir.Text = outputFolderBrowserDialog.SelectedPath.ToString();
        }

        /**
         * Click event on Make Sprite button
         */
        private void makeButton_Click(object sender, EventArgs e)
        {
            this.updateAppSettings();

            if (mApp.makeSprite() == true)
            {
                MessageBox.Show("SpriteSheet created!");
            }
        }

        /**
         * Change Event on Sprite Params radio buttons
         */
        private void radioSprite1_CheckedChanged(object sender, EventArgs e)
        {
            groupSprite.Visible = false;
        }
        private void radioSprite2_CheckedChanged(object sender, EventArgs e)
        {
            groupSprite.Visible = true;
        }

        /**
         * Change Event on Input / Outpu Image Format dropdown box
         */
        private void outputImageFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (outputImageFormat.Text == "jpg")
            {
                outputImageQuality.Visible = true;
                imageQualityText.Visible = true;
            }
            else
            {
                outputImageQuality.Visible = false;
                imageQualityText.Visible = false;
            }
        }

        /**
         * Click Event on Update Color Key button
         */ 
        private void updateColorButton_Click(object sender, EventArgs e)
        {
            if (this.updateColorKey() == false)
                MessageBox.Show("Please input correct RGB values for color key");
        }

        /**
         * Save current settings to config file
         */ 
        private void saveSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.updateAppSettings();
            mApp.saveConfig();
            labelResult.ForeColor = Color.FromArgb(0, 150, 0);
            labelResult.Text = "Settings saved.";
        }

        /**
         * Load settings from config file
         */ 
        private void loadSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mApp.loadConfig();
            this.setFormValues();
            labelResult.ForeColor = Color.FromArgb(0, 150, 0);
            labelResult.Text = "Settings loaded.";
        }

        /**
         * Show About dialog box
         */
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: Michael Chan", "image2sprite", MessageBoxButtons.OK);
        }

        #endregion
    }
}
