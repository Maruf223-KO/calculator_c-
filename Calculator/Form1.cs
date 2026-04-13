using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "3";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "+";
        }

        private void four_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "6";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "-";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "9";
        }

        private void muiti_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "*";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "0";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "/";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            int operand = 0;
            string num = "";
            char opt = '0';
            int temp = 0;
            string expression = display.Text + "/";
            for(int i = 0; i < expression.Length; i++)
            {
                num += expression[i];
                if (expression[i] == '+' || expression[i] == '-' || expression[i] == '*' || expression[i] == '/')
                {
                    operand=Int32.Parse(num.Substring(0,num.Length-1));
                    if (opt == '0')
                    {
                        opt = display.Text[i];
                    }
                    else
                    {
                        if (opt == '+')
                        {
                            operand = temp + operand;
                        }else if (opt == '-')
                        {
                            operand = temp - operand;
                        }else if (opt == '*')
                        {
                            operand = temp * operand;
                        }else if (opt=='/')
                        {
                            operand = temp / operand;
                        }
                        opt = expression[i];
                    }
                    temp = operand;
                    operand = 0;
                    num = "";
                }
            }
            display.Text = temp.ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            display.Text = "";
        }
    }
}
