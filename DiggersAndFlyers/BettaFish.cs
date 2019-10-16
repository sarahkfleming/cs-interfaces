using System;

namespace DiggersAndFlyers
{
    public class BettaFish : ISwimming
    {
        public int MaximumDepth { get; set; }

        public void Swim()
        {
            Console.WriteLine($"The betta fish dives down {MaximumDepth} inches.");;
        }
    }
}