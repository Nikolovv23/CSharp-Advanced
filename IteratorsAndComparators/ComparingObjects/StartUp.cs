// Create a class Person. Each person should have a name, an age and a town. You should implement the interface – IComparable<T> and implement the CompareTo method.
// When you compare two people, first you should compare their names, after that – their age and finally – their towns. You will be receiving input with information
// about the people until you receive the "END" command in the following format:
// "{name} {age} {town}"
// After that, you will receive n – the n'th person from your collection, starting from 1. You should keep statistics how many people are equal to him,
// how many people are not equal to him, and the total people in your collection in the following format:
// "{count of total matches} {number of not equal people} {total number of people}"
// If there are no equal people print: "No matches".
// Input
// •	You will be receiving lines in the format described above, until the "END" command.
// •	After the "END" command, you will receive the position of the person you should compare the others to. 
// Note: Start counting the people in your collection from 1.
// Output
// •	Print a single line of output in the format described above.
// Constraints
// •	Input names, ages and addresses will be valid. 
// •	Input number will always be а valid integer in the range [2…100].
// •	The total matches equal the number of people identical to the reference person, plus one (the reference person themself).

//   Input                     Output:
// Peter 22 Varna              No matches
// George 14 Sofia
// END
// 2


namespace IteratorsAndComparatorsExercise
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] information = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = information[0];
                int age = int.Parse(information[1]);
                string town = information[2];

                Person person = new Person() 
                { 
                  Name = name,
                  Age = age,
                  Town = town
                };
                people.Add(person);
            }

            int personIndex = int.Parse(Console.ReadLine());
            Person referencePerson = people[personIndex - 1];

            int equalCount = 0;
            int differentCount = 0;
            foreach (Person person in people)
            { 
                if( person.CompareTo(referencePerson) != 0 )
                {
                    differentCount++;
                }
                else
                {
                    equalCount++;
                }
            }
            if ( equalCount == 1 )
            {
                Console.WriteLine("No matches");
                return;
            }
            Console.WriteLine(equalCount + " " + differentCount + " " + people.Count);
          
        }
    }
}
