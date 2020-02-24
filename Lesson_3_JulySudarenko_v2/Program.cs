using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_3_CSharp_Lvl1;
using static Lesson_2_CSharp_Lvl1.ViewJulyS;
using static Lesson_3_CSharp_Lvl1.Fraction;
using static Lesson_3_CSharp_Lvl1.Complex;

namespace Lesson_3_JulySudarenko
{
    class Program
    {
        static void Main()
        {
            //TaskClassComplex();
            //TaskStructCompleks();
            //Task2();
            Task3();
            Pause();

        }


    /*
    1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
    б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
    в) Добавить диалог с использованием switch демонстрирующий работу класса.*/
       
        private static void TaskClassComplex()
        {
            Complex complex1;
            complex1 = new Complex(1, 1);

            Complex complex2 = new Complex(2, 2);

            complex2.Im = 3;

            Complex resultPlus = complex1.Plus(complex2);
            Complex resultMinus = complex1.Minus(complex2);
            Complex resultMultiPlus = complex1.MultiPlus(complex2);

            //Задание 1б. Выведем на консоль все результаты вычислений. 
            Print($"Сумма комплексных чисел: {resultPlus.ComplexToString()}.");
            Print($"Разность комплексных чисел: {resultMinus.ComplexToString()}.");
            Print($"Произведение комплексных чисел: {resultMultiPlus.ComplexToString()}.");

            //Задание 1в. Диалог с использованием switch.
            Print("Введите операцию \"+\", \"*\" или \"-\" :");
            char c = GetChar();
            switch (c)
            {
                case '+':
                    Print($"Сумма комплексных чисел: {resultPlus.ComplexToString()}.");
                    break;
                case '-':
                    Print($"Разность комплексных чисел: {resultMinus.ComplexToString()}.");
                    break;
                case '*':
                    Print($"Произведение комплексных чисел: {resultMultiPlus.ComplexToString()}.");
                    break;
                default:
                    Print("Такая операция не предусмотрена.");
                    break;
            }

        }

        
        //Задание 1а. Демонстрируем работу структуры Complex.
        private static void TaskStructCompleks()
        {
            ComplexStruct complexStruct1;
            complexStruct1.im = 1;
            complexStruct1.re = 1;

            ComplexStruct complexStruct2;
            complexStruct2.im = 2;
            complexStruct2.re = 2;

            ComplexStruct resultPlus = complexStruct1.Plus(complexStruct2);
            ComplexStruct resultMinus = complexStruct1.Minus(complexStruct2);
            ComplexStruct resultMultiPlus = complexStruct1.MultiPlus(complexStruct2);

            Print($"Сумма комплексных чисел: {resultPlus.ComplexStructToString()}.");
            Print($"Разность комплексных чисел: {resultMinus.ComplexStructToString()}.");
            Print($"Произведение комплексных чисел: {resultMultiPlus.ComplexStructToString()}.");
        }

        
        struct ComplexStruct
        {
            public double im;
            public double re;


            //Сложение

            public ComplexStruct Plus(ComplexStruct x)
            {
                ComplexStruct y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }


            //Вычитание

            public ComplexStruct Minus(ComplexStruct x)
            {
                ComplexStruct y;
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }

            //Умножение
            
            public ComplexStruct MultiPlus(ComplexStruct x)
            {
                ComplexStruct y;
                y.im = x.im * re + x.re * im;
                y.re = x.re * re - x.im * im;
                return y;
            }


            public string ComplexStructToString()
            {
                if (im < 0)
                    return re + " - " + Math.Abs(im) + "i";
                else
                    return re + " + " + im + "i";
            }
        }


        /*
         2. а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
         Требуется подсчитать сумму всех нечётных положительных чисел. 
         Сами числа и сумму вывести на экран, используя tryParse.*/

        private static void Task2()
        {
            int a;
            int result = 0;
            Print("Вводите числа. Когда надоест введите 0.");
            do
            {
                a = GetInt();//Доработала метод GetInt. Добавила tryParse.
                if (a % 2 != 0 && a > 0)
                    result += a;
                else
                    continue;
            }
            while (a != 0);
            Print($"Сумма нечетных положительных чисел: {result}.");
            //Для проверки можно использовать последовательность: 37, 90, 23, 8, -77, 0. Сумма 60.
        }


        /*3. * Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. 
        * Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
        * Написать программу, демонстрирующую все разработанные элементы класса.
        * Добавить свойства типа int для доступа к числителю и знаменателю;
        * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
        ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
        *** Добавить упрощение дробей.*/

        private static void Task3()
        {

            Fraction f0 = new Fraction(1, 0); //Для проверки на ввод нулевого знаменателя.
            Fraction f1 = new Fraction(1, 2); //Для сложения, вычитания, умножения, деления.
            Fraction f2 = new Fraction(1, 4); //Для сложения, вычитания, умножения, деления.
            Fraction f3 = new Fraction(78, 108); //Для упрощения.
            Fraction f4 = new Fraction(0, 5); //Для деления.
            
            Fraction resultMultiPlus = f1.MultiPlus(f2);
            Fraction resultDivide = f1.Divide(f2);
            Fraction resultPlus = f1.Plus(f2);
            Fraction resultMinus = f1.Minus(f2);
            Fraction resultMinus1 = f1.Minus1(f2);
            
            double resultDecimal1 = FractionDecimal(f1);
            double resultDecimal2 = FractionDecimal(f2);
            double resultDecimal3 = FractionDecimal(f3);


            Print("Введены две дроби: ");
            Print(f1.FractionToString());
            Print(f2.FractionToString());
            Print($"Результат умножения: {resultMultiPlus.FractionToString()}.");
            Print($"Результат деления: {resultDivide.FractionToString()}.");
            Print($"Результат сложения: {resultPlus.FractionToString()}.");
            Print($"Результат вычитания: {resultMinus.FractionToString()}.");
            Print($"Результат вычитания другим способом: {resultMinus1.FractionToString()}.");


            Print(f3.FractionToString());
            Fraction resultSimple = f3.Simple(ref f3);
            Print($"Результат упрощения: {resultSimple.FractionToString()}.");

            Print($"Вывод в десятичном формате: {resultDecimal1:f}, {resultDecimal2:f} и {resultDecimal3:f}.");

            Print("Проверка на 0.");
            Print(f0.FractionToString());
            
            Print(f4.FractionToString());

        }


    }
}
