// Using the Car class, you already created, define another class Engine.
// The class should have private fields for:
// •	horsePower: int
// •	cubicCapacity: double
// The class should also have properties for:
// •	HorsePower: int
// •	CubicCapacity: double
// The class should also have a constructor, which accepts horsepower and cubicCapacity upon initialization

// Create a class Tire.
// The class should have private fields for:
// •	year: int
// •	pressure: double
// The class should also have properties for:
// •	Year: int
// •	Pressure: double
// The class should also have a constructor, which accepts year and pressure upon initialization

// Finally, go to the Car class and create private fields and public properties for Engine and Tire[].Create another constructor,
// which accepts make, model, year, fuelQuantity, fuelConsumption, Engine and Tire[] upon initialization

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Tire[] tires = new Tire[4]
            {
                new Tire(1, 2.5),
                new Tire(1, 2.1),
                new Tire(2, 0.5),
                new Tire(2, 2.3)
            };

            Engine engine = new Engine(560, 6300);
            Car car = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);
        }
    }
}