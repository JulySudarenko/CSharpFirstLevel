using System;
using Timer = System.Timers.Timer;
using System.Drawing;
using System.Windows.Forms;
using JulyArrayLibrary;



namespace Lesson_7_JulySudarenko
{
    public partial class CountTrainer : Form
    {
        SingleLevelArray result;
        Label[] labels;
        MaskedTextBox[] textBoxes;
        Timer timer = new Timer();
        int n = 10;
        int min;
        int sec;

        public CountTrainer()
        {
            InitializeComponent();
            StartButton.Text = "Начать";
            FinishButton.Text = "Готово";
            labels = new Label[10] { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10 };
            for (int i = 0; i < labels.Length; i++)
                labels[i].Text = string.Empty;
            textBoxes = new MaskedTextBox[10] { maskedTextBox1, maskedTextBox2, maskedTextBox3, maskedTextBox4, maskedTextBox5, maskedTextBox6, maskedTextBox7, maskedTextBox8, maskedTextBox9, maskedTextBox10 };
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            SingleLevelArray element1 = new SingleLevelArray(n, 2, 9);
            SingleLevelArray element2 = new SingleLevelArray(n, 11, 99);
            
            result = new SingleLevelArray(n);

            for (int i = 0; i < n; i++)
            {
                result[i] = element1[i] * element2[i];
                labels[i].Text = $"{element1[i]} x {element2[i]} = ";
                textBoxes[i].Text = string.Empty;
                textBoxes[i].BackColor = SystemColors.Window;
                textBoxes[i].Visible = true;
            }
            
            min = 0;
            sec = 0;
            Minutes.Text = Convert.ToString(min);
            Seconds.Text = Convert.ToString(sec);
            Minutes.Visible = true;
            Seconds.Visible = true;
            Colon.Visible = true;

            timer1.Start();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            int mistake = 0;

        //for (int i = 12; i < result.Length; i++) //можно создавать новые строки, чтобы дополнить массив.
        //    textBoxes[i] = new TextBox();

            for (int i = 0; i < n; i++)
            {
                if ((textBoxes[i].Text == string.Empty) || (result[i] != int.Parse(textBoxes[i].Text)))
                {
                    textBoxes[i].BackColor = Color.LightCoral;
                    mistake++;
                }
                else
                    textBoxes[i].BackColor = Color.LightGreen;
            }
            timer1.Stop();

            MessageBox.Show($"Ваше время: {min} : {sec}.\nКоличество ошибок: {mistake}!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec += 1;
            if (sec == 59)
            {
                min++;
                sec = 0;
            }
            Seconds.Text = Convert.ToString(sec);
            Minutes.Text = Convert.ToString(min);
        }
    }
}
