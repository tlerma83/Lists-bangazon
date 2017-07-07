using System;
using System.Collections.Generic;



namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dude!"); 
            List<string> planetList = new List<string>(){
                "Mercury", "Mars"
            };
            planetList.Add("Jupiter");       
            planetList.Add("Saturn");

            // Console.WriteLine(planetCount);
            List<string> betterPlanets = new List<string>(){
                "Uranus", "Neptune"
            };


            planetList.AddRange(betterPlanets);



            planetList.Insert(1, "Venus");
            planetList.Insert(3, "Earth");

            planetList.Add("Pluto");


            List<string> rockyPlanets = new List<string>(planetList.GetRange(0, 4));

            
            foreach(string rocky in rockyPlanets) {
                Console.WriteLine(rocky);
            }

            planetList.RemoveAt(8);

            foreach(string planet in planetList) {
                Console.WriteLine(planet);
            }


        }
    }

}
