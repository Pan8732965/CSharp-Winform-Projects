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
        double value=0;
        string operation = "";
        bool operation_clicked = false;

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
            result.Text = result.Text + b.Text;
        }

        private void clear_all_button_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value =double.Parse(result.Text);
            operation_clicked = true;
            showing_quation.Text = value + "" + operation;
        }

        private void equal_button_Click(object sender, EventArgs e)
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
                default:
                    break;
            }// finsihed the switch
            operation_clicked = false;
        }

        private void clear_front_button_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
