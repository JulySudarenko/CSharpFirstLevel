using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lesson_2_CSharp_Lvl1.ViewJulyS;
using static Lesson_2_CSharp_Lvl1.UsefulForJulyS;

namespace Lesson_2_JulySudarenko_HomeWork
{
    class Program
    {


        static void Main(string[] args)
        {
            Task1();
            Task2(); //через цикл
            //Task2Convert(); //через конвертацию в строку
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
            Pause();
        }



        //1. Написать метод, возвращающий минимальное из трех чисел.

        private static void Task1()
        {
            Print("Введите первое число: " , false);
            int a = GetInt();
            Print("Введите второе число: ", false);
            int b = GetInt();
            Print("Введите третье число: ", false);
            int с = GetInt();
            
            Print($"Минимальное число: {MinNumberTerm(a, b, с)}.");//При помощи тернарного оператора
            Print(MinNumberIf1(a, b, с));//При помощи условий
            Print(MinNumberIf2(a, b, с));
        }
        
        //Тернарный оператор
        private static int MinNumberTerm(int a, int b, int c)
        {
            int min = a < b ? a : b;
            //return _ = c < min ? c : min; //Работает, но я не до конца поняла как... "_ =" - надо почитать.
            return c < min ? c : min;
        }

        //Вложенные условия. И без ввода переменной min.
        private static int MinNumberIf1(int a, int b, int c)
        {
            if (a <= b)
                if (a <= c)
                    return a;
                else
                    return c;
            else
                if (b <= c)
                    return b;
                else 
                    return c;
        }
        
        //Тоже самое с использованием &&
        private static int MinNumberIf2(int a, int b, int c)
        {
            if (a <= b && a <= c)
                return a;
            else
                if (b <= c)
                    return b;
                else 
                    return c;
        }



        //2. написать метод подсчета количества цифр числа.
        private static void Task2()
        {
            Print("Введите число побольше: ", false);
            ulong num = Convert.ToUInt64(Console.ReadLine());
            int count = 0;
            while (num != 0)
            {
                count++;
                num /= 10;
            }
            Print($"Количество цифр в числе: {count}."); ;
        }

        //Считаем через конвертацию и измерению длины строки.
        private static void Task2Convert() 
        {
            Print("Введите число побольше: ", false);
            ulong t = Convert.ToUInt64(Console.ReadLine());
            string s = Convert.ToString(t);
            int i = s.Length;
            Print($"Количество цифр в числе: {i}.");
        }

       
        //3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        private static void Task3()
        {
            int a;
            int result = 0;
            Print("Вводите числа. Когда надоест введите 0.");
            do
            {
                a = GetInt();
                if (a % 2 != 0 && a > 0)
                    result += a;
                else
                    continue;
            }
            while (a != 0);
            Print($"Сумма нечетных положительных чисел: {result}.");
            //Для проверки можно использовать последовательность: 37, 90, 23, 8, -77, 0. Сумма 60.
        }
        

        /*
        * 4. Реализовать метод проверки логина и пароля.
        * На вход метода подается логин и пароль.
        * На выходе истина, если прошел авторизацию, и ложь, если не прошел.
        * Логин: root. Password: GeekBrains.
        * Используя метод логина и пароля написать программу: 
        * пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        * С помощью цикла do while ограничить ввод пароля тремя попытками.*/

         private static void Task4()
         {
            string login = "root";
            string password = "GeekBrains";
            

            bool v = CheckLoginPassword(login, password);
            
            //int tryCount = 3;
            //bool v = Print(CheckLoginPasswordRecursion(login, password, tryCount)); //проверка через рекурсию

            
            if (v == true)
                    Print("Доступ разрешен");
                else
                    Print("В доступе отказано");
         }

