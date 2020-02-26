using System;
using static Lesson_2_CSharp_Lvl1.ViewJulyS;

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
            //while (dn == 0)
            //{
            //    Print("Знаменатель не может быть равен 0! Введите другое значение");
            //    dn = GetInt();
            //}
            this.nm = nm;
            this.dn = dn;
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
            return Simple(y);
        }
        
        
        //Деление. Сделать проверку!!!

        public Fraction Divide(Fraction x)
        {
            Fraction y = new Fraction();
            y.nm = nm * x.dn;
            y.dn = dn * x.nm;
            return Simple(y);
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
            
            return Simple(y);
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
            return Simple(y);
        }


        //Можно сделать с использованием ф-ии плюс. 
        
        public Fraction Minus1(Fraction x)
        {
            Fraction y = new Fraction();
            y.nm = -1 * x.nm;
            y.dn = x.dn;
            Fraction z = Plus(y);
            return Simple(z);
        }

        //Перевод в десятичные дроби

        public static double FractionDecimal(Fraction x)
        {
            return Convert.ToDouble(x.nm) / Convert.ToDouble(x.dn);
        }


        public static double FractionDecimalEx()
        {
            Fraction y = new Fraction();
            y.nm = GetInt();
            y.dn = GetInt();
            int fr = 0;

            try
            {
                fr = y.nm / y.dn;
                Print(fr);
            }
            catch (DivideByZeroException e)
            {
                Print(e.Message);// Не могу понять почему не выдает мое сообщение.
                //throw new DivideByZeroException("Знаменатель не может быть равен 0!");
            }
            return fr;
        }


        //Упрощение

        public Fraction Simple(Fraction x) 
        {
            Fraction y = new Fraction();
            y.nm = x.nm;
            y.dn = x.dn;
            int i = 2;
            while ((y.nm > i) || (y.dn > i))
            {
                while ((y.nm % i == 0) && (y.dn % i == 0))
                {
                    y.nm /= i;
                    y.dn /= i;
                }
                i++;
            }
            return y;
        }
    }
}
