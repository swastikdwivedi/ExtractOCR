
namespace ExtractOCR
{
    partial class PdfOCRForm
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
            this.btnBrowsePDF = new System.Windows.Forms.Button();
            this.btnExtractPDF = new System.Windows.Forms.Button();
            this.ExtractedPDF = new System.Windows.Forms.TextBox();
            this.PagesNo = new System.Windows.Forms.Label();
            this.PageCount = new System.Windows.Forms.Label();
            this.PDFError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrowsePDF
            // 
            this.btnBrowsePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowsePDF.Location = new System.Drawing.Point(173, 311);
            this.btnBrowsePDF.Name = "btnBrowsePDF";
            this.btnBrowsePDF.Size = new System.Drawing.Size(75, 32);
            this.btnBrowsePDF.TabIndex = 0;
            this.btnBrowsePDF.Text = "Browse";
            this.btnBrowsePDF.UseVisualStyleBackColor = true;
            this.btnBrowsePDF.Click += new System.EventHandler(this.btnBrowsePDF_Click);
            // 
            // btnExtractPDF
            // 
            this.btnExtractPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtractPDF.Location = new System.Drawing.Point(348, 311);
            this.btnExtractPDF.Name = "btnExtractPDF";
            this.btnExtractPDF.Size = new System.Drawing.Size(75, 32);
            this.btnExtractPDF.TabIndex = 1;
            this.btnExtractPDF.Text = "Extract";
            this.btnExtractPDF.UseVisualStyleBackColor = true;
            this.btnExtractPDF.Click += new System.EventHandler(this.btnExtractPDF_Click);
            // 
            // ExtractedPDF
            // 
            this.ExtractedPDF.Location = new System.Drawing.Point(85, 12);
            this.ExtractedPDF.Multiline = true;
            this.ExtractedPDF.Name = "ExtractedPDF";
            this.ExtractedPDF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ExtractedPDF.Size = new System.Drawing.Size(434, 293);
            this.ExtractedPDF.TabIndex = 2;
            // 
            // PagesNo
            // 
            this.PagesNo.AutoSize = true;
            this.PagesNo.BackColor = System.Drawing.Color.Transparent;
            this.PagesNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PagesNo.ForeColor = System.Drawing.Color.White;
            this.PagesNo.Location = new System.Drawing.Point(536, 15);
            this.PagesNo.Name = "PagesNo";
            this.PagesNo.Size = new System.Drawing.Size(105, 17);
            this.PagesNo.TabIndex = 3;
            this.PagesNo.Text = "Total Pages: ";
            // 
            // PageCount
            // 
            this.PageCount.AutoSize = true;
            this.PageCount.ForeColor = System.Drawing.Color.White;
            this.PageCount.Location = new System.Drawing.Point(647, 15);
            this.PageCount.Name = "PageCount";
            this.PageCount.Size = new System.Drawing.Size(0, 17);
            this.PageCount.TabIndex = 4;
            // 
            // PDFError
            // 
            this.PDFError.AutoSize = true;
            this.PDFError.BackColor = System.Drawing.Color.Red;
            this.PDFError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDFError.ForeColor = System.Drawing.Color.White;
            this.PDFError.Location = new System.Drawing.Point(82, 406);
            this.PDFError.Name = "PDFError";
            this.PDFError.Size = new System.Drawing.Size(0, 20);
            this.PDFError.TabIndex = 5;
            // 
            // PdfOCRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PDFError);
            this.Controls.Add(this.PageCount);
            this.Controls.Add(this.PagesNo);
            this.Controls.Add(this.ExtractedPDF);
            this.Controls.Add(this.btnExtractPDF);
            this.Controls.Add(this.btnBrowsePDF);
            this.Name = "PdfOCRForm";
            this.Text = "PDF OCR Extractor";
            this.Load += new System.EventHandler(this.PdfOCRForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowsePDF;
        private System.Windows.Forms.Button btnExtractPDF;
        private System.Windows.Forms.TextBox ExtractedPDF;
        private System.Windows.Forms.Label PagesNo;
        private System.Windows.Forms.Label PageCount;
        private System.Windows.Forms.Label PDFError;
    }
}