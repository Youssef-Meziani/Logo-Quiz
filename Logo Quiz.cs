using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logo_Quiz
{
    public partial class LogoQuiz : Form
    {
        string user_name = "Player";
        bool mousedown;
        private Point offset;
        public LogoQuiz()
        {
            InitializeComponent();
        }

        private void LogoQuiz_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
        }

        private void titlebar_panel_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mousedown = true;
        }

        private void titlebar_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                Point current_s_p = PointToScreen(e.Location);
                Location = new Point(current_s_p.X - offset.X, current_s_p.Y - offset.Y);
            }
        }

        private void titlebar_panel_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void name_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & e.KeyChar != '\b' & e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            int time, nbr_quiz, skips;
            if (radioButton_easy.Checked)
            {
                time = 60;
                nbr_quiz = 10;
                skips = 2;
            }
            else if (radioButton_medium.Checked)
            {
                time = 45;
                nbr_quiz = 15;
                skips = 1;
            }
            else
            {
                time = 30;
                nbr_quiz = 20;
                skips = 0;
            }
            if (name_textBox.Text.Length != 0) user_name = name_textBox.Text.ToUpper();
            GameBoard gb = new GameBoard(user_name, time, nbr_quiz, skips);
            panel_screen.Controls.Add(gb);
            panel_screen.BringToFront();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Instructions inst = new Instructions();
            inst.ShowDialog();
        }
    }
}
