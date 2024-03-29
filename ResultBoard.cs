using System;
using System.Drawing;
using System.Windows.Forms;

namespace Logo_Quiz
{
    public partial class ResultBoard : UserControl
    {
        int Score, Maxscore;
        public ResultBoard(int score, int maxscore)
        {
            InitializeComponent();
            Score = score;
            Maxscore = maxscore;
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ResultBoard_Load(object sender, EventArgs e)
        {
            textBox_score.Text = $"You Scored : {Score}/{Maxscore}";
            if (Score >= Maxscore / 2)
            {
                pictureBox.Image = Properties.Resources.trophy;
                textBox_status.Text = "Winner";
                textBox_status.ForeColor = Color.FromArgb(0, 255, 0);
                textBox_message.Text = "You've done a good job";
            }
            else
            {
                pictureBox.Image = Properties.Resources.ghost;
                textBox_status.Text = "Looser";
                textBox_status.ForeColor = Color.FromArgb(255, 0, 0);
                textBox_message.Text = "Better Luck Next Time";
            }
        }
    }
}
