// Create a generic class Box that can be initialized with any type and store the value. Override the ToString() method and print the type and stored value.
// Input
// •	On the first line, you will get n - the number of strings to read from the console.
// •	On the next n lines, you will get the actual strings.
// o	For each of them, create a box and call its ToString() method to print its data on the console.
// Output
// •	The output should be in the given format:
// "{class full name: value}"

// Input
// 2
// life in a box
// box in a life


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
            Console.WriteLine(box);
        }
    }
}
