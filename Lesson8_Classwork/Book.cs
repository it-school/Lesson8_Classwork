using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Classwork
{
    class Book
    {
        string title;
        string []authors;
        Publisher publisher;
        ushort pages;
        ushort year;

        public string Title { get => title; set => title = value; }
        public ushort Pages { get => pages; set => pages = (value < 5000 ? value : (ushort)0); }
        public ushort Year { get => year; set => year = (value > 2019 ? (ushort)2019 : value); }
        public string[] Authors { get => authors; set => authors = value; }
        internal Publisher Publisher { get => publisher; set => publisher = value; }

        public Book(string title, string[] authors, Publisher publisher, ushort pages, ushort year)
        {
            this.title = title;
            this.authors = authors;
            this.Publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public Book()
        {
        }

        public Book(string title, string authors, Publisher publisher, ushort pages, ushort year)
        {
            this.title = title;
            this.authors = authors.Split(',');
            for (int i = 0; i < this.authors.Length; i++)
                this.authors[i] = this.authors[i].Trim();

            this.Publisher = publisher;
            this.pages = pages;
            this.year = year;
        }
        public override string ToString()
        {
            if (this.title != null)
            {
                string authors = this.authors[0];
                for (int i = 1; i < this.authors.Length; i++)
                    authors += ", " + this.authors[i];

                return this.title + "\n" + authors + "\n" + this.Publisher + "\npages: " + this.pages + "\nyesr: " + this.year;
            }
            else
                return "";
        }

        public bool Equals(Book book) 
        {
            bool result = false;

            if (this.title != null && book.title != null && this.title.ToLower().Equals(book.title.ToLower()))
                result = true;

            return result;
        }
    }
}
