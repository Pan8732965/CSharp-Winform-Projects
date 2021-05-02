
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasyTimer));
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC2 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC3 = new ePOSOne.btnProduct.Button_WOC();
            this.lostProgressBar1 = new ReaLTaiizor.Controls.LostProgressBar();
            this.show_time = new ReaLTaiizor.Controls.BigLabel();
            this.hopeNumeric2 = new ReaLTaiizor.Controls.HopeNumeric();
            this.hopeNumeric3 = new ReaLTaiizor.Controls.HopeNumeric();
            this.hopeNumeric1 = new ReaLTaiizor.Controls.HopeNumeric();
            this.SuspendLayout();
            // 
            // button_WOC1
            // 
            this.button_WOC1.BorderColor = System.Drawing.Color.White;
            this.button_WOC1.ButtonColor = System.Drawing.Color.Tomato;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.Image = global::Timer.Properties.Resources.play_100px;
            this.button_WOC1.Location = new System.Drawing.Point(615, 206);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Tomato;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Black;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC1.Size = new System.Drawing.Size(139, 88);
            this.button_WOC1.TabIndex = 5;
            this.button_WOC1.Text = "Start";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = true;
            // 
            // button_WOC2
            // 
            this.button_WOC2.BorderColor = System.Drawing.Color.White;
            this.button_WOC2.ButtonColor = System.Drawing.Color.Tomato;
            this.button_WOC2.FlatAppearance.BorderSize = 0;
            this.button_WOC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC2.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC2.Image = global::Timer.Properties.Resources.play_100px;
            this.button_WOC2.Location = new System.Drawing.Point(615, 112);
            this.button_WOC2.Name = "button_WOC2";
            this.button_WOC2.OnHoverBorderColor = System.Drawing.Color.Tomato;
            this.button_WOC2.OnHoverButtonColor = System.Drawing.Color.Black;
            this.button_WOC2.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC2.Size = new System.Drawing.Size(139, 88);
            this.button_WOC2.TabIndex = 6;
            this.button_WOC2.Text = "Pause";
            this.button_WOC2.TextColor = System.Drawing.Color.White;
            this.button_WOC2.UseVisualStyleBackColor = true;
            // 
            // button_WOC3
            // 
            this.button_WOC3.BackColor = System.Drawing.Color.Tomato;
            this.button_WOC3.BorderColor = System.Drawing.Color.White;
            this.button_WOC3.ButtonColor = System.Drawing.Color.Turquoise;
            this.button_WOC3.FlatAppearance.BorderSize = 0;
            this.button_WOC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC3.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC3.Image = global::Timer.Properties.Resources.play_100px;
            this.button_WOC3.Location = new System.Drawing.Point(782, 206);
            this.button_WOC3.Name = "button_WOC3";
            this.button_WOC3.OnHoverBorderColor = System.Drawing.Color.Tomato;
            this.button_WOC3.OnHoverButtonColor = System.Drawing.Color.Black;
            this.button_WOC3.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC3.Size = new System.Drawing.Size(139, 88);
            this.button_WOC3.TabIndex = 7;
            this.button_WOC3.Text = "Reset";
            this.button_WOC3.TextColor = System.Drawing.Color.DarkSlateGray;
            this.button_WOC3.UseVisualStyleBackColor = false;
            // 
            // lostProgressBar1
            // 
            this.lostProgressBar1.BackColor = System.Drawing.Color.Tomato;
            this.lostProgressBar1.Color = System.Drawing.Color.Snow;
            this.lostProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.lostProgressBar1.Hover = false;
            this.lostProgressBar1.Location = new System.Drawing.Point(90, 367);
            this.lostProgressBar1.Name = "lostProgressBar1";
            this.lostProgressBar1.Progress = 50;
            this.lostProgressBar1.Size = new System.Drawing.Size(822, 32);
            this.lostProgressBar1.TabIndex = 13;
            this.lostProgressBar1.Text = "lostProgressBar1";
            // 
            // show_time
            // 
            this.show_time.AutoSize = true;
            this.show_time.BackColor = System.Drawing.Color.Transparent;
            this.show_time.Font = new System.Drawing.Font("Nirmala UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_time.ForeColor = System.Drawing.Color.White;
            this.show_time.Location = new System.Drawing.Point(68, 166);
            this.show_time.Name = "show_time";
            this.show_time.Size = new System.Drawing.Size(541, 128);
            this.show_time.TabIndex = 0;
            this.show_time.Text = "00 : 00 : 00";
            // 
            // hopeNumeric2
            // 
            this.hopeNumeric2.BackColor = System.Drawing.Color.White;
            this.hopeNumeric2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.hopeNumeric2.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopeNumeric2.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopeNumeric2.BorderHoverColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeNumeric2.ButtonTextColorA = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeNumeric2.ButtonTextColorB = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeNumeric2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeNumeric2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeNumeric2.ForeColor = System.Drawing.Color.Black;
            this.hopeNumeric2.HoverButtonTextColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeNumeric2.HoverButtonTextColorB = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeNumeric2.Location = new System.Drawing.Point(272, 297);
            this.hopeNumeric2.MaxNum = 60F;
            this.hopeNumeric2.MinNum = 0F;
            this.hopeNumeric2.Name = "hopeNumeric2";
            this.hopeNumeric2.Precision = 0;
            this.hopeNumeric2.Size = new System.Drawing.Size(120, 32);
            this.hopeNumeric2.Step = 1F;
            this.hopeNumeric2.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
            this.hopeNumeric2.TabIndex = 15;
            this.hopeNumeric2.Text = "hopeNumeric2";
            this.hopeNumeric2.ValueNumber = 0F;
            // 
            // hopeNumeric3
            // 
            this.hopeNumeric3.BackColor = System.Drawing.Color.White;
            this.hopeNumeric3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.hopeNumeric3.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopeNumeric3.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopeNumeric3.BorderHoverColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeNumeric3.ButtonTextColorA = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeNumeric3.ButtonTextColorB = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeNumeric3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeNumeric3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeNumeric3.ForeColor = System.Drawing.Color.Black;
            this.hopeNumeric3.HoverButtonTextColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeNumeric3.HoverButtonTextColorB = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeNumeric3.Location = new System.Drawing.Point(461, 297);
            this.hopeNumeric3.MaxNum = 60F;
            this.hopeNumeric3.MinNum = 0F;
            this.hopeNumeric3.Name = "hopeNumeric3";
            this.hopeNumeric3.Precision = 0;
            this.hopeNumeric3.Size = new System.Drawing.Size(120, 32);
            this.hopeNumeric3.Step = 1F;
            this.hopeNumeric3.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
            this.hopeNumeric3.TabIndex = 16;
            this.hopeNumeric3.Text = "hopeNumeric3";
            this.hopeNumeric3.ValueNumber = 0F;
            // 
            // hopeNumeric1
            // 
            this.hopeNumeric1.BackColor = System.Drawing.Color.White;
            this.hopeNumeric1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.hopeNumeric1.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopeNumeric1.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopeNumeric1.BorderHoverColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeNumeric1.ButtonTextColorA = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeNumeric1.ButtonTextColorB = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeNumeric1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeNumeric1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeNumeric1.ForeColor = System.Drawing.Color.Black;
            this.hopeNumeric1.HoverButtonTextColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeNumeric1.HoverButtonTextColorB = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeNumeric1.Location = new System.Drawing.Point(90, 297);
            this.hopeNumeric1.MaxNum = 99F;
            this.hopeNumeric1.MinNum = 0F;
            this.hopeNumeric1.Name = "hopeNumeric1";
            this.hopeNumeric1.Precision = 0;
            this.hopeNumeric1.Size = new System.Drawing.Size(120, 32);
            this.hopeNumeric1.Step = 1F;
            this.hopeNumeric1.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
            this.hopeNumeric1.TabIndex = 17;
            this.hopeNumeric1.Text = "hopeNumeric1";
            this.hopeNumeric1.ValueNumber = 0F;
            // 
            // EasyTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(952, 527);
            this.Controls.Add(this.hopeNumeric1);
            this.Controls.Add(this.hopeNumeric3);
            this.Controls.Add(this.hopeNumeric2);
            this.Controls.Add(this.lostProgressBar1);
            this.Controls.Add(this.button_WOC3);
            this.Controls.Add(this.button_WOC2);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.show_time);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EasyTimer";
            this.Text = "EasyTimer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private ePOSOne.btnProduct.Button_WOC button_WOC2;
        private ePOSOne.btnProduct.Button_WOC button_WOC3;
        private ReaLTaiizor.Controls.LostProgressBar lostProgressBar1;
        private ReaLTaiizor.Controls.BigLabel show_time;
        private ReaLTaiizor.Controls.HopeNumeric hopeNumeric2;
        private ReaLTaiizor.Controls.HopeNumeric hopeNumeric3;
        private ReaLTaiizor.Controls.HopeNumeric hopeNumeric1;
    }
}

