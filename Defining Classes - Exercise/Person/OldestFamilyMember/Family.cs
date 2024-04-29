namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people = new List<Person>();
        public void AddMember(Person person)
        {
          people.Add(person);
        }
        public Person GetOldestMember()
        {
            //int maxAge = people.Max(person => person.Age);
            //Person oldestPerson = people.FirstOrDefault(person => person.Age == maxAge);
            //return oldestPerson;
            return people.FirstOrDefault(p => p.Age == people.Max(p => p.Age));
        }
    }
    
}
