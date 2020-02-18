using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lesson_2_CSharp_Lvl1.ViewJulyS;

namespace Lesson_2_JulySudarenko_HomeWork
{
    class Program
    {


        static void Main(string[] args)
        {
            //Task1();
            //Pause();
            //Task2();
            //Pause();
            Task3();
            Pause();
        }
        
        
        
        //1. Написать метод, возвращающий минимальное из трех чисел.
        
        private static void Task1()
        {
            Print("Введите первое число");
            int a = GetInt();
            Print("Введите второе число");
            int b = GetInt();
            Print("Введите третье число");
            int с = GetInt();
            Print($"Минимальное число: {MinNumberTerm(a, b, с)}.");//При помощи тернарного оператора
            Print(MinNumberIf1(a, b, с));//При помощи условий
            Print(MinNumberIf2(a, b, с));
        }
        
        //Тернарный оператор
        private static int MinNumberTerm(int a, int b, int c)
        {
            int min = a < b ? a : b;
            return _ = c < min ? c : min; //Работает, но я не до конца поняла как... "_ =" - надо почитать.
            //return c < min ? c : min;

        }

        //Вложенные условия. И без ввода переменной min.
        private static int MinNumberIf1(int a, int b, int c)
        {
            if (a < b)
                if (a < c)
                    return a;
                else
                    return c;
            else
                if (b < c)
                    return b;
                else 
                    return c;
        }
        
        //Не доделано. Надо проверить равенство.
        private static int MinNumberIf2(int a, int b, int c)
        {
            int min = a;
            if (min < b && min < c)
                return min;
            else 
                if (b < min && b < c)
                    return _ = b;
                else 
                    return _= c;
        }


        //2. написать метод подсчета количества цифр числа.
        
        //Если вводить слишком большое число ругается. Вопрос как проверить вводимые данные на число?
        private static void Task2() 
        {
            Print("Введите число");
            ulong t = Convert.ToUInt64(Console.ReadLine());
            string s = Convert.ToString(t);
            int i = s.Length;
            Print($"Количество цифр в числе: {i}.");
        }

        
        
        //3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        // Можно ли сделать через while? Сделать рекурсию.
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
            }
            while (a != 0);
            Print($"Сумма нечетных положительных чисел: {result}.");
        }
        //private static void Task3Recorsion(int a, int result)
        //{

        //    a = GetInt();
        //    if (a % 2 != 0 && a > 0)
        //        result += a;


        //}




        /*4. Реализовать метод проверки логина и пароля.
        * На вход метода подается логин и пароль.
        * На выходе истина, если прошел авторизацию, и ложь, если не прошел.
        * Логин: root.Password: GeekBrains.
        * Используя метод логина и пароля написать программу: 
        * пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        * С помощью цикла do while ограничить ввод пароля тремя попытками.*/

         
        
        
        /* 
        * 5. а) Написать программу, которая запрашивает массу и рост человека, 
        * вычисляет его индекс массы тела и
        * сообщает, нужно ли человеку похудеть, набрать вес или все в норме.
        * б) *Рассчитать, на сколько кг похудеть или набрать для нормального веса.
        * 6. *Написать программу подсчета количества "хороших" чисел 
        * в диапазоне от 1 до 1 000 000 000.
        * "Хорошим" называется число, которое делится на сумму своих цифр.
        * Реализовать подсчет времени выполнения программы, используя DateTime.
        * 7. а) Разработать рекурсивный метод, который выводит на экран числа от a до b (a < b). 
        * б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
       */
    }
}
