// Rewrite the "GenericCountMethodString" program to work with double values and test
// Input:          Output:
// 3               2
// 7.13
// 123.22
// 42.78
// 7.55

using System.Globalization;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            for (int i = 0; i < lines; i++)
            {
                box.Add(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            }
            double compareWith = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine(box.Count(compareWith));
        }
    }
}