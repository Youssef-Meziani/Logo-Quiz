using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Logo_Quiz
{
    public partial class GameBoard : UserControl
    {
        Random random = new Random();
        int Time, skips, countdown, nbr_quiz, image_indx, score = 0, progress = 0;
        List<int> pass_quiz = new List<int>();
        string answer = "";
        public GameBoard(string user_name, int time, int quiz, int skip)
        {
            InitializeComponent();
            label_name.Text = user_name;
            Time = time;
            nbr_quiz = quiz;
            skips = skip;
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            if (skips == 0) button_skip.Enabled = false;
            label_score.Text = "Score : " + score;
            Update_scr();
            timer1.Start();
        }

        private void Update_scr()
        {
            result();
            flowLayoutPanel_rb.Controls.Clear();
            flowLayoutPanel_answer.Controls.Clear();
            button_next.Enabled = false;

            image_indx = random.Next(0, 182);
            while (pass_quiz.Contains(image_indx))
            {
                image_indx = random.Next(0, 182);
            }
            pass_quiz.Add(image_indx);
            pictureBox_logo.Image = EditedLogos.Images[image_indx];
            answer = EditedLogos.Images.Keys[image_indx];
            answer = answer.Substring(0, answer.Length - 4);

            foreach (char c in Shuffle(answer))
            {
                Button b = new Button();
                b.Text = c.ToString().ToUpper();
                b.Size = new Size(50, 50);
                b.Font = new Font("Gadugi", 14);
                b.FlatStyle = FlatStyle.Flat;
                b.BackColor = Color.FromArgb(24, 30, 54);
                b.ForeColor = Color.FromArgb(255, 255, 255);
                b.Margin = new Padding(8);
                b.Click += Buttons_Click;
                flowLayoutPanel_rb.Controls.Add(b);
            }

            progress++;
            label_prog.Text = $"{progress} / {nbr_quiz}";

            countdown = Time;
            label_timer.Text = countdown.ToString();
            label_timer.ForeColor = Color.Green;
            timer1.Start();
        }
        public void result()
        {
            if (progress > nbr_quiz)
            {
                int maxscore = nbr_quiz * 10;
                ResultBoard rb = new ResultBoard(score, maxscore);
                panel_result.Controls.Add(rb);
                panel_result.BringToFront();
            }
        }
        private void Buttons_Click(object sender, EventArgs e)
        {
            pictureBox_checkstat.Image = null;
            Button b = (Button)sender;
            if (b.Parent == flowLayoutPanel_rb)
            {
                if (flowLayoutPanel_answer.Controls.Count < answer.Length)
                {
                    flowLayoutPanel_rb.Controls.Remove(b);
                    flowLayoutPanel_answer.Controls.Add(b);
                }
            }
            else
            {
                flowLayoutPanel_answer.Controls.Remove(b);
                flowLayoutPanel_rb.Controls.Add(b);
            }
        }
        public string Shuffle(string answer)
        {
            while (answer.Length < 14)
                answer += (char)random.Next('a', 'z');
            var list = new SortedList<int, char>();
            foreach (char c in answer)
                list.Add(random.Next(), c);
            return new string(list.Values.ToArray());
        }

        private void Panel_updater(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            p.Location = new Point(500 - p.Size.Width / 2, p.Location.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countdown--;
            label_timer.Text = countdown.ToString();
            if (countdown == 10)
            {
                label_timer.ForeColor = Color.Red;
            }
            if (countdown < 0)
            {
                timer1.Stop();
                label_timer.ForeColor = Color.Green;
                Update_scr();
                result();
            }
        }

        private void button_skip_Click(object sender, EventArgs e)
        {
            score += 10;
            label_score.Text = "Score : " + score;
            result();
            Update_scr();
            skips--;
            if (skips == 0) button_skip.Enabled = false;
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            string usr_answer = "";
            foreach (Button b in flowLayoutPanel_answer.Controls)
            {
                usr_answer += b.Text.ToLower();
            }
            if (answer == usr_answer)
            {
                if (OriginalLogos.Images.ContainsKey(answer + ".png")) pictureBox_logo.Image = OriginalLogos.Images[answer + ".png"];
                pictureBox_checkstat.Image = Properties.Resources.check;
                button_next.Enabled = true;
                timer1.Stop();
                score += 10;
                label_score.Text = "Score : " + score;
                button_check.Enabled = false;
            }
            else
                pictureBox_checkstat.Image = Properties.Resources.cross;
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            Update_scr();
            result();
            button_check.Enabled = true;
            pictureBox_checkstat.Image = null;
        }
    }
}
