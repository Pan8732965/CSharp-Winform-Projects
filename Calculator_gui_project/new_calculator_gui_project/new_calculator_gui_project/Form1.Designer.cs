
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
            this.zero_button = new System.Windows.Forms.Button();
            this.one_button = new System.Windows.Forms.Button();
            this.two_button = new System.Windows.Forms.Button();
            this.three_button = new System.Windows.Forms.Button();
            this.dot_button = new System.Windows.Forms.Button();
            this.minus_button = new System.Windows.Forms.Button();
            this.equal_button = new System.Windows.Forms.Button();
            this.plus_button = new System.Windows.Forms.Button();
            this.four_button = new System.Windows.Forms.Button();
            this.seven_button = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.five_button = new System.Windows.Forms.Button();
            this.eight_button = new System.Windows.Forms.Button();
            this.six_button = new System.Windows.Forms.Button();
            this.nine_button = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.divide_button = new System.Windows.Forms.Button();
            this.multipy_button = new System.Windows.Forms.Button();
            this.remainder_button = new System.Windows.Forms.Button();
            this.clear_all_button = new System.Windows.Forms.Button();
            this.clear_front_button = new System.Windows.Forms.Button();
            this.show_equation = new System.Windows.Forms.Label();
            this.showing_quation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft JhengHei UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(51, 25);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.result.Size = new System.Drawing.Size(589, 62);
            this.result.TabIndex = 0;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // zero_button
            // 
            this.zero_button.Font = new System.Drawing.Font("思源黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zero_button.Location = new System.Drawing.Point(51, 478);
            this.zero_button.Name = "zero_button";
            this.zero_button.Size = new System.Drawing.Size(213, 73);
            this.zero_button.TabIndex = 1;
            this.zero_button.Text = "0";
            this.zero_button.UseVisualStyleBackColor = true;
            this.zero_button.Click += new System.EventHandler(this.one_button_Click);
            // 
            // one_button
            // 
            this.one_button.Font = new System.Drawing.Font("思源黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.one_button.Location = new System.Drawing.Point(51, 389);
            this.one_button.Name = "one_button";
            this.one_button.Size = new System.Drawing.Size(94, 83);
            this.one_button.TabIndex = 19;
            this.one_button.Text = "1";
            this.one_button.UseVisualStyleBackColor = true;
            this.one_button.Click += new System.EventHandler(this.one_button_Click);
            // 
            // two_button
            // 
            this.two_button.Font = new System.Drawing.Font("思源黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.two_button.Location = new System.Drawing.Point(164, 389);
            this.two_button.Name = "two_button";
            this.two_button.Size = new System.Drawing.Size(100, 83);
            this.two_button.TabIndex = 20;
            this.two_button.Text = "2";
            this.two_button.UseVisualStyleBackColor = true;
            this.two_button.Click += new System.EventHandler(this.one_button_Click);
            // 
            // three_button
            // 
            this.three_button.Font = new System.Drawing.Font("思源黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.three_button.Location = new System.Drawing.Point(281, 389);
            this.three_button.Name = "three_button";
            this.three_button.Size = new System.Drawing.Size(90, 83);
            this.three_button.TabIndex = 23;
            this.three_button.Text = "3";
            this.three_button.UseVisualStyleBackColor = true;
            this.three_button.Click += new System.EventHandler(this.one_button_Click);
            // 
            // dot_button
            // 
            this.dot_button.BackColor = System.Drawing.Color.DarkOrchid;
            this.dot_button.Font = new System.Drawing.Font("思源黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dot_button.ForeColor = System.Drawing.Color.Transparent;
            this.dot_button.Location = new System.Drawing.Point(281, 478);
            this.dot_button.Name = "dot_button";
            this.dot_button.Size = new System.Drawing.Size(90, 73);
            this.dot_button.TabIndex = 24;
            this.dot_button.Text = ".";
            this.dot_button.UseVisualStyleBackColor = false;
            this.dot_button.Click += new System.EventHandler(this.one_button_Click);
            // 
            // minus_button
            // 
            this.minus_button.Font = new System.Drawing.Font("思源黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minus_button.Location = new System.Drawing.Point(391, 478);
            this.minus_button.Name = "minus_button";
            this.minus_button.Size = new System.Drawing.Size(103, 73);
            this.minus_button.TabIndex = 25;
            this.minus_button.Text = "-";
            this.minus_button.UseVisualStyleBackColor = true;
            this.minus_button.Click += new System.EventHandler(this.operation_click);
            // 
            // equal_button
            // 
            this.equal_button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.equal_button.Font = new System.Drawing.Font("思源黑體 Heavy", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.equal_button.Location = new System.Drawing.Point(520, 389);
            this.equal_button.Name = "equal_button";
            this.equal_button.Size = new System.Drawing.Size(120, 162);
            this.equal_button.TabIndex = 26;
            this.equal_button.Text = "=";
            this.equal_button.UseVisualStyleBackColor = false;
            this.equal_button.Click += new System.EventHandler(this.equal_button_Click);
            // 
            // plus_button
            // 
            this.plus_button.Font = new System.Drawing.Font("思源黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plus_button.Location = new System.Drawing.Point(391, 389);
            this.plus_button.Name = "plus_button";
            this.plus_button.Size = new System.Drawing.Size(103, 83);
            this.plus_button.TabIndex = 27;
            this.plus_button.Text = "+";
            this.plus_button.UseVisualStyleBackColor = true;
            this.plus_button.Click += new System.EventHandler(this.operation_click);
            // 
            // four_button
            // 
            this.four_button.Font = new System.Drawing.Font("思源黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.four_button.Location = new System.Drawing.Point(51, 289);
            this.four_button.Name = "four_button";
            this.four_button.Size = new System.Drawing.Size(94, 83);
            this.four_button.TabIndex = 28;
            this.four_button.Text = "4";
            this.four_button.UseVisualStyleBackColor = true;
            this.four_button.Click += new System.EventHandler(this.one_button_Click);
            // 
            // seven_button
            // 
            this.seven_button.Font = new System.Drawing.Font("思源黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.seven_button.Location = new System.Drawing.Point(51, 195);
            this.seven_button.Name = "seven_button";
            this.seven_button.Size = new System.Drawing.Size(94, 83);
            this.seven_button.TabIndex = 29;
            this.seven_button.Text = "7";
            this.seven_button.UseVisualStyleBackColor = true;
            this.seven_button.Click += new System.EventHandler(this.one_button_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("思源黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(51, 110);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(213, 69);
            this.button9.TabIndex = 30;
            this.button9.Text = "Log";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // five_button
            // 
            this.five_button.Font = new System.Drawing.Font("思源黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.five_button.Location = new System.Drawing.Point(164, 289);
            this.five_button.Name = "five_button";
            this.five_button.Size = new System.Drawing.Size(100, 83);
            this.five_button.TabIndex = 31;
            this.five_button.Text = "5";
            this.five_button.UseVisualStyleBackColor = true;
            this.five_button.Click += new System.EventHandler(this.one_button_Click);
            // 
            // eight_button
            // 
            this.eight_button.Font = new System.Drawing.Font("思源黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eight_button.Location = new System.Drawing.Point(164, 195);
            this.eight_button.Name = "eight_button";
            this.eight_button.Size = new System.Drawing.Size(100, 83);
            this.eight_button.TabIndex = 32;
            this.eight_button.Text = "8";
            this.eight_button.UseVisualStyleBackColor = true;
            this.eight_button.Click += new System.EventHandler(this.one_button_Click);
            // 
            // six_button
            // 
            this.six_button.Font = new System.Drawing.Font("思源黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.six_button.Location = new System.Drawing.Point(281, 289);
            this.six_button.Name = "six_button";
            this.six_button.Size = new System.Drawing.Size(90, 83);
            this.six_button.TabIndex = 33;
            this.six_button.Text = "6";
            this.six_button.UseVisualStyleBackColor = true;
            this.six_button.Click += new System.EventHandler(this.one_button_Click);
            // 
            // nine_button
            // 
            this.nine_button.Font = new System.Drawing.Font("思源黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nine_button.Location = new System.Drawing.Point(281, 195);
            this.nine_button.Name = "nine_button";
            this.nine_button.Size = new System.Drawing.Size(90, 83);
            this.nine_button.TabIndex = 34;
            this.nine_button.Text = "9";
            this.nine_button.UseVisualStyleBackColor = true;
            this.nine_button.Click += new System.EventHandler(this.one_button_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("思源黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button14.Location = new System.Drawing.Point(281, 110);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(90, 69);
            this.button14.TabIndex = 35;
            this.button14.Text = "√";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("思源黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button15.Location = new System.Drawing.Point(391, 110);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(103, 69);
            this.button15.TabIndex = 36;
            this.button15.Text = "x²";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.funtion_clicked);
            // 
            // divide_button
            // 
            this.divide_button.Font = new System.Drawing.Font("思源黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.divide_button.Location = new System.Drawing.Point(391, 195);
            this.divide_button.Name = "divide_button";
            this.divide_button.Size = new System.Drawing.Size(103, 83);
            this.divide_button.TabIndex = 37;
            this.divide_button.Text = "÷";
            this.divide_button.UseVisualStyleBackColor = true;
            this.divide_button.Click += new System.EventHandler(this.operation_click);
            // 
            // multipy_button
            // 
            this.multipy_button.Font = new System.Drawing.Font("思源黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.multipy_button.Location = new System.Drawing.Point(391, 289);
            this.multipy_button.Name = "multipy_button";
            this.multipy_button.Size = new System.Drawing.Size(103, 83);
            this.multipy_button.TabIndex = 38;
            this.multipy_button.Text = "×";
            this.multipy_button.UseVisualStyleBackColor = true;
            this.multipy_button.Click += new System.EventHandler(this.operation_click);
            // 
            // remainder_button
            // 
            this.remainder_button.Font = new System.Drawing.Font("思源黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remainder_button.Location = new System.Drawing.Point(520, 289);
            this.remainder_button.Name = "remainder_button";
            this.remainder_button.Size = new System.Drawing.Size(120, 83);
            this.remainder_button.TabIndex = 39;
            this.remainder_button.Text = "%";
            this.remainder_button.UseVisualStyleBackColor = true;
            this.remainder_button.Click += new System.EventHandler(this.operation_click);
            // 
            // clear_all_button
            // 
            this.clear_all_button.BackColor = System.Drawing.Color.Red;
            this.clear_all_button.Font = new System.Drawing.Font("思源黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear_all_button.ForeColor = System.Drawing.Color.Transparent;
            this.clear_all_button.Location = new System.Drawing.Point(520, 195);
            this.clear_all_button.Name = "clear_all_button";
            this.clear_all_button.Size = new System.Drawing.Size(120, 83);
            this.clear_all_button.TabIndex = 40;
            this.clear_all_button.Text = "C";
            this.clear_all_button.UseVisualStyleBackColor = false;
            this.clear_all_button.Click += new System.EventHandler(this.clear_all_button_Click);
            // 
            // clear_front_button
            // 
            this.clear_front_button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.clear_front_button.Font = new System.Drawing.Font("思源黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear_front_button.ForeColor = System.Drawing.SystemColors.Desktop;
            this.clear_front_button.Location = new System.Drawing.Point(520, 110);
            this.clear_front_button.Name = "clear_front_button";
            this.clear_front_button.Size = new System.Drawing.Size(120, 69);
            this.clear_front_button.TabIndex = 41;
            this.clear_front_button.Text = "CE";
            this.clear_front_button.UseVisualStyleBackColor = false;
            this.clear_front_button.Click += new System.EventHandler(this.clear_front_button_Click);
            // 
            // show_equation
            // 
            this.show_equation.AutoSize = true;
            this.show_equation.BackColor = System.Drawing.Color.White;
            this.show_equation.Font = new System.Drawing.Font("思源黑體 Medium", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.show_equation.Location = new System.Drawing.Point(-413, -106);
            this.show_equation.Name = "show_equation";
            this.show_equation.Size = new System.Drawing.Size(0, 43);
            this.show_equation.TabIndex = 42;
            // 
            // showing_quation
            // 
            this.showing_quation.AutoSize = true;
            this.showing_quation.BackColor = System.Drawing.Color.White;
            this.showing_quation.Font = new System.Drawing.Font("思源黑體 Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.showing_quation.Location = new System.Drawing.Point(51, 25);
            this.showing_quation.Name = "showing_quation";
            this.showing_quation.Size = new System.Drawing.Size(0, 29);
            this.showing_quation.TabIndex = 43;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(678, 575);
            this.Controls.Add(this.showing_quation);
            this.Controls.Add(this.show_equation);
            this.Controls.Add(this.clear_front_button);
            this.Controls.Add(this.clear_all_button);
            this.Controls.Add(this.remainder_button);
            this.Controls.Add(this.multipy_button);
            this.Controls.Add(this.divide_button);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.nine_button);
            this.Controls.Add(this.six_button);
            this.Controls.Add(this.eight_button);
            this.Controls.Add(this.five_button);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.seven_button);
            this.Controls.Add(this.four_button);
            this.Controls.Add(this.plus_button);
            this.Controls.Add(this.equal_button);
            this.Controls.Add(this.minus_button);
            this.Controls.Add(this.dot_button);
            this.Controls.Add(this.three_button);
            this.Controls.Add(this.two_button);
            this.Controls.Add(this.one_button);
            this.Controls.Add(this.zero_button);
            this.Controls.Add(this.result);
            this.Name = "Calculator";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button zero_button;
        private System.Windows.Forms.Button one_button;
        private System.Windows.Forms.Button two_button;
        private System.Windows.Forms.Button three_button;
        private System.Windows.Forms.Button dot_button;
        private System.Windows.Forms.Button minus_button;
        private System.Windows.Forms.Button equal_button;
        private System.Windows.Forms.Button plus_button;
        private System.Windows.Forms.Button four_button;
        private System.Windows.Forms.Button seven_button;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button five_button;
        private System.Windows.Forms.Button eight_button;
        private System.Windows.Forms.Button six_button;
        private System.Windows.Forms.Button nine_button;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button divide_button;
        private System.Windows.Forms.Button multipy_button;
        private System.Windows.Forms.Button remainder_button;
        private System.Windows.Forms.Button clear_all_button;
        private System.Windows.Forms.Button clear_front_button;
        private System.Windows.Forms.Label show_equation;
        private System.Windows.Forms.Label showing_quation;
    }
}

