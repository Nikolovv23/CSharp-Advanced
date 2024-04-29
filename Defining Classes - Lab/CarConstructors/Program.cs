// Using the class from the "Car Extension" problem create one parameterless constructor with default values:
// •	Make – VW
// •	Model – Golf
// •	Year – 2025
// •	FuelQuantity – 200
// •	FuelConsumption – 10
// Create a second constructor accepting make, model and year upon initialization and call the base constructor with its default values for
// fuelQuantity and fuelConsumption.

//Create a third constructor accepting make, model, year, fuelQuantity and fuelConsumption upon initialization and reuse the second constructor to set the make,
//model and year values.

// Go to StartUp.cs file and make 3 different instances of the class Car, using the different overloads of the constructor.
namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);
            Console.WriteLine(firstCar.WhoAmI());
            Console.WriteLine(secondCar.WhoAmI());
            Console.WriteLine(thirdCar.WhoAmI());

        }
    }
}

