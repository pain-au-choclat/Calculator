using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWFA
{
  
    public partial class Form1 : Form
    {
        
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        double num1, num2;
        List<string> memory = new List<string> { };

        public Form1()
        {
            InitializeComponent();
            
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if(input.Contains("."))
            {
                // Do not pass anymore "."
            }
            else input += ".";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.richTextBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (operand1.Length > 0)
            {
                this.richTextBox1.Text += input + " / ";
                this.textBox1.Text = "";

                operand2 = input;
                double num3, num4, ans;
                double.TryParse(operand1, out num3);
                double.TryParse(operand2, out num4);
                ans = num3 / num4;
                operand1 = ans.ToString();
                this.input = string.Empty;
            }
            else
            {
                operand1 = input;
                operation = '/';
                this.richTextBox1.Text += input + " / ";
                input = string.Empty;
            }

        }

        private void times_Click(object sender, EventArgs e)
        {
            if (operand1.Length > 0)
            {
                this.richTextBox1.Text += input + " x ";
                this.textBox1.Text = "";

                operand2 = input;
                double num3, num4, ans;
                double.TryParse(operand1, out num3);
                double.TryParse(operand2, out num4);
                ans = num3 * num4;
                operand1 = ans.ToString();
                this.input = string.Empty;
            }
            else
            {
                operand1 = input;
                operation = '*';
                this.richTextBox1.Text += input + " x ";
                input = string.Empty;
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (operand1.Length > 0)
            {
                this.richTextBox1.Text += input + " + ";
                this.textBox1.Text = "";

                operand2 = input;
                double num3, num4, ans;
                double.TryParse(operand1, out num3);
                double.TryParse(operand2, out num4);
                ans = num3 + num4;
                operand1 = ans.ToString();
                this.input = string.Empty;
            }
            else
            {
                operand1 = input;
                operation = '+';
                this.richTextBox1.Text += input + " + ";
                input = string.Empty;
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (operand1.Length > 0)
            {
                this.richTextBox1.Text += input + " - ";
                this.textBox1.Text = "";

                operand2 = input;
                double num3, num4, ans;
                double.TryParse(operand1, out num3);
                double.TryParse(operand2, out num4);
                ans = num3 - num4;
                operand1 = ans.ToString();
                this.input = string.Empty;
            }
            else
            {
                operand1 = input;
                operation = '-';
                this.richTextBox1.Text += input + " - ";
                input = string.Empty;
            }
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            operand1 = input;
            double.TryParse(operand1, out num1);
            if (num1 == 0)
            {
                // We dont want the sqrt of nothing
            }
            else
            {
                this.richTextBox1.Text += " √" + num1;
                num1 = Math.Sqrt(num1);

                textBox1.Text = num1.ToString();
                input = num1.ToString();
            }
            
        }

        private void memrec_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += memory[1];
            // this.richTextBox1.Text += memory[1];
            input = memory[1];
        }

        private void memplus_Click(object sender, EventArgs e)
        {
            if(memory.Count == 0) memory.Add("");
            if (memory.Count >= 2)
            {
                if (double.Parse(memory[1]) > 0)
                {
                    memory.RemoveAt(1);
                    string memPlus = textBox1.Text;
                    memory.Add(memPlus);
                    this.richTextBox1.Text = "Memory saved!";
                }
                
            }
            else
            {
                string memPlus = textBox1.Text;
                memory.Add(memPlus);
                this.richTextBox1.Text = "Memory saved!";
            }
        }

        // Equals button
        private void equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            this.richTextBox1.Text += input;
            this.richTextBox1.Text += " = ";
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";
                }
            }
            input = result.ToString();
        }
    }
}
