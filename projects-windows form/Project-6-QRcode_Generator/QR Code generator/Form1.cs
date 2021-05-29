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
        //*important:control c# tab event*/
        /*problem:
        1.if the custom size is larger,the red label won't show up.
        2.the custom function can't work in the url tab page.
        3.can't save the file in the url mode.(solved)
        /*need to improve:
        1.the design of the ui need to improve.
        2.qrcode can have a margin.
        3.it's the best that it can save qrcode image in a paricular form. */
        
        
        
        public static int pxValue=300;
        int savefilenumber=0;
        public bool InTextTab = true; //whether we are in the text tab page or the url tab page.
        
        public Form1()
        {
            InitializeComponent();
        }
        public void tabControl_SelectedIndexChanged(object sender, EventArgs e) //control the tab event.
        {
            switch (TabControl.SelectedIndex)
            {
                case 0: //the number of the tab index
                    InTextTab = true;
                    generateTextQRcode();
                    break;
                case 1:
                    InTextTab = false;
                    generateUrlQRcode();
                    break;
            }
        }
        public void  generateTextQRcode()
        {
            
            InTextTab = true;
            var MyQRcode = QRCodeWriter.CreateQrCode(enterText_textbox.Text, pxValue, QRCodeWriter.QrErrorCorrectionLevel.Medium).Image;
            qr_code_picbox_text.Image = MyQRcode;
            qr_code_picbox_text.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;//set the size into middle.
        }
        public void generateUrlQRcode()
        {
            InTextTab = false;
            var MyQRcode = QRCodeWriter.CreateQrCode(enter_url_textbox.Text, pxValue, QRCodeWriter.QrErrorCorrectionLevel.Medium).Image;
            qrcode_picbox_url.Image = MyQRcode;
            qr_code_picbox_text.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;//set the size into midddle.
        }

        private void generate_btn_Click(object sender, EventArgs e)
        {
            if (InTextTab == true)
            {
                generateTextQRcode();
            }
            else if (InTextTab == false)
            {
                generateUrlQRcode();
            }
            
        }


        private void fifty_px_btn_Click(object sender, EventArgs e)
        {
            
            pxValue = 50;
            if (InTextTab == true)
            {
                generateTextQRcode();
            }
            else 
            {
                generateUrlQRcode();
            }

        }

        private void one_hundred_px_btn_Click(object sender, EventArgs e)
        {
            
            pxValue = 100;
            if (InTextTab == true)
            {
                generateTextQRcode();
            }
            else if (InTextTab == false)
            {
                generateUrlQRcode();
            }
        }

        private void two_hundred_px_btn_Click(object sender, EventArgs e)
        {
            pxValue = 200;
            if (InTextTab == true)
            {
                generateTextQRcode();
            }
            else if (InTextTab == false)
            {
                generateUrlQRcode();
            }
        }

        private void three_hundred_px_btn_Click(object sender, EventArgs e)
        {
            pxValue = 300;
            if (InTextTab == true)
            {
                generateTextQRcode();
            }
            else if (InTextTab == false)
            {
                generateUrlQRcode();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void OK_button_text_Click(object sender, EventArgs e)
        {
            
            if (InTextTab == true)
            {
                pxValue = (int)custom_numberic_text.Value;
                generateTextQRcode();
            }
            else if (InTextTab == false)
            {
                pxValue = (int)custom_numberic_url.Value;
                generateUrlQRcode();
            }

            if (custom_numberic_text.Value > 400 || custom_numberic_url.Value > 400)//didn't work
            {
                warning_label.Text = "The display size is limited in 400px but you can sitll save with" + custom_numberic_text.Value.ToString() + "px size";
            }

        }

        private void generate_url_btn_Click(object sender, EventArgs e)
        {
            generateUrlQRcode();
        }

        private void save_pngFile_linkLabel_Click(object sender, EventArgs e)
        {
            if (InTextTab == true)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "PNG(*.PNG)|*.png";
                sf.FileName = enterText_textbox.Text + "_qrcode";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    qr_code_picbox_text.Image.Save(sf.FileName);
                    MessageBox.Show("Saved successfully!");
                }
                
            }
            else if (InTextTab == false)//tab in url.
            {
                savefilenumber++;
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "PNG(*.PNG)|*.png";
                sf.FileName = "url"+savefilenumber+ "_qrcode";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    qrcode_picbox_url.Image.Save(sf.FileName);
                    MessageBox.Show("Saved successfully!");
                }
                
            }
            
        }

        private void save_jpgFile_linkLabel_Click(object sender, EventArgs e)
        {
            if (InTextTab == true)
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
            else if (InTextTab == false)//tab in url.
            {
                savefilenumber++;
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "JPG(*.JPG)|*.jpg";
                sf.FileName = "url" + savefilenumber + "_qrcode";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    qrcode_picbox_url.Image.Save(sf.FileName);
                    MessageBox.Show("Saved successfully!");
                }

            }
         }

        private void save_gifFile_linkLabel_Click(object sender, EventArgs e)
        {
            if (InTextTab == true)
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
            else if (InTextTab == false)//tab in url.
            {
                savefilenumber++;
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "GIF(*.GIF)|*.gif";
                sf.FileName = "url" + savefilenumber + "_qrcode";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    qrcode_picbox_url.Image.Save(sf.FileName);
                    MessageBox.Show("Saved successfully!");
                }
                
            }
        }

        private void save_svgFile_linkLabel_Click(object sender, EventArgs e)
        {
            if (InTextTab == true)
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
            else if (InTextTab == false)//tab in url.
            {
                savefilenumber++;
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "SVG(*.SVG)|*.svg";
                sf.FileName = "url" + savefilenumber + "_qrcode";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    qrcode_picbox_url.Image.Save(sf.FileName);
                    MessageBox.Show("Saved successfully!");
                }
                
            }
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
