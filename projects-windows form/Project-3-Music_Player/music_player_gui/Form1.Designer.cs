
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
            this.audio_switcher = new System.Windows.Forms.VScrollBar();
            this.stop_music = new System.Windows.Forms.Button();
            this.searching_file = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.play_music = new System.Windows.Forms.Button();
            this.text_show = new System.Windows.Forms.Label();
            this.music_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // browse_musics
            // 
            this.browse_musics.SelectedPath = "C:\\Users\\User\\Desktop\\testmsuic";
            // 
            // showing_text
            // 
            this.showing_text.AutoSize = true;
            this.showing_text.Font = new System.Drawing.Font("思源黑體 TW", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.showing_text.Location = new System.Drawing.Point(12, 9);
            this.showing_text.Name = "showing_text";
            this.showing_text.Size = new System.Drawing.Size(0, 35);
            this.showing_text.TabIndex = 3;
            this.showing_text.Click += new System.EventHandler(this.showing_text_Click);
            // 
            // audio_switcher
            // 
            this.audio_switcher.AllowDrop = true;
            this.audio_switcher.Location = new System.Drawing.Point(434, 255);
            this.audio_switcher.Name = "audio_switcher";
            this.audio_switcher.Size = new System.Drawing.Size(43, 132);
            this.audio_switcher.TabIndex = 6;
            this.audio_switcher.Value = 30;
            this.audio_switcher.Scroll += new System.Windows.Forms.ScrollEventHandler(this.audio_switcher_Scroll);
            // 
            // stop_music
            // 
            this.stop_music.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.stop_music.FlatAppearance.BorderSize = 0;
            this.stop_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_music.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stop_music.Image = global::music_player_gui.Properties.Resources.stop_v3;
            this.stop_music.Location = new System.Drawing.Point(2, 300);
            this.stop_music.Name = "stop_music";
            this.stop_music.Size = new System.Drawing.Size(101, 88);
            this.stop_music.TabIndex = 7;
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
            this.searching_file.Location = new System.Drawing.Point(326, 298);
            this.searching_file.Name = "searching_file";
            this.searching_file.Size = new System.Drawing.Size(87, 88);
            this.searching_file.TabIndex = 5;
            this.searching_file.UseVisualStyleBackColor = true;
            this.searching_file.Click += new System.EventHandler(this.searching_file_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(109, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 88);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.pause_music_Click);
            // 
            // play_music
            // 
            this.play_music.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.play_music.FlatAppearance.BorderSize = 0;
            this.play_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_music.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.play_music.Image = global::music_player_gui.Properties.Resources.play_v3;
            this.play_music.Location = new System.Drawing.Point(219, 299);
            this.play_music.Name = "play_music";
            this.play_music.Size = new System.Drawing.Size(87, 88);
            this.play_music.TabIndex = 0;
            this.play_music.UseVisualStyleBackColor = true;
            this.play_music.Click += new System.EventHandler(this.play_music_Click);
            // 
            // text_show
            // 
            this.text_show.AllowDrop = true;
            this.text_show.AutoSize = true;
            this.text_show.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.text_show.Font = new System.Drawing.Font("思源黑體 TW Heavy", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_show.Location = new System.Drawing.Point(12, 63);
            this.text_show.Name = "text_show";
            this.text_show.Size = new System.Drawing.Size(484, 35);
            this.text_show.TabIndex = 8;
            this.text_show.Text = "Welcome!請按資料夾logo，開始音樂之旅!";
            this.text_show.Click += new System.EventHandler(this.text_show_Click);
            // 
            // music_listBox
            // 
            this.music_listBox.Font = new System.Drawing.Font("思源黑體 TW", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.music_listBox.FormattingEnabled = true;
            this.music_listBox.ItemHeight = 26;
            this.music_listBox.Location = new System.Drawing.Point(536, 0);
            this.music_listBox.Name = "music_listBox";
            this.music_listBox.Size = new System.Drawing.Size(376, 446);
            this.music_listBox.TabIndex = 9;
            // 
            // music_player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(909, 526);
            this.Controls.Add(this.music_listBox);
            this.Controls.Add(this.text_show);
            this.Controls.Add(this.stop_music);
            this.Controls.Add(this.audio_switcher);
            this.Controls.Add(this.searching_file);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showing_text);
            this.Controls.Add(this.play_music);
            this.Name = "music_player";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.music_player_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play_music;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog browse_musics;
        private System.Windows.Forms.Button searching_file;
        private System.Windows.Forms.Label showing_text;
        private System.Windows.Forms.VScrollBar audio_switcher;
        private System.Windows.Forms.Button stop_music;
        private System.Windows.Forms.Label text_show;
        private System.Windows.Forms.ListBox music_listBox;
    }
}

