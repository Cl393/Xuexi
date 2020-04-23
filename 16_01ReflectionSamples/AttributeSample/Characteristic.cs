using System;
using System.Collections.Generic;
using System.Text;

namespace AttributeSample
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
  public  class Characteristic:Attribute
    {
        public string Title { get; set; }
        public int Number { get; set; }
        // 有两个必选参数
        public Characteristic(string title, int number)
        {
            Title = title;
            Number = number;
        }
        public Characteristic(string title)
        {
            Title = title;


    }
}
