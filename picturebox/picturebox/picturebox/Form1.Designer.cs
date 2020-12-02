
namespace picturebox
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
            this.catbox = new System.Windows.Forms.PictureBox();
            this.changephoto = new System.Windows.Forms.Button();
            this.back_to_normal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.catbox)).BeginInit();
            this.SuspendLayout();
            // 
            // catbox
            // 
            this.catbox.Image = ((System.Drawing.Image)(resources.GetObject("catbox.Image")));
            this.catbox.Location = new System.Drawing.Point(178, 42);
            this.catbox.Name = "catbox";
            this.catbox.Size = new System.Drawing.Size(392, 364);
            this.catbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.catbox.TabIndex = 0;
            this.catbox.TabStop = false;
            // 
            // changephoto
            // 
            this.changephoto.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changephoto.Location = new System.Drawing.Point(165, 456);
            this.changephoto.Name = "changephoto";
            this.changephoto.Size = new System.Drawing.Size(205, 63);
            this.changephoto.TabIndex = 1;
            this.changephoto.Text = "變臉!";
            this.changephoto.UseVisualStyleBackColor = true;
            this.changephoto.Click += new System.EventHandler(this.changephoto_Click);
            // 
            // back_to_normal
            // 
            this.back_to_normal.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back_to_normal.Location = new System.Drawing.Point(376, 456);
            this.back_to_normal.Name = "back_to_normal";
            this.back_to_normal.Size = new System.Drawing.Size(205, 63);
            this.back_to_normal.TabIndex = 3;
            this.back_to_normal.Text = "變回去!";
            this.back_to_normal.UseVisualStyleBackColor = true;
            this.back_to_normal.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 544);
            this.Controls.Add(this.back_to_normal);
            this.Controls.Add(this.changephoto);
            this.Controls.Add(this.catbox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.catbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox catbox;
        private System.Windows.Forms.Button changephoto;
        private System.Windows.Forms.Button back_to_normal;
    }
}

