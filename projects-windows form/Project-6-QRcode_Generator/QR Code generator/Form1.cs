using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronBarCode;
using System;
using System.Drawing;
using System.Linq;

namespace QR_Code_generator
{
    public partial class Form1 : Form
    {
        //*problem:1.if the custom size is larger,the red label won't show up.
        //2.can't change the size in the url mode.it will went wrong.
        //3.the beauty of the ui need to improve.
        //4.can't save the file in the url mode.
        //*issue:why the function of the text and url need to be divided.
        //*important:the tab of the text and url is divided.But the some buttons function are in sync with two tab.
        public static int pxValue=300;
        
        public Form1()
        {
            InitializeComponent();
        }
        public void  generateTextQRcode()
        {

            /*QRCodeWriter.CreateQrCode(enterText_textbox.Text, 500, QRCodeWriter.QrErrorCorrectionLevel.Medium).SaveAsImage.
            //qr_code_picbox_text.Image
            System.Diagnostics.Process.Start("MyQR.png");
            //qr_code_picbox.Image = "MyQR.png";*/

            var MyQRcode = QRCodeWriter.CreateQrCode(enterText_textbox.Text, pxValue, QRCodeWriter.QrErrorCorrectionLevel.Medium).Image;
            qr_code_picbox_text.Image = MyQRcode;
            qr_code_picbox_text.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        }
        public void generateUrlQRcode()
        {
            var MyQRcode = QRCodeWriter.CreateQrCode(enter_url_textbox.Text, pxValue, QRCodeWriter.QrErrorCorrectionLevel.Medium).Image;
            qrcode_picbox_url.Image = MyQRcode;
            qr_code_picbox_text.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        }

        private void generate_btn_Click(object sender, EventArgs e)
        {

            /*QRCodeWriter.CreateQrCode(enterText_textbox.Text, 500, QRCodeWriter.QrErrorCorrectionLevel.Medium).SaveAsImage.
            //qr_code_picbox_text.Image
            System.Diagnostics.Process.Start("MyQR.png");
            //qr_code_picbox.Image = "MyQR.png";*/

            /*var MyQRcode = QRCodeWriter.CreateQrCode(enterText_textbox.Text, pxValue, QRCodeWriter.QrErrorCorrectionLevel.Medium).Image;
            qr_code_picbox_text.Image = MyQRcode;*/
            generateTextQRcode();
            
        }


        private void fifty_px_btn_Click(object sender, EventArgs e)
        {
            //if()
            pxValue = 50;
            generateTextQRcode();
        }

        private void one_hundred_px_btn_Click(object sender, EventArgs e)
        {
            pxValue = 100;
            generateTextQRcode();
        }

        private void two_hundred_px_btn_Click(object sender, EventArgs e)
        {
            pxValue = 200;
            generateTextQRcode();
        }

        private void three_hundred_px_btn_Click(object sender, EventArgs e)
        {
            pxValue = 300;
            generateTextQRcode();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void OK_button_text_Click(object sender, EventArgs e)
        {
            pxValue = (int)custom_numberic_text.Value;
            if (custom_numberic_text.Value > 400)//didn't work
            {
                warning_label.Text = "The display size is limited in 400px but you can sitll save with" + custom_numberic_text.Value.ToString() + "px size";
            }
            generateTextQRcode();
            
        }

        private void generate_url_btn_Click(object sender, EventArgs e)
        {
            generateUrlQRcode();
        }

        private void save_pngFile_linkLabel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "PNG(*.PNG)|*.png";
            sf.FileName = enterText_textbox.Text+"_qrcode";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                qr_code_picbox_text.Image.Save(sf.FileName);
                MessageBox.Show("Saved successfully!");
            }
            
        }

        private void save_jpgFile_linkLabel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPG(*.JPG)|*.jpg";
            sf.FileName = enterText_textbox.Text + "_qrcode";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                qr_code_picbox_text.Image.Save(sf.FileName);
                MessageBox.Show("Saved successfully!");
            }
        }

        private void save_gifFile_linkLabel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "GIF(*.GIF)|*.gif";
            sf.FileName = enterText_textbox.Text + "_qrcode";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                qr_code_picbox_text.Image.Save(sf.FileName);
                MessageBox.Show("Saved successfully!");
            }
        }

        private void save_svgFile_linkLabel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "SVG(*.SVG)|*.svg";
            sf.FileName = enterText_textbox.Text + "_qrcode";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                qr_code_picbox_text.Image.Save(sf.FileName);
                MessageBox.Show("Saved successfully!");
            }
        }
    }
}
