using System;
using System.Reflection;
using System.Text;
using static AttributeSample.Characteristic;

namespace AttributeSample
{
    class Program
    {
        static void Main(string[] args)
        {

            Type ty=typeof(MyAttributeUsageClass);
            var Fan = ty.GetMethod("Print");
            Characteristic text = (Characteristic)Fan.GetCustomAttribute(typeof(Characteristic), true);

            ConstructorInfo[] ciArray = ty.GetConstructors(); //获取类的所有构造函数
            foreach (var item in text.Title)
            {
                Console.WriteLine(text.Title);
                Console.WriteLine("OK");
            }
            Console.ReadLine();
            //Console.WriteLine("Hello World!");
        }
    }
}
