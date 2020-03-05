using System;
using System.IO;
using static Lesson_2_CSharp_Lvl1.ViewJulyS;
using static Lesson_4_CSharp_Lvl1.SingleLevelArray;
using Lesson_4_CSharp_Lvl1;



namespace Lesson_4_JulySudarenko
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
                    Task4S();
                    break;
                default:
                    Print("Такая операция не предусмотрена.");
                    break;
            }
            Pause();
        }

        #region Task1
        /// <summary>
        ///     1. Дан целочисленный  массив из 20 элементов.
        ///     Элементы массива могут принимать  целые значения от –10 000 до 10 000 включительно.
        ///     Заполнить случайными числами.
        ///     Написать программу, позволяющую найти и вывести количество пар элементов массива, 
        ///     в которых только одно число делится на 3. 
        ///     В данной задаче под парой подразумевается два подряд идущих элемента массива.
        ///     Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
        /// </summary>

        private static void Task1()
        {
            int[] arr;
            arr = new int[20];
            Print("Целочисленный массив из 20 элементов от -10 000 до 10 000");
            RandomArray(arr, -10000, 10000);
            PrintArray(arr);
            Print($"\nСчитаем пары через цикл for: {PairsCounter(arr)}.");
            Print($"Считаем пары через цикл while: {PairsCounter1(arr)}.");


        }
        private static void RandomArray(int[] array, int min, int max)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(min, max);
            }
        }

        private static void PrintArray(int[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                char s = ' ';
                int i = array[index];
                Print($"{s}{i}", false);
            }
        }

        private static int PairsCounter(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if ((array[i] % 3 != 0) && (array[i + 1] % 3 == 0))
                    count++;
                else if ((array[i] % 3 == 0) && (array[i + 1] % 3 != 0))
                    count++;
                else
                    continue;
            }
            return count;
        }

        private static int PairsCounter1(int[] array)
        {
            int count = 0;
            int i = 0;
            while (i < array.Length - 1)
            {
                if (((array[i] % 3 != 0) && (array[i + 1] % 3 == 0)) || ((array[i] % 3 == 0) && (array[i + 1] % 3 != 0)))
                {
                    count++;
                    i++;
                }
                else
                    i++;
            }
            return count;
        }
        #endregion

        #region Task2
        /// <summary>
        ///     2. Реализуйте задачу 1 в виде статического класса StaticClass:
        ///     а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
        ///     б) *Добавьте статический метод для считывания массива из текстового файла;
        ///     Метод должен возвращать массив целых чисел;
        ///     в) **Добавьте обработку ситуации отсутствия файла на диске.
        /// </summary>

        private static void Task2()
        {
            SingleLevelArray arr1 = new SingleLevelArray(20, -10000, 10000);
            Print("Целочисленный массив из 20 элементов от -10 000 до 10 000");
            Print(arr1);
            
            int count = arr1.PairsCounter(arr1);
            Print("Считаем пары");
            Print(count);

            Print("Загрузка массива из файла");
            SingleLevelArray arrPath = FileRead("d:\\geekbrains.ru\\Projects\\Lvl1_JulySudarenko\\Task2.txt");
            Print(arrPath);

            Print("Обработка ситуации отсутствия файла");
            SingleLevelArray arrNoFile = FileRead("d:\\geekbrains.ru\\Projects\\Lvl1_JulySudarenko\\Task.txt");
            Print(arrNoFile);
        }

        #endregion

        #region Task3
        /// <summary>
        ///     3. а) Дописать класс для работы с одномерным массивом.
        ///     Реализовать конструктор, создающий массив определенного размера
        ///     и заполняющий массив числами от начального значения с заданным шагом.
        ///     Создать свойство Sum, которое возвращает сумму элементов массива, 
        ///     метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива
        ///     (старый массив, остается без изменений),  
        ///     метод Multi, умножающий каждый элемент массива на определённое число,
        ///     свойство MaxCount, возвращающее количество максимальных элементов.
        ///     б) ** Создать библиотеку содержащую класс для работы с массивом.
        ///     Продемонстрировать работу библиотеки.
        ///     в) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)
        /// </summary>

        private static void Task3()
        {
            SingleLevelArray arr2;
            arr2 = new SingleLevelArray(3, 1);
            Print("Создаем массив при помощи конструктора от 3х с шагом 1");
            Print(arr2);

            Print($"Сумма чисел массива {arr2.Sum(arr2)}.");

            SingleLevelArray arrInverse = arr2.Inverse(arr2);
            Print("Массив с противоположными числами");
            Print(arrInverse);

            SingleLevelArray arrMulti = arr2.Multi(arr2, 2);
            Print("Каждый элемент массива умножили на 2");
            Print(arrMulti);

            SingleLevelArray arrMax = new SingleLevelArray(10, 1, 7);
            Print("Массив для поиска максимальных чисел");
            Print(arrMax);

            int arrMaxCount = MaxCount(arrMax);
            Print($"Количество максимальных чисел массива {arrMaxCount}.");
        }



        #endregion

        #region Task4
        /// <summary>
        ///     4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
        ///     Создайте структуру Account, содержащую Login и Password.
        /// </summary>

        private static void Task4()
        {
            Account user1 = Account.FileArrayString("d:\\geekbrains.ru\\Projects\\Lvl1_JulySudarenko\\Account.txt");
            //Print(user1.ToString());

            bool v = Account.CheckAccount(user1);

            if (v == true)
                Print("Доступ разрешен");
            else
                Print("В доступе отказано");
        }

        private static void Task4S()
        {
            AccountF[] users = AccountF.FromFile("..\\..\\AccountF.txt");
            AccountF user1 = new AccountF();
            int count = 3;
            bool v = AccountF.CheckAccountF(users, user1, count);

            if (v == true)
                Print("Доступ разрешен");
            else
                Print("В доступе отказано");

        }
        struct AccountF
        {
            public string login;
            public string password;

            public AccountF(string log, string pas)
            {
                login = log;
                password = pas;
            }

            public static AccountF[] FromFile(string path)
            {
                StreamReader sr = new StreamReader(path);
                int n = File.ReadAllLines(path).Length;
                AccountF[] a = new AccountF[n];
                
                Print("Данные на входе:");
                for (int i = 0; i < n; i++)
                {
                    string[] s = sr.ReadLine().Split(' ');
                    a[i].login = s[0];
                    a[i].password = s[1];
                    Print($"{a[i].login} {a[i].password}");
                }

                sr.Close();

                return a;
            }

            public static bool CheckAccountF(AccountF[] users, AccountF user, int count)
            {
                Print("Введите логин: ", false);
                user.login = GetString();
                Print("Введите пароль: ", false);
                user.password = GetString();

                for (int i = 0; i < users.Length; i++)
                    if ((user.login == users[i].login) && (user.password == users[i].password))
                        return true;
                if (count > 1)
                {
                    Print("Не верно. Попробуйте еще раз.");
                    return CheckAccountF(users, user, count - 1);
                }
                else
                    return false;
            }

        }

        struct Account
        {
            public string[] str;

            public Account(int n)
            {
                str = new string[n];
            }

            public string this[int i]
            {
                get { return str[i]; }
                set { str[i] = value; }
            }


            public static Account FileArrayString(string path)
            {
                StreamReader sr = null;
                Account user1 = new Account(1);
                try
                {
                    sr = new StreamReader(path);
                    int l = File.ReadAllLines(path).Length;
                    user1 = new Account(l);

                    for (int i = 0; i < l; i++)
                    {
                        user1[i] = sr.ReadLine();
                    }
                    sr.Close();
                }
                catch (FileNotFoundException e)
                {
                    Print(e.Message);
                }
                return user1;
            }

            public override string ToString()
            {
                string s = " ";
                for (int i = 0; i < str.Length; i++)
                {
                    string t = str[i];
                    s = s + t + " ";
                }
                return s;
            }

            public static bool CheckAccount(Account s)
            {
                int tryCount = 3;
                bool v = false;
                Account user1 = new Account(2);
                do
                {
                    Print("Введите логин: ", false);
                    user1[0] = GetString();
                    Print("Введите пароль: ", false);
                    user1[1] = GetString();

                    if (s[0] == user1[0] && s[1] == user1[1])
                    {
                        v = true;
                        break;
                    }
                    else if (tryCount > 1)
                    {
                        Print("Не верно. Попробуйте еще раз.");
                        --tryCount;
                    }
                    else
                        --tryCount;

                }
                while (tryCount > 0);
                return v;

            }
        }

        #endregion

        #region Task5 Не делала
        /// <summary>
        ///     5. * а) Реализовать библиотеку с классом для работы с двумерным массивом.
        ///     Реализовать конструктор, заполняющий массив случайными числами.
        ///     Создать методы, которые возвращают сумму всех элементов массива, 
        ///     сумму всех элементов массива больше заданного,
        ///     свойство, возвращающее минимальный элемент массива, 
        ///     свойство, возвращающее максимальный элемент массива,
        ///     метод, возвращающий номер максимального элемента массива
        ///     (через параметры, используя модификатор ref или out).
        ///     ** б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
        ///     ** в) Обработать возможные исключительные ситуации при работе с файлами.
        /// </summary>

        #endregion
    }
}
