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
        string operation = "";
        string function = "";
        
        //problem:1.keypressed problem;
        
        //problem:2.when muitipy two numbers and clicked x^2, it'll went wrong
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
                equal_button.PerformClick();
                operation_clicked = true;
                operation = b.Text;
                showing_quation.Text = gotUserInput + " " + operation;
            }
            else 
            {
                operation = b.Text;
                gotUserInput =double.Parse(result.Text);
                operation_clicked = true;
                showing_quation.Text = gotUserInput + "" + operation;
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
            //value = Int32.Parse(result.Text);
            //operation = "";
          
            operation_clicked = true;
            gotUserInput = 0;
            gotUserResult = true;

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
                case "ENTER":
                    equal_button.PerformClick();
                    showing_quation.Text = "";
                    break;
                default:
                    break;
            }
        }
    }
}
