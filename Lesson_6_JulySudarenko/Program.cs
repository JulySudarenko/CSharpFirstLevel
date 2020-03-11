using System;
using System.Collections.Generic;
using System.Text;
using static Lesson_2_CSharp_Lvl1.ViewJulyS;
using System.IO;


namespace Lesson_6_JulySudarenko
{
    class Program
    {
        static void Main()
        {
            Print("Введите номер задания:");
            int c = GetInt();
            switch (c)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                default:
                    Print("Такая операция не предусмотрена.");
                    break;
            }
            Pause();
        }

        #region Task1
        /// <summary>
        /// 1. Изменить программу вывода таблицы функции так, 
        /// чтобы можно было передавать функции типа double (double, double). 
        /// Продемонстрировать работу на функции с функцией a* x^2 
        /// и функцией a* sin(x).
        /// </summary>

   #if false
        // Описываем делегат. В делегате описывается сигнатура методов, на
        // которые он сможет ссылаться в дальнейшем (хранить в себе)
        public delegate double Fun(double x);
        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        private static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        // Создаем метод для передачи его в качестве параметра в Table
        private static double MyFunc(double x)
        {
            return x * x * x;
        }
        #endif
        


        private static void Task1()
        {
#region Пример делегатов из методички
            //// Создаем новый делегат и передаем ссылку на него в метод Table
            //Console.WriteLine("Таблица функции MyFunc:");
            //// Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            //Table(new Fun(MyFunc), -2, 2);
            //Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            //// Упрощение(c C# 2.0).Делегат создается автоматически.            
            //Table(MyFunc, -2, 2);
            //Console.WriteLine("Таблица функции Sin:");
            //Table(Math.Sin, -2, 2);      // Можно передавать уже созданные методы
            //Console.WriteLine("Таблица функции x^2:");
            //// Упрощение(с C# 2.0). Использование анонимного метода
            //Table(delegate (double x) { return x * x; }, 0, 3);
#endregion

            Print("Новая таблица с функцией a* x^2:");
            TableFeature(MySquare, 2, -2, 2);
            Print("Новая таблица с функцией a* sin(x):");
            TableFeature(MySin, 2, -2, 2);
        }
        public delegate double Feature(double a, double x);