        //Решение через цикл do while
        private static bool CheckLoginPassword(string login, string password)
        {
            int tryCount = 3;
            bool v = false;
            do
            {
                Print("Введите логин: ", false);
                string userLogin = GetString();
                Print("Введите пароль: ", false);
                string userPassword = GetString();

                if (login == userLogin && password == userPassword)
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

        //Решение через рекурсию.
        private static bool CheckLoginPasswordRecursion(string login, string password, int tryCount)
        {
            Print("Введите логин: ", false);
            string userLogin = GetString();
            Print("Введите пароль: ", false);
            string userPassword = GetString();
           
            bool v = false;
            
            if (login == userLogin && password == userPassword && tryCount > 0)
            {
                v = true;
                return v;
            }
            else if (tryCount <= 1)
                return v;
            else
            {
                Print("Не верно. Попробуйте еще раз.");
                return CheckLoginPasswordRecursion(login, password, tryCount - 1);
            }

        }
        
        
        
        /*
        * 5. а) Написать программу, которая запрашивает массу и рост человека, 
        * вычисляет его индекс массы тела и
        * сообщает, нужно ли человеку похудеть, набрать вес или все в норме.
        * б) *Рассчитать, на сколько кг похудеть или набрать для нормального веса.*/

        private static void Task5()
        {
            Print("Укажите рост в сантиметрах: ");
            byte height = Convert.ToByte(Console.ReadLine());
            
            //float heightMetre = Convert.ToSingle(height);
            float heightMetre = (float)height;
            
            heightMetre /= 100f;
            
            Print("Вес в килограммах: ");
            byte weight = Convert.ToByte(Console.ReadLine());

            float bml = BodyMassIndex(weight, heightMetre);
            Print($"Ваш индекс массы тела составляет {bml:f}.");
            
            float minNormalWeight = 18.50f * heightMetre * heightMetre;
            float maxNormalWeight = 25.00f * heightMetre * heightMetre;
            
            if (bml < 18.50)
                Print($"Дефицит массы тела {minNormalWeight - weight:f1} кг.");
            else if (bml >= 18.50 && bml <= 25.00)
                Print("Нормальная масса тела.");
            else if (bml > 25.00)
                Print($"Избыточная масса тела {weight - maxNormalWeight:f1} кг.");
        }


        
        /* 
        * 6. *Написать программу подсчета количества "хороших" чисел 
        * в диапазоне от 1 до 1 000 000 000.
        * "Хорошим" называется число, которое делится на сумму своих цифр.
        * Реализовать подсчет времени выполнения программы, используя DateTime.*/

        private static void Task6()
        {
            Print("Программа считает, пожалуйста, подождите. Это займет не более 2х минут.");
            DateTime start = DateTime.Now;
            int count = 0;
            int i = 1;
            while (i < 1000000001)
            {
                if (i % SumOfDigits(i) == 0)
                    count++;
                i++;
            }
            DateTime finish = DateTime.Now;
            Print($"Количество \"хороших\" чисел: {count}. Время выполнения программы: {finish - start}.");
        }
        //Итог: Количество "хороших" чисел: 61574510. Время выполнения программы: 00:01:31.1172032.
        //Можно ли через некоторые промежутки времени выдавать пользователю % выполнения?


        
        /* 
        * 7. а) Разработать рекурсивный метод, который выводит на экран числа от a до b (a < b). 
        * б) *Разработать рекурсивный метод, который считает сумму чисел от a до b. */
        private static void Task7()
        {
            Print("Введите a: ", false);
            int a = GetInt();
            Print("Введите b. Оно должно быть больше a: ", false);
            int b = GetInt();
            while (a >= b)
            {
                Print("a должно быть меньше b. Введить b еще раз: ", false);
                b = GetInt();
            }
            //int b = GetB(a); //Решение через рекурсию.
            SeriesOfNumber(a, b);
            Print($"\nСумма чисел от a до b равна: {SumSeriesOfNumbers(a, b)}.");
            //Для проверки a = 2, b = 10. Сумма 54.
        }


        //считает сумму чисел от a до b.
        private static int SumSeriesOfNumbers(int a, int b)
        {
            if (a < b)
                return SumSeriesOfNumbers(a + 1, b) + a;
            else
                return a;
        }


        //выводит на экран числа от a до b (a < b)
        private static void SeriesOfNumber(int a, int b)
        {
            Console.Write("{0} ", a);
            if (a < b) 
                SeriesOfNumber(a + 1, b);
        }


        //Решение через рекурсию. Проверка b.
        private static int GetB(int a)
        {
            int b = GetInt();
            if (a >= b)
            {
                Print("a должно быть меньше b. Введить b еще раз: ", false);
                return GetB(a);
            }
            else
                return b;
        }


    }
}
