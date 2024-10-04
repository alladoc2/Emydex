using System;
using System.Collections.Generic;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        // Queue to hold animals in a FIFO manner
        private Queue<Animal> _animals = new Queue<Animal>();

        // Event for when the farm becomes empty
        public event Action FarmEmpty;

        // Method to add an animal to the farm (FIFO)
        public void AddAnimal(Animal animal)
        {
            _animals.Enqueue(animal);
        }

        //TEST 1
        // Method to open the farm and let animals in
        public void OpenFarm()
        {
            foreach (Animal animal in _animals)
            {
                animal.EnterFarm();
            }
        }

        //TEST 2
        public void MakeNoise()
        {
            foreach (Animal animal in _animals)
            {
                animal.MakeNoise();
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            foreach (Animal animal in _animals)
            {
                if (animal is IMilkableAnimal milkableAnimal)
                {
                    milkableAnimal.ProduceMilk();
                }
            }
        }

        //TEST 4
        // Method to release all animals and clear the farm
        public void ReleaseAllAnimals()
        {
            while (_animals.Count > 0)
            {
                Animal animal = _animals.Dequeue();
                animal.LeaveFarm(); // Each animal leaves the farm
            }

            FarmEmpty?.Invoke();
        }
    }
}