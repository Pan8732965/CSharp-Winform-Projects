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
    //public class InkCanvas : System.Windows.FrameworkElement, System.Windows.Markup.IAddChild;
    public partial class Form1 : Form
    {
        Graphics g;
        public Point current = new Point();
        public Point old = new Point();
        public Pen p = new Pen(Color.Black,5);
        //public float width;
        //public Pen pe = new Pen(Color.White, 15); // eraser
        //public int x,y = -1;
        //public bool moving = false;
        /* bug1.how to write switch or if statement to choose color at a time.Instead of setting clicked events indivitual.
        //2.eraser method
        //3.the process of the taskbar won't follow up with the numberic.The solution is as same as the numberic.*/
        //issue:idk to find the last color.<sol>:google.
        Pen pen;
        

        public Form1()
        {
            InitializeComponent();
            g = panel2.CreateGraphics();//to make it can draw on the panel
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
            g = panel2.CreateGraphics(); 
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)//the panel for painting
        {
            old = e.Location;

            //gObject.DrawLine(blackPen, 10, 10, 400, 375);//just write a  straight line
            /*moving = true;
            x = e.X;//to get the x and y location while mouse moving
            y = e.Y;*/

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
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

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            /*moving = false;
            x = -1;
            y = -1;*/
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            panel2.Invalidate();
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
    }
}
