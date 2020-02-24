using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lesson_2_CSharp_Lvl1.ViewJulyS;
using static Lesson_2_CSharp_Lvl1.UsefulForJulyS;

namespace Lesson_3_CSharp_Lvl1
{
    /*
    3. * Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
    Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
    Написать программу, демонстрирующую все разработанные элементы класса.
    * Добавить свойства типа int для доступа к числителю и знаменателю;
    * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
    ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException ("Знаменатель не может быть равен 0");
    *** Добавить упрощение дробей.
    */
    class Fraction
    {
        private int nm; //numerator - числитель
        private int dn; //denominator - знаменатель

        public Fraction()
        {
            nm = 0;
            dn = 1;
        }

        public Fraction(int nm, int dn)
        {
            //Если сразу ввести проверку, то уже не надо отслеживать значения в примерах.
            //У меня не получилось здесь вставить ArgumentException.
            
            while (dn == 0)
            {
                Print("Знаменатель не может быть равен 0! Введите другое значение");
                dn = GetInt();
            }
            this.nm = nm;
            this.dn = dn;
            //try
            //{
            //    this.dn = dn;
            //}
            //catch (ArgumentNullException)
            //{
            //    Console.WriteLine("Знаменатель не может быть равен 0!", this.dn);
            //}
        }
        
        
        //На печать

        public string FractionToString()
        {
            return nm + "/" + dn;
        }

        
        //Умножение

        public Fraction MultiPlus(Fraction x)
        {
            Fraction y = new Fraction();
            y.nm = nm * x.nm;
            y.dn = dn * x.dn;
            return y;
        }
        
        
        //Деление. Сделать проверку!!!

        public Fraction Divide(Fraction x)
        {
            Fraction y = new Fraction();
            y.nm = nm * x.dn;
            y.dn = dn * x.nm;
            return y;

        }
        
        
        //Сложение

        public Fraction Plus(Fraction x)
        {
            Fraction y = new Fraction();
            if (dn == x.dn)
            {
                y.nm = nm + x.dn;
                y.dn = dn;
            }
            else
            {
                y.nm = nm * x.dn + dn * x.nm;
                y.dn = dn * x.dn;
            }
            
            return y;
        }


        //Вычитание
        
        public Fraction Minus(Fraction x)
        {
            Fraction y = new Fraction();
            if (dn == x.dn)
            {
                y.nm = nm - x.dn;
                y.dn = dn;
            }
            else
            {
                y.nm = nm * x.dn - dn * x.nm;
                y.dn = dn * x.dn;
            }
            return y;
        }


        //Можно сделать с использованием ф-ии плюс. 
        
        public Fraction Minus1(Fraction x)
        {
            Fraction y = new Fraction();
            y.nm = -1 * x.nm;
            y.dn = x.dn;
            Fraction z = Plus(y);
            return z;
        }

        //Перевод в десятичные дроби

        public static double FractionDecimal(Fraction x)
        {
            //double fr = 0.0d;
            //try
            //{
            //    fr = Convert.ToDouble(x.nm) / Convert.ToDouble(x.dn);
            //}
            //catch (DivideByZeroException)
            //{
            //    Print("Знаменатель не может быть равен 0!");
            //}
            return Convert.ToDouble(x.nm) / Convert.ToDouble(x.dn);
        }


        //Упрощение

        public Fraction Simple(ref Fraction x) 
        {
            int i = 1;
            while ((nm > i) || (dn > i))
            {
                if ((nm % i == 0) && (dn % i == 0))
                {
                    nm /= i;
                    dn /= i;
                    i++;
                }
                else
                    i++;
            }
            return x;
         
        }


    }
}
