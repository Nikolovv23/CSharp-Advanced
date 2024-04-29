// Let's play a game. You have a tiny little Frog and a Lake that has a path of stones in it. Every stone has a number.
// Our frog must cross the lake along that path and then return. But there are some rules. First, the frog must jump on all the stones,
// which are in even positions in ascending order, and then on all the odd ones, but in reversed order.
// The order of the stones and their numbers will be given on the first line of input. Then you must print the order of stones in which
// our frog jumped from one to another.
  
// Try to achieve this functionality by creating a class Lake(it will hold all stone numbers in order) that implements the IEnumerable<int> interface
// and overrides its GetEnumerator() methods.

// Input                                          Output
// 1, 2, 3, 4, 5, 6, 7, 8                         1, 3, 5, 7, 8, 6, 4, 2

namespace IteratorsAndComparatorsExercise
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List <int> list = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Lake lake = new Lake(list);
            string result = string.Join(", ", lake);
            Console.WriteLine(result);
        }
    }
}
