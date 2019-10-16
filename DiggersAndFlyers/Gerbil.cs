using System;

namespace DiggersAndFlyers
{
    public class Gerbil : IDigging
    {
        public void Burrow()
        {
            Console.WriteLine($"The gerbil burrows into the ground.");
        }

        public void Resurface()
        {
            Console.WriteLine($"The gerbil pops out of its underground lair.");
        }
    }
}