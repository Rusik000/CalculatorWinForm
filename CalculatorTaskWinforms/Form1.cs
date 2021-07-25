using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorTaskWinforms
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_Click(object sender, EventArgs e)
        {

            if ((ResultTxt.Text == "0") || (operation_pressed))
            {
                ResultTxt.Clear();
            }
            operation_pressed = false;
            Button b = (Button)sender;
            ResultTxt.Text = ResultTxt.Text + b.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(ResultTxt.Text);
            operation_pressed = true;
            resultlbl.Text = value + " " + operation;
        }

        private void equalbtn_Click(object sender, EventArgs e)
        {
            resultlbl.Text = "";
            switch (operation)
            {
                case "+":
                    ResultTxt.Text = (value + double.Parse(ResultTxt.Text)).ToString();
                    break;
                case "-":
                    ResultTxt.Text = (value - double.Parse(ResultTxt.Text)).ToString();
                    break;
                case "*":
                    ResultTxt.Text = (value * double.Parse(ResultTxt.Text)).ToString();
                    break;
                case "/":
                    ResultTxt.Text = (value / double.Parse(ResultTxt.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
        private void deletebtn_Click(object sender, EventArgs e)
        {
            ResultTxt.Text = "0";
            value = 0; 
        }
    }
}
