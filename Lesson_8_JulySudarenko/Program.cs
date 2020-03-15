using System;
using System.Windows.Forms;

namespace Lesson_8_JulySudarenko
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Task1());
        }
    }
    /*
    Не делала
    4. *Используя полученные знания и класс TrueFalse в качестве шаблона, разработать собственную утилиту хранения данных (Например: Дни рождения, Траты, Напоминалка, Английские слова и другие).
    5. **Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
    */

}
