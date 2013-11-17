using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication24
{
    public partial class Form1 : Form
    {
        int a;
        bool plus = false;
        bool minus = false;
        bool multiply = false;
        bool divide = false;
        bool power = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int a = textBox1.Text.Length;
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(a - 1);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                plus = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                minus = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                multiply = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                divide = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                if (textBox1.Text.Contains("-"))
                {
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                }
                else
                {
                    textBox1.Text = "-" + textBox1.Text;
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("."))
            {
                return;
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                power = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (plus)
            {
                decimal dec = Convert.ToDecimal(textBox1.Tag) + Convert.ToDecimal(textBox1.Text);
                textBox1.Text = dec.ToString();
            }
            else if (minus)
            {
                decimal dec = Convert.ToDecimal(textBox1.Tag) - Convert.ToDecimal(textBox1.Text);
                textBox1.Text = dec.ToString();
            }
            else if (multiply)
            {
                decimal dec = Convert.ToDecimal(textBox1.Tag) * Convert.ToDecimal(textBox1.Text);
                textBox1.Text = dec.ToString();
            }
            else if (divide)
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "0";
                }
                else if (textBox1.Text != "0")
                {
                    decimal dec = Convert.ToDecimal(textBox1.Tag) / Convert.ToDecimal(textBox1.Text);
                    textBox1.Text = dec.ToString();
                }
            }
            else if (power)
            {
                decimal dec = Convert.ToDecimal(textBox1.Tag) * Convert.ToDecimal(textBox1.Tag);
                textBox1.Text = dec.ToString();
            }
            return;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
