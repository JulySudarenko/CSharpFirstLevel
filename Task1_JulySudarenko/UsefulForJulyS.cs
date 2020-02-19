using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_CSharp_Lvl1
{
    public class UsefulForJulyS
    {
        public static float BodyMassIndex(byte weight, float heightMetre)
        {
            return weight / (heightMetre * heightMetre);
        }

        public static double Pifagor(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static long SumOfDigits(int num)
        {
            long sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}
