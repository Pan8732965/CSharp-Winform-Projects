
namespace new_calculator_gui_project
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.result = new System.Windows.Forms.TextBox();
            this.showing_quation = new System.Windows.Forms.Label();
            this.one_button = new System.Windows.Forms.Button();
            this.equal_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.c_button = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.squre = new System.Windows.Forms.Button();
            this.three_button = new System.Windows.Forms.Button();
            this.plus_button = new System.Windows.Forms.Button();
            this.divide_button = new System.Windows.Forms.Button();
            this.multipy_button = new System.Windows.Forms.Button();
            this.minus_button = new System.Windows.Forms.Button();
            this.zero_button = new System.Windows.Forms.Button();
            this.nine_button = new System.Windows.Forms.Button();
            this.dot_button = new System.Windows.Forms.Button();
            this.eight_button = new System.Windows.Forms.Button();
            this.four_button = new System.Windows.Forms.Button();
            this.five_button = new System.Windows.Forms.Button();
            this.seven_button = new System.Windows.Forms.Button();
            this.six_button = new System.Windows.Forms.Button();
            this.two_button = new System.Windows.Forms.Button();
            this.Log_button = new System.Windows.Forms.Button();
            this.remainder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft JhengHei UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(55, 95);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.result.Size = new System.Drawing.Size(589, 62);
            this.result.TabIndex = 0;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // showing_quation
            // 
            this.showing_quation.BackColor = System.Drawing.Color.White;
            this.showing_quation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.showing_quation.Location = new System.Drawing.Point(55, 69);
            this.showing_quation.Name = "showing_quation";
            this.showing_quation.Size = new System.Drawing.Size(589, 33);
            this.showing_quation.TabIndex = 43;
            this.showing_quation.Text = "Calculator";
            this.showing_quation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // one_button
            // 
            this.one_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.one_button.Location = new System.Drawing.Point(63, 443);
            this.one_button.Name = "one_button";
            this.one_button.Size = new System.Drawing.Size(112, 82);
            this.one_button.TabIndex = 46;
            this.one_button.Text = "1";
            this.one_button.UseVisualStyleBackColor = true;
            this.one_button.Click += new System.EventHandler(this.number_button_Click);
            this.one_button.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed_1);
            // 
            // equal_button
            // 
            this.equal_button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.equal_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.equal_button.Location = new System.Drawing.Point(537, 443);
            this.equal_button.Name = "equal_button";
            this.equal_button.Size = new System.Drawing.Size(109, 171);
            this.equal_button.TabIndex = 50;
            this.equal_button.Text = "=";
            this.equal_button.UseVisualStyleBackColor = false;
            this.equal_button.Click += new System.EventHandler(this.equal_button_Click);
            this.equal_button.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed_1);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back_button.ForeColor = System.Drawing.SystemColors.Desktop;
            this.back_button.Location = new System.Drawing.Point(533, 179);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(113, 82);
            this.back_button.TabIndex = 63;
            this.back_button.Text = "⌫";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.clear_front_button_Click);
            this.back_button.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed_1);
            // 
            // c_button
            // 
            this.c_button.BackColor = System.Drawing.Color.Red;
            this.c_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.c_button.ForeColor = System.Drawing.Color.Transparent;
            this.c_button.Location = new System.Drawing.Point(533, 267);
            this.c_button.Name = "c_button";
            this.c_button.Size = new System.Drawing.Size(113, 82);
            this.c_button.TabIndex = 62;
            this.c_button.Text = "C";
            this.c_button.UseVisualStyleBackColor = false;
            this.c_button.Click += new System.EventHandler(this.clear_all_button_Click);
            // 
            // sqrt
            // 
            this.sqrt.BackColor = System.Drawing.Color.Coral;
            this.sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sqrt.Location = new System.Drawing.Point(299, 179);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(111, 82);
            this.sqrt.TabIndex = 58;
            this.sqrt.Text = "√";
            this.sqrt.UseVisualStyleBackColor = false;
            this.sqrt.Click += new System.EventHandler(this.funtion_clicked);
            // 
            // squre
            // 
            this.squre.BackColor = System.Drawing.Color.Coral;
            this.squre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.squre.Location = new System.Drawing.Point(416, 179);
            this.squre.Name = "squre";
            this.squre.Size = new System.Drawing.Size(109, 82);
            this.squre.TabIndex = 59;
            this.squre.Text = "x²";
            this.squre.UseVisualStyleBackColor = false;
            this.squre.Click += new System.EventHandler(this.funtion_clicked);
            // 
            // three_button
            // 
            this.three_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.three_button.Location = new System.Drawing.Point(299, 443);
            this.three_button.Name = "three_button";
            this.three_button.Size = new System.Drawing.Size(111, 82);
            this.three_button.TabIndex = 47;
            this.three_button.Text = "3";
            this.three_button.UseVisualStyleBackColor = true;
            this.three_button.Click += new System.EventHandler(this.number_button_Click);
            this.three_button.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed_1);
            // 
            // plus_button
            // 
            this.plus_button.BackColor = System.Drawing.Color.Gray;
            this.plus_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plus_button.Location = new System.Drawing.Point(416, 443);
            this.plus_button.Name = "plus_button";
            this.plus_button.Size = new System.Drawing.Size(109, 82);
            this.plus_button.TabIndex = 51;
            this.plus_button.Text = "+";
            this.plus_button.UseVisualStyleBackColor = false;
            this.plus_button.Click += new System.EventHandler(this.operation_click);
            this.plus_button.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed_1);
            // 
            // divide_button
            // 
            this.divide_button.BackColor = System.Drawing.Color.Gray;
            this.divide_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.divide_button.Location = new System.Drawing.Point(416, 267);
            this.divide_button.Name = "divide_button";
            this.divide_button.Size = new System.Drawing.Size(109, 82);
            this.divide_button.TabIndex = 60;
            this.divide_button.Text = "÷";
            this.divide_button.UseVisualStyleBackColor = false;
            this.divide_button.Click += new System.EventHandler(this.operation_click);
            this.divide_button.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed_1);
            // 
            // multipy_button
            // 
            this.multipy_button.BackColor = System.Drawing.Color.Gray;
            this.multipy_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.multipy_button.Location = new System.Drawing.Point(416, 355);
            this.multipy_button.Name = "multipy_button";
            this.multipy_button.Size = new System.Drawing.Size(109, 82);
            this.multipy_button.TabIndex = 61;
            this.multipy_button.Text = "×";
            this.multipy_button.UseVisualStyleBackColor = false;
            this.multipy_button.Click += new System.EventHandler(this.operation_click);
            this.multipy_button.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed_1);
            // 
            // minus_button
            // 
            this.minus_button.BackColor = System.Drawing.Color.Gray;
            this.minus_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minus_button.Location = new System.Drawing.Point(416, 531);
            this.minus_button.Name = "minus_button";
            this.minus_button.Size = new System.Drawing.Size(109, 83);
            this.minus_button.TabIndex = 49;
            this.minus_button.Text = "-";
            this.minus_button.UseVisualStyleBackColor = false;
            this.minus_button.Click += new System.EventHandler(this.operation_click);
            this.minus_button.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed_1);
            // 
            // zero_button
            // 
            this.zero_button.BackColor = System.Drawing.Color.Gray;
            this.zero_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.zero_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zero_button.Location = new System.Drawing.Point(63, 531);
            this.zero_button.Name = "zero_button";
            this.zero_button.Size = new System.Drawing.Size(229, 83);
            this.zero_button.TabIndex = 45;
            this.zero_button.Text = "0";
            this.zero_button.UseVisualStyleBackColor = false;
            this.zero_button.Click += new System.EventHandler(this.number_button_Click);
            this.zero_button.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed_1);
            // 
            // nine_button
            // 
            this.nine_button.BackColor = System.Drawing.Color.White;
            this.nine_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nine_button.Location = new System.Drawing.Point(299, 267);
            this.nine_button.Name = "nine_button";
            this.nine_button.Size = new System.Drawing.Size(111, 82);
            this.nine_button.TabIndex = 57;
            this.nine_button.Text = "9";
            this.nine_button.UseVisualStyleBackColor = false;
            this.nine_button.Click += new System.EventHandler(this.number_button_Click);
            // 
            // dot_button
            // 
            this.dot_button.BackColor = System.Drawing.Color.DarkOrchid;
            this.dot_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dot_button.ForeColor = System.Drawing.Color.Transparent;
            this.dot_button.Location = new System.Drawing.Point(299, 531);
            this.dot_button.Name = "dot_button";
            this.dot_button.Size = new System.Drawing.Size(111, 83);
            this.dot_button.TabIndex = 48;
            this.dot_button.Text = ".";
            this.dot_button.UseVisualStyleBackColor = false;
            this.dot_button.Click += new System.EventHandler(this.number_button_Click);
            this.dot_button.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed_1);
            // 
            // eight_button
            // 
            this.eight_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eight_button.Location = new System.Drawing.Point(181, 267);
            this.eight_button.Name = "eight_button";
            this.eight_button.Size = new System.Drawing.Size(112, 82);
            this.eight_button.TabIndex = 55;
            this.eight_button.Text = "8";
            this.eight_button.UseVisualStyleBackColor = true;
            this.eight_button.Click += new System.EventHandler(this.number_button_Click);
            this.eight_button.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed_1);
            // 
            // four_button
            // 
            this.four_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.four_button.Location = new System.Drawing.Point(63, 355);
            this.four_button.Name = "four_button";
            this.four_button.Size = new System.Drawing.Size(112, 82);
            this.four_button.TabIndex = 52;
            this.four_button.Text = "4";
            this.four_button.UseVisualStyleBackColor = true;
            this.four_button.Click += new System.EventHandler(this.number_button_Click);
            this.four_button.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed_1);
            // 
            // five_button
            // 
            this.five_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.five_button.Location = new System.Drawing.Point(181, 355);
            this.five_button.Name = "five_button";
            this.five_button.Size = new System.Drawing.Size(112, 82);
            this.five_button.TabIndex = 54;
            this.five_button.Text = "5";
            this.five_button.UseVisualStyleBackColor = true;
            this.five_button.Click += new System.EventHandler(this.number_button_Click);
            this.five_button.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed_1);
            // 
            // seven_button
            // 
            this.seven_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.seven_button.Location = new System.Drawing.Point(63, 267);
            this.seven_button.Name = "seven_button";
            this.seven_button.Size = new System.Drawing.Size(112, 82);
            this.seven_button.TabIndex = 53;
            this.seven_button.Text = "7";
            this.seven_button.UseVisualStyleBackColor = true;
            this.seven_button.Click += new System.EventHandler(this.number_button_Click);
            this.seven_button.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed_1);
            // 
            // six_button
            // 
            this.six_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.six_button.Location = new System.Drawing.Point(299, 355);
            this.six_button.Name = "six_button";
            this.six_button.Size = new System.Drawing.Size(111, 82);
            this.six_button.TabIndex = 56;
            this.six_button.Text = "6";
            this.six_button.UseVisualStyleBackColor = true;
            this.six_button.Click += new System.EventHandler(this.number_button_Click);
            this.six_button.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed_1);
            // 
            // two_button
            // 
            this.two_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.two_button.Location = new System.Drawing.Point(181, 445);
            this.two_button.Name = "two_button";
            this.two_button.Size = new System.Drawing.Size(111, 82);
            this.two_button.TabIndex = 64;
            this.two_button.Text = "2";
            this.two_button.UseVisualStyleBackColor = true;
            this.two_button.Click += new System.EventHandler(this.number_button_Click);
            this.two_button.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed_1);
            // 
            // Log_button
            // 
            this.Log_button.BackColor = System.Drawing.Color.Coral;
            this.Log_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Log_button.Location = new System.Drawing.Point(64, 179);
            this.Log_button.Name = "Log_button";
            this.Log_button.Size = new System.Drawing.Size(228, 82);
            this.Log_button.TabIndex = 65;
            this.Log_button.Text = "Log";
            this.Log_button.UseVisualStyleBackColor = false;
            this.Log_button.Click += new System.EventHandler(this.funtion_clicked);
            // 
            // remainder
            // 
            this.remainder.BackColor = System.Drawing.Color.Gray;
            this.remainder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remainder.Location = new System.Drawing.Point(537, 355);
            this.remainder.Name = "remainder";
            this.remainder.Size = new System.Drawing.Size(109, 82);
            this.remainder.TabIndex = 66;
            this.remainder.Text = "%";
            this.remainder.UseVisualStyleBackColor = false;
            this.remainder.Click += new System.EventHandler(this.operation_click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(699, 649);
            this.Controls.Add(this.remainder);
            this.Controls.Add(this.Log_button);
            this.Controls.Add(this.two_button);
            this.Controls.Add(this.one_button);
            this.Controls.Add(this.equal_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.c_button);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.squre);
            this.Controls.Add(this.three_button);
            this.Controls.Add(this.plus_button);
            this.Controls.Add(this.divide_button);
            this.Controls.Add(this.multipy_button);
            this.Controls.Add(this.minus_button);
            this.Controls.Add(this.zero_button);
            this.Controls.Add(this.nine_button);
            this.Controls.Add(this.dot_button);
            this.Controls.Add(this.eight_button);
            this.Controls.Add(this.four_button);
            this.Controls.Add(this.five_button);
            this.Controls.Add(this.seven_button);
            this.Controls.Add(this.six_button);
            this.Controls.Add(this.showing_quation);
            this.Controls.Add(this.result);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Calculator";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Easy Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label To_show_equation;
        private System.Windows.Forms.Label showing_quation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button equal_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button c_button;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button squre;
        private System.Windows.Forms.Button three_button;
        private System.Windows.Forms.Button plus_button;
        private System.Windows.Forms.Button divide_button;
        private System.Windows.Forms.Button multipy_button;
        private System.Windows.Forms.Button minus_button;
        private System.Windows.Forms.Button zero_button;
        private System.Windows.Forms.Button nine_button;
        private System.Windows.Forms.Button dot_button;
        private System.Windows.Forms.Button eight_button;
        private System.Windows.Forms.Button four_button;
        private System.Windows.Forms.Button five_button;
        private System.Windows.Forms.Button seven_button;
        private System.Windows.Forms.Button six_button;
        private System.Windows.Forms.Button two_button;
        private System.Windows.Forms.Button one_button;
        private System.Windows.Forms.Button Log_button;
        private System.Windows.Forms.Button remainder;
        //private System.Windows.Forms.Label To_show_equation;
    }
}

