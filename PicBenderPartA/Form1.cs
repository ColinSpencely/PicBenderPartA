// Name:            Colin Spencely
// Date:            11/3/2016 (added title block)
// Class:           CMPE1600
// Instructor:      Simon Walker
//
// PicBenderPartA
//
// Load and manipulate pixels in an image (contrast, black and white, tint, noise).

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicBenderPartA
{
    public partial class Form1 : Form
    {
        const int UPPERBOUND = 255; // Upper bound of colour range.
        const int MIDPOINT = 128; // Midpoint value of colour range.
        const double CONTRASTMOD = 0.2; // Contrast modifier.
        const int PERCENTAGE = 100; // Maximum slider value.
        Random random = new Random(); // For random number generation.

        public Form1()
        {
            InitializeComponent();
            UI_TBar_Slider.SetRange(0, PERCENTAGE); // Set range of slider.
        }

        // When Load Picture is clicked, open file dialog is displayed and user is able
        // to select a file.
        // If file is invalid or any I/O error occurs, a message box pops up to inform the 
        // user of the error.
        private void UI_B1_LoadPicture_Click(object sender, EventArgs e)
        {
            // If a picture has already been loaded, disable Transform button until new picture loaded.
            if (UI_B1_LoadPicture.Enabled)
            {
                UI_B2_Transform.Enabled = false;
            }
            // Check if user closed file dialog by loading a picture file.
            if (_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Do this if user chose a valid picture file.
                try
                {
                    UI_PB_Picture.Load(_OpenFileDialog.FileName); // Load picture.
                    UI_B2_Transform.Enabled = true;
                }
                // If error occurs, display message box.
                catch
                {
                    MessageBox.Show("Picture cannot be loaded!",
                        "File I/O Error!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                }
            }
        }

        // Method runs appropriate pixel manipulation method when Transform button is clicked.
        private void UI_B2_Transform_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(UI_PB_Picture.Image); // Create a new BitMap from the image for editing purposes.
            Color pixel = new Color(); // Holds original pixel.
            Color newPixel = new Color(); // Holds transformed pixel.
            UI_PGB_ProgressBar.Maximum = bm.Height * bm.Width;
            UI_PGB_ProgressBar.Value = 0;

            if (UI_RB1_Contrast.Checked)
            {
                // Loop through each row...
                for (int y = 0; y < bm.Height; ++y)
                {
                    // Loop through each column...
                    for (int x = 0; x < bm.Width; ++x)
                    {
                        pixel = bm.GetPixel(x, y); // Get pixel from bitmap.
                        newPixel = PixelContrast(pixel); // Contrast op on pixel.
                        bm.SetPixel(x, y, newPixel); // Set pixel in bitmap.
                        UI_PGB_ProgressBar.Value += 1;
                    }
                }
                UI_PB_Picture.Image = bm; // Load contrasted bitmap into window.
            }
            else if (UI_RB2_BlackAndWhite.Checked)
            {
                // Loop through each row...
                for (int y = 0; y < bm.Height; ++y)
                {
                    // Loop through each column...
                    for (int x = 0; x < bm.Width; ++x)
                    {
                        pixel = bm.GetPixel(x, y); // Get pixel from bitmap.
                        newPixel = PixelGrayscale(pixel); // Contrast op on pixel.
                        bm.SetPixel(x, y, newPixel); // Set pixel in bitmap.
                        UI_PGB_ProgressBar.Value += 1;
                    }
                }
                UI_PB_Picture.Image = bm; // Load black and white bitmap into window.
            }
            else if (UI_RB3_Tint.Checked)
            {
                // Loop through each row...
                for (int y = 0; y < bm.Height; ++y)
                {
                    // Loop through each column...
                    for (int x = 0; x < bm.Width; ++x)
                    {
                        pixel = bm.GetPixel(x, y); // Get pixel from bitmap.
                        newPixel = PixelTint(pixel); // Contrast op on pixel.
                        bm.SetPixel(x, y, newPixel); // Set pixel in bitmap.
                        UI_PGB_ProgressBar.Value += 1;
                    }
                }
                UI_PB_Picture.Image = bm; // Load tinted bitmap into window.
            }
            else if (UI_RB4_Noise.Checked)
            {
                // Loop through each row...
                for (int y = 0; y < bm.Height; ++y)
                {
                    // Loop through each column...
                    for (int x = 0; x < bm.Width; ++x)
                    {
                        pixel = bm.GetPixel(x, y); // Get pixel from bitmap.
                        newPixel = PixelNoise(pixel); // Contrast op on pixel.
                        bm.SetPixel(x, y, newPixel); // Set pixel in bitmap.
                        UI_PGB_ProgressBar.Value += 1;
                    }
                }
                UI_PB_Picture.Image = bm; // Load noisy bitmap into window.
            }
        }

        // Method adds noise to a pixel.
        private Color PixelNoise(Color pixel)
        {
            int red = pixel.R + (random.Next() % ((UI_TBar_Slider.Value + 1) * 2)) - UI_TBar_Slider.Value; // Perform noise op.

            // After op, if red is greater than upperbound...
            if (red > UPPERBOUND)
            {
                red = UPPERBOUND; // Set red to upperbound.
            }
            // After op, if red is less than 0...
            else if (red < 0)
            {
                red = 0; // Set red to 0.
            }

            int green = pixel.G + (random.Next() % ((UI_TBar_Slider.Value + 1) * 2)) - UI_TBar_Slider.Value; // Perform noise op.

            // After op, if green is greater than upperbound.
            if (green > UPPERBOUND)
            {
                green = UPPERBOUND; // Set green to upperbound.
            }
            // After op, if green is less than 0...
            else if (green < 0)
            {
                green = 0; // Set green to 0.
            }

            int blue = pixel.B + (random.Next() % ((UI_TBar_Slider.Value + 1) * 2)) - UI_TBar_Slider.Value; // Perform noise op.

            // After op, if blue is greater than upperbound...
            if (blue > UPPERBOUND)
            {
                blue = UPPERBOUND; // Set blue to upperbound.
            }
            // After op, if blue is less than 0...
            else if (blue < 0)
            {
                blue = 0; // Set blue to 0.
            }

            return Color.FromArgb(red, green, blue); // Return modified Color to calling method.
        }

        // Method performs tint operation on a pixel.
        private Color PixelTint(Color pixel)
        {
            int red = pixel.R; // Set red to value of original pixel red.
            int green = pixel.G; // Set green to value of original pixel green.
            int blue = pixel.B; // Set blue to value of original pixel blue.

            // Slider less than midpoint...
            if (UI_TBar_Slider.Value < PERCENTAGE / 2)
            {
                red += PERCENTAGE / 2 - UI_TBar_Slider.Value; // Perform tint op.

                // After op, if red greater than upperbound...
                if (red > UPPERBOUND)
                {
                    red = UPPERBOUND; // Set red to upperbound.
                }
                // After op, if red less than 0...
                else if (red < 0)
                {
                    red = 0; // Set red to 0.
                }
            }
            // Slider above midpoint...
            else if (UI_TBar_Slider.Value > PERCENTAGE / 2)
            {
                green += UI_TBar_Slider.Value - PERCENTAGE / 2; // Perform tint op.

                // After op, if green greater than upperbound...
                if (green > UPPERBOUND)
                {
                    green = UPPERBOUND; // Set green to upperbound.
                }
                // After op, if green less than 0...
                else if (green < 0)
                {
                    green = 0; // Set green to 0.
                }
            }

            return Color.FromArgb(red, green, blue); // Return color to calling function.
        }

        // Method performs grayscale op on a pixel.
        private Color PixelGrayscale(Color pixel)
        {
            int red = pixel.R; // Set red to value of original pixel red.
            int green = pixel.G; // Set green to value of original pixel green.
            int blue = pixel.B; // Set blue to value of original pixel blue.
            double average = (double)((red + green + blue) / 3); // Find average of three colour values.

            red = (int)(red + (average - red) * UI_TBar_Slider.Value / 100);
            // After op, red greater than upperbound.
            if (red > UPPERBOUND)
            {
                red = UPPERBOUND; // Set red to upperbound.
            }
            // After op, red is less than 0.
            else if (red < 0)
            {
                red = 0; // Set red to 0.
            }

            green = (int)(green + (average - green) * UI_TBar_Slider.Value / 100);
            // After op, green greater than upperbound.
            if (green > UPPERBOUND)
            {
                green = UPPERBOUND; // Set green to upperbound.
            }
            // After op, green is less than 0.
            else if (green < 0)
            {
                green = 0; // Set green to 0.
            }

            blue = (int)(blue + (average - blue) * UI_TBar_Slider.Value / 100);
            // After op, blue greater than upperbound.
            if (blue > UPPERBOUND)
            {
                blue = UPPERBOUND; // Set blue to upperbound.
            }
            // After op, blue is less than 0.
            else if (blue < 0)
            {
                blue = 0; // Set blue to 0.
            }

            return Color.FromArgb(red, green, blue); // Return pixel to calling function.
        }

        // Method tranforms by pixel contrast.
        private Color PixelContrast(Color pixel)
        {
            int red = 0; // Holds red value.
            int green = 0; // Holds green value.
            int blue = 0; // Holds blue value.

            //  Red greater than midpoint.
            if (pixel.R > MIDPOINT)
            {
                red = (int)(pixel.R + CONTRASTMOD * UI_TBar_Slider.Value);
                // After op, red greater than upperbound.
                if (red > UPPERBOUND)
                {
                    red = UPPERBOUND; // Set red to upperbound.
                }
            }
            // Red less than midpoint.
            else if (pixel.R < MIDPOINT)
            {
                red = (int)(pixel.R - CONTRASTMOD * UI_TBar_Slider.Value);
                // After op, red less than 0.
                if (red < 0)
                {
                    red = 0; // Set red to 0.
                }
            }
            // Red at midpoint.
            else
            {
                red = pixel.R; // Red stays constant.
            }

            // Green greater than midpoint.
            if (pixel.G > MIDPOINT)
            {
                green = (int)(pixel.G + CONTRASTMOD * UI_TBar_Slider.Value);
                // After op, green greater than upperbound.
                if (green > UPPERBOUND)
                {
                    green = UPPERBOUND; // Set green to upperbound.
                }
            }
            // Green less than midpoint.
            else if (pixel.G < MIDPOINT)
            {
                green = (int)(pixel.G - CONTRASTMOD * UI_TBar_Slider.Value);
                // After op, green is less than 0.
                if (green < 0)
                {
                    green = 0; // Set green to 0.
                }
            }
            // Green at midpoint.
            else
            {
                green = pixel.G; // Green stays constant.
            }

            // Blue greater than midpoint.
            if (pixel.B > MIDPOINT)
            {
                blue = (int)(pixel.B + CONTRASTMOD * UI_TBar_Slider.Value);
                // After op, blue greater than upperbound.
                if (blue > UPPERBOUND)
                {
                    blue = UPPERBOUND; // Set blue to upperbound.
                }
            }
            // Blue is less than midpoint.
            else if (pixel.B < MIDPOINT)
            {
                blue = (int)(pixel.B - CONTRASTMOD * UI_TBar_Slider.Value);
                // After op, blue is less than 0.
                if (blue < 0)
                {
                    blue = 0; // Set blue to 0.
                }
            }
            // Blue at midpoint.
            else
            {
                blue = pixel.B; // Blue stays constant.
            }

            return Color.FromArgb(red, green, blue); // Return pixel to calling function.
        }

        // Method displays value of slider in label.
        private void UI_TBar_Slider_Scroll(object sender, EventArgs e)
        {
            // For tint op...
            if (UI_RB3_Tint.Checked)
            {
                if (UI_TBar_Slider.Value < PERCENTAGE / 2)
                {
                    UI_L3_Middle.Text = "To Red: " + (PERCENTAGE / 2 - UI_TBar_Slider.Value).ToString();
                }
                else if (UI_TBar_Slider.Value > PERCENTAGE / 2)
                {
                    UI_L3_Middle.Text = "To Green: " + (UI_TBar_Slider.Value - PERCENTAGE / 2).ToString();
                }
                else
                {
                    UI_L3_Middle.Text = (UI_TBar_Slider.Value - PERCENTAGE / 2).ToString();
                }
            }
            // For all other ops...
            else
            {
                UI_L3_Middle.Text = UI_TBar_Slider.Value.ToString();
            }
        }

        // Method changes applicable labels if Tint radio button is checked.
        private void UI_RB3_Tint_CheckedChanged(object sender, EventArgs e)
        {
            UI_L1_LeftSide.Text = "Red";
            UI_L2_RightSide.Text = "Green";
            if (UI_TBar_Slider.Value < PERCENTAGE / 2)
            {
                UI_L3_Middle.Text = "To Red: " + (PERCENTAGE / 2 - UI_TBar_Slider.Value).ToString();
            }
            else if (UI_TBar_Slider.Value > PERCENTAGE / 2)
            {
                UI_L3_Middle.Text = "To Green: " + (UI_TBar_Slider.Value - PERCENTAGE / 2).ToString();
            }
            else
            {
                UI_L3_Middle.Text = (UI_TBar_Slider.Value - PERCENTAGE / 2).ToString();
            }
        }

        // Method sets labels for all operations except Tint.
        private void SetLabels(object sender, EventArgs e)
        {
            UI_L1_LeftSide.Text = "Less";
            UI_L2_RightSide.Text = "More";
            UI_L3_Middle.Text = UI_TBar_Slider.Value.ToString();
        }
    }
}

