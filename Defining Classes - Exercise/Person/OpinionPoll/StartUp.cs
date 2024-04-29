// Using the Person class, write a program that reads from the console N lines of personal information and then prints all people,
// whose age is more than 30 years, sorted in alphabetical order.

// Input:
// 3
// Peter 12
// Sam 31
// Ivan 48

// Output:
// Ivan - 48
// Sam - 31


namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine()); 
            List<Person> people = new List<Person>();
            for (int i = 0; i < numberOfLines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var person = new Person(input[0], int.Parse(input[1]));
                people.Add(person);
            }
            var orderedPeople = people
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToList();
            foreach (Person person in orderedPeople)
            {
                 Console.WriteLine(person.Name + " - " + person.Age);
            }
        }
    }
}
