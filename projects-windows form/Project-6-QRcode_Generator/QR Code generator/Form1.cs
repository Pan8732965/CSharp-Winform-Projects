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
using QRCoder;

namespace QR_Code_generator
{
    //qrcode nuget used：qrcoder 
    

    public partial class Form1 : Form
    {   

        public double blockValue=4.76;//the qrcode one block size. 4.76 is for showing the whole qrcode size with 100px 
        int savefilenumber=0;
        public bool InTextTab = true , InUrlTab = true; // distingush whether in the text tab page or the url tab page.

        
        
        public Form1()
        {
            InitializeComponent();
        }
        
        public void  generateTextQRcode() //the process to generate qrcode in the text tab.
        {
            //here uses try and catch to deal with exceptions that is the qrcode size.
            try
            {
                InUrlTab = false;
                InTextTab = true;
                QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
                var QrData = QG.CreateQrCode(enterText_textbox.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
                var code = new QRCoder.QRCode(QrData);
                Image mycode = code.GetGraphic((int)blockValue);
                qr_code_picbox_text.Image = mycode;
            }
            catch(Exception exl)
            {
                MessageBox.Show(exl.Message+"Because the Minimal size is 21,please enter your size number up to 20.");
            }
            
        }
        public void generateUrlQRcode() //the process to generate qrcode in the url tab.
        {
            try
            {
                InUrlTab = true;
                InTextTab = false;
                QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
                var QrData = QG.CreateQrCode(enter_url_textbox.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
                var code = new QRCoder.QRCode(QrData);
                Image mycode = code.GetGraphic((int)blockValue);
                qrcode_picbox_url.Image = mycode;
            }
            catch (Exception exl)
            {
                MessageBox.Show(exl.Message + "Because the Minimal size is 21,please enter your size number up to 20.");
            }
            
        }

        private void generate_btn_Click(object sender, EventArgs e)
        {
            generateTextQRcode();
        }


        private void fifty_px_btn_Click(object sender, EventArgs e)
        {
            /*
            50ptx(50x50) --> blockvalue=2.38
            100ptx(100x100) --> blockvalue=4.76
            200ptx(200x200) --> blockvalue= 9.52
            300ptx(300x300) --> blockvalue=14.29
            21*blockxvalue = x ptx(the whole qrcode size)
            ptx value = 21*blockvaule
            -->blockvalue=ptx value/21
            */
            blockValue = 2.38;
            warning_label_text.Text=""; //make warning text disappeared.
            warning_label_url.Text = "";
            if (InTextTab == true && InUrlTab == false)
            {
                generateTextQRcode();
            }
            else if(InTextTab == false && InUrlTab == true)
            {
                generateUrlQRcode();
            }
            
        }

        private void one_hundred_px_btn_Click(object sender, EventArgs e)
        {
            warning_label_text.Text = "";
            warning_label_url.Text = "";
            blockValue = 4.76;
            if (InTextTab == true && InUrlTab == false)
            {
                generateTextQRcode();
            }
            else if (InTextTab == false && InUrlTab == true)
            {
                generateUrlQRcode();
            }
            
        }

        private void two_hundred_px_btn_Click(object sender, EventArgs e)
        {
            warning_label_text.Text = "";
            warning_label_url.Text = "";
            blockValue = 9.52;
            if (InTextTab == true && InUrlTab == false)
            {
                generateTextQRcode();
            }
            else if (InTextTab == false && InUrlTab == true)
            {
                generateUrlQRcode();
            }
           
        }

        private void three_hundred_px_btn_Click(object sender, EventArgs e)
        {
            warning_label_text.Text = "";
            warning_label_url.Text = "";
            blockValue = 14.29;
            if (InTextTab == true && InUrlTab == false)
            {
                generateTextQRcode();
            }
            else if (InTextTab == false && InUrlTab == true)
            {
                generateUrlQRcode();
            }
            
        }

        private void OK_button_text_Click(object sender, EventArgs e) //ok button of the sizechanged
        {
            blockValue = (int)custom_numberic_text.Value / 21; //custom_numberic_text.value is whole qrcode ptx value
            generateTextQRcode();

            if (custom_numberic_text.Value > 400 || custom_numberic_url.Value > 400)//distinguish the display size.
            {
                warning_label_text.Text = "The display size is limited in 400px but you can sitll save with\n" + custom_numberic_text.Value.ToString() + "px size";
            }
            else if(custom_numberic_text.Value < 400 || custom_numberic_url.Value < 400)
            {
                warning_label_text.Text = "";
            }
        }

        private void generate_url_btn_Click(object sender, EventArgs e)
        {
            
            generateUrlQRcode();
        }

        private void save_pngFile_linkLabel_Click(object sender, EventArgs e) // saving files
        {
            if (InTextTab == true)// In the text tab to save file.
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "PNG(*.PNG)|*.png";
                sf.FileName = enterText_textbox.Text + "_qrcode";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    qr_code_picbox_text.Image.Save(sf.FileName);
                    MessageBox.Show("Saved successfully!✔️");
                }
                
            }
            else if (InTextTab == false)// In the url tab to save file.
            {
                savefilenumber++;// to show the saving numbers while saved for several times.
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "PNG(*.PNG)|*.png";
                sf.FileName = "url"+savefilenumber+ "_qrcode";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    qrcode_picbox_url.Image.Save(sf.FileName);
                    MessageBox.Show("Saved successfully!✔️");
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
                    MessageBox.Show("Saved successfully!✔️");
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
                    MessageBox.Show("Saved successfully!✔️");
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
                    MessageBox.Show("Saved successfully!✔️");
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
                    MessageBox.Show("Saved successfully!✔️");
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
                    MessageBox.Show("Saved successfully!✔️");
                }

            }
            else if (InTextTab == false)
            {
                savefilenumber++;
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "SVG(*.SVG)|*.svg";
                sf.FileName = "url" + savefilenumber + "_qrcode";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    qrcode_picbox_url.Image.Save(sf.FileName);
                    MessageBox.Show("Saved successfully!✔️");
                }
            }
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ok_url_btn(object sender, EventArgs e)
        {
            blockValue = (int)custom_numberic_url.Value / 21; //custom_numberic_text.value is whole qrcode ptx value.
            generateUrlQRcode();
            if (custom_numberic_url.Value > 400 || custom_numberic_url.Value > 400) //show the warning text of custom blockValue 
            {
                warning_label_url.Text = "The display size is limited in 400px but you can sitll save with\n" + custom_numberic_url.Value.ToString() + "px size";
            }
            else if(custom_numberic_url.Value < 400 || custom_numberic_url.Value < 400) // if the blockValue is smaller than 400 then disappeared.
            {
                warning_label_url.Text = "";
            }
        }

        private void save_pngFile_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
