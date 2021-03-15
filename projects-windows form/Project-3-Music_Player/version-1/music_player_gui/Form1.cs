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

        //have to check out the label using
        /*adding functions:music wave、audio switcher
        combine with play and pause button when hit the button、playlist*/
        //
        //bug:can't clear the text from the beginning of browsing file.(ok)
        //bug:when hit the stop mp3 button it's can't show the name of the song
        //bug:audio switcher can't follow the switcher to decrease the music volume
        //bug:list box can't display musics name
        //bug:when the show_text set to autosize,the white stuff will block the text.
        SoundPlayer mSimpleSound; //soundplayer為一變數;
        WindowsMediaPlayer mPlayer;
        public string[] paths , files;
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
            text_show.Text = "";//clear the text first

        }

        private void play_music_Click(object sender, EventArgs e)//play button cicked
        {
            playSimpleSound();
            mPlayer.settings.volume = 30;
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
            mPlayer.settings.volume = 30;
        }
        private void StopMP3File()//replay the music
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
                text_show.Text = "stop";
                mPlayer.close();
            }
        }
        private void Player_MediaError(object pMediaObject)
        {
            //Console.WriteLine("Error");
            text_show.Text = "Error";
            mPlayer.close();
        }

        public void searching_file_Click(object sender, EventArgs e)//browsing songs
        {
            OpenFileDialog searchfile = new OpenFileDialog();
            searchfile.Multiselect = true;
            if (searchfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = searchfile.SafeFileNames; //save the names of the track
                paths = searchfile.FileNames; // save the path of the track
                //mPlayer.URL = (paths);
                mPlayer.settings.volume = 20;
                //string getfilename = System.IO.Path.GetFileName(paths);//get the name
                for (int i = 0; i < files.Length; i++)
                {
                    music_listBox.Items.Add(files[i]);//display songs in listbox
                }
                text_show.Text = "";
                text_show.Text = "" + "現正播放:" + "\n" + files + "\n";
            }
        }

        private void showing_text_Click(object sender, EventArgs e)
        {

        }

        private void audio_switcher_Scroll(object sender, ScrollEventArgs e)
        {
            mPlayer.settings.volume = 30;
            //mPlayer.settings.volume = audio_switcher.Value;

        }

        private void stop_music_Click(object sender, EventArgs e)
        {
            StopMP3File();
            playSimpleSound();
        }

        private void text_show_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void music_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[music_listBox.SelectedIndex];
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}

