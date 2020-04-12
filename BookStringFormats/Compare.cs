using System;
using System.Collections.Generic;
using System.Text;

namespace BookStringFormats
{

    public enum CompareToBook
    {
        BookName,
        Press,//出版社
        Prean,//价格
        Author
    }


    class Compare:IComparer<Book>
    {
        private CompareToBook _compareToBook;
        public Compare(CompareToBook compareType)
        {
            _compareToBook = compareType;
        }

        int IComparer<Book>.Compare(Book x, Book y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            int books;
            switch (_compareToBook)
            {
                case CompareToBook.BookName:
                    books = string.Compare(x.BookName, y.BookName);
                    break;
                case CompareToBook.Author:
                    books = string.Compare(x.Author, y.Author);
                    break;

                case CompareToBook.Prean:
                    books = x.Prean.CompareTo(y.Prean);
                    break;
                default:
                    throw new ArgumentException("Invalid Compare Type");
            }
            return books;
        }
    }
}
