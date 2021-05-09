using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class EasyTimer : Form
    {
        /*bug:
         *1.press pause then press start,it'll back to the original time.
         *2.the progress bar didn't work.
         */
        //*improve:it can set the time in a paritcular windows.like press the set time btn and it
        // will pop out a  windows to set time;
        private TimeSpan timeleft;
        


        public EasyTimer()
        {
            InitializeComponent();
        }

        private void TimerCountdown_Tick(object sender, EventArgs e)
        {
            timespan_progressbar.PerformLayout();//perform the timespan layout.
            show_time_label.Text = timeleft.ToString(@"hh\：mm\：ss");
            timeleft = timeleft.Subtract(TimeSpan.FromSeconds(1));
            
            if (timeleft.TotalSeconds <= 0)
            {
                TimerCountdown.Stop();
            }
            // = TotalSpanTime;
            /*int TotalSpanTime = (int)timeleft.TotalSeconds;
            timespan_progressbar.Maximum = TotalSpanTime;
            timespan_progressbar.Step = 1000;*/
            
        }

        private void start_btn_Click(object sender, EventArgs e)
        {

            pause_btn.Visible = true;
            start_btn.Visible = false;
            bool pressStopBtn = false;
            int SecNumbericValue = Convert.ToInt32(second_Numeric.Value);//convert numberic value to int number.
            int MinNumbericValue = Convert.ToInt32(Minutes_Numeric.Value);
            int HourNumbericValue = Convert.ToInt32(Hour_Numeric.Value);
            timeleft = new TimeSpan(HourNumbericValue, MinNumbericValue, SecNumbericValue);
            show_time_label.Text = timeleft.ToString(@"hh\：mm\：ss");
            int TotalSpanTime = (int)timeleft.TotalSeconds; //set the totalspantime to get the maxinum progress bar number.
            timespan_progressbar.Maximum = TotalSpanTime;   
            timespan_progressbar.Step = 1000;
            TimerCountdown.Start();
            label1.Text = TotalSpanTime.ToString(); //show the total span time.
            if (pressStopBtn == true)
            {
                TimerCountdown.Start();
            }
            
        }

        private void pause_btn_Click(object sender, EventArgs e)
        {
            pause_btn.Visible = false;
            start_btn.Visible = true;
            TimerCountdown.Stop();
            
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            TimerCountdown.Stop();
            timeleft = new TimeSpan(0, 0, 0);
            show_time_label.Text = timeleft.ToString(@"hh\：mm\：ss");
            pause_btn.Visible = false;
            start_btn.Visible = true;

        }
    }
}
