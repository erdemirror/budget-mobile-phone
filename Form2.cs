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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 calcul= new Form3();
            calcul.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4 call = new Form4();
            call.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form5 sms = new Form5();
            sms.Show();
            

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form7 tic = new Form7();
            tic.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form10 paint  = new Form10();
            paint.Show();
            
        }
    }
}
