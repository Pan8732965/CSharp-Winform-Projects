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
        static double gotUserInput=0; 
        bool gotUserResult = false;
        bool operation_clicked = false;
        bool number_button_clicked = false;
        string operation = "";
        string function = "";
        
        //problem:1.keypressed problem-->backspace keypress didn't work;
        
        //problem:2.when complete calculate one number,at that time if i enter a new 
        //number,it's can't let user enter a new number to calculate (it'll enter at the old number)
        public Calculator()
        {
            InitializeComponent();
        }

        private void number_button_Click(object sender, EventArgs e)
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
            
            if (gotUserResult == false)
                result.Text = result.Text + b.Text;
            else {
                result.Text = b.Text;
                gotUserResult = false;
            }
            /*if (operation_clicked == true)
            {
                result.Text = "0";
            }*/
            
                
        }

        private void clear_all_button_Click(object sender, EventArgs e)//ce button
        {
            result.Clear();
            gotUserInput = 0;
            result.Text = "0";
            showing_quation.Text = " ";
        }

        private void operation_click(object sender, EventArgs e) //operation button
        {
            Button b = (Button)sender;
            if (gotUserInput!=0)
            {
                equal_button.PerformClick();//perform the function of the equal_button
                gotUserInput = 0; //set the userinput to zero,so that the number input of the 
                                    //next operate can continue.
                gotUserInput = Double.Parse(result.Text); //string to double
                //get the number of the reuslt.text that operate with the user input
                //remenber set to double,because if use int32 or 64,the number maybe is too large 
                //to launch and failed.
                result.Text = "";
                operation_clicked = true;
                operation = b.Text;
                showing_quation.Text = gotUserInput + " " + operation;
                gotUserResult = true;
            }
            else 
            {
                operation = b.Text;
                gotUserInput =double.Parse(result.Text);
                operation_clicked = true;
                showing_quation.Text = gotUserInput + "" + operation;
                gotUserResult = true;
            }
        }

        private void equal_button_Click(object sender, EventArgs e) //equal button
        {
            showing_quation.Text = "";

            switch (operation)
            {
                case "×":
                    result.Text=(gotUserInput * double.Parse(result.Text)).ToString();
                    break;
                case "÷":
                    result.Text = (gotUserInput / double.Parse(result.Text)).ToString();
                    break;
                case "+":
                    result.Text = (gotUserInput + double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (gotUserInput - double.Parse(result.Text)).ToString();
                    break;
                case "%":
                    result.Text = (gotUserInput % double.Parse(result.Text)).ToString();
                    break;
                
                default:
                    break;
            }// finsihed the switch
           
            gotUserInput = 0;

        }

        private void clear_front_button_Click(object sender, EventArgs e) //c button
        {
            result.Text = result.Text.Remove((result.Text.Length - 1));
            if (gotUserInput != 0)
            {
                showing_quation.Text = gotUserInput + " " + operation;
            }
           
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void funtion_clicked(object sender, EventArgs e) //log、sqrt、x^2 button
        {
            operation_clicked = false;
            Button b = (Button)sender;
            function = b.Text;
            gotUserInput = double.Parse(result.Text);  //double.Parse(result.Text) is the number the user input
            switch (function)
            {
                case "x²":
                    result.Text = (Math.Pow(double.Parse(result.Text), 2).ToString());
                    showing_quation.Text = "x²" + "(" + gotUserInput + ")";
                    break;
                case "√":
                    result.Text = (Math.Sqrt(double.Parse(result.Text)).ToString());
                    showing_quation.Text = "sqrt" + "(" + gotUserInput + ")";
                    break;
                case "Log":
                    result.Text = (Math.Log(double.Parse(result.Text)).ToString());
                    showing_quation.Text = "Log"+"("+gotUserInput+")";
                    break;
                default:
                    break;
            }
            

        }

        private void KeyPressed_1(object sender, KeyPressEventArgs e)
        {
            equal_button.Focus();
            //back_button.Focus();
            switch (e.KeyChar.ToString())
            {
                case "1":
                    one_button.PerformClick();
                    e.Handled = true;
                    break;
                case "2":
                    two_button.PerformClick();
                    e.Handled = true;
                    break;
                case "3":
                    three_button.PerformClick();
                    e.Handled = true;
                    break;
                case "4":
                    four_button.PerformClick();
                    e.Handled = true;
                    break;
                case "5":
                    five_button.PerformClick();
                    e.Handled = true;
                    break;
                case "6":
                    six_button.PerformClick();
                    e.Handled = true;
                    break;
                case "7":
                    seven_button.PerformClick();
                    e.Handled = true;
                    break;
                case "8":
                    eight_button.PerformClick();
                    e.Handled = true;
                    break;
                case "9":
                    nine_button.PerformClick();
                    e.Handled = true;
                    break;
                case "0":
                    zero_button.PerformClick();
                    e.Handled = true;
                    break;
                case "+":
                    plus_button.PerformClick();
                    e.Handled = true;
                    break;
                case "-":
                    minus_button.PerformClick();
                    e.Handled = true;
                    break;
                case "*":
                    multipy_button.PerformClick();
                    e.Handled = true;
                    break;
                case "/":
                    divide_button.PerformClick();
                    e.Handled = true;
                    break;
                case "Enter":
                    equal_button.PerformClick();
                    showing_quation.Text = "";
                    e.Handled = true;
                    break;
                case "Back":
                    back_button.PerformClick();
                    e.Handled = true;
                    break;
                case "c":
                    c_button.PerformClick();
                    e.Handled = true;
                    break;
                case ".":
                    dot_button.PerformClick();
                    e.Handled = true;
                    break;
                default:
                    break;
            }
        }
    }
}
