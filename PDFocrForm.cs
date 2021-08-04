using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronOcr;

namespace ExtractOCR
{
    public partial class PdfOCRForm : Form
    {
        string PDFPath;
        public PdfOCRForm()
        {
            InitializeComponent();
        }

        //This button will browse the pdf file which user want to extract
        private void btnBrowsePDF_Click(object sender, EventArgs e)
        {
            var ofdPDF = new OpenFileDialog();
            ofdPDF.Filter = "PDF|*.pdf";
            if (ofdPDF.ShowDialog() == DialogResult.OK)
            {
               PDFPath = ofdPDF.FileName;
               ExtractedPDF.Text = "Click on Extract button";
            }
        }

        //Below is the code for extracting text from pdf
        private void btnExtractPDF_Click(object sender, EventArgs e)
        {
            if (PDFPath != null)
            {
                var PDFOcr = new IronTesseract();
                using (var PDFInput = new OcrInput())
                {
                    // OCR entire document
                    PDFInput.AddPdf(PDFPath);
                    var Result = PDFOcr.Read(PDFPath);
                    ExtractedPDF.Text = Result.Text; //Extracted text will be shown in text box in form 
                    PageCount.Text = Result.Pages.Count().ToString(); //This is to count the number of pages in pdf
                    PDFError.Text = "";
                }
            }
            else
            {
                PDFError.Show();
                PDFError.Text = "Please select a pdf file.";
            }
        }

        private void PdfOCRForm_Load(object sender, EventArgs e)
        {
            PDFError.Hide();
        }
    }
}
