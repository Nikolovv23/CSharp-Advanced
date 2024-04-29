// Create a program that tracks cars and their cargo. 
// Start by defining a class Car that holds information about:
// •	Model: a string property
// •	Engine: a class with two properties – speed and power,
// •	Cargo: a class with two properties – type and weight 
// •	Tires: a collection of exactly 4 tires. Each tire should have two properties: age and pressure.
// Create a constructor that receives all of the information about the Car and creates and initializes the model and its inner components (engine, cargo and tires).
// Input
// On the first line of input, you will receive a number N representing the number of cars you have. 
// 1.	On the next N lines, you will receive information about each car in the format:
// "{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"
// •	The speed, power, weight and tire age are integers.
// •	The tire pressure is a floating point number. 
// 2.	Next, you will receive a single line with one of the following commands:  "fragile" or "flammable".
// Output
// As an output, if the command is:
// •	"fragile" - print all cars, whose cargo is "fragile" and have a pressure of a single tire < 1.
// •	"flammable" - print all cars, whose cargo is "flammable" and have engine power > 250.
// The cars should be printed in order of appearing in the input.

//     Input
// 2
// ChevroletAstro 200 180 1000 fragile 1.3 1 1.5 2 1.4 2 1.7 4
// Citroen2CV 190 165 1200 fragile 0.9 3 0.85 2 0.95 2 1.1 1
// fragile
//     Output
// Citroen2CV



namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();   
            int counter = int.Parse(Console.ReadLine());
            for (int i = 0; i < counter; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string model = input[0];
                Engine engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                Cargo cargo = new Cargo(int.Parse(input[3]), input[4].ToLower());
                Tire tire1 = new Tire(double.Parse(input[5]), int.Parse(input[6]));
                Tire tire2 = new Tire(double.Parse(input[7]), int.Parse(input[8]));
                Tire tire3 = new Tire(double.Parse(input[9]), int.Parse(input[10]));
                Tire tire4 = new Tire(double.Parse(input[11]), int.Parse(input[12]));
                Tire[] tires = new Tire[4]
                {
                    tire1, tire2, tire3, tire4
                };
                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }
            string command = Console.ReadLine().Trim();
            if (command == "fragile")
            {
                var output = cars.Where(c => c.Cargo.Type == "fragile").Where( c => c.Tires.Any(t => t.Pressure < 1)).ToList();
                foreach (var car in output)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else // command == "flammable"
            {
                var output = cars.Where(c => c.Cargo.Type == "flammable").Where(c => c.Engine.HorsePower > 250).ToList();
                foreach (var car in output)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
