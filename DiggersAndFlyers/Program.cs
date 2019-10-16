using System;
using System.Collections.Generic;

namespace DiggersAndFlyers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Containers:
            Animals that dig and live in the ground
            Animals that move about on the ground
            Animals that swim in water
            Animals that fly above the ground
            
            Before you write any classes for the above animals, determine the common properties and behaviors that some of them share and define interfaces first.
            
            Once you believe you have a good set of interfaces, then start creating your specific animal classes and have them implement the appropriate interface.
            
            Then define classes to represent the containers that will hold various animals. Each container class should have a single property - a list to hold animal instances.
            
            Lastly, in Main() create one (or more if you like) instances of each type of animal and each container. Then add the animals to their corresponding container.
            */

            Ant antony = new Ant();
            BettaFish dasani = new BettaFish()
            {
                MaximumDepth = 11
            };
            CopperheadSnake scarySnake1 = new CopperheadSnake();
            Earthworm gary = new Earthworm();
            Finch finchy = new Finch()
            {
                WindSpeed = 9
            };
            Gerbil geronimo = new Gerbil();
            Mouse mighty = new Mouse();
            Parakeet polly = new Parakeet()
            {
                WindSpeed = 5
            };
            Terrapin speedy = new Terrapin()
            {
                MaximumDepth = 14
            };
            TimberRattlesnake scarySnake2 = new TimberRattlesnake();

            AnimalsOnGround animalsOnGround = new AnimalsOnGround();
            animalsOnGround.groundAnimals.Add(scarySnake1);
            animalsOnGround.groundAnimals.Add(scarySnake2);

            AnimalsThatDig diggers = new AnimalsThatDig();
            diggers.diggingAnimals.Add(antony);
            diggers.diggingAnimals.Add(gary);
            diggers.diggingAnimals.Add(geronimo);
            diggers.diggingAnimals.Add(mighty);

            AnimalsThatFly flyers = new AnimalsThatFly();
            flyers.flyingAnimals.Add(finchy);
            flyers.flyingAnimals.Add(polly);

            AnimalsThatSwim swimmers = new AnimalsThatSwim();
            swimmers.swimmingAnimals.Add(dasani);
            swimmers.swimmingAnimals.Add(speedy);
        }
    }
}
