
namespace ExtractOCR
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
            this.label1 = new System.Windows.Forms.Label();
            this.ExtractImageText = new System.Windows.Forms.Button();
            this.ExtractPDFText = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image PDF OCR Extractor";
            // 
            // ExtractImageText
            // 
            this.ExtractImageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtractImageText.Location = new System.Drawing.Point(151, 347);
            this.ExtractImageText.Name = "ExtractImageText";
            this.ExtractImageText.Size = new System.Drawing.Size(178, 34);
            this.ExtractImageText.TabIndex = 1;
            this.ExtractImageText.Text = "Extract Image Text";
            this.ExtractImageText.UseVisualStyleBackColor = true;
            this.ExtractImageText.Click += new System.EventHandler(this.ExtractImageText_Click);
            // 
            // ExtractPDFText
            // 
            this.ExtractPDFText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtractPDFText.Location = new System.Drawing.Point(502, 347);
            this.ExtractPDFText.Name = "ExtractPDFText";
            this.ExtractPDFText.Size = new System.Drawing.Size(169, 34);
            this.ExtractPDFText.TabIndex = 2;
            this.ExtractPDFText.Text = "Extract PDF Text";
            this.ExtractPDFText.UseVisualStyleBackColor = true;
            this.ExtractPDFText.Click += new System.EventHandler(this.ExtractPDFText_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(148, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 68);
            this.label2.TabIndex = 3;
            this.label2.Text = "We sometime face problem to extract text from Image or any PDF.\r\n\r\nTo solve that " +
    "probelm we are introducing Image PDF OCR Extractor \r\nwhich solve the probelm of " +
    "getting text from Image or PDF.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExtractPDFText);
            this.Controls.Add(this.ExtractImageText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "OCR Extractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExtractImageText;
        private System.Windows.Forms.Button ExtractPDFText;
        private System.Windows.Forms.Label label2;
    }
}

