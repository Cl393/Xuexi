using System;


namespace BookStringFormats
{
    public class Book : IFormattable
    {
        public string BookName { get; }
        public string Press { get; }//出版社
        public double Prean { get; }//价格
        public string Author { get; }//作者
        public Book(string bookName, string press, double prean, string author)
        {
            BookName = bookName;
            Press = press;
            Prean = prean;
            Author = author;
        }
        public override string ToString()
        {
            return BookName + " " + Prean + " " + Press + " " + Author;
        }
        public virtual string ToString(string formats)
        {
            return ToString(formats, null);
        }
        public string ToString(string formats, IFormatProvider formatProvider)
        {
            switch (formats)
            {
                case null:
                case "A":
                    return ToString();
                case "N":
                    return BookName;
                case "P":
                    return $"{ BookName}{Prean}";
                default:
                    throw new FormatException($"invalid format string {formats}");

            }
        }
        public int CompareTo(Book other)
        {
            int compare = BookName?.CompareTo(other?.BookName) ?? -1;  
            if (compare == 0)
            {
                return Author?.CompareTo(other?.Author) ?? -1;     
            }
            return compare;
        }
    }
}

