
// This is the final and most interesting problem in this lab. Until you receive the command "No more tires", you will be given tire info in the format:
// { year}
// { pressure}
// { year}
// { pressure}
// …
// "No more tires"
// You have to collect all the tires provided. Next, until you receive the command "Engines done" you will be given engine info and you also have to collect
// all that info.
// {horsePower} { cubicCapacity}
// { horsePower}
// { cubicCapacity} 
// …
// The final step - until you receive "Show special", you will be given information about cars in the format:
// { make}
// { model}
// { year}
// { fuelQuantity}
// { fuelConsumption}
// { engineIndex}
// { tiresIndex}
// …
// Every time you have to create a new Car with the information provided. The car engine is the provided engineIndex and the tires are tiresIndex.
// Finally, collect all the created cars. When you receive the command "Show special", drive 20 kilometers all the cars, which were manufactured during 2017 or after,
// have horsepower above 330 and the sum of their tire pressure is between 9 and 10. Finally, print information about each special car in the following format:

// "Make: {specialCar.Make}"
// "Model: {specialCar.Model}"
// "Year: {specialCar.Year}"
// "HorsePowers: {specialCar.Engine.HorsePower}"
// "FuelQuantity: {specialCar.FuelQuantity}"

// Input:
// 2 2.6 3 1.6 2 3.6 3 1.6
// 1 3.3 2 1.6 5 2.4 1 3.2
// No more tires
// 331 2.2
// 145 2.0
// Engines done
// Audi A5 2017 200 12 0 0
// BMW X5 2007 175 18 1 1
// Show special

// Output:
// Make: Audi
// Model: A5
// Year: 2017
// HorsePowers: 331
// FuelQuantity: 197.6


namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "No more tires")
                {
                    break;
                }

                string[] tiresData = command.Split();
                List<Tire> tiresList = new List<Tire>();

                for (int i = 0; i < tiresData.Length; i += 2)
                {
                    int year = int.Parse(tiresData[i]);
                    double pressure = double.Parse(tiresData[i + 1]);
                    Tire tire = new Tire(year, pressure);
                    tiresList.Add(tire);
                }

                tires.Add(tiresList.ToArray());
            }

            List<Engine> engines = new List<Engine>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Engines done")
                {
                    break;
                }

                string[] enginesData = command.Split();
                int horsePower = int.Parse(enginesData[0]);
                double cubicCapacity = double.Parse(enginesData[1]);
                Engine engine = new Engine(horsePower, cubicCapacity);
                engines.Add(engine);
            }

            List<Car> cars = new List<Car>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Show special")
                {
                    break;
                }

                string[] carData = command.Split();
                string make = carData[0];
                string model = carData[1];
                int year = int.Parse(carData[2]);
                double fuelQuantity = double.Parse(carData[3]);
                double fuelConsumption = double.Parse(carData[4]);
                int engineIndex = int.Parse(carData[5]);
                int tiresIndex = int.Parse(carData[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]);
                cars.Add(car);
            }

            Func<Car, bool> filter = c => c.Year >= 2017 &&
                                          c.Engine.HorsePower > 330 &&
                                          c.Tires.Sum(t => t.Pressure) >= 9 &&
                                          c.Tires.Sum(t => t.Pressure) <= 10;

            List<Car> specialCars = new List<Car>();
            foreach (Car car in cars.Where(filter))
            {
                car.Drive(20);
                specialCars.Add(car);
            }

            Console.WriteLine(String.Join("", specialCars));
        }
    }
}