using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe_1
{
    class Book
    {
        public string author;
        public string title;
        public string description;
        private int pageCount;

        public Book()
        {
            Console.WriteLine("Creating Book");
            author = "";
            title = "";
            description = "";
            pageCount = 0;
        }
        public Book(string bookName)
        {
            Console.WriteLine("Creating Book");
            author = "";
            title = bookName;
            description = "";
            pageCount = 0;
        }
        public Book(string bookName, string bookAuthor, int bookPages)
        {
            Console.WriteLine("Creating Book");
            author = bookAuthor;
            title = bookName;
            description = "";
            pageCount = 0;
            PageCount = bookPages;
        }
        public int PageCount
        {
            get { return pageCount; }
            set { pageCount = value > 0 ? value: pageCount ; }
        }

    }
}
