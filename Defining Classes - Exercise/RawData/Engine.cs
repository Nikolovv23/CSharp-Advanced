
namespace DefiningClasses
{
    public class Engine
    {
        public int Speed { get; set; }
        public int HorsePower { get; set;}

        public Engine(int speed, int horsePower)
        {
            Speed = speed;
            HorsePower = horsePower;
        }
    }
}
