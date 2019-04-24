using System;

namespace Animals.Library
{

    // from console terminal
    // dotnet new classlib --name Animals.Library

    // one solution 2 projects. Keeps things from getting tangeled and messy

    // (from animals folder) mv Animals.Library/Class1.cs Animals.Library/Dog.cs
    public class Dog
    {
        // classes can contain methods... they also contain data
        // properties to store data

        public string Breed { get; set; }
        public string Name { get; set; }

        public void Bark()
        {
            Console.WriteLine("Bark");
        }

        // every dog object will have his own breed, name, and the ability to bark
    }
}
