
namespace DefiningClasses
{
    public class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; } 
        public int Displacement{ get; set; }
        public string Efficiency { get; set; }

        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }
        public Engine(string model, int power, int displacement)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
        }
        public Engine(string model, int power, string efficienty)
        {
            Model = model;
            Power = power;
            Efficiency = efficienty;
        }
        public Engine(string model, int power, int displacement, string efficienty)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficienty;
        }
    }
}
