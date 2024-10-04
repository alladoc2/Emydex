using System;

namespace FarmSystem.Test1
{
    public class Cow : Animal, IMilkableAnimal
    {
        public override string Name => "Cow";
        private string _id;
        private int _noOfLegs = 4;


        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = 4;
            }
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Cow says Moo!");
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Cow was milked!");
        }

    }
}