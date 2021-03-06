﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookStringFormats
{
    public class Person : IFormattable
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString() => FirstName + " " + LastName;

        public virtual string ToString(string format) => ToString(format, null);


        public string ToString(string format, IFormatProvider formatProvider)
        {
            switch (format)
            {
                case null:
                case "A":
                    return ToString();
                case "F":
                    return FirstName;
                case "L":
                    return LastName;
                case "C": return $"{LastName} {FirstName}";
                default:
                    throw new FormatException($"invalid format string {format}");
            }
        }
    }
}
 
