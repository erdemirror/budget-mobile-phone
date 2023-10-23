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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            MySqlConnection mcn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=1234;database=visualz");
            mcn.Open();
            MessageBox.Show("connected");
            MySqlCommand cmd = new MySqlCommand("select * from people");
            cmd.Connection= mcn;
            MySqlDataReader dr = cmd.ExecuteReader();   
            DataTable tab1 = new DataTable();   

            tab1.Load(dr);
            dataGridView1.DataSource = tab1;
            mcn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            Form9 add = new Form9();
            add.Show();
            this.Close();
        }

        private void button_woc2_Click(object sender, EventArgs e)
        {
            MySqlConnection mcn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=1234;database=visualz");
            mcn.Open();

            // get the ID of the row to delete from the text box
            int id = Convert.ToInt32(textBox1.Text);
            // create and execute the delete command
            MySqlCommand cmd = new MySqlCommand("DELETE FROM people WHERE ID=@id", mcn);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
