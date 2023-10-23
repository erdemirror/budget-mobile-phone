using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mobile
{
    public partial class FormCall : Form
    {
        public FormCall()
        {
            InitializeComponent();
        }

        private void button_woc13_Click(object sender, EventArgs e)
        {
            Form4 caller = new Form4();
            caller.Show();
            this.Hide();
        }

        private void FormCall_Load(object sender, EventArgs e)
        {
            string phoneNumber = Form4.dugaar;
            MySqlConnection mcn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=1234;database=visualz");
            mcn.Open();
            MessageBox.Show("connected");
            string query = "SELECT CName FROM people WHERE CNumber = @phoneNumber";
            using (MySqlCommand command = new MySqlCommand(query, mcn))
            {
                command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Set the text of label2 to the contact name
                        string contactName = reader.GetString(0);
                        label2.Text = contactName;
                    }
                    else
                    {
                        
                        label2.Text = Form4.dugaar;
                    }
                }
            }
        }
        }
    }

