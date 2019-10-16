using System;

namespace DiggersAndFlyers
{
    public class Parakeet : IFlying
    {
        public double WindSpeed { get; set; }
        public void Fly()
        {
            Console.WriteLine($"The parakeet flies at {WindSpeed} mph.");
        }
        public void Land()
        {
            Console.WriteLine($"The parakeet lands on the ground.");
        }
    }
}