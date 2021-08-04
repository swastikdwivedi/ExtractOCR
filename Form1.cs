using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtractOCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This button will open the form for Extracting Image
        private void ExtractImageText_Click(object sender, EventArgs e)
        {
            this.Hide();
            ImageOCRForm imageOCRForm = new ImageOCRForm();
            imageOCRForm.Show();
        }

        //This button will open the form for extracting PDF
        private void ExtractPDFText_Click(object sender, EventArgs e)
        {
            this.Hide();
            PdfOCRForm pdfOCRform = new PdfOCRForm();
            pdfOCRform.Show();
        }
    }
}
