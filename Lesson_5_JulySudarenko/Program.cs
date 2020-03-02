using System;
using static Lesson_2_CSharp_Lvl1.ViewJulyS;
using System.Text.RegularExpressions;
using static Lesson_5_CSharp_Lvl1.Message;
using Lesson_5_CSharp_Lvl1;
using System.IO;

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

            Print("Проверка при помощи регулярных выражений.");
            LoginReg(login);
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

        private static void LoginReg(string login)
        {
            Regex reg = new Regex("^[A-Za-z]{1}[A-Za-z^0-9]{1,9}");
            if (reg.IsMatch(login) == true)
                Print("Логин принят.");
            else
                Print("Логин не корректен.");
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

            Print("Проверяем первым способом:");
            Print(SortLetters(word1, word3));
            Print(SortLetters(word1, word2));

            Print("Проверяем вторым способом:");
            Print(SortLetters1(word1, word3));
            Print(SortLetters1(word1, word2));
        }

        #region Перевод в числовой массив.
        private static int[] WordToIntArray(string word)
        {
            char[] w = word.ToCharArray();
            int[] codeW = new int[w.Length];

            for (int i = 0; i < w.Length; i++)
            {
                codeW[i] = (int)(w[i]);
            }
            Array.Sort(codeW);

            return codeW;
        }
        #endregion

        private static bool SortLetters(string word1, string word2)
        {
            char[] w1 = word1.ToCharArray();
            char[] w2 = word2.ToCharArray();

            Array.Sort(w1);
            Array.Sort(w2);

            string wordSort1 = new string(w1);
            string wordSort2 = new string(w2);

            if (wordSort1.Equals(wordSort2))
                return true;
            else
                return false;
        }

        private static bool SortLetters1(string word1, string word2)
        {
            char[] w1 = word1.ToCharArray();
            char[] w2 = word2.ToCharArray();

            Array.Sort(w1);
            Array.Sort(w2);

            if (w1.Length != w2.Length)
                return false;

            for (int i = 0; i < w1.Length; i++)
                if (w1[i] != w2[i])
                    return false;

            return true;
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
        /// </summary>
        private static void Task4()
        {
            Exam[] a = Exam.FromFile("..\\..\\Exam.txt");
            
            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < a.Length -1; j++)
                    if (a[j].rate > a[j + 1].rate)
                    {
                        Exam t = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = t;
                    }
            
            Print("Результат сортировки:");
            for (int i = 0; i < a.Length; i++)
                Print($"{a[i].name} {a[i].rate}");

            int toList = a[3].rate;

            Print("Список худших учеников:");
            for (int i = 0; i < a.Length; i++)
                if(a[i].rate <= toList)
                    Print(a[i].name);

        }

        #endregion
    }

    #region Struct Exam

    public struct Exam
    {
        public string name;
        public int rate;

        public static Exam[] FromFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            int n = File.ReadAllLines(path).Length;
            Exam[] a = new Exam[n];
            Print("Данные на входе:");
            for (int i = 0; i < n; i++)
            {
                string[] s = sr.ReadLine().Split(' ');
                a[i].name = $"{s[0]} {s[1]}";
                a[i].rate = int.Parse(s[2]) + int.Parse(s[3]) + int.Parse(s[4]);
                Print($"{a[i].name} {a[i].rate}");
            }

            sr.Close();

            return a;
        }


    }
    #endregion
}



