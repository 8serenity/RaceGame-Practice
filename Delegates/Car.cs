using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceGame
{
    public abstract class Car
    {
        public delegate void CarOperationsHandler(object sender, CarArgs args);

        protected Random rnd;

        public bool IsFinished { get; set; }
        public string Name { get; set; }
        public double CurrentSpeed { get; set; }
        public double MaxSpeed { get; set; }
        public double DistanceCovered { get; set; }
        public double MaxDistance { get; set; }
        public abstract void Go();

        public Car()
        {
            rnd = new Random();
        }
    }
}
