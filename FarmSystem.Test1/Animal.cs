using System;

namespace FarmSystem.Test1
{
    public abstract class Animal
    {
        public abstract string Name { get; }

        public virtual void EnterFarm()
        {
            Console.WriteLine($"{Name} has entered the Emydex farm");
        }

        public abstract void MakeNoise();

        public virtual void LeaveFarm()
        {
            Console.WriteLine($"{Name} has left the farm");
        }
    }
}
