using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clicker
{
    public partial class Form1 : Form
    {
        int times = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void click_Click(object sender, EventArgs e)
        {
            times++;
            showtimes.Text = "您已點了" + times + "下";
        }

        private void reset_times_Click(object sender, EventArgs e)
        {
            times = 0;
            showtimes.Text = "您已點了" + times + "下";
        }
    }
}
