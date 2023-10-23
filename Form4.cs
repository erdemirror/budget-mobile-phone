using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mobile
{
    public partial class Form4 : Form
    {
        public static string dugaar;
        public Form4()
        {
            InitializeComponent();
            
        }

        public class Contacts
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 newsms = new Form6();
            newsms.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form8 conta = new Form8();
            conta.Show();
            this.Hide();
        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button_woc2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button_woc3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button_woc4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button_woc5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button_woc6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button_woc7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button_woc8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button_woc9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button_woc11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button_woc13_Click(object sender, EventArgs e)
        {
            dugaar = textBox1.Text;
            FormCall callk = new FormCall();
            callk.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if ((String.Compare(textBox1.Text, " ") < 0))
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1 + 1);
            }
            else
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }
    }
}
