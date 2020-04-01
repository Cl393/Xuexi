using System;

namespace GetAStringDemo
{
    class Program
    {
        //private delegate string GetAString();

        static void Main()
        {
            int x = 40;
            //GetAString firstStringMethod = new GetAString(x.ToString);
       Func<string> func1 = new Func< string>(x.ToString);

            Console.WriteLine($"String is {func1()}");
            // With firstStringMethod initialized to x.ToString(),
            // the above statement is equivalent to saying
            // Console.WriteLine("String is {0}", x.ToString());

            var balance = new Currency(34, 50);
            Func<string> func2 = new Func<string>(balance.ToString);
            // firstStringMethod references an instance method
            //firstStringMethod = balance.ToString;
            Console.WriteLine($"String is {func2()}");

            // firstStringMethod references a static method
            Func<string> func3 = new Func<string>(Currency.GetCurrencyUnit);

            //firstStringMethod = new GetAString(Currency.GetCurrencyUnit);
            Console.WriteLine($"String is {func3()}");
        }
    }
}
