
namespace ExtractOCR
{
    partial class ImageOCRForm
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.btnExtractImage = new System.Windows.Forms.Button();
            this.ImageExtracted = new System.Windows.Forms.TextBox();
            this.XaxisLabel = new System.Windows.Forms.Label();
            this.YaxisLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.Xvalue = new System.Windows.Forms.TextBox();
            this.Yvalue = new System.Windows.Forms.TextBox();
            this.HeightValue = new System.Windows.Forms.TextBox();
            this.WidthValue = new System.Windows.Forms.TextBox();
            this.btnSelectRegion = new System.Windows.Forms.Button();
            this.btnExtractAxis = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox.Location = new System.Drawing.Point(23, 41);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(443, 259);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseImage.Location = new System.Drawing.Point(23, 317);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(75, 29);
            this.btnBrowseImage.TabIndex = 1;
            this.btnBrowseImage.Text = "Browse";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // btnExtractImage
            // 
            this.btnExtractImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtractImage.Location = new System.Drawing.Point(336, 308);
            this.btnExtractImage.Name = "btnExtractImage";
            this.btnExtractImage.Size = new System.Drawing.Size(130, 29);
            this.btnExtractImage.TabIndex = 2;
            this.btnExtractImage.Text = "Extract All";
            this.btnExtractImage.UseVisualStyleBackColor = true;
            this.btnExtractImage.Click += new System.EventHandler(this.btnExtractImage_Click);
            // 
            // ImageExtracted
            // 
            this.ImageExtracted.Location = new System.Drawing.Point(518, 41);
            this.ImageExtracted.Multiline = true;
            this.ImageExtracted.Name = "ImageExtracted";
            this.ImageExtracted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ImageExtracted.Size = new System.Drawing.Size(208, 231);
            this.ImageExtracted.TabIndex = 3;
            this.ImageExtracted.Text = "Extracted text will appear here: ";
            // 
            // XaxisLabel
            // 
            this.XaxisLabel.AutoSize = true;
            this.XaxisLabel.ForeColor = System.Drawing.Color.White;
            this.XaxisLabel.Location = new System.Drawing.Point(515, 285);
            this.XaxisLabel.Name = "XaxisLabel";
            this.XaxisLabel.Size = new System.Drawing.Size(51, 17);
            this.XaxisLabel.TabIndex = 4;
            this.XaxisLabel.Text = "X-Axis:";
            // 
            // YaxisLabel
            // 
            this.YaxisLabel.AutoSize = true;
            this.YaxisLabel.ForeColor = System.Drawing.Color.White;
            this.YaxisLabel.Location = new System.Drawing.Point(515, 313);
            this.YaxisLabel.Name = "YaxisLabel";
            this.YaxisLabel.Size = new System.Drawing.Size(51, 17);
            this.YaxisLabel.TabIndex = 5;
            this.YaxisLabel.Text = "Y-Axis:";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.ForeColor = System.Drawing.Color.White;
            this.HeightLabel.Location = new System.Drawing.Point(515, 343);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(53, 17);
            this.HeightLabel.TabIndex = 6;
            this.HeightLabel.Text = "Height:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.ForeColor = System.Drawing.Color.White;
            this.WidthLabel.Location = new System.Drawing.Point(515, 372);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(48, 17);
            this.WidthLabel.TabIndex = 7;
            this.WidthLabel.Text = "Width:";
            // 
            // Xvalue
            // 
            this.Xvalue.Location = new System.Drawing.Point(572, 285);
            this.Xvalue.Name = "Xvalue";
            this.Xvalue.Size = new System.Drawing.Size(154, 22);
            this.Xvalue.TabIndex = 8;
            this.Xvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Xvalue_KeyPress);
            // 
            // Yvalue
            // 
            this.Yvalue.Location = new System.Drawing.Point(572, 313);
            this.Yvalue.Name = "Yvalue";
            this.Yvalue.Size = new System.Drawing.Size(154, 22);
            this.Yvalue.TabIndex = 9;
            this.Yvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Yvalue_KeyPress);
            // 
            // HeightValue
            // 
            this.HeightValue.Location = new System.Drawing.Point(572, 343);
            this.HeightValue.Name = "HeightValue";
            this.HeightValue.Size = new System.Drawing.Size(154, 22);
            this.HeightValue.TabIndex = 10;
            this.HeightValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightValue_KeyPress);
            // 
            // WidthValue
            // 
            this.WidthValue.Location = new System.Drawing.Point(572, 372);
            this.WidthValue.Name = "WidthValue";
            this.WidthValue.Size = new System.Drawing.Size(154, 22);
            this.WidthValue.TabIndex = 11;
            this.WidthValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WidthValue_KeyPress);
            // 
            // btnSelectRegion
            // 
            this.btnSelectRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectRegion.Location = new System.Drawing.Point(336, 343);
            this.btnSelectRegion.Name = "btnSelectRegion";
            this.btnSelectRegion.Size = new System.Drawing.Size(130, 30);
            this.btnSelectRegion.TabIndex = 12;
            this.btnSelectRegion.Text = "Select Region";
            this.btnSelectRegion.UseVisualStyleBackColor = true;
            this.btnSelectRegion.Click += new System.EventHandler(this.btnSelectRegion_Click);
            // 
            // btnExtractAxis
            // 
            this.btnExtractAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtractAxis.Location = new System.Drawing.Point(572, 400);
            this.btnExtractAxis.Name = "btnExtractAxis";
            this.btnExtractAxis.Size = new System.Drawing.Size(154, 31);
            this.btnExtractAxis.TabIndex = 13;
            this.btnExtractAxis.Text = "Extract Region";
            this.btnExtractAxis.UseVisualStyleBackColor = true;
            this.btnExtractAxis.Click += new System.EventHandler(this.btnExtractAxis_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.Color.Red;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.White;
            this.ErrorLabel.Location = new System.Drawing.Point(19, 367);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(52, 20);
            this.ErrorLabel.TabIndex = 14;
            this.ErrorLabel.Text = "Error";
            // 
            // ImageOCRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(769, 456);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.btnExtractAxis);
            this.Controls.Add(this.btnSelectRegion);
            this.Controls.Add(this.WidthValue);
            this.Controls.Add(this.HeightValue);
            this.Controls.Add(this.Yvalue);
            this.Controls.Add(this.Xvalue);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.YaxisLabel);
            this.Controls.Add(this.XaxisLabel);
            this.Controls.Add(this.ImageExtracted);
            this.Controls.Add(this.btnExtractImage);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.PictureBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ImageOCRForm";
            this.Text = "Image OCR Extractor";
            this.Load += new System.EventHandler(this.ImageOCRForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Button btnExtractImage;
        private System.Windows.Forms.TextBox ImageExtracted;
        private System.Windows.Forms.Label XaxisLabel;
        private System.Windows.Forms.Label YaxisLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox Xvalue;
        private System.Windows.Forms.TextBox Yvalue;
        private System.Windows.Forms.TextBox HeightValue;
        private System.Windows.Forms.TextBox WidthValue;
        private System.Windows.Forms.Button btnSelectRegion;
        private System.Windows.Forms.Button btnExtractAxis;
        private System.Windows.Forms.Label ErrorLabel;
    }
}