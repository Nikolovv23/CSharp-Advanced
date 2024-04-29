// Look "Tuple" task.
// Create a Class Threeuple. Its name is telling us that it will hold no longer, just a pair of objects. The task is simple, our Threeuple should hold three objects.
// Make it have getters and setters. You can even extend the previous class.
// Input
// The input consists of three lines:
// •	The first one is holding a name, an address and a town. Format of the input:
// { first name}
// { last name}
// { address}
// { town}
// •	The second line is holding a name, beer liters, and a boolean variable with value - drunk or not. Format:
// { name}
// { liters of beer}
// { drunk or not}
// •	The last line will hold a name, a bank balance (double) and a bank name. Format:
// { name}
// { account balance}
// { bank name}
// Output
// •	Print the Threeuples' objects in format:
// "{firstElement} -> {secondElement} -> {thirdElement}"

//          Input
// Adam Smith Wallstreet New York
// Mark 18 drunk
// Karren 0.10 USBank
//          Output
// Adam Smith -> Wallstreet -> New York
// Mark -> 18 -> True
// Karren -> 0.1 -> USBank


namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] nameTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] beerTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] numberTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string citySecondName = "";
            if (nameTokens.Length > 4)
            {
                citySecondName = nameTokens[4];
            }
            Threeuple<string, string, string> adress = new($"{nameTokens[0]} {nameTokens[1]}", nameTokens[2], $"{nameTokens[3]} {citySecondName}");
            Threeuple<string, int , bool> beers = new(beerTokens[0], int.Parse(beerTokens[1]), beerTokens[2] == "drunk");
            Threeuple<string, double, string> numbers = new(numberTokens[0], double.Parse(numberTokens[1]), numberTokens[2]);
            Console.WriteLine(adress);
            Console.WriteLine(beers);
            Console.WriteLine(numbers);

        }
    }
}