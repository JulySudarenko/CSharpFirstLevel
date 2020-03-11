using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lesson_7_JulySudarenko
{

    public partial class FirstGame : Form
    {
        private Random _random;
        private Color[] _colors;
        public FirstGame()
        {
            InitializeComponent();
            _random = new Random();
            _colors = new[]
            {
                Color.Silver,
                Color.LightSeaGreen,
                Color.Aqua,
                Color.White,
                Color.LightYellow,
                Color.Pink,
                Color.Chartreuse,
                Color.LemonChiffon,
                Color.AliceBlue
            };
        }

        private void ButtonNo_MouseEnter(object sender, EventArgs e)
        {
            buttonNo.Text = "Да";
            buttonNo.BackColor = Color.ForestGreen;
        }

        private void ButtonNo_MouseLeave(object sender, EventArgs e)
        {
            buttonNo.Text = "Нет";
            buttonNo.BackColor = Color.Crimson;
        }

        private void buttonNo_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Я так и знал!");
        }

        private void ButtonYes_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Я так и знал!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = _colors[_random.Next(0, _colors.Length)];
        }
    }
}
