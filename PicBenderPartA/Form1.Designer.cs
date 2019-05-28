namespace PicBenderPartA
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
            this.UI_PB_Picture = new System.Windows.Forms.PictureBox();
            this.UI_B1_LoadPicture = new System.Windows.Forms.Button();
            this.UI_PGB_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.UI_GB_ModificationType = new System.Windows.Forms.GroupBox();
            this.UI_RB4_Noise = new System.Windows.Forms.RadioButton();
            this.UI_RB3_Tint = new System.Windows.Forms.RadioButton();
            this.UI_RB2_BlackAndWhite = new System.Windows.Forms.RadioButton();
            this.UI_RB1_Contrast = new System.Windows.Forms.RadioButton();
            this.UI_TBar_Slider = new System.Windows.Forms.TrackBar();
            this.UI_B2_Transform = new System.Windows.Forms.Button();
            this.UI_L1_LeftSide = new System.Windows.Forms.Label();
            this.UI_L2_RightSide = new System.Windows.Forms.Label();
            this.UI_L3_Middle = new System.Windows.Forms.Label();
            this._OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.UI_PB_Picture)).BeginInit();
            this.UI_GB_ModificationType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_TBar_Slider)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_PB_Picture
            // 
            this.UI_PB_Picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_PB_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UI_PB_Picture.Location = new System.Drawing.Point(16, 15);
            this.UI_PB_Picture.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UI_PB_Picture.Name = "UI_PB_Picture";
            this.UI_PB_Picture.Size = new System.Drawing.Size(1538, 432);
            this.UI_PB_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UI_PB_Picture.TabIndex = 0;
            this.UI_PB_Picture.TabStop = false;
            // 
            // UI_B1_LoadPicture
            // 
            this.UI_B1_LoadPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_B1_LoadPicture.Location = new System.Drawing.Point(24, 498);
            this.UI_B1_LoadPicture.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UI_B1_LoadPicture.Name = "UI_B1_LoadPicture";
            this.UI_B1_LoadPicture.Size = new System.Drawing.Size(152, 63);
            this.UI_B1_LoadPicture.TabIndex = 1;
            this.UI_B1_LoadPicture.Text = "Load Picture";
            this.UI_B1_LoadPicture.UseVisualStyleBackColor = true;
            this.UI_B1_LoadPicture.Click += new System.EventHandler(this.UI_B1_LoadPicture_Click);
            // 
            // UI_PGB_ProgressBar
            // 
            this.UI_PGB_ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_PGB_ProgressBar.BackColor = System.Drawing.Color.White;
            this.UI_PGB_ProgressBar.ForeColor = System.Drawing.Color.Lime;
            this.UI_PGB_ProgressBar.Location = new System.Drawing.Point(16, 459);
            this.UI_PGB_ProgressBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UI_PGB_ProgressBar.Maximum = 1000;
            this.UI_PGB_ProgressBar.Name = "UI_PGB_ProgressBar";
            this.UI_PGB_ProgressBar.Size = new System.Drawing.Size(1538, 29);
            this.UI_PGB_ProgressBar.Step = 1;
            this.UI_PGB_ProgressBar.TabIndex = 2;
            // 
            // UI_GB_ModificationType
            // 
            this.UI_GB_ModificationType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_GB_ModificationType.Controls.Add(this.UI_RB4_Noise);
            this.UI_GB_ModificationType.Controls.Add(this.UI_RB3_Tint);
            this.UI_GB_ModificationType.Controls.Add(this.UI_RB2_BlackAndWhite);
            this.UI_GB_ModificationType.Controls.Add(this.UI_RB1_Contrast);
            this.UI_GB_ModificationType.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UI_GB_ModificationType.Location = new System.Drawing.Point(188, 501);
            this.UI_GB_ModificationType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UI_GB_ModificationType.Name = "UI_GB_ModificationType";
            this.UI_GB_ModificationType.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UI_GB_ModificationType.Size = new System.Drawing.Size(494, 119);
            this.UI_GB_ModificationType.TabIndex = 3;
            this.UI_GB_ModificationType.TabStop = false;
            this.UI_GB_ModificationType.Text = "Modification Type";
            // 
            // UI_RB4_Noise
            // 
            this.UI_RB4_Noise.AutoSize = true;
            this.UI_RB4_Noise.ForeColor = System.Drawing.SystemColors.Desktop;
            this.UI_RB4_Noise.Location = new System.Drawing.Point(302, 81);
            this.UI_RB4_Noise.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UI_RB4_Noise.Name = "UI_RB4_Noise";
            this.UI_RB4_Noise.Size = new System.Drawing.Size(98, 29);
            this.UI_RB4_Noise.TabIndex = 3;
            this.UI_RB4_Noise.Text = "Noise";
            this.UI_RB4_Noise.UseVisualStyleBackColor = true;
            this.UI_RB4_Noise.CheckedChanged += new System.EventHandler(this.SetLabels);
            // 
            // UI_RB3_Tint
            // 
            this.UI_RB3_Tint.AutoSize = true;
            this.UI_RB3_Tint.ForeColor = System.Drawing.SystemColors.Desktop;
            this.UI_RB3_Tint.Location = new System.Drawing.Point(302, 37);
            this.UI_RB3_Tint.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UI_RB3_Tint.Name = "UI_RB3_Tint";
            this.UI_RB3_Tint.Size = new System.Drawing.Size(79, 29);
            this.UI_RB3_Tint.TabIndex = 2;
            this.UI_RB3_Tint.Text = "Tint";
            this.UI_RB3_Tint.UseVisualStyleBackColor = true;
            this.UI_RB3_Tint.CheckedChanged += new System.EventHandler(this.UI_RB3_Tint_CheckedChanged);
            // 
            // UI_RB2_BlackAndWhite
            // 
            this.UI_RB2_BlackAndWhite.AutoSize = true;
            this.UI_RB2_BlackAndWhite.ForeColor = System.Drawing.SystemColors.Desktop;
            this.UI_RB2_BlackAndWhite.Location = new System.Drawing.Point(12, 81);
            this.UI_RB2_BlackAndWhite.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UI_RB2_BlackAndWhite.Name = "UI_RB2_BlackAndWhite";
            this.UI_RB2_BlackAndWhite.Size = new System.Drawing.Size(199, 29);
            this.UI_RB2_BlackAndWhite.TabIndex = 1;
            this.UI_RB2_BlackAndWhite.Text = "Black and White";
            this.UI_RB2_BlackAndWhite.UseVisualStyleBackColor = true;
            this.UI_RB2_BlackAndWhite.CheckedChanged += new System.EventHandler(this.SetLabels);
            // 
            // UI_RB1_Contrast
            // 
            this.UI_RB1_Contrast.AutoSize = true;
            this.UI_RB1_Contrast.Checked = true;
            this.UI_RB1_Contrast.ForeColor = System.Drawing.SystemColors.Desktop;
            this.UI_RB1_Contrast.Location = new System.Drawing.Point(12, 37);
            this.UI_RB1_Contrast.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UI_RB1_Contrast.Name = "UI_RB1_Contrast";
            this.UI_RB1_Contrast.Size = new System.Drawing.Size(124, 29);
            this.UI_RB1_Contrast.TabIndex = 0;
            this.UI_RB1_Contrast.TabStop = true;
            this.UI_RB1_Contrast.Text = "Contrast";
            this.UI_RB1_Contrast.UseVisualStyleBackColor = true;
            this.UI_RB1_Contrast.CheckedChanged += new System.EventHandler(this.SetLabels);
            // 
            // UI_TBar_Slider
            // 
            this.UI_TBar_Slider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_TBar_Slider.Location = new System.Drawing.Point(668, 498);
            this.UI_TBar_Slider.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UI_TBar_Slider.Name = "UI_TBar_Slider";
            this.UI_TBar_Slider.Size = new System.Drawing.Size(702, 90);
            this.UI_TBar_Slider.TabIndex = 4;
            this.UI_TBar_Slider.Scroll += new System.EventHandler(this.UI_TBar_Slider_Scroll);
            // 
            // UI_B2_Transform
            // 
            this.UI_B2_Transform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_B2_Transform.Enabled = false;
            this.UI_B2_Transform.Location = new System.Drawing.Point(1384, 498);
            this.UI_B2_Transform.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UI_B2_Transform.Name = "UI_B2_Transform";
            this.UI_B2_Transform.Size = new System.Drawing.Size(150, 44);
            this.UI_B2_Transform.TabIndex = 5;
            this.UI_B2_Transform.Text = "Transform";
            this.UI_B2_Transform.UseVisualStyleBackColor = true;
            this.UI_B2_Transform.Click += new System.EventHandler(this.UI_B2_Transform_Click);
            // 
            // UI_L1_LeftSide
            // 
            this.UI_L1_LeftSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_L1_LeftSide.AutoSize = true;
            this.UI_L1_LeftSide.ForeColor = System.Drawing.SystemColors.Desktop;
            this.UI_L1_LeftSide.Location = new System.Drawing.Point(674, 594);
            this.UI_L1_LeftSide.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UI_L1_LeftSide.Name = "UI_L1_LeftSide";
            this.UI_L1_LeftSide.Size = new System.Drawing.Size(58, 25);
            this.UI_L1_LeftSide.TabIndex = 6;
            this.UI_L1_LeftSide.Text = "Less";
            // 
            // UI_L2_RightSide
            // 
            this.UI_L2_RightSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_L2_RightSide.AutoSize = true;
            this.UI_L2_RightSide.Location = new System.Drawing.Point(1302, 594);
            this.UI_L2_RightSide.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UI_L2_RightSide.Name = "UI_L2_RightSide";
            this.UI_L2_RightSide.Size = new System.Drawing.Size(61, 25);
            this.UI_L2_RightSide.TabIndex = 7;
            this.UI_L2_RightSide.Text = "More";
            // 
            // UI_L3_Middle
            // 
            this.UI_L3_Middle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UI_L3_Middle.AutoSize = true;
            this.UI_L3_Middle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UI_L3_Middle.Location = new System.Drawing.Point(992, 596);
            this.UI_L3_Middle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UI_L3_Middle.Name = "UI_L3_Middle";
            this.UI_L3_Middle.Size = new System.Drawing.Size(24, 25);
            this.UI_L3_Middle.TabIndex = 8;
            this.UI_L3_Middle.Text = "0";
            // 
            // _OpenFileDialog
            // 
            this._OpenFileDialog.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this._OpenFileDialog.RestoreDirectory = true;
            this._OpenFileDialog.Title = "Select a Picture File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 700);
            this.Controls.Add(this.UI_L3_Middle);
            this.Controls.Add(this.UI_L2_RightSide);
            this.Controls.Add(this.UI_L1_LeftSide);
            this.Controls.Add(this.UI_B2_Transform);
            this.Controls.Add(this.UI_TBar_Slider);
            this.Controls.Add(this.UI_GB_ModificationType);
            this.Controls.Add(this.UI_PGB_ProgressBar);
            this.Controls.Add(this.UI_B1_LoadPicture);
            this.Controls.Add(this.UI_PB_Picture);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(1604, 771);
            this.Name = "Form1";
            this.Text = "PicBender";
            ((System.ComponentModel.ISupportInitialize)(this.UI_PB_Picture)).EndInit();
            this.UI_GB_ModificationType.ResumeLayout(false);
            this.UI_GB_ModificationType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_TBar_Slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UI_PB_Picture;
        private System.Windows.Forms.Button UI_B1_LoadPicture;
        private System.Windows.Forms.ProgressBar UI_PGB_ProgressBar;
        private System.Windows.Forms.GroupBox UI_GB_ModificationType;
        private System.Windows.Forms.RadioButton UI_RB4_Noise;
        private System.Windows.Forms.RadioButton UI_RB3_Tint;
        private System.Windows.Forms.RadioButton UI_RB2_BlackAndWhite;
        private System.Windows.Forms.RadioButton UI_RB1_Contrast;
        private System.Windows.Forms.TrackBar UI_TBar_Slider;
        private System.Windows.Forms.Button UI_B2_Transform;
        private System.Windows.Forms.Label UI_L1_LeftSide;
        private System.Windows.Forms.Label UI_L2_RightSide;
        private System.Windows.Forms.Label UI_L3_Middle;
        private System.Windows.Forms.OpenFileDialog _OpenFileDialog;
    }
}

