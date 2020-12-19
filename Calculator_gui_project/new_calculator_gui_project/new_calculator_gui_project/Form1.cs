using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_calculator_gui_project
{
    public partial class Calculator : Form
    {
        static double value=0;
        string operation = "";
        string function = "";
        bool operation_clicked = false;

        //problem:1.when entered the equal for the first turn,the showing number can still input the number
        //當按完等號，顯示的數字仍然可以繼續輸入數字
        //problem:2.the functions of sqrt and log can't use
        //problem:3.when from entered the number to pressed the equal button,and pressed the operator it went wrong on the textbox.
        //problem:4.and a lot that idk how to describe...
        public Calculator()
        {
            InitializeComponent();
        }

        private void one_button_Click(object sender, EventArgs e)
        {
            if (result.Text == "0"||operation_clicked)
            {
                result.Clear();
            }
            operation_clicked = false;
            Button b = (Button)sender;  // create new object to get numbers
            if (b.Text == ".")
            {
                if(!result.Text.Contains("."))
                    result.Text = result.Text + b.Text; //print the result
            }else
            result.Text = result.Text + b.Text;
        }

        private void clear_all_button_Click(object sender, EventArgs e)//ce button
        {
            result.Clear();
            value = 0;
            result.Text = "0";
            showing_quation.Text = " ";
        }

        private void operation_click(object sender, EventArgs e) //operation button
        {
            Button b = (Button)sender;
            if (value!=0)
            {
                equal_button.PerformClick();
                operation_clicked = true;
                operation = b.Text;
                show_equation.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                value =double.Parse(result.Text);
                operation_clicked = true;
                showing_quation.Text = value + "" + operation;
            }
        }

        private void equal_button_Click(object sender, EventArgs e) //equal button
        {
            showing_quation.Text = "";
            
            switch (operation)
            {
                case "×":
                    result.Text=(value * double.Parse(result.Text)).ToString();
                    break;
                case "÷":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "%":
                    result.Text = (value % double.Parse(result.Text)).ToString();
                    break;
                
                default:
                    break;
            }// finsihed the switch
            //value = Int32.Parse(result.Text);
            //operation = "";
            operation_clicked = false;


        }

        private void clear_front_button_Click(object sender, EventArgs e) //c button
        {
            result.Text = "0";
            showing_quation.Text = " ";
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void funtion_clicked(object sender, EventArgs e) //log、sqrt、x^2 button
        {
            operation_clicked = false;
            Button b = (Button)sender;
            function = b.Text;
            value = double.Parse(result.Text);  //double.Parse(result.Text) is the number the user input
            switch (function)
            {
                case "x²":
                    result.Text = (Math.Pow(double.Parse(result.Text),2).ToString());
                    break;
                case "√":
                    result.Text = (Math.Sqrt(double.Parse(result.Text)).ToString());
                    break;
                case "Log":
                    result.Text = (Math.Log(double.Parse(result.Text)).ToString());
                    break;
                default:
                    break;
            }
            
        }

        private void keyPressed(object sender, KeyPressEventArgs e)  //use keypad to enter
        {
            switch (e.KeyChar.ToString())
            {
                case "1":
                    one_button.PerformClick();
                    break;
                case "2":
                    two_button.PerformClick();
                    break;
                case "3":
                    three_button.PerformClick();
                    break;
                case "4":
                    four_button.PerformClick();
                    break;
                case "5":
                    five_button.PerformClick();
                    break;
                case "6":
                    six_button.PerformClick();
                    break;
                case "7":
                    seven_button.PerformClick();
                    break;
                case "8":
                    eight_button.PerformClick();
                    break;
                case "9":
                    nine_button.PerformClick();
                    break;
                case "0":
                    zero_button.PerformClick();
                    break;
                case "+":
                    plus_button.PerformClick();
                    break;
                case "-":
                    minus_button.PerformClick();
                    break;
                case "*":
                    multipy_button.PerformClick();
                    break;
                case "/":
                    divide_button.PerformClick();
                    break;
                case "=":
                    equal_button.PerformClick();
                    showing_quation.Text = "";
                    break;
                default:
                    break;
            }
        }
    }
}
