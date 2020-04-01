using System;

namespace Wrox.ProCSharp.Delegates
{
    delegate double DoubleOp(double x);

    class Program
    {
        static void Main()
        {

            Func<double, double> func1 = new Func<double, double>(MathOperations.MultiplyByTwo);
            Func<double, double> func2 = new Func<double, double>(MathOperations.Square);
            double d1 = 2.2;
            double d2 = 3.3;
            double d3 = 0;
            d3 = func1.Invoke(d1);
            Console.WriteLine(d3);
            d3 = func2.Invoke(d2);
            Console.WriteLine(d3);


            DoubleOp[] operations =
            {
                MathOperations.MultiplyByTwo,
                MathOperations.Square
            };

            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine($"使用 operations[{i}]:");
                ProcessAndDisplayNumber(operations[i], 2.0);
                ProcessAndDisplayNumber(operations[i], 7.94);
                ProcessAndDisplayNumber(operations[i], 1.414);
                Console.WriteLine();
            }
        }

        static void ProcessAndDisplayNumber(DoubleOp action, double value) =>
            Console.WriteLine($"原始数据：{value}, 对数据处理后： {action(value)}");
    }
}
