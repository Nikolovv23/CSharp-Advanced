// Define a class Person with private fields for name and age and public properties Name and Age.

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person Peter = new Person
            { 
               Name = "Peter",
               Age = 20
            };
            Person George = new Person("George", 18);
            var Jose = new Person("Jose", 43);

            Console.WriteLine($"{Peter.Name} : {Peter.Age}");
            Console.WriteLine($"{George.Name} : {George.Age}");
            Console.WriteLine($"{Jose.Name} : {Jose.Age}");


        }
    }
}
