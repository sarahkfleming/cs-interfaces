using System;

namespace DiggersAndFlyers
{
    public class Terrapin : ISwimming
    {
        public int MaximumDepth { get; set; }
        public void Swim()
        {
            Console.WriteLine($"The turtle dives {MaximumDepth} feet.");
        }
    }
}