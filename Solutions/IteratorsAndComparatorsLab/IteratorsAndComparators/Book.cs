using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        private string title;
        private int year;
        private List<string> authors;

        public Book(string title, int year, params string[] authors) 
        {
            this.title = title;
            this.year = year;
            this.authors = new List<string>(authors);
        }

        public string Title { get { return title; } set { title = value; } }
        public int Year { get { return year;} set { year = value; } }
        public List<string> Authors { get { return authors; } set { authors = value; } }

        public int CompareTo(Book other)
        {
            if(Year < other.year)
            {
                return -1;
            }
            else if(Year > other.Year)
            {
                return 1;
            }
            return Title.CompareTo(other.Title);
        }

        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
}
