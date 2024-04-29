// Use your Person class from the previous tasks. Create a class Family. The class should have a list of people, a method for adding members -
// void AddMember(Person member) and a method returning the oldest family member – Person GetOldestMember(). Write a program that reads the names
// and ages of N people and adds them to the family. Then print the name and age of the oldest member.

// Input:                 Output:
// 3                      Annie 5
// Peter 3
// George 4
// Annie 5

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine()); 
            Family family = new Family();
            for (int i = 0; i < numberOfLines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var person = new Person(input[0], int.Parse(input[1]));
                family.AddMember(person);
            }
            Person oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
