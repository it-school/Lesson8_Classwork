using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Classwork
{
    class Publisher
    {
        string title;
        string country;

        public string Title { get => title; set => title = value; }
        public string Country { get => country; set => country = value; }

        public Publisher(string title, string country)
        {
            this.title = title;
            this.country = country;
        }

        public override string ToString()
        {
            return this.title + ", " + this.country;
        }
    }
}
