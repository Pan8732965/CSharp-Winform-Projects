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
        //public int x,y = -1;
        //public bool moving = false;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            g = panel2.CreateGraphics();//to make it can draw on the panel
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);// make paint smooth
        }

        private void dungeonTrackBar1_ValueChanged()
        {

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
    }
}
