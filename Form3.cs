using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile
{
    public partial class Form3 : Form
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userinput = "";
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userinput += "1";
            textBox1.Text += "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            first = "";
            second = "";
            userinput = "";
            result = 0.0;
            textBox1.Text = string.Empty;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {   userinput+= "2";
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            userinput+= "3";
            textBox1.Text += "3";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {userinput += "4";
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {userinput += "5";
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {userinput += "6";
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {userinput += "7";
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {userinput += "8";
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {userinput += "9";
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {userinput += "0";
            textBox1.Text += "0";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userinput;
            userinput= "";
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userinput;
            userinput = "";
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userinput;
            userinput = "";
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userinput;
            userinput = "";
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            second = userinput;
            double firsttoo , secondtoo ;
            firsttoo = Convert.ToDouble(first);
            secondtoo = Convert.ToDouble(second);
            

            if (function == '+')
            {
                result = firsttoo+secondtoo;
                firsttoo = result;
                textBox1.Text = result.ToString();
            }
            else if (function == '-')
            {
                result = firsttoo-secondtoo;
                firsttoo = result;
                textBox1.Text = result.ToString();
            }
            else if (function == '*')
            {
                result = firsttoo*secondtoo;
                firsttoo = result;
                textBox1.Text = result.ToString();
            }
            else if (function == '/')
            {
                if (secondtoo == 0)
                {
                    textBox1.Text = "Undefined";
                }
                else
                {
                    result = firsttoo/ secondtoo;
                    textBox1.Text = result.ToString();
                    firsttoo = result;

                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }
    }
}
