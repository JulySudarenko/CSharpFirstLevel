using System;
using static Lesson_2_CSharp_Lvl1.ViewJulyS;
using System.IO;

namespace Lesson_4_CSharp_Lvl1
{
    #region Task2a
    /// <summary>
    ///     2. Реализуйте задачу 1 в виде статического класса StaticClass;
    ///     а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
    /// </summary>

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

                if (((array[i] % 3 != 0) && (array[i + 1] % 3 == 0)) || ((array[i] % 3 == 0) && (array[i + 1] % 3 != 0)))
                {
                    count++;
                    i++;
                }
                else
                    i++;
            }
            return count;
        }

    #endregion

        #region Task2File
        /// <summary>
        ///     2. б) *Добавьте статический метод для считывания массива из текстового файла.
        ///     Метод должен возвращать массив целых чисел;
        ///     в) **Добавьте обработку ситуации отсутствия файла на диске.
        /// </summary>

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


        #endregion


        #region Task3
        /// <summary>
        ///     3. а) Дописать класс для работы с одномерным массивом.
        ///     Реализовать конструктор, создающий массив определенного размера
        ///     и заполняющий массив числами от начального значения с заданным шагом.
        ///     Создать свойство Sum, которое возвращает сумму элементов массива, 
        ///     метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива
        ///     (старый массив, остается без изменений),  
        ///     метод Multi, умножающий каждый элемент массива на определённое число,
        ///     свойство MaxCount, возвращающее количество максимальных элементов.
        ///     б)** Создать библиотеку содержащую класс для работы с массивом.
        ///     Продемонстрировать работу библиотеки.
        ///     в) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)
        /// </summary>
        
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

            #region while
            //int i = 1;
            //do
            //{
            //    if (array[i] > max)
            //        max = array[i];
            //    i++;
            //}
            //while (i < array.Length);
            //i = 0;
            //while (i < array.Length)
            //{
            //    if (max == array[i])
            //        maxCount++;
            //    i++;
            //}
            #endregion
            return maxCount;
        }

        #endregion
    }
}
