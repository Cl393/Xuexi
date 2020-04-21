using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncReturnValueTpye
{
    static class DoAsyncStuffValueTask
    {

        //private static int GetSum(int x, int y)   
        //{
        //    return x + y;
        //}

        private static double GetInvolution(double x)
        {
            return x * x;
        }
        //private static async ValueTask<int> CalculateSumAsync(int x, int y)
        //{
        //    //如果参数1为0，无须进去任务调用，加快程序执行效率
        //    if (x == 0)
        //    {
        //        return y;
        //    }
        //    int sum = await Task.Run(() => GetSum(x, y));
        //    return sum;
        //}
        private static async ValueTask<double> CalculateInvolutionAsync(double x)
        {

            var power = await Task.Run(() => GetInvolution(x));
            return power;
        }
        //static public void CallAsyncMethodReturnValueTask()
        //{
        //    Console.WriteLine("调用返回值为ValueTask的异步方法");
        //    ValueTask<int> value = CalculateSumAsync(0, 6);
        //    //（如有需要） 此处可以做其它事情 ...          
        //    Console.WriteLine($"ValueTask1: {value.Result}");           
        //    value = CalculateSumAsync(5, 6);
        //    //（如有需要） 此处可以做其它事情 ...         
        //    Console.WriteLine($"ValueTask2: {value.Result}");
        //    Console.WriteLine("其它处理4");
        //}

        static public void CallAsyncMethodReturnValueTask()
        {
            Console.WriteLine("调用返回值为ValueTask的异步方法");
            ValueTask<double> value = CalculateInvolutionAsync(4);
            //（ 此处可以做其它事情         
            Console.WriteLine($"ValueTask1: {value.Result}");
            value = CalculateInvolutionAsync(5);
            //此处可以做其它事情       
            Console.WriteLine($"ValueTask2: {value.Result}");
            Console.WriteLine("其它处理4");
        }

    }
}
