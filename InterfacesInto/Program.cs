using System;

namespace InterfacesInto
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jill = new Person(28, "Jill");
            Dog rick = new Dog()
            {
                Name = "Rick",
                Breed = "Collie"
            };

            Console.WriteLine(jill);
            Console.WriteLine(rick);

            AgeThatThing(jill);
            AgeThatThing(rick);

            Console.WriteLine(jill);
            Console.WriteLine(rick);
        }

        // You can make a function without creating an object
        static void AgeThatThing(IAge ageableThing)
        {
            ageableThing.IncrementAge();
        }

    }
}
