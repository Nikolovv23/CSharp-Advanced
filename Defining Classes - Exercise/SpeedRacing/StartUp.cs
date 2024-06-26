﻿// Create a program that keeps track of cars and their fuel and supports methods for moving the cars. Define a class Car. Each Car has the following properties:
// •	string Model
// •	double FuelAmount
// •	double FuelConsumptionPerKilometer
// •	double Travelled distance
// A car's model is unique - there will never be 2 cars with the same model. On the first line of the input, you will receive a number N – the number of cars you need
// to track. On each of the next N lines, you will receive information about a car in the following format: 
// "{model} {fuelAmount} {fuelConsumptionFor1km}"
// All cars start at 0 kilometers traveled. After the N lines, until the command "End" is received, you will receive commands in the following format: 
// "Drive {carModel} {amountOfKm}"
// Implement a method in the Car class to calculate whether or not a car can move that distance. If it can, the car's fuel amount should be reduced by the amount
// of used fuel and its traveled distance should be increased by the number of the traveled kilometers. Otherwise, the car should not move (its fuel amount and
// the traveled distance should stay the same) and you should print on the console:
// "Insufficient fuel for the drive"
// After the "End" command is received, print each car and its current fuel amount and the traveled distance in the format:
//  "{model} {fuelAmount} {distanceTraveled}"
// Print the fuel amount formatted two digits after the decimal separator.

//     Input
// 2
// AudiA4 23 0.3
// BMW-M2 45 0.42
// Drive BMW-M2 56
// Drive AudiA4 5
// Drive AudiA4 13
// End
//     Output
// AudiA4 17.60 18
// BMW-M2 21.48 56



namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int carCounter = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>(carCounter);
            
            for (int i = 0; i < carCounter; i++) 
            {
                string[] info = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string model = info[0];
                double fuelAmount = double.Parse(info[1]);
                double fuelConsumbtionPerKilometer = double.Parse(info[2]);
               Car car = new Car(model, fuelAmount, fuelConsumbtionPerKilometer);
                cars.Add(car);
            }

            string input = default;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = commands[0];
                string model = commands[1];
                double distance = double.Parse(commands[2]);

                Car car = cars.FirstOrDefault(car => car.Model == model);
                car.Drive(car, model, distance);
             
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
