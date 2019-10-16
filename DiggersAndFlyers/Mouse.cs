using System;

namespace DiggersAndFlyers
{
    public class Mouse : IDigging
    {
        public void Burrow()
        {
            Console.WriteLine($"The mouse burrows into the ground.");
        }

        public void Resurface()
        {
            Console.WriteLine($"The mouse comes out of its underground lair.");
        }
    }
}