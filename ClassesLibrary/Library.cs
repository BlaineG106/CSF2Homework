using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Library
    {
        //fields
        //properties
        public List<Book> BookList { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        //CTORS
        public Library(List<Book> bookList, string libraryName, string streetAddress, string city, string state, string zip)
        {
            BookList = bookList;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }

        public Library() { }

        //methods
        public override string ToString()
        {
            string booksNeeded = "";

            foreach (Book b in BookList)
            {
                booksNeeded += b + "\n";
            }
            return string.Format("Books: {0}\n" +
                "Library Name = {1}\n" +
                "Street Address: {2}\n" +
                "City: {3}\n" +
                "State: {4}\n" +
                "Zip: {5}\n",
                booksNeeded, LibraryName, StreetAddress, City, State, Zip);
        }

    }
}
