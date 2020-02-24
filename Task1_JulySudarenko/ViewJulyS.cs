using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;//далее можно не писать Console.

namespace Lesson_2_CSharp_Lvl1
{
    public class ViewJulyS
    {
        public static void Print(object value, bool isNewLine = true) 
        {
            if (isNewLine)
                WriteLine(value);
            else
                Write(value);
        }
        
        public static int GetInt()
        {
            int num;
            while (!Int32.TryParse(ReadLine(), out num))
            {
                Print("Нужно ввести число: ");
            }
            return num;
        }

        
        
        public static string GetString()
        {
            return ReadLine();
        }

        public static char GetChar()
        {
            return Convert.ToChar(ReadLine());
        }

        public static void Pause()
        {
            ReadKey();
        }
        
        public static void PrintXY(string message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
        }
    }
}
