using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_guessing_game_gui
{
    public partial class Form1 : Form
    {
        static int computernumber = 0;
        static int times = 5;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            computernumber = random.Next(0, 101);
        }
        private void guessNumber_Click(object sender, EventArgs e)
        {
            int toguessnum = (int)InputNumber.Value;
            showInfosLabel.ForeColor = Color.White;
            times--;
            timesLabel.Text = "剩下次數:" + times;

            if (times == 0)
            {
                showInfosLabel.Text = " 沒有次數了!😕答案是:" + computernumber;
                guessNumber.Enabled = false;
                //howInfosLabel.Location = new Point(98, 231);
                showInfosLabel.ForeColor = Color.Yellow;
            }
            else if (computernumber < toguessnum)
            {
                showInfosLabel.Text = "數字小一點⬇️";
                //showInfosLabel.Location = new Point(192, 231);
            }
            else if (computernumber > toguessnum)
            {
                showInfosLabel.Text = "數字大一點🔼";
                //showInfosLabel.Location = new Point(192, 231);
            }
            else if (computernumber == toguessnum)
            {
                showInfosLabel.Text = "恭喜猜對了!🎉";
                //showInfosLabel.Location = new Point(192, 231);
                guessNumber.Enabled = false;

            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            times = 5;
            timesLabel.Text = "剩下次數:" + times;
            guessNumber.Enabled = true;
            showInfosLabel.Text = "在猜一個數字吧。😃";
            //showInfosLabel.Location = new Point(98, 231);
            Random random = new Random();
            computernumber = random.Next(0, 101);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
