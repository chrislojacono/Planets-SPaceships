using System;
using System.Collections.Generic;

namespace Planets_and_Spaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            var lastTwoPlanets = new List<string> { "Uranus", "Neptune" };

            planetList.AddRange(lastTwoPlanets);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            var rockyPlanets = new List<string>();

            var rockPlanets = planetList.GetRange(0, 4);

            rockyPlanets.AddRange(rockPlanets);

            planetList.Remove("Pluto");

            foreach (var item in planetList)
            {
                Console.WriteLine(item);
            }
            foreach (var item in rockyPlanets)
            {
                Console.WriteLine(item);
            }

            var solarSystemProbes = new Dictionary<string, List<string>>();

            solarSystemProbes.Add("Mercury", new List<string> { "Mariner 10", "Messenger", "BepiColombo" });
            solarSystemProbes.Add("Venus", new List<string> { "Mariner 2", "Cosmos 27", "Zond 1" });
            solarSystemProbes.Add("Earth", new List<string> { "Mariner 10", "Pioneers 10", "Voyager 1" });
            solarSystemProbes.Add("Mars", new List<string> { "2001 Mars Odyssey", "Beagle 2", "Rosetta" });
            solarSystemProbes.Add("Jupiter", new List<string> { "JUICE", "Europa Clipper", "IHP-2" });
            solarSystemProbes.Add("Saturn", new List<string> { "Pioneer 11", "Cassini", "Voyager 2" });
            solarSystemProbes.Add("Uranus", new List<string> { "Voyager 2" });
            solarSystemProbes.Add("Neptune", new List<string> { "Voyager 2", "IHP-2"});
            solarSystemProbes.Add("Pluto", new List<string> { "New Horizons", });

            foreach (var planet in planetList)
            {
                foreach (var item in solarSystemProbes)
                {
                    if (planet == item.Key)
                    {
                        Console.WriteLine($"{planet} : {string.Join(", " , item.Value)}");
                    }
                }

            }
            


            //Family Dictionary exercise

            var myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Evan" }, { "age", "25" } });
            myFamily.Add("mom", new Dictionary<string, string>() { { "name", "Laura" }, { "age", "60" } });
            myFamily.Add("brother2", new Dictionary<string, string>() { { "name", "Michael" }, { "age", "31" } });
            myFamily.Add("dad", new Dictionary<string, string>() { { "name", "Steve" }, { "age", "64" } });

            foreach (var item in myFamily)
            {
                Console.WriteLine($"{item.Value["name"]} is my {item.Key} and is {item.Value["age"]}");

            }

        }
    }
}
