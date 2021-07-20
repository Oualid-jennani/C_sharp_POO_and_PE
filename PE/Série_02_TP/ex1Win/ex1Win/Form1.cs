using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1Win
{
    public partial class Form1 : Form
    {
        char op;
        double number1,number2;
        double r;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)

        {
           
            textBox1.Text += "1";
            label2.Text += "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            label2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           number1 = Convert.ToDouble(textBox1.Text);
            op = '+';
            textBox1.Clear();
            label2.Text += "+";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            label2.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = ",";
            label2.Text += ",";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label2.Text = "";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            label2.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            label2.Text += "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            label2.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            label2.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            label2.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            label2.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            op = '-';
            textBox1.Clear();
            label2.Text += "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            op = '*';
            textBox1.Clear();
            label2.Text += "*";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            op = '/';
            textBox1.Clear();
            label2.Text += "/";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "+")
            {
                number1 = Convert.ToDouble(textBox1.Text);
                op = '+';
                textBox1.Clear();
            }


            if (comboBox1.Text == "-")
            {
                number1 = Convert.ToDouble(textBox1.Text);
                op = '-';
                textBox1.Clear();
            }

            if (comboBox1.Text == "*")
            {
                number1 = Convert.ToDouble(textBox1.Text);
                op = '*';
                textBox1.Clear();
            }

            if (comboBox1.Text == "/")
            {
                number1 = Convert.ToDouble(textBox1.Text);
                op = '/';
                textBox1.Clear();
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            op = '+';
            textBox1.Clear();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            op = '-';
            textBox1.Clear();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            op = '*';
            textBox1.Clear();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            op = '/';
            textBox1.Clear();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number2= Convert.ToDouble(textBox1.Text);
           switch (op)
            {
                
                case '+':
                    r= number1 + number2;
                textBox1.Text = Convert.ToString(r);
                    
                    break;
                case '-':
                    r = number1 - number2;
                    textBox1.Text = Convert.ToString(r);
                   
                    break;
                case '*':
                    r = number1 * number2;
                    textBox1.Text = Convert.ToString(r);
                   
                    break;
                case '/':
                    r = number1 / number2;
                    textBox1.Text = Convert.ToString(r);
                   
                    break;
            }
           
        }
    }
}
