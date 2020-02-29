using System;
using static Lesson_2_CSharp_Lvl1.ViewJulyS;
using System.Text;
using static Lesson_5_CSharp_Lvl1.Message;
using Lesson_5_CSharp_Lvl1;

namespace Lesson_5_JulySudarenko
{
    class Program
    {
        static void Main()
        {
            Print("Введите номер задания:");
            int c = GetInt();
            switch (c)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                default:
                    Print("Такая операция не предусмотрена.");
                    break;
            }
            Pause();

        }

        #region Task1
        /// <summary>
        /// 1. Создать программу, которая будет проверять корректность ввода логина. 
        /// Корректным логином будет строка от 2 до 10 символов, 
        /// содержащая только буквы латинского алфавита или цифры, 
        /// при этом цифра не может быть первой: 
        /// а) без использования регулярных выражений;
        /// б) ** с использованием регулярных выражений.
        /// </summary>


        private static void Task1()
        {
            Print("Введите логин: ", false);
            string login = GetString();
            bool check = true;

            if ((login.Length < 2) || (login.Length > 10))
            {
                Print("Длина логина должна быть от 2х до 10 символов.");
                check = false;
            }

            if (char.IsNumber(login[0]))
            {
                Print("Логин не может начинаться с цифры.");
                check = false;
            }

            if (CheckSymbols(login) == false)
            {
                Print("Логин должен состоять из букв латинского алфавита или цифр.");
                check = false;
            }

            if (check == true)
                Print("Логин принят.");
        }

        private static bool CheckSymbols(string login)
        {
            for (int i = 0; i < login.Length; i++)
            {
                if (!(char.IsNumber(login[i]) || (char.ToLower(login[i]) >= 'a' && char.ToLower(login[i]) <= 'z')))
                    return false;
            }
            return true;
        }


        #endregion


        #region Task2
        /// <summary>
        /// 2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста: 
        /// а) Вывести только те слова сообщения,  которые содержат не более n букв. 
        /// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ. 
        /// в) Найти самое длинное слово сообщения.
        /// г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        /// д) *** Создать метод, который производит частотный анализ текста.
        /// В качестве параметра в него передается массив слов и текст, 
        /// в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
        /// Здесь требуется использовать класс Dictionary.
        /// </summary>

        private static void Task2()
        {
            Message mes = new Message("Четыре черненьких чумазеньких чертенка чертили черными чернилами чертёж");

            Print("Ввели текст:");
            Print(mes);

            int n = 7;
            Print($"Слова, содержащие не более {n} букв: ");
            CountLetters(mes, n);


            string letter = "х";
            Print($"Уберем все слова с буквой \"{letter}\" в конце:");
            LastLetter(mes, letter);

            Print("Самое длинное слово в тексте: ", false);
            MaxWord(mes);

            Message mesLong = new Message($"В четверг четвёртого числа четыре четверти часа \nчетыре чёрненьких чумазеньких чертёнка \nчертили чёрными чернилами четыре чертежа чрезвычайно чисто");
            Print("Введем текст подлиннее:");
            Print(mesLong);
            Print("Самые длинные слова в тексте: ");
            BigWords(mesLong);

            //Dictionary()

            #region Пример из методички
            //string m = "Четыре черненьких чумазеньких чертенка чертили черными чернилами чертёж";
            //char[] gap = { ' '};
            //string[] parts = m.Split(gap);
            //Console.WriteLine("Результат разбиения строки на части: ");
            //for (int i = 0; i < parts.Length; i++)
            //{
            //    //Console.WriteLine(parts[i]);
            //    if (parts[i].Length <= n)
            //        Print(parts[i]);
            //}
            //Print(parts.Length);
            //// собираем эти части в одну строку, в качестве разделителя используем символ |
            //string str = String.Join("|", parts);
            //Console.WriteLine("Результат сборки: ");
            //Console.WriteLine(str);
            #endregion
        }


        #endregion

        #region Task3
        /// <summary>
        /// 3. * Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. 
        /// Например:
        /// badc являются перестановкой abcd.
        /// </summary>

        private static void Task3()
        {
            string word1 = "ball";
            string word2 = "lab";
            string word3 = "blal";

            //SortLetters(word1);
            Print(string.CompareOrdinal(word1, word3));
        }

        private static void SortLetters(string word)
        {
            //char[] sortword = word;
        }
    



    

        #endregion

        #region Task4
        /// <summary>
        /// 4. * Задача ЕГЭ. 
        /// На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы.
        /// В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, 
        /// каждая из следующих N строк имеет следующий формат: 
        /// <Фамилия> <Имя> <оценки>,
        /// где<Фамилия> — строка, состоящая не более чем из 20 символов, 
        /// <Имя> — строка, состоящая не более чем из 15 символов, 
        /// <оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. 
        /// <Фамилия> и<Имя>, а также<Имя> и<оценки> разделены одним пробелом. 
        /// Пример входной строки: 
        /// Иванов Петр 4 5 3 
        /// Требуется написать как можно более эффективную программу, 
        /// которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. 
        /// Если среди остальных есть ученики, 
        /// набравшие тот же средний балл, что и один из трёх худших, 
        /// следует вывести и их фамилии и имена.
        /// Для решения задач используйте неизменяемые строки (string).
        /// </summary>
        private static void Task4()
        {
            Print(" ");
        }

        #endregion
    }
}
    
 

