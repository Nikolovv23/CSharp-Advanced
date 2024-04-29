using System.Text;

namespace DefiningClasses
{
    public class Car
    {  
        public string Model { get; set; }
        public string EngineName { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public Engine Engine { get; set; }

        public Car(string model, string engineName, Engine engine)
        {
            Model = model;
            EngineName = engineName;
            Engine = engine;
        }
        public Car (string model, string engineName, int weight, Engine engine)
        {
            Model = model;
            EngineName = engineName;
            Weight = weight;
            Engine = engine;
        }
        public Car(string model, string engineName, string color, Engine engine)
        {
            Model = model;
            EngineName = engineName;
            Color = color;
            Engine = engine;
        }
        public Car(string model, string engineName, int weight, string color, Engine engine)
        {
            Model = model;
            EngineName = engineName;
            Weight = weight;
            Color = color;
            Engine = engine;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); 
            sb.AppendLine($"{Model}:");

            sb.AppendLine($"  {EngineName}:");
            sb.AppendLine($"    Power: {Engine.Power}");
            if ( Engine.Displacement != 0 )
            {
                sb.AppendLine($"    Displacement: {Engine.Displacement}");
            }
            else
            {
                sb.AppendLine($"    Displacement: n/a");

            }
            if (Engine.Efficiency != null)
            {
                sb.AppendLine($"    Efficiency: {Engine.Efficiency}");
            }
            else
            {
                sb.AppendLine($"    Efficiency: n/a");

            }
            if (Weight != 0)
            {
                sb.AppendLine($"  Weight: {Weight}");
            }
            else
            {
                sb.AppendLine($"  Weight: n/a");

            }
            if (Color != null)
            {
                sb.AppendLine($"  Color: {Color}");
            }
            else
            {
                sb.AppendLine($"  Color: n/a");

            }

            return sb.ToString().TrimEnd();
        }
    }
}
