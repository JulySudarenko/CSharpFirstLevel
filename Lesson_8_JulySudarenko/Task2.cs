using System;
using System.Windows.Forms;

namespace Lesson_8_JulySudarenko
{
    /// <summary>
    /// 2. Создайте простую форму на которой 
    /// свяжите свойство Text элемента TextBox 
    /// со свойством Value элемента NumericUpDown.
    /// </summary>

    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void CounterUpDown_ValueChanged(object sender, EventArgs e)
        {
            textBox.Text = counterUpDown.Value.ToString();
        }
    }
}
