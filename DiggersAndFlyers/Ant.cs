using System;

namespace DiggersAndFlyers
{
    public class Ant : IDigging
    {
        public void Burrow()
        {
            Console.WriteLine($"The ant burrows into the ground.");
        }

        public void Resurface()
        {
            Console.WriteLine($"The ant exits its anthill.");
        }
    }
}