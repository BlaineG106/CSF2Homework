using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Book
    {
        //fields
        //properties
        public string Title { get; set; }
        public string Author { get; set; }
        public int NbrOfPages { get; set; }

        //FQCTOR
        public Book(string title, string author, int nbrOfPages)
        {
            Title = title;
            Author = author;
            NbrOfPages = nbrOfPages;
        }//end FQCTOR

        public Book() { }

        //Method
        public override string ToString()
        {
            return string.Format("Title: {0}\n" +
                "Author: {1}\n" +
                "Number of Pages: {2}\n",
                Title, Author, NbrOfPages);
        }//end ToString()
    }//end class
}//end namespace 
