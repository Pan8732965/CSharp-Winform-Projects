
namespace new_guessing_game_gui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guessNumber = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.InputNumber = new System.Windows.Forms.NumericUpDown();
            this.showInfosLabel = new System.Windows.Forms.Label();
            this.timesLabel = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InputNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // guessNumber
            // 
            this.guessNumber.Font = new System.Drawing.Font("思源黑體 HW", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guessNumber.Location = new System.Drawing.Point(142, 158);
            this.guessNumber.Name = "guessNumber";
            this.guessNumber.Size = new System.Drawing.Size(244, 68);
            this.guessNumber.TabIndex = 0;
            this.guessNumber.Text = "猜";
            this.guessNumber.UseVisualStyleBackColor = true;
            this.guessNumber.Click += new System.EventHandler(this.guessNumber_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("思源黑體 HW", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetButton.Location = new System.Drawing.Point(142, 232);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(244, 73);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "在猜一次(回合重設)";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // InputNumber
            // 
            this.InputNumber.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputNumber.Location = new System.Drawing.Point(423, 158);
            this.InputNumber.Name = "InputNumber";
            this.InputNumber.Size = new System.Drawing.Size(168, 33);
            this.InputNumber.TabIndex = 2;
            // 
            // showInfosLabel
            // 
            this.showInfosLabel.AutoSize = true;
            this.showInfosLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showInfosLabel.Font = new System.Drawing.Font("思源黑體 HW", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.showInfosLabel.ForeColor = System.Drawing.Color.White;
            this.showInfosLabel.Location = new System.Drawing.Point(423, 206);
            this.showInfosLabel.Name = "showInfosLabel";
            this.showInfosLabel.Size = new System.Drawing.Size(168, 32);
            this.showInfosLabel.TabIndex = 3;
            this.showInfosLabel.Text = "請輸入您的數字";
            // 
            // timesLabel
            // 
            this.timesLabel.AutoSize = true;
            this.timesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timesLabel.Font = new System.Drawing.Font("思源黑體 HW", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timesLabel.ForeColor = System.Drawing.Color.Aqua;
            this.timesLabel.Location = new System.Drawing.Point(423, 252);
            this.timesLabel.Name = "timesLabel";
            this.timesLabel.Size = new System.Drawing.Size(131, 33);
            this.timesLabel.TabIndex = 4;
            this.timesLabel.Text = "剩下次數:5";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.WelcomeLabel.Font = new System.Drawing.Font("思源黑體 HW", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WelcomeLabel.Location = new System.Drawing.Point(127, 76);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(501, 39);
            this.WelcomeLabel.TabIndex = 5;
            this.WelcomeLabel.Text = "歡迎來到猜數字遊戲，猜一個數字吧!😀";
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("思源黑體 HW", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit.Location = new System.Drawing.Point(216, 311);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 40);
            this.exit.TabIndex = 6;
            this.exit.Text = "離開🚪";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(764, 427);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.timesLabel);
            this.Controls.Add(this.showInfosLabel);
            this.Controls.Add(this.InputNumber);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.guessNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "猜數字遊戲";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InputNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guessNumber;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.NumericUpDown InputNumber;
        private System.Windows.Forms.Label showInfosLabel;
        private System.Windows.Forms.Label timesLabel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button exit;
    }
}

