
namespace music_player_pj_1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.last_music_btn = new System.Windows.Forms.Button();
            this.text_show = new System.Windows.Forms.Label();
            this.next_music_btn = new System.Windows.Forms.Button();
            this.browse_files = new System.Windows.Forms.Button();
            this.speaker_text_symbol = new System.Windows.Forms.Label();
            this.volume_taskbar = new System.Windows.Forms.TrackBar();
            this.stop_button = new System.Windows.Forms.Button();
            this.pause_button = new System.Windows.Forms.Button();
            this.play_button = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.music_listBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_taskbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.last_music_btn);
            this.panel1.Controls.Add(this.text_show);
            this.panel1.Controls.Add(this.next_music_btn);
            this.panel1.Controls.Add(this.browse_files);
            this.panel1.Controls.Add(this.speaker_text_symbol);
            this.panel1.Controls.Add(this.volume_taskbar);
            this.panel1.Controls.Add(this.stop_button);
            this.panel1.Controls.Add(this.pause_button);
            this.panel1.Controls.Add(this.play_button);
            this.panel1.Location = new System.Drawing.Point(0, 511);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 69);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // last_music_btn
            // 
            this.last_music_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.last_music_btn.FlatAppearance.BorderSize = 0;
            this.last_music_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.last_music_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_music_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.last_music_btn.Location = new System.Drawing.Point(2, 16);
            this.last_music_btn.Margin = new System.Windows.Forms.Padding(2);
            this.last_music_btn.Name = "last_music_btn";
            this.last_music_btn.Size = new System.Drawing.Size(37, 42);
            this.last_music_btn.TabIndex = 8;
            this.last_music_btn.Text = "⏪";
            this.last_music_btn.UseVisualStyleBackColor = false;
            this.last_music_btn.Click += new System.EventHandler(this.last_music_btn_Click);
            // 
            // text_show
            // 
            this.text_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_show.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.text_show.Location = new System.Drawing.Point(145, 0);
            this.text_show.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text_show.Name = "text_show";
            this.text_show.Size = new System.Drawing.Size(398, 69);
            this.text_show.TabIndex = 2;
            this.text_show.Text = "welcome!";
            this.text_show.Click += new System.EventHandler(this.text_show_Click);
            // 
            // next_music_btn
            // 
            this.next_music_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.next_music_btn.FlatAppearance.BorderSize = 0;
            this.next_music_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_music_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_music_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.next_music_btn.Location = new System.Drawing.Point(73, 16);
            this.next_music_btn.Margin = new System.Windows.Forms.Padding(2);
            this.next_music_btn.Name = "next_music_btn";
            this.next_music_btn.Size = new System.Drawing.Size(37, 42);
            this.next_music_btn.TabIndex = 7;
            this.next_music_btn.Text = "⏩";
            this.next_music_btn.UseVisualStyleBackColor = false;
            this.next_music_btn.Click += new System.EventHandler(this.next_music_btn_Click);
            // 
            // browse_files
            // 
            this.browse_files.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.browse_files.FlatAppearance.BorderSize = 0;
            this.browse_files.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse_files.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse_files.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.browse_files.Location = new System.Drawing.Point(710, 11);
            this.browse_files.Margin = new System.Windows.Forms.Padding(2);
            this.browse_files.Name = "browse_files";
            this.browse_files.Size = new System.Drawing.Size(46, 46);
            this.browse_files.TabIndex = 6;
            this.browse_files.Text = "📁";
            this.browse_files.UseVisualStyleBackColor = false;
            this.browse_files.Click += new System.EventHandler(this.browse_files_Click);
            // 
            // speaker_text_symbol
            // 
            this.speaker_text_symbol.AutoSize = true;
            this.speaker_text_symbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speaker_text_symbol.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.speaker_text_symbol.Location = new System.Drawing.Point(536, 22);
            this.speaker_text_symbol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speaker_text_symbol.Name = "speaker_text_symbol";
            this.speaker_text_symbol.Size = new System.Drawing.Size(47, 31);
            this.speaker_text_symbol.TabIndex = 5;
            this.speaker_text_symbol.Text = "🔊";
            this.speaker_text_symbol.Click += new System.EventHandler(this.speaker_text_symbol_Click);
            // 
            // volume_taskbar
            // 
            this.volume_taskbar.LargeChange = 10;
            this.volume_taskbar.Location = new System.Drawing.Point(576, 22);
            this.volume_taskbar.Margin = new System.Windows.Forms.Padding(2);
            this.volume_taskbar.Maximum = 100;
            this.volume_taskbar.Name = "volume_taskbar";
            this.volume_taskbar.Size = new System.Drawing.Size(130, 45);
            this.volume_taskbar.TabIndex = 4;
            this.volume_taskbar.Value = 50;
            this.volume_taskbar.Scroll += new System.EventHandler(this.volume_taskbar_Scroll);
            // 
            // stop_button
            // 
            this.stop_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stop_button.FlatAppearance.BorderSize = 0;
            this.stop_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stop_button.Location = new System.Drawing.Point(114, 16);
            this.stop_button.Margin = new System.Windows.Forms.Padding(2);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(37, 42);
            this.stop_button.TabIndex = 2;
            this.stop_button.Text = "⏹";
            this.stop_button.UseVisualStyleBackColor = false;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // pause_button
            // 
            this.pause_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pause_button.FlatAppearance.BorderSize = 0;
            this.pause_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pause_button.Location = new System.Drawing.Point(28, 15);
            this.pause_button.Margin = new System.Windows.Forms.Padding(2);
            this.pause_button.Name = "pause_button";
            this.pause_button.Size = new System.Drawing.Size(50, 43);
            this.pause_button.TabIndex = 1;
            this.pause_button.Text = "❚❚";
            this.pause_button.UseVisualStyleBackColor = false;
            this.pause_button.Visible = false;
            this.pause_button.Click += new System.EventHandler(this.pause_button_Click);
            // 
            // play_button
            // 
            this.play_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.play_button.FlatAppearance.BorderSize = 0;
            this.play_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.play_button.Location = new System.Drawing.Point(41, 15);
            this.play_button.Margin = new System.Windows.Forms.Padding(2);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(37, 42);
            this.play_button.TabIndex = 0;
            this.play_button.Text = "▶";
            this.play_button.UseVisualStyleBackColor = false;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(758, 544);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // music_listBox
            // 
            this.music_listBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.music_listBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.music_listBox.ForeColor = System.Drawing.SystemColors.Info;
            this.music_listBox.FormattingEnabled = true;
            this.music_listBox.ItemHeight = 24;
            this.music_listBox.Location = new System.Drawing.Point(762, 0);
            this.music_listBox.Margin = new System.Windows.Forms.Padding(2);
            this.music_listBox.Name = "music_listBox";
            this.music_listBox.Size = new System.Drawing.Size(307, 580);
            this.music_listBox.TabIndex = 3;
            this.music_listBox.SelectedIndexChanged += new System.EventHandler(this.music_listBox_SelectedIndexChanged_1);
            // 
            // music_player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1073, 580);
            this.Controls.Add(this.music_listBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "music_player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_taskbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button pause_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.TrackBar volume_taskbar;
        private System.Windows.Forms.Label speaker_text_symbol;
        private System.Windows.Forms.Button browse_files;
        private System.Windows.Forms.Label text_show;
        private System.Windows.Forms.ListBox music_listBox;
        private System.Windows.Forms.Button last_music_btn;
        private System.Windows.Forms.Button next_music_btn;
    }
}

