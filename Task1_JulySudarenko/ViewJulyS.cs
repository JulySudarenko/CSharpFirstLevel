using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;//далее можно не писать Console.

namespace Lesson2_CSharp_Lvl1
{
    public class ViewJulyS
    {
        public static void Print(object value) 
        {
            WriteLine(value);        
        }
        
        public static int GetInt()
        {
            return Int32.Parse(ReadLine());
        }
        
        public static string GetString()
        {
            return ReadLine();
        }
        
        public static void Pause()
        {
            ReadKey();
        }
    }
}
