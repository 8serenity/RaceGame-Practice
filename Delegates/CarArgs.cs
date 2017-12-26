using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceGame
{
    public class CarArgs
    {
        public double DistanceCovered { get; set; }
        public CarArgs(double distance)
        {

            DistanceCovered = distance;
        }
    }
}
