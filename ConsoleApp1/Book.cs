using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string atitle,string Author,int Pages)
        {
            title = atitle;
            author = Author;
            pages = Pages;
            Console.WriteLine("creating book");
        }
    }
}
