// Define a class Trainer and a class Pokemon. 
// Trainers have:
// •	Name
// •	Number of badges
// •	A collection of pokemon
// Pokemon have:
// •	Name
// •	Element
// •	Health
// All values are mandatory. Every Trainer starts with 0 badges.
// You will be receiving lines until you receive the command "Tournament". Each line will carry information about a pokemon and the trainer who caught it in the format:
// "{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
// TrainerName is the name of the Trainer who caught the pokemon. Trainers' names are unique.
// After receiving the command "Tournament", you will start receiving commands until the "End" command is received. They can contain one of the following:
// •	"Fire"
// •	"Water"
// •	"Electricity"
// For every command, you must check if a trainer has at least 1 pokemon with the given element. If he does, he receives 1 badge. Otherwise,
// all of his pokemon lose 10 health. If a pokemon falls to 0 or less health, he dies and must be deleted from the trainer's collection. In the end,
// you should print all of the trainers, sorted by the number of badges they have in descending order (if two trainers have the same amount of badges,
// they should be sorted by order of appearance in the input) in the format: 
// "{trainerName} {badges} {numberOfPokemon}"

//          Input
// Peter Charizard Fire 100
// George Squirtle Water 38
// Peter Pikachu Electricity 10
// Tournament
// Fire
// Electricity
// End
//          Output
// Peter 2 2
// George 0 1



using System.Data;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<Pokemon>> list = new Dictionary<string,List<Pokemon>>();
            List<Trainer> trainers = new List<Trainer>();
            string command = default;
            while ((command = Console.ReadLine()) != "Tournament")
            {
                string[] info = command
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string trainerName = info[0];
                string pokemonName = info[1];
                string pokemonElement = info[2];
                int health = int.Parse(info[3]);
                
                Pokemon pokemon = new Pokemon (pokemonName, pokemonElement, health);

                if (!list.ContainsKey(trainerName))
                {
                    list.Add(trainerName, new List<Pokemon>());
                }
                list[trainerName].Add(pokemon);
            }
            foreach (var kvp in list)
            {
                Trainer trainer = new Trainer();
                trainer.Name = kvp.Key;
                trainer.Badges = 0;
                trainer.Pokemons = kvp.Value;
                trainers.Add(trainer);
            }

            string element = default;
            while((element = Console.ReadLine()) != "End")
            {
               
                foreach (var trainer in trainers)
                {
                    bool IsItContainsElement = false;

                    foreach (var pokemon in trainer.Pokemons)
                    {
                        if (pokemon.Element == element)
                        {
                            trainer.Badges++;
                            IsItContainsElement = true;
                            break;
                        }
                        if (!IsItContainsElement)
                        {
                            pokemon.Health -= 10;
                        }
                    }
                }
            }
            var sortedTrainers = trainers
                .OrderByDescending(x => x.Badges)
                .ToList();
            foreach(var trainer in sortedTrainers)
            {
                Console.WriteLine(trainer.Name + " " + trainer.Badges + " " + trainer.Pokemons.Where(p => p.Health >= 0).Count());
            }
        }
    }
}
