using System;

namespace Cats
{
    class Program
    {
        static void Main(string[] args)
        {
            // Try out your skills with inheritance here!
            HouseCat august = new HouseCat("August", 5.0);
            august.Eat();
            Console.WriteLine(august.Tired);
            Console.WriteLine(august.Noise());
            august.Sleep();
            Console.WriteLine(august.Hungry);

            HouseCat benji = new HouseCat("Benji");
            Console.WriteLine(benji.Weight);
        }
    }
}
