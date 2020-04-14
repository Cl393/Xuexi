using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodsS
{
 public static   class ExtensionClass
    {
        public static bool IsCapitalized(this string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            return char.IsUpper(s[0]);
        }


        public static string GetStar(this string c,int count)
        {
            
            return c.PadRight(c.Length+count,'*');
        }
    }
}
