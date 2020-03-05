using System;
using System.IO;
using static Lesson_2_CSharp_Lvl1.ViewJulyS;



namespace JulyArrayLibrary
{
    public class SingleLevelArray
    {
        private int[] _arr;

        public int Get(int i)
        {
            return _arr[i];
        }

        public void Set(int i, int value)
        {
            _arr[i] = value;
        }

        public int this[int i]
        {
            get { return _arr[i]; }
            set { _arr[i] = value; }
        }

        public int Length
        {
            get
            {
                return _arr.Length;
            }
        }

        public SingleLevelArray(int n)
        {
            _arr = new int[n];
        }

        public SingleLevelArray(int n, int min, int max)
        {
            _arr = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                _arr[i] = rnd.Next(min, max);
            }
        }

        public override string ToString()
        {
            string s = " ";
            for (int i = 0; i < _arr.Length; i++)
            {
                int t = _arr[i];
                s = s + t + " ";
            }
            return s;
        }

        public int PairsCounter(SingleLevelArray array)
        {
            int count = 0;
            int i = 0;
            while (i < array.Length - 1)
            {
                if (Term(array[i], array[i + 1]))
                    count++;
                i++;
            }
            return count;
        }

        private static bool Term(int a, int b)
        {
            if (((a % 3 != 0) && (b % 3 == 0)) || ((a % 3 == 0) && (b % 3 != 3)))
                return true;
            else
                return false;
        }

        public static SingleLevelArray FileRead(string path)
        {
            StreamReader sr = null;
            SingleLevelArray a = new SingleLevelArray(1);
            try
            {
                sr = new StreamReader(path);
                int l = File.ReadAllLines(path).Length;
                a = new SingleLevelArray(l);

                for (int i = 0; i < File.ReadAllLines(path).Length; i++)
                {
                    a[i] = Int32.Parse(sr.ReadLine());
                }
                sr.Close();
            }
            catch (FileNotFoundException e)
            {
                Print(e.Message);
            }
            return a;
        }

        public SingleLevelArray(int start, int step)
        {
            Print("Определите размер массива: ", false);
            int n = GetInt();
            _arr = new int[n];
            _arr[0] = start;

            for (int i = 1; i < n; i++)
            {
                _arr[i] = _arr[i - 1] + step;
            }
        }

        public int Sum(SingleLevelArray array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            return result;
        }

        public SingleLevelArray Inverse(SingleLevelArray array)
        {
            SingleLevelArray b = new SingleLevelArray(array.Length);
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = array[i] * -1;
            }
            return b;
        }

        public SingleLevelArray Multi(SingleLevelArray array, int x)
        {
            SingleLevelArray b = new SingleLevelArray(array.Length);
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = array[i] * x;
            }
            return b;
        }

        public static int MaxCount(SingleLevelArray array)
        {
            int maxCount = 0;
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
                if (array[i] > max)
                    max = array[i];
            for (int i = 0; i < array.Length; i++)
                if (max == array[i])
                    maxCount++;

            return maxCount;
        }
    }
}
