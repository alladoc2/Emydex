using System;

namespace FarmSystem.Test1
{
    public class Horse : Animal
    {
        public override string Name => "Horse";
        private string _id;
        private int _noOfLegs;

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
            Console.WriteLine("Horse says neigh!");
        }
        
    }
}