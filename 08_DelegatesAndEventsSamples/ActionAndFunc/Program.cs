using System;

namespace ActionAndFunc
{
    
    class Program
    {
        private delegate int Fun(int x,int y);
        private delegate void Acti();
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            //Action action = new Action(calculator.Report);

            Acti acti = new Acti(calculator.Report);
            calculator.Report();    //
            acti.Invoke();         //等价三联
            acti();               //


            //Func<int, int, int> func1 = new Func <int, int, int>(calculator.Add);
            //Func<int, int, int> func2 = new Func<int, int, int>(calculator.Sub);
           Fun fun = new Fun(calculator.Sub);
            int x = 100;
            int y = 200;
            int z = 0;
            int z1 = 0;
            z = fun.Invoke(x, y);
            Console.WriteLine(z);


            z1 = calculator.Add(x,y);//调用Add方法，输出Z1数据
            z = fun.Invoke(x, y);
            Console.WriteLine(z1);

        }
    }
}
