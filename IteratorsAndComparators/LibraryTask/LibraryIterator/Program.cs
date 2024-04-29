// Extend your solution from the previous task. Inside the Library, create a nested class LibraryIterator, which should implement the IEnumerator<Book> interface.
// Try to implement the bodies of the inherited methods by yourself. You will need two more members:
// •	List<Book> books
// •	int currentIndex
// Now you should be able to iterate through a Library in the Main method.

namespace IteratorsAndComparators
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002,
                "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

            foreach (var book in libraryTwo)
            {
                Console.WriteLine(book.Title);
            }

        }
    }
}
