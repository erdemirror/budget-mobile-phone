using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mobile
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         //name       
        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            Form8 cont = new Form8();
            cont.Show();
            this.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            MySqlConnection mcn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=1234;database=visualz");
            mcn.Open();
            


          

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //number
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //email
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //group 
        }

        private void button_woc12_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mcn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=1234;database=visualz");
                mcn.Open();

                string name = textBox1.Text;
                string number = textBox2.Text;
                string email = textBox3.Text;
                string group = textBox4.Text;

                MySqlCommand cmd = new MySqlCommand("INSERT INTO people (CName,CNumber, CEmail, CType) VALUES (@name, @number, @email, @group)", mcn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@number", number);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@group", group);

                int rowsAffected = cmd.ExecuteNonQuery();

                MessageBox.Show(rowsAffected.ToString() + " row(s) inserted into the database.");

                mcn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
