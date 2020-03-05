using System;
using System.Text;
using static Lesson_2_CSharp_Lvl1.ViewJulyS;

namespace Lesson_5_CSharp_Lvl1
{
    class Message
    {
        #region Task2
        /// <summary>
        /// 2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста: 
        /// а) Вывести только те слова сообщения,  которые содержат не более n букв. 
        /// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ. 
        /// в) Найти самое длинное слово сообщения.
        /// г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        /// д) *** Создать метод, который производит частотный анализ текста.
        /// В качестве параметра в него передается массив слов и текст, 
        /// в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
        /// Здесь требуется использовать класс Dictionary.
        /// </summary>

        private string _mes;

        public Message()
        {
            _mes = Console.ReadLine();
        }

        public Message(string mes)
        {
            _mes = mes;
        }

        public int Length
        {
            get
            {
                return _mes.Length;
            }
        }

        public override string ToString()
        {
            return _mes;
        }

        public string Join(string[] str)
        {
            _mes = String.Join(" ", str);
            return _mes;
        }

        //public string Concat(string str)
        //{
        //    return _mes.Concat(str);
        //}
        
        public string[] Split(char[] a)
        {
            return _mes.Split(a);
        }

        public string[] SplitWords(Message mes)
        {
            char[] gap = { ' '};
            return mes.Split(gap);
        }

        

        public static void CountLetters(Message mes, int n)
        {

            string[] parts = mes.SplitWords(mes);
            string str = String.Empty;

            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Length <= n)
                {
                    str = $"{str} {parts[i]}";
                }
            }
            Print(str);
        }

        public static void LastLetter(Message mes, string letter)
        {
            string[] parts = mes.SplitWords(mes);
            string str = String.Empty;

            for (int i = 0; i < parts.Length; i++)
            {
                if (!parts[i].EndsWith(letter))
                {
                    str = $"{str} {parts[i]}";
                }
                
                //    str.Join(parts); //работает, но собирает все выражение.
            }
            Print(str);
        }

        public static int Max(Message mes)
        {
            string[] parts = mes.SplitWords(mes);
            int max = parts[0].Length;

            for (int i = 1; i < parts.Length; i++)
                if (parts[i].Length > max)
                {
                    max = parts[i].Length;
                }
            return max;
        }

        public static void MaxWord(Message mes)
        {
            string[] parts = mes.SplitWords(mes);
            int max = Max(mes);
            int indexMax = 0;

            for (int i = 1; i < parts.Length; i++)
                if (parts[i].Length == max)
                {
                    indexMax = i;
                }
            Print(parts[indexMax]);
        }

        public static void BigWords(Message mes)
        {
            string[] parts = mes.SplitWords(mes);
            int max = Max(mes);
            StringBuilder str = new StringBuilder(20);
            
            for (int i = 1; i < parts.Length; i++)
            {
                if (max == parts[i].Length)
                    str.Append($"{parts[i]} ");
            }
            Print(str);
        }

        #endregion
    }
}
