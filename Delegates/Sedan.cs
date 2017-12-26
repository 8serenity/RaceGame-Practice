using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceGame
{
    public class Sedan : Car
    {
        public event CarOperationsHandler HasFinished;

        public Sedan(double maxDistance)
        {
            MaxSpeed = 225;
            DistanceCovered = 0;
            MaxDistance = maxDistance;
        }
        public override void Go()
        {
            CurrentSpeed = MaxSpeed * rnd.NextDouble();
            DistanceCovered += CurrentSpeed * 1000 / 3600;
            if (HasFinished != null && DistanceCovered >= MaxDistance)
            {
                IsFinished = true;
                HasFinished(this, new CarArgs(DistanceCovered));
            }
        }
    }
}
