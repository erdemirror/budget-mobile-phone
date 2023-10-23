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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mobile
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            MySqlConnection mcn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=1234;database=visualz");
            mcn.Open();
            MessageBox.Show("connected");
            MySqlCommand cmd = new MySqlCommand("select * from people");
            cmd.Connection = mcn;
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable tab1 = new DataTable();

            tab1.Load(dr);
            dataGridView1.DataSource = tab1;
            mcn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mcn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=1234;database=visualz");
                mcn.Open();

                string person = textBox2.Text;
                string message = textBox1.Text;

                MySqlCommand cmd = new MySqlCommand("INSERT INTO message (person, mess) VALUES (@person, @message)", mcn);
                cmd.Parameters.AddWithValue("@person", person);
                cmd.Parameters.AddWithValue("@message", message);

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
