using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace music_player_gui
{
    public partial class music_player : Form
    {
        //功能:
        /*新增瀏覽文件功能(ok)、拖曳條(audio switcher,not ok)、圖片為button(ok)
        adding functions:music wave、shoing the name of the song、combine with play 
        and pause button when hit the button*/
        //bug:stop mp3 button went wrong
        //bug:audio switcher can't follow the switcher to decrease the volume
        SoundPlayer mSimpleSound; //soundplayer為一變數;
        WindowsMediaPlayer mPlayer;
        public music_player()
        {
            InitializeComponent();
            mSimpleSound = new SoundPlayer(@"C:\Users\User\Desktop\testmsuic\test2.wav");
            mPlayer = new WMPLib.WindowsMediaPlayer();
            mPlayer.PlayStateChange +=
             new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            mPlayer.MediaError +=
            new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
            mPlayer.URL = "";
            mPlayer.controls.stop();
        }

        private void play_music_Click(object sender, EventArgs e)//play button cicked
        {
            playSimpleSound();
            
        }

        private void pause_music_Click(object sender, EventArgs e)//pause button clicked
        {
            PauseMP3File();
        }

        


        private void music_player_Load(object sender, EventArgs e)
        {
            InitializeComponent();

        }

        

        private void playSimpleSound()
        {
            //mSimpleSound.Play();            
            PlayMP3File();

        }

        private void PauseMP3File()//pause music
        {
            mPlayer.controls.pause();
        }
        private void PlayMP3File()//play music
        {
            mPlayer.controls.play();
        }
        private void StopMP3File()
        {
            mPlayer.controls.stop();
        }

        private void Player_PlayStateChange(int NewState)
        {
            var state = (WMPLib.WMPPlayState)NewState;
            //state.Dump();

            if ((WMPPlayState)NewState == WMPPlayState.wmppsStopped)
            {
                //Console.WriteLine("Stop");
                showing_text.Text = "Stop";
                mPlayer.close();
            }
        }
        private void Player_MediaError(object pMediaObject)
        {
            //Console.WriteLine("Error");
            showing_text.Text = "Error";
            mPlayer.close();
        }

        private void searching_file_Click(object sender, EventArgs e)//browsing songs
        {
            OpenFileDialog searchfile = new OpenFileDialog();
            if (searchfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strfilename = searchfile.FileName;
                mPlayer.URL = (strfilename);
                showing_text.Text = "";
                showing_text.Text = (strfilename);
                
            }
        }

        private void showing_text_Click(object sender, EventArgs e)
        {
            
        }

        

        

        

        private void audio_switcher_Scroll(object sender, ScrollEventArgs e)
        {
            mPlayer.settings.volume = audio_switcher.Value;

        }

        private void stop_music_Click(object sender, EventArgs e)
        {
            StopMP3File();
            

        }
    }
}
