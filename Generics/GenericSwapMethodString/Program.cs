// Create a generic method that receives a list, containing any type of data and swaps the elements at two given indexes.
// Input
// •	On the first line, you will read n number of boxes of type string and add them to the list.
// •	On the next line, however, you will receive a swap command consisting of two indexes.
// Output
// •	Use the method you've created to swap the elements that correspond to the given indexes and print each element in the list.
//       Input
// 3
// Peter
// George
// Swap me with Peter
// 0 2
//       Output
// System.String: Swap me with Peter
// System.String: George
// System.String: Peter



namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<string>list = new();
            for (int i = 0; i < lines; i++)
            {
                list.Add(Console.ReadLine());  
            }
            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            GenericSwap(list, indexes[0], indexes[1]);
            foreach (var item in list)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
            
        }
        public static void GenericSwap<T>(List<T> items, int firstIndex, int secondIndex)
        {
            //Option1
            /* T temp = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = temp;*/

            (items[firstIndex], items[secondIndex]) = (items[secondIndex], items[firstIndex]);
        }
    }
}
