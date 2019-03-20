using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Classwork
{
    class Library
    {
        private Book[] books;
        int n;

        public Book[] Books { get => books; }

        public Library()
        {
            this.n = 0;
            this.books = new Book[n];
        }

        public Library(int n)
        {
            this.n = n;
            this.books = new Book[n];
            for (int i = 0; i < n; i++)
            {
                this.books[i] = new Book();
            }
        }

        public void AddBook(Book book)
        {
            int i;
            if (this.n > 0)
            {
                for (i = this.books.Length - 1; i >= 0; i--)
                {
                    if (this.books[i] != null)
                        break;
                }
                this.n = i+1;
            }

            this.n++;
            Array.Resize(ref this.books, this.n);
            this.books[n - 1] = book;
        }

        public override string ToString()
        {
            string result = "";
            /*
            for (int i = 0; i < this.books.Length; i++)
                if (this.books[i].Title != null)
                    result += this.Books[i] + "\n--------------------------\n";
                    */

            foreach (Book item in this.books)
                if (item.Title != null)
                    result += item + "\n-----------------------\n";

            return result;
        }

        public string FindByAuthor(string authorName)
        {
            string result = "";


            foreach (Book book in this.Books)
            {
                if (book.Title != null)
                {
                    foreach (string author in book.Authors)
                    {
                        if (author.ToLower().Contains(authorName.ToLower()))
                            result += book + "\n\n";
                    }
                }
            }

            return result;
        }


        public Library GetLibraryByAuthor(string authorName)
        {
            Library library = new Library();
            bool flag = false;

            foreach (Book book in this.Books)
            {
                if (book.Title != null)
                {
                    foreach (string author in book.Authors)
                    {
                        if (author.ToLower().Contains(authorName.ToLower()))
                        {
                            flag = false;
                            foreach (Book item in this.books)
                            {
                                if (item.Equals(book))
                                {
                                    flag = true;
                                    break;
                                }
                            }
                            if (flag == false || library.books.Length == 0)
                                library.AddBook(book);
                        }
                    }
                }
            }

            return library;
        }

    }
}
