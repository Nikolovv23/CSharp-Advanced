namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumbtionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumbtionPerKilometer) 
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumbtionPerKilometer = fuelConsumbtionPerKilometer;
        }

        public void Drive( Car car, string model, double distance)
        {
            double fuelNeeded = distance * car.FuelConsumbtionPerKilometer;
            if (fuelNeeded > car.FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                car.TravelledDistance += distance;
                car.FuelAmount -= fuelNeeded;
            }
        }
    }
}
