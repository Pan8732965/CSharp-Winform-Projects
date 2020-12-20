
namespace clicker
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
            this.showtimes = new System.Windows.Forms.Label();
            this.click = new System.Windows.Forms.Button();
            this.reset_times = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showtimes
            // 
            this.showtimes.AutoSize = true;
            this.showtimes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.showtimes.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.showtimes.Location = new System.Drawing.Point(310, 134);
            this.showtimes.Name = "showtimes";
            this.showtimes.Size = new System.Drawing.Size(246, 50);
            this.showtimes.TabIndex = 0;
            this.showtimes.Text = "您已點了0下";
            // 
            // click
            // 
            this.click.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.click.Location = new System.Drawing.Point(267, 218);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(332, 62);
            this.click.TabIndex = 1;
            this.click.Text = "點我";
            this.click.UseVisualStyleBackColor = true;
            this.click.Click += new System.EventHandler(this.click_Click);
            // 
            // reset_times
            // 
            this.reset_times.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reset_times.Location = new System.Drawing.Point(353, 301);
            this.reset_times.Name = "reset_times";
            this.reset_times.Size = new System.Drawing.Size(164, 48);
            this.reset_times.TabIndex = 2;
            this.reset_times.Text = "重設次數";
            this.reset_times.UseVisualStyleBackColor = true;
            this.reset_times.Click += new System.EventHandler(this.reset_times_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reset_times);
            this.Controls.Add(this.click);
            this.Controls.Add(this.showtimes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label showtimes;
        private System.Windows.Forms.Button click;
        private System.Windows.Forms.Button reset_times;
    }
}

