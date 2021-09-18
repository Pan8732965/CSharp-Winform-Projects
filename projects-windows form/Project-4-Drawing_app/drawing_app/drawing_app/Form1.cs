using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace drawing_app
{
    
    public partial class Form1 : Form
    {
        Bitmap myImage;
        int PBwidth, PBheight;//get the width and height of the picbox to create new canva weight and height
        int currentXpos, currentYpos;
        bool beginPaint = true;
        bool beginMove = false;
        int SavefileNumber = 1;
        public Pen pen = new Pen(Color.Black,5); //new main pen create
        public Pen eraser = new Pen(Color.White, 20); //new eraser


        /*
           bug:
               1.it will start to draw without any click initially.(ok)
               2.the pen in picbox is without antialiasing(ok)
               3. the pen of shape is strange
               4.when clcik the pen btn , canva will reset(ok)
               5.when click the pen btn then click eraser , the pen color will turned into white. (can't back to oringinal color.)
          */


       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void dungeonTrackBar1_ValueChanged()
        {
            pen.Width = thickness_TrackBar.Value;
            thickness_Numeric.Value = thickness_TrackBar.Value;
           
        }

        private void pen_btn_Click(object sender, EventArgs e)
        {
            beginPaint = true;
            Canva.Image = myImage;
            
        }

        
        private void clear_btn_Click(object sender, EventArgs e)
        {
            Graphics graphic = Graphics.FromImage(Canva.Image);
            graphic.Clear(Color.White);//Color to fill the background and reset the box
            graphic.Dispose();
            Canva.Refresh();
            
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.Black;
        }

        private void roundButton12_Click(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.Gray;
        }

        private void roundButton11_Click(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.DarkRed;
        }

        private void eraser_btn_Click(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.White;
        }

        private void thickness_Numeric_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = (float)thickness_Numeric.Value;
        }

        private void roundButton10_Click(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.Red;
        }

        private void roundButton9_Click(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.OrangeRed;
        }

        private void roundButton8_Click(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.Yellow;
        }

        private void roundButton7_Click(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.Green;
        }

        private void roundButton6_Click(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.Blue;
        }

        private void roundButton5_Click(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.DarkBlue;
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.Purple;
        }

        private void roundButton18_Click(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.White;
        }

        private void roundButton17_Click(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.LightGray;
        }

        private void roundButton16_Click(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.SaddleBrown;
        }

        private void roundButton15_Click(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.Pink;
        }

        private void roundButton14_Click(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.Yellow;
        }

        private void roundButton13_Click(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.LightYellow;
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.YellowGreen;
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.LightBlue;
        }

        private void roundButton20_Click(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.CornflowerBlue;
        }

        private void roundButton19_Click(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.Purple;
        }

        private void nightLabel5_Click(object sender, EventArgs e)
        {

        }

        private void savefile_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPG(*.JPG)|*.jpg";
            sfd.FileName = "MyWork_" + SavefileNumber;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
               SavefileNumber++;
               myImage.Save(sfd.FileName);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PBwidth = Canva.Width;
            PBheight = Canva.Height;
            beginPaint = true;
            myImage = new Bitmap(PBwidth, PBheight); //create new bitmap img.
            Graphics g = Graphics.FromImage(myImage);
            Canva.Image = myImage;
            pen.Width = thickness_TrackBar.Value;
            thickness_Numeric.Value = thickness_TrackBar.Value;
        }

        private void Canva_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                Graphics gp = Graphics.FromImage(myImage);  //create the canva in the past bitmap , as drawing
                gp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                gp.DrawLine(pen, currentXpos, currentYpos, e.X, e.Y);//draw line
                // again to direct the drown pic to show on picbox
                Canva.Image = myImage;
                //again tp record currnt mouse value , prepare for the next move of mouse drawing
                currentXpos = e.X;
                currentYpos = e.Y;
            }
        }

        private void Canva_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = false;
                currentXpos = 0;
                currentYpos = 0;
            }
        }

        private void Canva_MouseDown(object sender, MouseEventArgs e)
        {
            if (beginPaint == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    beginMove = true;
                    currentXpos = e.X;
                    currentYpos = e.Y;
                }
            }
        }

        
    }
}
