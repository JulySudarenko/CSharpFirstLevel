using System;

namespace Lesson_3_CSharp_Lvl1
{
    /*    
    1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
    б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
    в) Добавить диалог с использованием switch демонстрирующий работу класса.*/
    
    public class Complex
    {
        private double im;
        private double re;

        //Если значения на входе не заданы, они будут считаться нулевыми.
        public Complex()
        {
            im = 0;
            re = 0;
        }

        //Если задать значения на входе.
        public Complex(double im, double re)
        {
            this.im = im;
            this.re = re;
        }

        //Сложение
        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        //Вычитание
        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }

        //Умножение
        public Complex MultiPlus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im * re + x2.re * im;
            x3.re = x2.re * re - x2.im * im;
            return x3;
        }

        //Другие свойства из методички.
        public double Im
        {
            get
            {
                return im;
            }
            set
            {
                if (value >= 0)
                    im = value;
            }
        }

        //Так выводить на экран
        public string ComplexToString()
        {
            if (im < 0)
                return re + " - " + Math.Abs(im) + "i";//Можно было бы вывести без знака "-" и без модуля. Но получается не эстетично.
            else
                return re + " + " + im + "i";
        }

    }
}
