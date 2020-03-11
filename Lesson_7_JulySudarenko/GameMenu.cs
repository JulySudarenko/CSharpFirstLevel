using System;
using System.Windows.Forms;

namespace Lesson_7_JulySudarenko
{
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
        }

        private void FirstGame_Click(object sender, EventArgs e)
        {
            Form FirstGame = new FirstGame();
            FirstGame.Show();
        }

        private void WF_Udvoitel_Click(object sender, EventArgs e)
        {
            Form WF_Udvoitel = new WF_Udvoitel();
            WF_Udvoitel.Show();
        }

        private void CountTrainer_Click(object sender, EventArgs e)
        {
            Form CountTrainer = new CountTrainer();
            CountTrainer.Show();
        }

        private void GuessNumber_Click(object sender, EventArgs e)
        {
            Form GuessNumber = new GuessNumber();
            GuessNumber.Show();
        }
    }
}
