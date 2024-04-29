// Create a public class named Car within the namespace CarManufacturer:
// Define in the above class private fields for:
// •	make: string
// •	model: string
// •	year: int
// The class should also have public properties for:
// •	Make: string
// •	Model: string
// •	Year: int

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car();
            car.Make = "Honda";
            car.Model = "civic";
            car.Year = 1012;
            Console.WriteLine($"Make: {car.Make} \nModel:{car.Model} \nYears:{car.Year}");
        }
    }
}
