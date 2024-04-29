//Create a method that receives as an argument a list of any type, that can be compared and an element of the given type.
//The method should return the count of elements that are greater than the value of the given element.
//Modify your Box class to support comparison by the value of the stored data.
//Input
//•	 On the first line, you will receive n - the number of elements to add to the list.
//•	 On the next n lines, you will receive the actual elements.
//•	 On the last line, you will get the value of the element for comparison.
//Output
//•	Print the count of elements that are larger than the value of the given element.

// Input:          Output:
// 3               2
// aa
// aaa
// bb
// aa

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < lines; i++)
            {
                box.Add(Console.ReadLine());
            }
            string compareWith = Console.ReadLine();
            Console.WriteLine(box.Count(compareWith));
        }
    }
}