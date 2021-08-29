using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawing_app
{
    
    public partial class Form1 : Form
    {
        Graphics g;
        public Point current = new Point();
        public Point old = new Point();
        public Pen p = new Pen(Color.Black,5);
        Pen pen;
        /*
         * 1. to do:
            (1) change pen brush.
            (2) bucket
            (3) save file(ok)
           2. not do:
            (1) copy and paste
            (2) crop
            (3) zoom
           3. maybe can try:
            (1) save file
            (2)undo and redo
           4.bug:
               the save image is empty.
         * */


        public Form1()
        {
            InitializeComponent();
            g = EmptyCanva.CreateGraphics();//to make it can draw on the panel
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);// make paint smooth
            //pe.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
        }

        private void dungeonTrackBar1_ValueChanged()
        {
            p.Width = thickness_TrackBar.Value;
           /*float p.Width = float.Parse(p.width);
            show_ptx_Label.Text = float.Parse(p.Width);*/
        }

        private void pen_btn_Click(object sender, EventArgs e)
        {
            //g = panel2.CreateGraphics(); 
            g = EmptyCanva.CreateGraphics();
        }

        private void EmptyCanva_MouseDown(object sender, MouseEventArgs e)//the panel for painting
        {
            old = e.Location;

            //gObject.DrawLine(blackPen, 10, 10, 400, 375);//just write a  straight line
            /*moving = true;
            x = e.X;//to get the x and y location while mouse moving
            y = e.Y;*/

        }

        private void EmptyCanva_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                current = e.Location;
                g.DrawLine(p, old, current);
                old = current;
            }
            
            /*if(moving=false && x!=-1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }*/
        }

        private void EmptyCanva_MouseUp(object sender, MouseEventArgs e)
        {
            /*moving = false;
            x = -1;
            y = -1;*/
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            
            EmptyCanva.Invalidate();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            p.Color = System.Drawing.Color.Black;
        }

        private void roundButton12_Click(object sender, EventArgs e)
        {
            p.Color = System.Drawing.Color.Gray;
        }

        private void roundButton11_Click(object sender, EventArgs e)
        {
            p.Color = System.Drawing.Color.DarkRed;
        }

        private void eraser_btn_Click(object sender, EventArgs e)
        {
            /*inkCanvas1.EditingModeInverted = InkCanvasEditingMode.EraseByPoint;
            inkCanvas1.EraserShape = new EllipseStylusShape(5, 5);*/
            /*current = e.Location;
            g.DrawLine(new Pen(Color.White,Width), old, current);
            old = current;*/
            p.Color = System.Drawing.Color.White;
        }

        private void thickness_Numeric_ValueChanged(object sender, EventArgs e)
        {
            p.Width = (float)thickness_Numeric.Value;
        }

        private void PaintBucket_btn_Click(object sender, EventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.Blue);

            // Create rectangle.
            Rectangle rect = new Rectangle(0, 0, 200, 200);

            // Fill rectangle to screen.
            //e.g.FillRectangle(blueBrush, rect);
        }
        //switch()

        private void roundButton10_Click(object sender, EventArgs e)
        {
            p.Color = System.Drawing.Color.Red;
        }

        private void roundButton9_Click(object sender, EventArgs e)
        {
            p.Color = System.Drawing.Color.OrangeRed;
        }

        private void roundButton8_Click(object sender, EventArgs e)
        {
            p.Color = System.Drawing.Color.Yellow;
        }

        private void roundButton7_Click(object sender, EventArgs e)
        {
            p.Color = System.Drawing.Color.Green;
        }

        private void roundButton6_Click(object sender, EventArgs e)
        {
            p.Color = System.Drawing.Color.Blue;//-
        }

        private void roundButton5_Click(object sender, EventArgs e)
        {
            p.Color = System.Drawing.Color.DarkBlue;//-
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            p.Color = System.Drawing.Color.Purple;
        }

        private void roundButton18_Click(object sender, EventArgs e)
        {
            p.Color = System.Drawing.Color.White;
        }

        private void roundButton17_Click(object sender, EventArgs e)
        {
            p.Color = System.Drawing.Color.LightGray;
        }

        private void roundButton16_Click(object sender, EventArgs e)
        {
            p.Color = System.Drawing.Color.SaddleBrown;
        }

        private void roundButton15_Click(object sender, EventArgs e)
        {
            p.Color = System.Drawing.Color.Pink;
        }

        private void roundButton14_Click(object sender, EventArgs e)
        {
            p.Color = System.Drawing.Color.Yellow;//-
        }

        private void roundButton13_Click(object sender, EventArgs e)
        {
            p.Color = System.Drawing.Color.LightYellow;//-
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            p.Color = System.Drawing.Color.YellowGreen;
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            p.Color = System.Drawing.Color.LightBlue;
        }

        private void roundButton20_Click(object sender, EventArgs e)
        {
            p.Color = System.Drawing.Color.CornflowerBlue;//-
        }

        private void roundButton19_Click(object sender, EventArgs e)
        {
            p.Color = System.Drawing.Color.Purple;//-
        }

        private void nightLabel5_Click(object sender, EventArgs e)
        {

        }

        private void savefile_btn_Click(object sender, EventArgs e)
        {
            int width = EmptyCanva.Size.Width;
            int height = EmptyCanva.Size.Height;

            Bitmap bm = new Bitmap(width, height);
            //EmptyCanva.DrawToBitmap(bm, new Rectangle(0, 0, width, height));

            SaveFileDialog sf = new SaveFileDialog();
            //sf.FileName = "url" + savefilenumber + "_qrcode";
            sf.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";
            sf.ShowDialog();
            var path = sf.FileName;
            bm.Save(path);
            MessageBox.Show("Saved successfully!✔️");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EmptyCanva_MouseDown_1(object sender, MouseEventArgs e)
        {
            old = e.Location;
        }

        private void EmptyCanva_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                current = e.Location;
                g.DrawLine(p, old, current);
                old = current;
            }
        }
    }
}
