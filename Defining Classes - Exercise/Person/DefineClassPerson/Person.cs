// Define a class Person with private fields for name and age and public properties Name and Age.

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public string Name 
        { 
            get => name;
            set => name = value;
        }
        public int Age 
        {
            get => age;
            set => age = value;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person() 
        {
            
        }
    }
}
