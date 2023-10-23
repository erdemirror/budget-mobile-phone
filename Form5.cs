using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Mobile
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 newsms  = new Form6();
            newsms.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            MySqlConnection mcn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=1234;database=visualz");
            mcn.Open();
            MessageBox.Show("connected");
            MySqlCommand cmd = new MySqlCommand("select * from message");
            cmd.Connection = mcn;
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable tab1 = new DataTable();

            tab1.Load(dr);
            dataGridView1.DataSource = tab1;
            mcn.Close();
        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            MySqlConnection mcn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=1234;database=visualz");
            mcn.Open();

            // get the ID of the row to delete from the text box
            int id = Convert.ToInt32(textBox1.Text);
            // create and execute the delete command
            MySqlCommand cmd = new MySqlCommand("DELETE FROM message WHERE ID=@id", mcn);
            cmd.Parameters.AddWithValue("@id", id);
            int rowsAffected = cmd.ExecuteNonQuery();

            // show a message based on whether the delete was successful or not
            if (rowsAffected > 0)
            {
                MessageBox.Show("Row deleted successfully!");
            }
            else
            {
                MessageBox.Show("Delete failed!");
            }

            mcn.Close();
        }
    }
}
