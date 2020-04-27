using System;

namespace DynamicFileText
{
    class Program
    {
        static void Main(string[] args)
        {
            var helper = new Dynamic();
            var employeeList = helper.ParseFile("TextFile.txt");
            foreach (var employee in employeeList)
            {
                Console.WriteLine($"{employee.Name} {employee.Sex}");
            }
            Console.ReadLine();
        }
    }
}
