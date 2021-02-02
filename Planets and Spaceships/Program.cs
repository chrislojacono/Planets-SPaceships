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

            


        }
    }
}
