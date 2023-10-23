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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            MySqlConnection mcn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=1234;database=visualz");
            mcn.Open();
            MessageBox.Show("connected");
            MySqlCommand cmd = new MySqlCommand("select * from score");
            cmd.Connection = mcn;
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable tab1 = new DataTable();

            tab1.Load(dr);
            dataGridView1.DataSource = tab1;
            mcn.Close();
        }
    }
}
