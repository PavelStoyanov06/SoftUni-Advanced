using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books) 
        {
            this.books = new SortedSet<Book>(books, new BookComparator()).ToList();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            //for (int i = 0; i < books.Count; i++)
            //{
            //    yield return books[i];
            //}
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> list;

            private int index = -1;

            public LibraryIterator(List<Book> list)
            {
                this.list = new List<Book>(list);
            }

            public Book Current { get { return list[index]; } }

            object IEnumerator.Current => Current;

            public void Dispose() { }

            public bool MoveNext()
            {
                index++;
                if(index >= list.Count)
                {
                    return false;
                }
                return true;
            }

            public void Reset()
            {
                index = 0;
            }
        }
    }
}
