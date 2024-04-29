// Add 3 constructors to the Person class from the last task. Use constructor chaining to reuse code:
// •	The first should take no arguments and produce a person with the name "No name" and age = 1. 
// •	The second should accept only an integer number for the age and produce a person with the name "No name" and age equal to the passed parameter.
// •	The third one should accept a string for the name and an integer for the age and should produce a person with the given name and age.

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var person1 = new Person();
            var person2 = new Person(15);
            var person3 = new Person("Ivan", 34);
            Console.WriteLine($"{person1.Name} {person1.Age}");
            Console.WriteLine($"{person2.Name} {person2.Age}");
            Console.WriteLine($"{person3.Name} {person3.Age}");

        }
    }
}
