
namespace music_player_gui
{
    partial class music_player
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(music_player));
            this.browse_musics = new System.Windows.Forms.FolderBrowserDialog();
            this.showing_text = new System.Windows.Forms.Label();
            this.text_show = new System.Windows.Forms.Label();
            this.music_listBox = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stop_music = new System.Windows.Forms.Button();
            this.searching_file = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.play_music = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // browse_musics
            // 
            this.browse_musics.SelectedPath = "C:\\Users\\User\\Desktop\\testmsuic";
            // 
            // showing_text
            // 
            this.showing_text.AutoSize = true;
            this.showing_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.showing_text.Location = new System.Drawing.Point(12, 9);
            this.showing_text.Name = "showing_text";
            this.showing_text.Size = new System.Drawing.Size(0, 29);
            this.showing_text.TabIndex = 3;
            this.showing_text.Click += new System.EventHandler(this.showing_text_Click);
            // 
            // text_show
            // 
            this.text_show.AllowDrop = true;
            this.text_show.AutoSize = true;
            this.text_show.BackColor = System.Drawing.Color.LightSlateGray;
            this.text_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_show.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.text_show.Location = new System.Drawing.Point(18, 9);
            this.text_show.Name = "text_show";
            this.text_show.Size = new System.Drawing.Size(488, 29);
            this.text_show.TabIndex = 8;
            this.text_show.Text = "Welcome!請按資料夾logo，開始音樂之旅!";
            this.text_show.Click += new System.EventHandler(this.text_show_Click);
            // 
            // music_listBox
            // 
            this.music_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.music_listBox.FormattingEnabled = true;
            this.music_listBox.ItemHeight = 22;
            this.music_listBox.Location = new System.Drawing.Point(640, 71);
            this.music_listBox.Name = "music_listBox";
            this.music_listBox.Size = new System.Drawing.Size(320, 444);
            this.music_listBox.TabIndex = 9;
            this.music_listBox.SelectedIndexChanged += new System.EventHandler(this.music_listBox_SelectedIndexChanged);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 113);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(960, 315);
            this.axWindowsMediaPlayer1.TabIndex = 10;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox2.Image = global::music_player_gui.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(912, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(975, 62);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // stop_music
            // 
            this.stop_music.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.stop_music.FlatAppearance.BorderSize = 0;
            this.stop_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_music.Font = new System.Drawing.Font("新細明體", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stop_music.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stop_music.Location = new System.Drawing.Point(65, 484);
            this.stop_music.Name = "stop_music";
            this.stop_music.Size = new System.Drawing.Size(83, 70);
            this.stop_music.TabIndex = 7;
            this.stop_music.Text = "⏹";
            this.stop_music.UseVisualStyleBackColor = true;
            this.stop_music.Click += new System.EventHandler(this.stop_music_Click);
            // 
            // searching_file
            // 
            this.searching_file.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.searching_file.FlatAppearance.BorderSize = 0;
            this.searching_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searching_file.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searching_file.Image = ((System.Drawing.Image)(resources.GetObject("searching_file.Image")));
            this.searching_file.Location = new System.Drawing.Point(544, 484);
            this.searching_file.Name = "searching_file";
            this.searching_file.Size = new System.Drawing.Size(73, 69);
            this.searching_file.TabIndex = 5;
            this.searching_file.UseVisualStyleBackColor = true;
            this.searching_file.Click += new System.EventHandler(this.searching_file_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("新細明體", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(154, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 69);
            this.button1.TabIndex = 4;
            this.button1.Text = "❚❚";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.pause_music_Click);
            // 
            // play_music
            // 
            this.play_music.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.play_music.FlatAppearance.BorderSize = 0;
            this.play_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_music.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_music.ForeColor = System.Drawing.SystemColors.Control;
            this.play_music.Location = new System.Drawing.Point(244, 488);
            this.play_music.Name = "play_music";
            this.play_music.Size = new System.Drawing.Size(64, 67);
            this.play_music.TabIndex = 0;
            this.play_music.Text = "▶ ";
            this.play_music.UseVisualStyleBackColor = true;
            this.play_music.Click += new System.EventHandler(this.play_music_Click);
            // 
            // music_player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(972, 588);
            this.Controls.Add(this.text_show);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.music_listBox);
            this.Controls.Add(this.stop_music);
            this.Controls.Add(this.searching_file);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showing_text);
            this.Controls.Add(this.play_music);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "music_player";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.music_player_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play_music;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog browse_musics;
        private System.Windows.Forms.Button searching_file;
        private System.Windows.Forms.Label showing_text;
        private System.Windows.Forms.Button stop_music;
        private System.Windows.Forms.Label text_show;
        private System.Windows.Forms.ListBox music_listBox;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

