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
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using Guna.UI2.WinForms;

namespace music_player_pj_1
{
    /* bugs:
     * 1.the button won't show up until clicked the btn.
     * ---------
     * features to add:
     * ok.1.show the name of the song.
     * ok.2.Can adjust the volume of the trackbar to the music.
     * 3.play the next music automatically(don't know how to do with foreach)
     * ok.4.show the button info when mouse stop at the btn.
     * 5.show the number of the music list.(as the same problem as 3.)*/

    
    public partial class music_player : Form
    {
        SoundPlayer mSimpleSound; //soundplayer為一變數;
        WindowsMediaPlayer mPlayer;
        //public string[] paths, files;

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
            text_show.Text = "Welcome!";//clear the text first
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            music_listBox.ValueMember = "Path";
            music_listBox.DisplayMember = "FileName";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void playSimpleSound()
        {
            //mSimpleSound.Play();            
            PlayMP3File();

        }

        private void PauseMP3File()//pause music
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
        private void PlayMP3File()//play music
        {
            //mPlayer.controls.play();
            axWindowsMediaPlayer1.Ctlcontrols.play();
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

        private void stop_music_Click(object sender, EventArgs e)
        {
            /*StopMP3File();
            playSimpleSound();*/
        }

        private void browse_files_Click(object sender, EventArgs e)
            //Filter="WMV|*.wmv|WAV|*.wav|MP3|*.mp3|MP4|*.mp4|MKV|*.mkv"
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.browse_files, "瀏覽歌曲");
            using (OpenFileDialog ofd=new OpenFileDialog() { Multiselect=true,ValidateNames=true})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    List<MediaFiles> files = new List<MediaFiles>();
                    foreach(string filename in ofd.FileNames)
                    {
                        FileInfo fi = new FileInfo(filename);
                        files.Add(new MediaFiles() { FileName = Path.GetFileNameWithoutExtension(fi.FullName), Path = fi.FullName });
                    }
                    music_listBox.DataSource = files;
                    //text_show.Text = FileName;
                }
                pause_button.Visible = true;
                play_button.Visible = false;
            }
            /*OpenFileDialog searchfile = new OpenFileDialog();
            searchfile.Multiselect = true;
            searchfile.Filter = "All Supported Audio | *.mp3; *.wma | MP3s | *.mp3 | WMAs | *.wma";

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

                //label1.Text = files;
            }
            axWindowsMediaPlayer1.URL = OpenFileDialog.files;*/
        }

        private void music_listBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            MediaFiles files = music_listBox.SelectedItem as MediaFiles;
            if(files != null)
            {
                //foreach()
                axWindowsMediaPlayer1.URL = files.Path;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                
                //if music stoped play the next music               
            }
           
            text_show.Text = "現正播放："+files.FileName;
            text_show.MaximumSize = new Size(398, 69);
            text_show.AutoSize = true;
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.play_button, "播放");
            PlayMP3File();
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)//while playing music
            {
                pause_button.Visible = true;
                play_button.Visible = false;
                text_show.Text = "播放中";
            }

        }

        private void pause_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pause_button, "暫停");
            PauseMP3File();
             if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)//while pause music
            {
                pause_button.Visible = false;
                play_button.Visible = true;
                text_show.Text = "暫停中";
            }
            

        }

        private void music_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.URL = files[music_listBox.SelectedIndex];
        }

        private void stop_button_Click(object sender, EventArgs e)
        {   
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.stop_button, "停止(重新播放此曲)");
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            
        }

        private void text_show_Click(object sender, EventArgs e)
        {
           // text_show.Text = files.Path;
        }

        private void show_hide_list_Click(object sender, EventArgs e)
        {
            /*bool btnClicked = true;
            if (btnClicked == true)
            {
                show_hide_list.PerformClick();
                music_listBox.Visible = false;
            }
            else
            {
                show_hide_list.PerformClick();
                music_listBox.Visible = true;
            }*/
            
            
        }

        private void next_music_btn_Click(object sender, EventArgs e)
        {

        }

        private void speaker_text_symbol_Click(object sender, EventArgs e)
        {

        }

        private void volume_taskbar_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = volume_taskbar.Value;
            //ControlCentre.lastVolume = Player_wmp.settings.volume;
        }

        private void last_music_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
