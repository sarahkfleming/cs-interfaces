using System;

namespace InterfacesInto
{
    public interface INameable
    {
        string Name { get; set; }
    }
    public interface IAge
    {
        int Age { get; }
        
        // There is no logic in the method below. This is just the definition of a method that must be implemented by classes using the interface.
        void IncrementAge();
    }
    
    public class Person : Mammal, INameable, IAge
    {
        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }
        public string Name { get; set; }
        public int Age { get; private set; }
        public void IncrementAge()
        {
            Age++;
        }
        
        public override string ToString()
        {
            return $"{Name} is {Age} years old.";
        }
    }

    public class Dog : Mammal, INameable, IAge
    {
        public Dog()
        {
            Age = 0;
        }
        public string Breed { get; set; }
        public string Name { get; set; }

        public int Age { get; private set; }

        public void IncrementAge()
        {
            Age++;
            if (Age > 20)
            {
                Console.WriteLine("That's an old dog.");
            }
        }
        public override string ToString()
        {
            return $"{Name} the {Breed} is {Age} years old.";
        }
    }
    
    public class Mammal
    {
        public double FurPercentage { get; set; }
    }
    
}