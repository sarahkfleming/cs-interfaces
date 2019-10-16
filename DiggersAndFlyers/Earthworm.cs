using System;

namespace DiggersAndFlyers
{
    public class Earthworm : IDigging
    {
        public void Burrow()
        {
            Console.WriteLine($"The earthworm burrows into the ground.");
        }

        public void Resurface()
        {
            Console.WriteLine($"The earthworm resurfaces during the rain.");
        }
    }
}