        private static void TableFeature(Feature F, double a, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a, x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        private static double MySquare(double a, double x)
        {
            return a * x * x;
        }
        private static double MySin(double a, double x)
        {
            return a * Math.Sin(x);
        }

        #endregion

        #region Task2
        /// <summary>
        /// 2. Модифицировать программу нахождения минимума функции так, 
        /// чтобы можно было передавать функцию в виде делегата. 
        /// а) Сделать меню с различными функциями и представить пользователю выбор, 
        /// для какой функции и на каком отрезке находить минимум.
        /// Использовать массив (или список) делегатов, в котором хранятся различные функции. 
        /// б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.
        /// Пусть она возвращает минимум через параметр (с использованием модификатора out). 
        /// </summary>
        /// 

        public delegate double FeatureMin(double x);
        
        public static double Feature1(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double Feature2(double x)
        {
            return (x + 10) * 7 * x;
        }

        public static double Feature3(double x)
        {
            return 3 * x - 8 * x * x;
        }
        
        public static void SaveFeature(FeatureMin F, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;

            while (x <= b)
            {
                bw.Write(F(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        
        public static double[] LoadFeature(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            long n = fs.Length / sizeof(double);
            double[] y = new double [n];
            for (int i = 0; i < n; i++)
            {
                y[i] = bw.ReadDouble();
                if (y[i] < min) 
                    min = y[i];
            }
            bw.Close();
            fs.Close();
            return y;
        }

        private static void Task2()
        {
            FeatureMin[] FeatureArray = new FeatureMin[7];
            FeatureArray[0] = new FeatureMin(Feature1);
            FeatureArray[1] = new FeatureMin(Feature2);
            FeatureArray[2] = new FeatureMin(Feature3);
            FeatureArray[3] = new FeatureMin(Math.Sin);
            FeatureArray[4] = new FeatureMin(Math.Cos);

            int i;
            do
            {
                Print("Выберите функцию (введите число от 1 до 5): \n1. (x * x - 50 * x + 10)\n2. ((x + 10) * 7 * x)\n3. (3 * x - 8 * x * x)\n4. sin(x)\n5. cos(x)");
                i = GetInt() - 1;
            } while ((i < 0) || (i > 5));

            int[,] limit = new int[3, 2] { { -100, -25 }, { -25, 25 }, { 25, 100 } };

            int l;
            do 
            {
                Print("Выберите границы отрезка для нахождения минимума\n1: ( -100, -25 ) \n2: ( -25, 25 ) \n3: ( 25, 100 ): ");
                l = GetInt() - 1;
            } while ((l < 0) || (l > 3));


            SaveFeature(FeatureArray[i], "data.bin", limit[l, 0], limit[l, 1], 0.5);
            
            double[] y = LoadFeature("data.bin", out double min);
            
            for (int j = 0; j < y.Length; j++)
                Print(y[j]);

            Print(min);
        }

        #endregion

        #region Task3
        /// <summary>
        /// 3. Переделать программу Пример использования коллекций для решения следующих задач:
        /// а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
        /// б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся
        /// (*частотный массив);
        /// в) отсортировать список по возрасту студента;
        /// г) *отсортировать список по курсу и возрасту студента;
        /// </summary>

        private static void Task3()
        {
            int[] аgeRange = new int[21];
            int[] courseAge = new int[7];
            int ageAllLim = 0;
            int courseRange = 0;
            List<Student> list = new List<Student>();
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("..\\students_1.csv", Encoding.GetEncoding(1251));
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');

                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));

                    if (int.Parse(s[6]) > 4)
                        courseRange++;

                    if ((int.Parse(s[5]) >= 18) && (int.Parse(s[5]) <= 20))
                        аgeRange[int.Parse(s[5])]++;
                    
                    if ((int.Parse(s[5]) >= 18) && (int.Parse(s[5]) <= 20))
                    {
                        courseAge[int.Parse(s[6])]++;
                        ageAllLim++;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) 
                        return;
                }
            }

            sr.Close();

            list.Sort(new Comparison<Student>(MyDelegat));

            SortStudents(list, SortCourseDel);
            SortStudents(list, SortAgeDel);
            //list.Sort(new Comparison<Student>(CompareCourse));
            //list.Sort(new Comparison<Student>(CompareAge));
            
            Print($"Всего студентов: {list.Count}");
            Print($"Учащихся на 5-6 курсах: {courseRange}");
            Print($"Учащихся в возрасте от 18 до 20 лет: {ageAllLim} человек.");
            for (int j = 0; j < courseAge.Length; j++)
            {
                if (courseAge[j] != 0)
                    Print($"На {j} курсе: {courseAge[j]} человек(a).");
            }

            for (int j = 0; j < аgeRange.Length; j++)
            {
                if (аgeRange[j] != 0)
                    Print($"Студентов в возресте {j} лет: {аgeRange[j]} человекa.");
            }
            
            for (int i = 0; i < list.Count; i++)
            {
                Student v = list[i];
                Print($"{v.course} {v.age} {v.firstName}");
            }


            Console.WriteLine(DateTime.Now - dt);
        }

        class Student
        {
            public string lastName;
            public string firstName;
            public string university;
            public string faculty;
            public string department;
            public int age;           
            public int course;
            public int group;
            public string city;

            public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
            {
                this.lastName = lastName;
                this.firstName = firstName;
                this.university = university;
                this.faculty = faculty;
                this.department = department;
                this.age = age;                
                this.course = course;
                this.group = group;
                this.city = city;
            }
        }

        static int MyDelegat(Student st1, Student st2)          
        {
            return String.Compare(st1.firstName, st2.firstName);    // Сравниваем две строки
        }

        static int CompareAge(Student st1, Student st2)
        {
            if (st1.age > st2.age) return 1;
            if (st1.age < st2.age) return -1;
            return 0;
        }
        static int CompareCourse(Student st1, Student st2)
        {
            if (st1.course > st2.course) return 1;
            if (st1.course < st2.course) return -1;
            return 0;
        }

        private delegate bool SortStudent(Student st1, Student st2);

        private static bool SortCourseDel(Student st1, Student st2)
        {
            if (st1.course > st2.course) 
                return true;
            else 
                return false;
        }

        private static bool SortAgeDel(Student st1, Student st2)
        {
            if (st1.age > st2.age)
                return true;
            else
                return false;
        }
        
        static void SortStudents(List<Student> list, SortStudent St)
        {
            for (int i = 0; i < list.Count; i++)
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (St(list[j], list[j+1]))
                    {
                        Student t = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = t;
                    }
                }
        }

        #endregion

        #region Task4 Не делала
        /// <summary>
        /// 4. **Считайте файл различными способами. 
        /// Смотрите “Пример записи файла различными способами”. 
        /// Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), 
        /// строку для StreamReader 
        /// и массив int для BinaryReader.
        /// </summary>

        private static void Task4()
        {
            Print(" ");
        }




        #endregion

    }
}
