// Rewrite the "GenericSwapMethodString" program to work with integers and test
//     Input
// 3
// 7
// 123
// 42
// 0 2

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<int>list = new();
            for (int i = 0; i < lines; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));  
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
