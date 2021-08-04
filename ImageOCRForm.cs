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
    public partial class ImageOCRForm : Form
    {

        int xValue = 0;
        int yValue = 0;
        int heightValue = 0;
        int widthValue = 0;

        public ImageOCRForm()
        {
            InitializeComponent();
        }

        //Some controls are hidden when form get loaded, they will be visible as per user requirement.
        private void ImageOCRForm_Load(object sender, EventArgs e)
        {
            //Labels co-ordinates
            XaxisLabel.Hide();
            YaxisLabel.Hide();
            HeightLabel.Hide();
            WidthLabel.Hide();
            //text box co-ordinates
            Xvalue.Hide();
            Yvalue.Hide();
            HeightValue.Hide();
            WidthValue.Hide();
            //button extract region
            btnExtractAxis.Hide();
            //Error label
            ErrorLabel.Hide();
        }

        //Below button is used to browse the images of Format jpg and png
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            var ofdImage = new OpenFileDialog();
            ofdImage.Filter = "Image File|*.jpg;*.png"; //This format of images will be selected
            if(ofdImage.ShowDialog() == DialogResult.OK)
            {
                PictureBox.Image = Image.FromFile(ofdImage.FileName);
            }
        }

        //Using the below code ocr will be extracted from image from use of IronOCR package
        private void btnExtractImage_Click(object sender, EventArgs e)
        {
            var ImageOCR = new IronTesseract();
            if (PictureBox.Image != null)
            {
                using (var ImageInput = new OcrInput(PictureBox.Image))
                {
                    ImageOCR.Language = OcrLanguage.English;
                    //ImageInput.Deskew();  // use if image not straight
                    //ImageInput.DeNoise(); // use if image contains digital noise
                    var ImageResult = ImageOCR.Read(ImageInput);
                    ImageExtracted.Text = (ImageResult.Text);
                    ErrorLabel.Text = "";
                }
            }
            else
            {
                ErrorLabel.Text = "Please select an image first";
                ErrorLabel.Show();
            }

        }

        private void btnSelectRegion_Click(object sender, EventArgs e)
        {
            // Show labels
            XaxisLabel.Show();
            YaxisLabel.Show();
            HeightLabel.Show();
            WidthLabel.Show();
            //Show text box to get value pf co-ordinates from user
            Xvalue.Show();
            Yvalue.Show();
            HeightValue.Show();
            WidthValue.Show();

            btnExtractAxis.Show();
        }
        //Below code can be used to extract the text from certain location of choosed image
        private void btnExtractAxis_Click(object sender, EventArgs e)
        {
            if (Xvalue.Text != "" && Yvalue.Text != "" && HeightValue.Text != "" && WidthValue.Text != "")
            {
                xValue = Convert.ToInt32(Xvalue.Text);
                yValue = Convert.ToInt32(Yvalue.Text);
                heightValue = Convert.ToInt32(HeightValue.Text);
                widthValue = Convert.ToInt32(WidthValue.Text);

                using (var ImageInput = new OcrInput())
                {
                    var OCRRegion = new IronTesseract();
                    var ContentArea = new System.Drawing.Rectangle() { X = xValue, Y = yValue, Height = heightValue, Width = widthValue };
                    if (PictureBox.Image != null)
                    {
                        ImageInput.AddImage(PictureBox.Image, ContentArea);

                        var ImageResult = OCRRegion.Read(ImageInput);
                        ImageExtracted.Text = (ImageResult.Text);
                        ErrorLabel.Text = "";
                    }
                    else
                    {
                        ErrorLabel.Text = "Please select an image first";
                        ErrorLabel.Show();
                    }
                }
            }
            else
            {
                ErrorLabel.Text = "Give all values in text box before Extracting.";
                ErrorLabel.Show();
            }
        }

        //Below code is to take only numbers in co-ordinates value
        private void Xvalue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch != 8 && ch !=46)
            {
                e.Handled = true;
            }
        }
 
        private void Yvalue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void HeightValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void WidthValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
