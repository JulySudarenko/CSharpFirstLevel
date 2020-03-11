using System;
using System.Windows.Forms;

namespace Lesson_7_JulySudarenko
{
    public partial class GuessNumber : Form
    {
        int num;
        int tryCount;
        public GuessNumber()
        {
            InitializeComponent();
            InfoForUser.Text = "Угадай число от 1 до 100.\nНажми \"Играть\"";
            OKbutton.Visible = false;
            UserAnswer.Visible = false;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            num = rnd.Next(1, 100);
            InfoForUser.Text = "Введи число от 1 до 100.";
            tryCount = 0;
            UserAnswer.Text = string.Empty;
            OKbutton.Visible = true;
            UserAnswer.Visible = true;
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            tryCount++;
            bool check = CheckParam(UserAnswer.Text);
            if (check == true)
            {
                int ans = int.Parse(UserAnswer.Text);
                CheckAnswer(ans, num);
            }
            else
                MessageBox.Show("Нужно ввести число от 1 до 100");
        }
        private static bool CheckParam(string a)
        {
            if (a == string.Empty)
                return false;
            else
            {
                if ((int.Parse(a) > 100) || (int.Parse(a) <= 0))
                    return false;
                else
                    return true;
            }
        }
        private void CheckAnswer(int ans, int num)
        {
            if (ans == num)
            {
                InfoForUser.Text = $"Поздравляю! Ответ {num}.\nВы угадали за {tryCount} ходов.";
                OKbutton.Visible = false;
                UserAnswer.Visible = false;
            }
            else
            {
                if (ans > num)
                {
                    InfoForUser.Text = "Вы ввели слишком большое число.";
                }
                else
                {
                    InfoForUser.Text = "Вы ввели слишком маленькое число.";
                }
            }

        }
    }
}
