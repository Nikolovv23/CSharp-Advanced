// Create a class DateModifier, which stores the difference of the days between two dates.
// It should have a method that takes two string parameters, representing dates as strings and calculates the difference in the days between them. 

// Input:               Output:
// 1992 05 31           8783
// 2016 06 17

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] dates = new string[2];
            for (int i = 0; i < 2; i++)
            {
               dates[i] = Console.ReadLine();
            }
            DateModifier dateModifier = new DateModifier(dates[0], dates[1]);
            Console.WriteLine(dateModifier.DifferenceInDays);
        }
    }
}
