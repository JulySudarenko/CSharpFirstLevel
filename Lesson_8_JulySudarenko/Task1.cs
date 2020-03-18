using System;
using System.Reflection;
using System.Windows.Forms;

namespace Lesson_8_JulySudarenko
{
    /// <summary>
    ///     1. С помощью рефлексии выведите все свойства структуры DateTime
    /// </summary>
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            PropertyInfo[] dateTimeProperties;
            dateTimeProperties = TypeInfo.GetType("System.DateTime").GetProperties();

            DateTime dateTime = new DateTime();

            for (int i = 0; i < dateTimeProperties.Length; i++)
            {
                properityTextBox.Text += $"{Environment.NewLine} {dateTimeProperties[i].Name.ToString()}";
                properityTextBox.Text += $"{GetPropertyInfo(dateTime, dateTimeProperties[i].Name.ToString()).GetValue(dateTime, null)}";
            }
        }

        private static PropertyInfo GetPropertyInfo(object obj, string str)
        {
            return obj.GetType().GetProperty(str);
        }
    }
}
