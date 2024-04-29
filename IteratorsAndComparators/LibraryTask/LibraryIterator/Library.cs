using System.Collections;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book >
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = books.ToList();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private int CurrentIndex = -1;
            private readonly List<Book> books;

            public LibraryIterator(List<Book> books)
            {
                this.books = books;
            }

            public Book Current => books[CurrentIndex];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
    
            }

            public bool MoveNext()
            {
               return ++ CurrentIndex < books.Count;
            }

            public void Reset()
            {
                CurrentIndex = -1;
            }
        }
    }
}
