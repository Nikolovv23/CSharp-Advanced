
// A Tuple is a class in C#, in which you can store a few objects. First, we are going to focus on the Tuple's type, which contains two objects.
// The first one is "item1" and the second one is "item2". It is kind of like a KeyValuePair, except – it simply has items, which are neither key nor value.
// Your task is to create a class "Tuple", which holds two objects. The first one will be "item1" and the second one – "item2".
// The tricky part here is to make the class hold generics. This means, that when you create a new object of class – "Tuple",
// there should be a way to explicitly specify both items' types separately.
// Input
// The input will be valid!
// The input consists of three lines:
// •	The first one holds a person's name and an address. They are separated by space(s). Your task is to collect them in the tuple and print them on the console.
// Format of the input:
// {first name} { last name}
// { address}
// •	The second line holds a name of a person and the amount of beer (int) he can drink. Format:
// { name}
// { liters of beer}
// •	The last line holds an integer and a double. Format:
// { integer}
// { double}
// Output
// •	Print the tuples' items in format: {item1} -> {item2}

//       Input
// Adam Smith California
// Mark 2
// 23 21.23212321
//       Output
// Adam Smith -> California
// Mark -> 2
// 23	-> 21.23212321



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
            double[] numberTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            CustomTuple<string, string> adress = new($"{nameTokens[0]} {nameTokens[1]}", nameTokens[2]);
            CustomTuple<string, int> beers = new(beerTokens[0], int.Parse(beerTokens[1]));
            CustomTuple<double, double> numbers = new(numberTokens[0], numberTokens[1]);
            Console.WriteLine(adress);
            Console.WriteLine(beers);
            Console.WriteLine(numbers);

        }
    }
}