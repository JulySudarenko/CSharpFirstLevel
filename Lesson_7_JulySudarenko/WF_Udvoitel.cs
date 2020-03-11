using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Lesson_7_JulySudarenko
{
    public partial class WF_Udvoitel : Form
    {
        int count = 0;
        int result;
        int move;
        Stack<int> numbers = new Stack<int>();

        public WF_Udvoitel()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "1";
            lbnCount.Text = "0";
            this.Text = "Удвоитель";

        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            numbers.Push(int.Parse(lblNumber.Text));
            count++;
            lbnCount.Text = count.ToString();

            if (int.Parse(lblNumber.Text) == result)
                MessageBox.Show($"Вы победили!\nМинимальное количество ходов {move}");
            if (int.Parse(lblNumber.Text) > result)
                MessageBox.Show($"Вы проиграли!\nМинимальное количество ходов {move}");
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            numbers.Push(int.Parse(lblNumber.Text));
            count++;
            lbnCount.Text = count.ToString();
            if (int.Parse(lblNumber.Text) == result)
                MessageBox.Show($"Вы победили!\nМинимальное количество ходов {move}.");
            if (int.Parse(lblNumber.Text) > result)
                MessageBox.Show($"Вы проиграли!\nМинимальное количество ходов {move}.");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            count = 0;
            lbnCount.Text = count.ToString();
        }

        private void PlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            result = r.Next(2, 100); 
            MessageBox.Show($"Получи {result}\nза минимальное\nколичество ходов.");

            numbers.Clear();
            numbers.Push(1);
            numbers.Push(1);
            int c = result;
            move = 0;

            do
            {
                if (c % 2 == 0)
                {
                    c /= 2;
                    move++;
                }

                else
                {
                    c -= 1;
                    move++;
                }
            } while (c > 1);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (numbers.Count == 1)
                MessageBox.Show("Больше нет ходов, которые можно отменить.");
            
            else
            { 
                if (lblNumber.Text == numbers.Peek().ToString())
                {
                    numbers.Pop();
                }

                lblNumber.Text = numbers.Pop().ToString();
                count--;
                lbnCount.Text = count.ToString();
            }

        }
    }
}
