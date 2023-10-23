using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Mobile
{
    public partial class Form7 : Form
    {
        private bool player1_turn = true;
        private int[,] boardValue = new int[3, 3];
        const int X_VALUE = 1;
        const int O_VALUE = 2;

        public Form7()
        {
            InitializeComponent();
            restart_matrix();
            player1_turn = true;
            
        }

        private void button_woc1_Click(object sender, EventArgs e)
        {

        }

        private void button_woc1_Click_1(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[0, 0] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[0, 0] = O_VALUE;
            }

            check_win();
        }

        private void button_woc2_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[0, 1] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[0, 1] = O_VALUE;
            }
            check_win();
        }

        private void button_woc3_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[0, 2] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[0, 2] = O_VALUE;
            }
            check_win();
        }

        private void button_woc6_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[1, 0] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[1, 0] = O_VALUE;
            }
            check_win();
        }

        private void button_woc5_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[1, 1] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[1, 1] = O_VALUE;
            }
            check_win();
        }

        private void button_woc4_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[1, 2] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[1, 2] = O_VALUE;
            }
            check_win();
        }

        private void button_woc7_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[2, 2] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[2, 2] = O_VALUE;
            }
            check_win();
        }

        private void button_woc8_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[2, 1] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[2, 1] = O_VALUE;
            }
            check_win();
        }

        private void button_woc9_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[2, 0] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[2, 0] = O_VALUE;
            }
            check_win();
        }
        private void check_win()
        {
            
            for (int i = 0; i < 3; ++i)
            {
                if (Convert.ToInt32(boardValue[i, 0]) == Convert.ToInt32(boardValue[i, 1]) &&
                    Convert.ToInt32(boardValue[i, 1]) == Convert.ToInt32(boardValue[i, 2]) &&
                    Convert.ToInt32(boardValue[i, 1]) != 0)
                {
                    color_winning_buttons(find_button_by_value(i, 0),
                        find_button_by_value(i, 1),
                        find_button_by_value(i, 2));
                    display_win_screen(boardValue[i, 0]);

                    return;
                }
            }

           
            for (int i = 0; i < 3; ++i)
            {
                if (Convert.ToInt32(boardValue[0, i]) == Convert.ToInt32(boardValue[1, i]) &&
                    Convert.ToInt32(boardValue[1, i]) == Convert.ToInt32(boardValue[2, i]) &&
                    Convert.ToInt32(boardValue[2, i]) != 0)
                {
                    color_winning_buttons(find_button_by_value(0, i),
                        find_button_by_value(1, i),
                        find_button_by_value(2, i));
                    display_win_screen(boardValue[1, i]);
                    return;
                }
            }

           
            if (Convert.ToInt32(boardValue[0, 0]) == Convert.ToInt32(boardValue[1, 1]) &&
                Convert.ToInt32(boardValue[1, 1]) == Convert.ToInt32(boardValue[2, 2]) &&
                Convert.ToInt32(boardValue[2, 2]) != 0)
            {
                color_winning_buttons(find_button_by_value(0, 0),
                    find_button_by_value(1, 1),
                    find_button_by_value(2, 2));
                display_win_screen(boardValue[1, 1]);
                return;
            }
            else if (Convert.ToInt32(boardValue[0, 2]) == Convert.ToInt32(boardValue[1, 1]) &&
              Convert.ToInt32(boardValue[1, 1]) == Convert.ToInt32(boardValue[2, 0]) &&
              Convert.ToInt32(boardValue[2, 0]) != 0)
            {
                color_winning_buttons(find_button_by_value(0, 2),
                    find_button_by_value(1, 1),
                    find_button_by_value(2, 0));
                display_win_screen(boardValue[1, 1]);
                return;
            }

           
            bool is_completed = true;
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; j++)
                    if (boardValue[i, j] == 0)
                        is_completed = false;
            if (is_completed)
            {
                MessageBox.Show("Draw");
                restart_matrix();
            }
        }


        private void display_win_screen(int val)
        {
            if (val == X_VALUE)
            {
                MessageBox.Show("Player 1 has won !");
                int player1_score = Convert.ToInt32(label6.Text);
                ++player1_score;
                label6.Text = player1_score.ToString();

            }
            else
            {
                MessageBox.Show("Player 2 has won!");
                int player2_score = Convert.ToInt32(label7.Text);
                ++player2_score;
                label7.Text = player2_score.ToString();
            }

            restart_matrix();
        }


        private void restart_matrix()
        {
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    boardValue[i, j] = 0;

            clear_buttons();
            player1_turn = true;
        }

        // Color winning buttons
        private void color_winning_buttons(Button button1, Button button2, Button button3)
        {
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
        }

        // Clear buttons
        private void clear_buttons()
        {
            // Content
            button_woc1.Text = "";
            button_woc2.Text = "";
            button_woc3.Text = "";
            button_woc6.Text = "";
            button_woc5.Text = "";
            button_woc4.Text = "";
            button_woc7.Text = "";
            button_woc8.Text = "";
            button_woc9.Text = "";


            button_woc1.BackColor = Color.Green;
            button_woc2.BackColor = Color.Green;
            button_woc3.BackColor = Color.Green;
            button_woc6.BackColor = Color.Green;
            button_woc5.BackColor = Color.Green;
            button_woc4.BackColor = Color.Green;
            button_woc7.BackColor = Color.Green;
            button_woc8.BackColor = Color.Green;
            button_woc9.BackColor = Color.Green;


            button_woc1.ForeColor = Color.White;
            button_woc2.ForeColor = Color.White;
            button_woc3.ForeColor = Color.White;
            button_woc6.ForeColor = Color.White;
            button_woc5.ForeColor = Color.White;
            button_woc4.ForeColor = Color.White;
            button_woc7.ForeColor = Color.White;
            button_woc8.ForeColor = Color.White;
            button_woc9.ForeColor = Color.White;
        }
        private Button find_button_by_value(int value_x, int value_y)
        {
            switch (value_x)
            {
                case 0:
                    if (value_y == 0)
                        return button_woc1;
                    if (value_y == 1)
                        return button_woc2;
                    if (value_y == 2)
                        return button_woc3;
                    return button_woc1;
                    break;
                case 1:
                    if (value_y == 0)
                        return button_woc4;
                    if (value_y == 1)
                        return button_woc5;
                    if (value_y == 2)
                        return button_woc6;
                    return button_woc1;
                    break;
                case 2:
                    if (value_y == 0)
                        return button_woc9;
                    if (value_y == 1)
                        return button_woc8;
                    if (value_y == 2)
                        return button_woc7;
                    return button_woc1;
                    break;

                default:
                    restart_matrix();
                    MessageBox.Show("Something failed!");
                    return button_woc1;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                label6.ForeColor = Color.Green;
                label7.ForeColor = Color.Black;
            }
            else
            {
                label7.ForeColor = Color.Green;
                label6.ForeColor = Color.Black;
            }
        }


        private void button_woc10_Click(object sender, EventArgs e)
        {
            restart_matrix();
            int player1_score = 0;
            label6.Text = player1_score.ToString();
            int player2_score = 0;
            label7.Text = player2_score.ToString();


        }

        private void button_woc11_Click(object sender, EventArgs e)
        {
            MySqlConnection mcn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=1234;database=visualz;");
            try
            {
                mcn.Open();
                MessageBox.Show("connected");

                MySqlCommand cmd = new MySqlCommand("INSERT INTO score (player1, player2) VALUES (@player1, @player2)", mcn);
                cmd.Parameters.AddWithValue("@player1", label6.Text);
                cmd.Parameters.AddWithValue("@player2", label7.Text);
                int rowsAffected = cmd.ExecuteNonQuery();
                MessageBox.Show(rowsAffected.ToString() + " Datas saved");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                mcn.Close();
            }
            Form11 asd = new Form11();
            asd.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
