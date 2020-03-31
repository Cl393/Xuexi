using System;
using System.Collections.Generic;

namespace CopyingElements
{
    class Program
    {
        public static List<T> CopyAtMost<T>(List<T> input, int maxElements)
        {
            int actualCount = Math.Min(input.Count, maxElements);
            List<T> ret = new List<T>(actualCount);
            for (int i = 0; i < actualCount; i++)
            {
                ret.Add(input[i]);
            }
            return ret;
        }
        static void Main(string[] args)
        {

            List<Student> Stu = new List<Student>()
            {
                new Student {Id=999,Name="人以虚"},
                new Student {Id=777,Name="小李子"}
            };



            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(20);
            List<Student> firstTwo = CopyAtMost<Student>(Stu, 2);
            Console.WriteLine(firstTwo.Count);
        }
    }
}
