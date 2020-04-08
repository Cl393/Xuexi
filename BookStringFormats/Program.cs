using System;
using System.Globalization;
using static System.FormattableString;

namespace BookStringFormats
{
  public  class Program
    {
        static void Main()
        {
            var p1 = new Book("Dio的奇妙冒险", "wryyyyy", 777, "荒木老贼");
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1.ToString("A", null));
            Console.WriteLine($"{p1:N}");
            Console.WriteLine($"{p1:P}");
            Console.ReadLine();
        }

           
        }
    }
