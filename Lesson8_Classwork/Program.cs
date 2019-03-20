using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Title", new string[] { "Author1" }, new Publisher("BHV", "Ukraine"), 1000, 2019);
            Book book2 = new Book("Title", "Author2, Author3", new Publisher("BHV", "Ukraine"), 1000, 2019);
            //Console.WriteLine(book1);
            //Console.WriteLine(book2);


            Library library2 = new Library(5);

            library2.AddBook(book1);
            library2.AddBook(book2);
            library2.AddBook(book2);
            library2.AddBook(book2);
            library2.AddBook(book2);
            library2.AddBook(book2);
            library2.AddBook(new Book("Azbooka", "ABVGDEIKIN, ABCshkin", new Publisher("Lorry", "London"), 40, 1990));

            //Console.WriteLine(library2);
            //Console.WriteLine(library2.FindByAuthor("ABV"));
            Library library1 = library2.GetLibraryByAuthor("AB");
            Console.WriteLine(library1);

        }
    }
}
