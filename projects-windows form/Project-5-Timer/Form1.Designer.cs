
namespace Timer
{
    partial class EasyTimer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasyTimer));
            this.show_time_label = new ReaLTaiizor.Controls.BigLabel();
            this.Hour_Numeric = new ReaLTaiizor.Controls.CrownNumeric();
            this.second_Numeric = new ReaLTaiizor.Controls.CrownNumeric();
            this.Minutes_Numeric = new ReaLTaiizor.Controls.CrownNumeric();
            this.TimerCountdown = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timespan_progressbar = new ReaLTaiizor.Controls.DreamProgressBar();
            this.reset_btn = new ePOSOne.btnProduct.Button_WOC();
            this.pause_btn = new ePOSOne.btnProduct.Button_WOC();
            this.start_btn = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Hour_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minutes_Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // show_time_label
            // 
            this.show_time_label.AutoSize = true;
            this.show_time_label.BackColor = System.Drawing.Color.Transparent;
            this.show_time_label.Font = new System.Drawing.Font("Nirmala UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_time_label.ForeColor = System.Drawing.Color.White;
            this.show_time_label.Location = new System.Drawing.Point(32, 162);
            this.show_time_label.Name = "show_time_label";
            this.show_time_label.Size = new System.Drawing.Size(577, 128);
            this.show_time_label.TabIndex = 0;
            this.show_time_label.Text = "00：00：00";
            // 
            // Hour_Numeric
            // 
            this.Hour_Numeric.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hour_Numeric.Location = new System.Drawing.Point(54, 286);
            this.Hour_Numeric.Name = "Hour_Numeric";
            this.Hour_Numeric.Size = new System.Drawing.Size(120, 35);
            this.Hour_Numeric.TabIndex = 14;
            // 
            // second_Numeric
            // 
            this.second_Numeric.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second_Numeric.Location = new System.Drawing.Point(461, 286);
            this.second_Numeric.Name = "second_Numeric";
            this.second_Numeric.Size = new System.Drawing.Size(120, 35);
            this.second_Numeric.TabIndex = 15;
            // 
            // Minutes_Numeric
            // 
            this.Minutes_Numeric.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minutes_Numeric.Location = new System.Drawing.Point(257, 286);
            this.Minutes_Numeric.Name = "Minutes_Numeric";
            this.Minutes_Numeric.Size = new System.Drawing.Size(120, 35);
            this.Minutes_Numeric.TabIndex = 16;
            // 
            // TimerCountdown
            // 
            this.TimerCountdown.Enabled = true;
            this.TimerCountdown.Interval = 1000;
            this.TimerCountdown.Tick += new System.EventHandler(this.TimerCountdown_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(107, 424);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(0, 0);
            this.progressBar1.TabIndex = 17;
            // 
            // timespan_progressbar
            // 
            this.timespan_progressbar.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.timespan_progressbar.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.timespan_progressbar.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.timespan_progressbar.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timespan_progressbar.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.timespan_progressbar.Location = new System.Drawing.Point(54, 424);
            this.timespan_progressbar.Name = "timespan_progressbar";
            this.timespan_progressbar.Size = new System.Drawing.Size(857, 23);
            this.timespan_progressbar.TabIndex = 22;
            this.timespan_progressbar.Value = 50;
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.Tomato;
            this.reset_btn.BorderColor = System.Drawing.Color.White;
            this.reset_btn.ButtonColor = System.Drawing.Color.Turquoise;
            this.reset_btn.FlatAppearance.BorderSize = 0;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_btn.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Image = global::Timer.Properties.Resources.play_100px;
            this.reset_btn.Location = new System.Drawing.Point(782, 206);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.OnHoverBorderColor = System.Drawing.Color.Tomato;
            this.reset_btn.OnHoverButtonColor = System.Drawing.Color.Black;
            this.reset_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.reset_btn.Size = new System.Drawing.Size(139, 88);
            this.reset_btn.TabIndex = 7;
            this.reset_btn.Text = "Reset";
            this.reset_btn.TextColor = System.Drawing.Color.DarkSlateGray;
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // pause_btn
            // 
            this.pause_btn.BorderColor = System.Drawing.Color.White;
            this.pause_btn.ButtonColor = System.Drawing.Color.Tomato;
            this.pause_btn.FlatAppearance.BorderSize = 0;
            this.pause_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause_btn.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause_btn.Image = global::Timer.Properties.Resources.play_100px;
            this.pause_btn.Location = new System.Drawing.Point(615, 206);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.OnHoverBorderColor = System.Drawing.Color.Tomato;
            this.pause_btn.OnHoverButtonColor = System.Drawing.Color.Black;
            this.pause_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.pause_btn.Size = new System.Drawing.Size(139, 88);
            this.pause_btn.TabIndex = 6;
            this.pause_btn.Text = "❚❚";
            this.pause_btn.TextColor = System.Drawing.Color.White;
            this.pause_btn.UseVisualStyleBackColor = true;
            this.pause_btn.Visible = false;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.BorderColor = System.Drawing.Color.White;
            this.start_btn.ButtonColor = System.Drawing.Color.Tomato;
            this.start_btn.FlatAppearance.BorderSize = 0;
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_btn.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Image = global::Timer.Properties.Resources.play_100px;
            this.start_btn.Location = new System.Drawing.Point(615, 206);
            this.start_btn.Name = "start_btn";
            this.start_btn.OnHoverBorderColor = System.Drawing.Color.Tomato;
            this.start_btn.OnHoverButtonColor = System.Drawing.Color.Black;
            this.start_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.start_btn.Size = new System.Drawing.Size(139, 88);
            this.start_btn.TabIndex = 5;
            this.start_btn.Text = "▶";
            this.start_btn.TextColor = System.Drawing.Color.White;
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(182, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            // 
            // EasyTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(952, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timespan_progressbar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Minutes_Numeric);
            this.Controls.Add(this.second_Numeric);
            this.Controls.Add(this.Hour_Numeric);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.pause_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.show_time_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EasyTimer";
            this.Text = "EasyTimer";
            ((System.ComponentModel.ISupportInitialize)(this.Hour_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minutes_Numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ePOSOne.btnProduct.Button_WOC start_btn;
        private ePOSOne.btnProduct.Button_WOC pause_btn;
        private ePOSOne.btnProduct.Button_WOC reset_btn;
        private ReaLTaiizor.Controls.BigLabel show_time_label;
        private ReaLTaiizor.Controls.CrownNumeric Hour_Numeric;
        private ReaLTaiizor.Controls.CrownNumeric second_Numeric;
        private ReaLTaiizor.Controls.CrownNumeric Minutes_Numeric;
        private System.Windows.Forms.Timer TimerCountdown;
        private System.Windows.Forms.ProgressBar progressBar1;
        private ReaLTaiizor.Controls.DreamProgressBar timespan_progressbar;
        private System.Windows.Forms.Label label1;
    }
}

