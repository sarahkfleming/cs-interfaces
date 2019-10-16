using System;

namespace DiggersAndFlyers
{
    public class Finch : IFlying
    {
        public double WindSpeed { get; set; }
        public void Fly()
        {
            Console.WriteLine($"The finch flies at {WindSpeed} mph.");
        }
        public void Land()
        {
            Console.WriteLine($"The finch lands on a birdfeeder.");
        }
    }
}