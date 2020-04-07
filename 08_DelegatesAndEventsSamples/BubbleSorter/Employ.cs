using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSorter
{
    class Employ
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static string Print(Employ emp) => $"员工ID：{emp.ID},姓名：{emp.Name}";
        public static bool CompareName(Employ e1, Employ e2) =>
            e1.Name.CompareTo(e2.Name) < 1 ? true : false;
    }
}
