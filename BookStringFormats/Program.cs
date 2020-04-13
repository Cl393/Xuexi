using System;
using System.Globalization;
using static System.FormattableString;
using System.Collections.Generic;

namespace BookStringFormats
{
    public class Program
    {
        static void Main()
        {
            FormattedStringDemo();
            DateAndNumbers();
            FormattedStringDemo();
            MoreFormattableString();
            UseCustomIFormattable();
            Book();
            //var p1 = new Book("Dio的奇妙冒险", "wryyyyy", 777, "荒木老贼");
            //Console.WriteLine(p1.ToString());
            //Console.WriteLine(p1.ToString("A", null));
            //Console.WriteLine($"{p1:N}");
            //Console.WriteLine($"{p1:P}");
            Console.ReadLine();

            
        }

        static void UseCustomIFormattable()
        {
            var p1 = new Person("Stephanie", "Nagel");
            Console.WriteLine(p1.ToString("C"));
            Console.WriteLine($"{p1:F}");
        }

        public static void FormattedStringDemo()
        {
            DateTime today = DateTime.Today;

            string s = "Hello";
            Console.WriteLine($"{{s}} displays the value of s: {s}");

            string formatString = $"{s}, {{0}}";
            string s2 = "World";

            Console.WriteLine(formatString, s2);
            Console.WriteLine($"{today:D}");

            var day = new DateTime(2025, 2, 14);
            Console.WriteLine($"{day:d}");
            Console.WriteLine(Invariant($"{day:d}"));
            string a1 = "a";
            int a2 = 3;
            double a3 = 3.4;
            ShowDetails($"a1: {a1} a2: {a2} a3: {a3}");
        }

        public static void MoreFormattableString()
        {
            int x = 3, y = 4;
            FormattableString s = $"The result of {x} + {y} is {x + y}";
            Console.WriteLine($"format: {s.Format}");
            for (int i = 0; i < s.ArgumentCount; i++)
            {
                Console.WriteLine($"argument {i}: {s.GetArgument(i)}");
            }
        }

        public static void ShowDetails(FormattableString s)
        {
            Console.WriteLine($"argument count: {s.ArgumentCount}");
            Console.WriteLine($"format: {s.Format}");
            for (int i = 0; i < s.ArgumentCount; i++)
            {
                Console.WriteLine($"Argument {i}: {s.GetArgument(i)}");
            }
        }

        public static void DateAndNumbers()
        {
            var now = new DateTime(2025, 2, 1);
            Console.WriteLine($"{now:D}");
            Console.WriteLine($"{now:d}");
            Console.WriteLine($"{now:dd-MMM-yyyy}");

            int i = 2477;
            Console.WriteLine($"{i:n} {i:e} {i:x} {i:c}");
            double d = 3.1415;
            Console.WriteLine($"{d:###.###}");
            Console.WriteLine($"{d:000.000}");
            Console.WriteLine($"{i:n2}");
        }
        public static void Book()
        {
            var p1 = new Book("Dio的奇妙冒险", "wryyyyy", 777, "荒木老贼");
            var p2 = new Book("Dio的奇妙冒险2", "wryyyyy", 777, "荒木老贼1");
            var p3 = new Book("Dio的奇妙冒险3", "wryyyyy", 777, "荒木老贼2");
            var books = new List<Book>(20) { p1, p2, p3 }; //集合
            books.Add(new Book("吉良吉影的奇妙冒险", "wryyyyy", 523, "荒木小号"));
            books.Add(new Book("迪亚波罗", "ゴゴゴゴゴ", 753, "荒木小号"));
            books.Sort(new Compare(CompareToBook.Prean));
            // remove elements
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine(books[i]);
            }
            Book book = books.Find(r => r.Author == "荒木小号");

            int zsIndex = books.FindIndex(r => r.Author == "荒木小号");

            List<Book> zsAll = books.FindAll(r => r.Author == "荒木小号");
            //Exists检索
            if (books.Exists(r => r.BookName == "迪亚波罗"))
            {
                Console.WriteLine("查询成功！");
            }
            else
            {
                Console.WriteLine("没有此出版号的书");

            }
            var index5 = books.BinarySearch(0, 5, p2, new Compare(CompareToBook.BookName));
            Console.WriteLine(index5);
        }

        private static void Display(List<string> list)
        {
            Console.WriteLine();
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }

}
