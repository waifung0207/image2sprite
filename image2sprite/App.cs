using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

using System.Configuration;
using System.Collections.Specialized;

namespace image2sprite
{
    /**
     * Fields to be saved in app.config file
     */
    enum ConfigFields
    {
        InputDir,
        InputImageFormat,
        OutputDir,
        OutputImageName,
        OutputImageFormat,
        OutputImageQuality,
        NumPicPerRow,
        EnableColorKey,
        ColorKeyR,
        ColorKeyG,
        ColorKeyB,
        SpriteAuto,
        SpriteWidth,
        SpriteHeight
    };

    /**
     * Main App class
     */
    class App
    {
        // to store configuration values
        private NameValueCollection mSettings = null;
        
        /**
         * constructor
         */
        public App()
        {
            // read parameters from config file
            this.loadConfig();
        }

        /**
         * Load configuration from file
         */
        public void loadConfig()
        {
            // from local config file, e.g. image2sprite.exe.Config
            mSettings = ConfigurationManager.AppSettings;
        }

        /**
         * Save configuration to file
         */
        public void saveConfig()
        {
            // create the object
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // make changes
            foreach (String key in mSettings)
            {
                var value = mSettings[key];
                config.AppSettings.Settings[key].Value = value;
            }

            // save to apply changes
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        /**
         * General functions for get / update settings
         */
        public String getSettings(ConfigFields _key)
        {
            String key = _key.ToString();
            return mSettings[key];
        }
        public void updateSettings(ConfigFields _key, String _value)
        {
            String key = _key.ToString();
            mSettings[key] = _value;
        }

        /**
         * Set color key of sprite sheet
         */
        public void updateColorKey(bool _enabled, String _r, String _g, String _b)
        {
            this.updateSettings(ConfigFields.EnableColorKey, _enabled.ToString());
            this.updateSettings(ConfigFields.ColorKeyR, _r);
            this.updateSettings(ConfigFields.ColorKeyG, _g);
            this.updateSettings(ConfigFields.ColorKeyB, _b);
        }

        /**
         * Set parameters of each sprite
         */
        public void updateSpriteParams(bool _auto, String _w, String _h)
        {
            this.updateSettings(ConfigFields.SpriteAuto, _auto.ToString());
            this.updateSettings(ConfigFields.SpriteWidth, _w);
            this.updateSettings(ConfigFields.SpriteHeight, _h);
        }

        /**
         * Confirm to create spritesheet
         */
        public bool makeSprite()
        {
            try
            {
                // get all required values from settings
                String input_dir            = this.getSettings(ConfigFields.InputDir);
                String input_image_format   = this.getSettings(ConfigFields.InputImageFormat);
                String output_dir           = this.getSettings(ConfigFields.OutputDir);
                String output_image_name    = this.getSettings(ConfigFields.OutputImageName);
                String output_image_format  = this.getSettings(ConfigFields.OutputImageFormat);
                int output_image_quality    = int.Parse(this.getSettings(ConfigFields.OutputImageQuality));
                int num_per_row             = int.Parse(this.getSettings(ConfigFields.NumPicPerRow));
                bool sprite_auto            = bool.Parse(this.getSettings(ConfigFields.SpriteAuto));
                int sprite_width            = int.Parse(this.getSettings(ConfigFields.SpriteWidth));
                int sprite_height           = int.Parse(this.getSettings(ConfigFields.SpriteHeight));
                bool color_enabled          = bool.Parse(this.getSettings(ConfigFields.EnableColorKey));
                int color_r                 = int.Parse(this.getSettings(ConfigFields.ColorKeyR));
                int color_g                 = int.Parse(this.getSettings(ConfigFields.ColorKeyG));
                int color_b                 = int.Parse(this.getSettings(ConfigFields.ColorKeyB));

                // full path for output spritesheet
                String output_image_path = output_dir + "\\" + output_image_name + "." + output_image_format;

                // delete the previously created image if exists
                if (File.Exists(output_image_path))
                    File.Delete(output_image_path);

                // get all files inside the input folder
                String[] input_files = Directory.GetFiles(input_dir, "*." + input_image_format, SearchOption.TopDirectoryOnly);

                // exception: no input files found
                if (input_files.Length == 0)
                {
                    MessageBox.Show("No images found in Input Folder", "Error");
                    return false;
                }

                // check the total width and height for new image
                Image first_image = Image.FromFile(input_files[0]);

                // handle situation when number of source images is less than "num_per_row"
                if (input_files.Length < num_per_row)
                    num_per_row = input_files.Length;

                // values for calculating dimensions
                int each_width, each_height, total_width, total_height;
                double row_num = (double)input_files.Length / (double)num_per_row;

                if (sprite_auto == true)
                {
                    // automatically obtain sprite dimensions by reading first image
                    each_width = first_image.Width;
                    each_height = first_image.Height;
                    total_width = first_image.Width * num_per_row;
                    total_height = first_image.Height * (int)Math.Ceiling(row_num);
                }
                else
                {
                    // use dimensions input by user
                    each_width = sprite_width;
                    each_height = sprite_height;
                    total_width = sprite_width * num_per_row;
                    total_height = sprite_height * (int)Math.Ceiling(row_num);
                }

                // prepare new image to store sprite sheet
                Bitmap output_bitmap = new Bitmap(total_width, total_height);
                Graphics output_canvas = Graphics.FromImage(output_bitmap);
                output_canvas.InterpolationMode = InterpolationMode.HighQualityBicubic;

                // set color key (optional)
                if (color_enabled)
                {
                    Color color_key = Color.FromArgb(color_r, color_g, color_b);
                    output_canvas.Clear(color_key);
                }

                // for counting
                int x = 0, y = 0, count_per_row = 0;

                // put each image onto the new image
                foreach (String imagePath in input_files)
                {
                    Image tmp_image = Image.FromFile(imagePath);
                    output_canvas.DrawImage(tmp_image, x, y, each_width, each_height);

                    // increment counts
                    x += each_width;
                    count_per_row++;

                    // jump to next row
                    if (count_per_row >= num_per_row)
                    {
                        x = 0;
                        y += each_height;
                        count_per_row = 0;
                    }
                }

                // output image to specific format
                output_canvas.Save();
                switch (output_image_format)
                {
                    case "png":
                        output_bitmap.Save(output_image_path, ImageFormat.Png);
                        break;
                    case "jpg":
                        // output with chosen Jpeg quality
                        ImageCodecInfo jgpEncoder = GetEncoder(ImageFormat.Jpeg);
                        System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                        EncoderParameters myEncoderParameters = new EncoderParameters(1);
                        EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, output_image_quality);
                        myEncoderParameters.Param[0] = myEncoderParameter;
                        output_bitmap.Save(output_image_path, jgpEncoder, myEncoderParameters);
                        break;
                    case "gif":
                        output_bitmap.Save(output_image_path, ImageFormat.Gif);
                        break;
                }

                // success
                return true;
            }
            catch (Exception e)
            {
                // failed
                MessageBox.Show("Error occurs: \n" + e.Message);
                return false;
            }
        }

        /**
         * Functions required for changing encoding quality
         * Reference: http://msdn.microsoft.com/en-us/library/bb882583%28v=vs.110%29.aspx
         */
        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
    }
}
