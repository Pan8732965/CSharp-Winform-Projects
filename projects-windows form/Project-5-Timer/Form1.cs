using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Timer
{
    public partial class EasyTimer : Form
    {
        //1000 millisecond= 1 second;
        string EachSpanTime;
        public TimeSpan timeleft = new TimeSpan();
        bool InitialStarted = false;
        bool InCountdownState=false;
        bool ClickPauseState;
        int TomatoCounter;
          
        public EasyTimer()
        {
            InitializeComponent();
        }
        private void playsound() // time's up sound playing.
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\smart\Desktop\DingSoundEffects.wav");
            splayer.Play();
        }
        private void TimerCountdown_Tick(object sender, EventArgs e)
        {
           
            if (InitialStarted==false && InCountdownState==false) //when the timer program initializing
            {
                timeleft = timeleft.Subtract(TimeSpan.Zero);
                show_time_label.Text = timeleft.ToString(@"hh\：mm\：ss");
            }
            else if (InitialStarted==true && InCountdownState==true) //timer countdown started
            {
               timeleft = timeleft.Subtract(TimeSpan.FromSeconds(1));
                show_time_label.Text = timeleft.ToString(@"hh\：mm\：ss");
            }
            
            if(timeleft.TotalSeconds <= 0 && InitialStarted ==true) //timer countdown pause
            {
                TimerCountdown.Stop();
                playsound();
                start_btn.Visible = true;
                start_btn.Enabled = false;
                start_btn.Cursor = Cursors.No;
                start_btn.BorderColor = Color.DimGray;
                start_btn.TextColor = Color.DimGray;
                pause_btn.Visible = false;
                if (BreakCheckbox.Checked == false)
                {
                    MessageBox.Show("Times up\n" + "Taking a break is a good choice!");
                    TomatoCounter++;
                    switch (TomatoCounter)
                    {
                        case 1:
                            tomato1.Visible = true;
                            tomatoUsedTimeLabel.Visible = true;
                            tomatoUsedTimeLabel.Text = EachSpanTime;
                            break;
                        case 2:
                            tomato2.Visible = true;
                            tomatoUsedTimeLabel2.Visible = true;
                            tomatoUsedTimeLabel2.Text = EachSpanTime;
                            break;
                        case 3:
                            tomato3.Visible = true;
                            tomatoUsedTimeLabel3.Visible = true;
                            tomatoUsedTimeLabel3.Text = EachSpanTime;
                            break;
                        case 4:
                            tomato4.Visible = true;
                            tomatoUsedTimeLabel4.Visible = true;
                            tomatoUsedTimeLabel4.Text = EachSpanTime;
                            break;
                        case 5:
                            tomato5.Visible = true;
                            tomatoUsedTimeLabel5.Visible = true;
                            tomatoUsedTimeLabel5.Text = EachSpanTime;
                            break;
                        case 6:
                            tomato6.Visible = true;
                            tomatoUsedTimeLabel6.Visible = true;
                            tomatoUsedTimeLabel6.Text = EachSpanTime;
                            break;
                        case 7:
                            tomato7.Visible = true;
                            tomatoUsedTimeLabel7.Visible = true;
                            tomatoUsedTimeLabel7.Text = EachSpanTime;
                            break;
                        case 8:
                            tomato8.Visible = true;
                            tomatoUsedTimeLabel8.Visible = true;
                            tomatoUsedTimeLabel8.Text = EachSpanTime;
                            break;
                        case 9:
                            tomato9.Visible = true;
                            tomatoUsedTimeLabel9.Visible = true;
                            tomatoUsedTimeLabel9.Text = EachSpanTime;
                            break;
                        case 10:
                            tomato10.Visible = true;
                            tomatoUsedTimeLabel10.Visible = true;
                            tomatoUsedTimeLabel10.Text = EachSpanTime;
                            break;
                    }
                    
                }
                else if (BreakCheckbox.Checked == true)
                {
                      MessageBox.Show("Times up!" + "Let's go back to work!");
                }
                
                //tick start 
            }
           
        }
        public void setCurrent_time()
        {
            int SecNumbericValue = Convert.ToInt32(second_Numeric.Value);//convert numberic value to int number.
            int MinNumbericValue = Convert.ToInt32(Minutes_Numeric.Value);
            int HourNumbericValue = Convert.ToInt32(Hour_Numeric.Value); 
            timeleft = new TimeSpan(HourNumbericValue, MinNumbericValue, SecNumbericValue); 
            show_time_label.Text = timeleft.ToString(@"hh\：mm\：ss");
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            InCountdownState = true;
            InitialStarted = true;
            pause_btn.Visible = true;
            start_btn.Visible = false;
            int TotalSpanTime = (int)timeleft.TotalSeconds;
            if (ClickPauseState==true)//to distingush whether click the pause btn.
            {
                TimerCountdown.Start();
            }
            else if (InitialStarted ==true && InCountdownState==true)//to distinguish whether started or countdownEnded
            {
                setCurrent_time();
                TotalTime.Text = timeleft.ToString(@"hh\:mm\:ss");
                EachSpanTime = TotalTime.Text;
                TimerCountdown.Start();
            }
            
        }

        private void pause_btn_Click(object sender, EventArgs e)
        {
            TimerCountdown.Stop();
            pause_btn.Visible = false;
            start_btn.Visible = true;
            ClickPauseState = true;
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            TimerCountdown.Stop();
            timeleft = new TimeSpan(0, 0, 0);
            show_time_label.Text = timeleft.ToString(@"hh\：mm\：ss");
            InitialStarted = false;
            InCountdownState = false;
            ClickPauseState = false;
            pause_btn.Visible = false;
            start_btn.Visible = true;
            start_btn.Enabled = true;
            start_btn.BorderColor = Color.White;
            start_btn.TextColor = Color.White;
            start_btn.Cursor = Cursors.Default;

        }

        private void EasyTimer_Load(object sender, EventArgs e)
        {
            tomato1.Visible = false;
            tomato2.Visible = false;
            tomato3.Visible = false;
            tomato4.Visible = false;

        }
    }
}
