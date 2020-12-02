
namespace numericupdown
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
            this.rowchooser = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.drawstars = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rowchooser)).BeginInit();
            this.SuspendLayout();
            // 
            // rowchooser
            // 
            this.rowchooser.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rowchooser.Location = new System.Drawing.Point(442, 159);
            this.rowchooser.Name = "rowchooser";
            this.rowchooser.Size = new System.Drawing.Size(150, 37);
            this.rowchooser.TabIndex = 0;
            this.rowchooser.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(180, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "您所要的星星列數:";
            // 
            // drawstars
            // 
            this.drawstars.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.drawstars.Location = new System.Drawing.Point(332, 279);
            this.drawstars.Name = "drawstars";
            this.drawstars.Size = new System.Drawing.Size(152, 47);
            this.drawstars.TabIndex = 2;
            this.drawstars.Text = "畫出星號";
            this.drawstars.UseVisualStyleBackColor = true;
            this.drawstars.Click += new System.EventHandler(this.drawstars_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawstars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rowchooser);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rowchooser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown rowchooser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button drawstars;
    }
}

