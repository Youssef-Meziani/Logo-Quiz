using System;
using System.Windows.Forms;

namespace Logo_Quiz
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
