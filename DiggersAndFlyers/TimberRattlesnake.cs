using System;

namespace DiggersAndFlyers
{
    public class TimberRattlesnake : IWalking
    {
        public void Run()
        {
            Console.WriteLine($"The snake slithers rapidly across the ground.");
        }
        public void Walk()
        {
            Console.WriteLine($"The snake slithers across the ground.");
        }
    }
}