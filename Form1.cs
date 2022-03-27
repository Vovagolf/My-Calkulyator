using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Calkulyator
{
    public partial class Калкулятор : Form
    {
        public string D;
        public string A;
        public bool C;
        public Калкулятор()
        {
            C = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            double x, result;
            x = Convert.ToDouble(textBox1.Text);
            result = -x;
            textBox1.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x, result;
            x = Convert.ToDouble(textBox1.Text);
            result = Math.Pow(x, 2);
            textBox1.Text = result.ToString();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (C)
            {
                C = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else textBox1.Text = textBox1.Text + B.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            A = textBox1.Text;
            C = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double dn1, dn2, result;
            result = 0;
            dn1 = Convert.ToDouble(A);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
            {
                result = dn1 + dn2;
            }
            if (D == "-")
            {
                result = dn1 - dn2;
            }
            if (D == "/")
            {
                result = dn1 / dn2;
            }
            if (D == "%")
            {
                result = dn1 * dn2 / 100;
            }
            if (D == "*")
            {
                result = dn1 * dn2;
            }
            D = "=";
            C = true;
            textBox1.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double x, result;
            x = Convert.ToDouble(textBox1.Text);
            result = Math.Sqrt(x);
            textBox1.Text = result.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x, result;
            x = Convert.ToDouble(textBox1.Text);
            result = 1 / x;
            textBox1.Text = result.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double x, result;
            x = Convert.ToDouble(textBox1.Text);
            result = Math.Pow(x, 3);
            textBox1.Text = result.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
