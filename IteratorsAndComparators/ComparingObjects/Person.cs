﻿namespace IteratorsAndComparatorsExercise
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo(Person other)
        {
            int result = Name.CompareTo(other.Name);
            if (result == 0)
            {
                result = Age.CompareTo(other.Age);
                if (result == 0)
                {
                    result = Town.CompareTo(other.Town);
                }
            }
            return result;
        }
    }
}
