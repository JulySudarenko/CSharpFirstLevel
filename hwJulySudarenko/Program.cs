using System;


namespace Lesson_1_JulySudarenko
 
{
    class Program
    {
        static void Main()
        {
            Task1and2();
            MyPrint.Pause();
            Task3();
            MyPrint.Pause();
            Task4();
            MyPrint.Pause();
            Task5();
            MyPrint.Pause();
        }
        //1. Программа "Анкета". Последовательно спросить у пользователя: имя, фамилию, возраст, рост, вес.
        //Вывести результат в одну строчку.
        //а. склеивание
        //б. форматированный вывод
        //в. вывод со знаком $
        
        
        private static void Task1and2()
        {
            Console.WriteLine("Доброго дня! Вас приветствует программа Анкета. Пожалуйста, напишите ваше имя: ");//Будет перенос строки.
            string firstname = Console.ReadLine();
            Console.WriteLine("Приятно познакомиться, " + firstname + "! Напишите Вашу фамилию:");//Склеивание.
            string lastname = Console.ReadLine();
            Console.Write("Сколько Вам лет? ");//Без переноса строки.
            uint age = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Еще интересен ваш рост в сантиметрах: ");
            uint height = Convert.ToUInt32(Console.ReadLine());
            float heightMetre = Convert.ToSingle(height);
            //float heightMetre = (float)height; //Как правильнее делать? Обязательно ли вводить новое имя переменной?
            heightMetre /= 100f;
            Console.Write("Для полноты данных напишите ваш вес в килограммах: ");
            uint weight = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Поступила информация: " + firstname + " " + lastname + " возраст " + age +
                " лет, рост " + "{0:F1}", heightMetre + " вес " + weight); // Склеивание и форматированный вывод.
            Console.WriteLine($"При весе {weight} килограмм, а росте {heightMetre:f1} метров " +
                $"ваш индекс массы тела составляет {BodyMassIndex(weight, heightMetre):f}."); // вывод со знаком $.
                                                                                              //Можно дополнить анализом ИМТ. Отклоняется ли от нормы. Еще можно сравнивать со статистическими данными.
        }
        //2. Рассчитать и вывести индекс массы тела. Формула: BMI = m / (h * h). m = масса тела в килограммах, h = рост в метрах.
        //Входные параметры uint weight в килограммах, float heightMetre в сантиметрах.
        //Выходной параметр float BodyMassIndex (BMI).
        
        
        private static float BodyMassIndex(uint weight, float heightMetre)
        {
            return weight / (heightMetre * heightMetre);
        }
        //3. Программа, которая подсчитывает расстояние между точками с координатами x1, x2, y1, y2.
        //а. Вывести результат, используя спецификатор .2f.
        //б. Оформить в виде метода
        
        
        private static void Task3()
        {
            double x1 = 105.00d;
            double x2 = 237.00d;
            double y1 = 47.67d;
            double y2 = 67.34d;
            Console.WriteLine($"Координаты первой точки ({x1};{y1}).\nКоординаты второй точки ({x2};{y2}).\n" +
                $"В результате вычислений получаем расстояние между точками {Pifagor(x1, x2, y1, y2):f}");
        }
        
        
        private static double Pifagor(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        //4. Программа обмена двух переменных:
        //а. с использованием третьей переменной;
        //б. без использования третьей переменной.
        private static void Task4()
        {
            int a = 17;
            int b = 15;
            Console.WriteLine("a = " + a + ", b = " + b);
            int i = a;
            a = b;
            b = i;
            Console.WriteLine(@"Меняем значения переменных местами используя третью переменную. 
        В итоге a =  " + a + ", b = " + b + ".");//Попробовала перенос с @. Табуляция сохраняется. Пришлось выравнивать самой.
            MyPrint.Pause();
            a += b;
            b = a - b;
            a -= b;
            Console.WriteLine("Меняем значения переменных местами используя сложение.\n" +
                "\tВ итоге a =  " + a + ", b = " + b + ".");//Перенос \n и \t. Мне больше понравилось. 
            MyPrint.Pause();
            a *= b;
            b = a / b;
            a /= b;
            Console.WriteLine("Меняем значения переменных местами используя умножение.\n" +
                "\tВ итоге a =  " + a + ", b = " + b + ".");
            MyPrint.Pause();
            Console.WriteLine("Меняем значения переменных местами используя силу мысли.\n" +
                "\tВ итоге a =  " + b + ", b = " + a + "."); //Ну и на последок третий вариант. 
                                                             //Это магия. После ее применение пользователь будет верить, что а и б изменились :)
        }
        //5.а.Написать программу, которая выводит на экран мое имя, фамилию и город проживание.
        //б. Сделать вывод в центре экрана.
        //в. Сделать задание с использованием собственных методов.
        
        
        private static void Task5()
        {
            Console.Clear();//Если не почистить экран текст наползает друг на друга.
            string fullname = "Юлия Сударенко";
            string homecity = "город Москва";
            int x = Console.WindowWidth / 2;
            int y = Console.WindowHeight / 2;
            MyPrint.PrintXY(fullname, x - fullname.Length / 2, y);
            MyPrint.PrintXY(homecity, x - homecity.Length / 2, y + 1);
        }
        //6. Создать класс с методами, которые могут пригодиться в учебе (Print, Pause).
        
        
        class MyPrint
        {
        //Перемещает курсор в точку с координатами (x, y). И выводит сообщение на экран.
            public static void PrintXY(string message, int x, int y)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(message);
            }
        
            
        //Пауза
            public static void Pause()
            {
                Console.ReadKey();
            }

        }
    }
}
