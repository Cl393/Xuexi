using System;
using System.Collections.Generic;
using System.Text;

namespace AttributeSample
{
    public class AttributeUsageClass
    {
        public string Title { get; set; }
        public int Number { get; set; }

        public AttributeUsageClass(string title, int number)
        {
            Title = title;
            Number = number;
        }
        [Characteristic("乔鲁诺·乔巴纳", 16)]

        public void Print()
        {
            Console.WriteLine($"{Title}:{Number}");
        }

        public class MyAttributeUsageClass
        {
            public string Title { get; set; }
            public int Number { get; set; }

            public MyAttributeUsageClass(string title, int number)
            {
                Title = title;
                Number = number;
            }
            [Characteristic("黄金体验", 16)]
            public void Print()
            {
                Console.WriteLine($"{Title}:{Number}");
            }
        }
    }
}
