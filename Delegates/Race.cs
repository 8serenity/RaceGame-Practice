using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceGame
{
    public class Race
    {
        public List<Car> Cars { get; set; }
        public List<Car> FinishedCars { get; set; }
        public double MaxDistance { get; set; }
        public Race(double distance)
        {
            MaxDistance = distance;
            Cars = new List<Car>();
            FinishedCars = new List<Car>();

            Cars.Add(new Bus(MaxDistance));
            (Cars.Last() as Bus).HasFinished += AddFinishers;
            Cars.Last().Name = "Astana Bus";

            Cars.Add(new Sedan(MaxDistance));
            (Cars.Last() as Sedan).HasFinished += AddFinishers;
            Cars.Last().Name = "Camry";

            Cars.Add(new SportCar(MaxDistance));
            (Cars.Last() as SportCar).HasFinished += AddFinishers;
            Cars.Last().Name = "Tesla Roadster";

            Cars.Add(new Bus(MaxDistance));
            (Cars.Last() as Bus).HasFinished += AddFinishers;
            Cars.Last().Name = "Shuttle Bus";

            Cars.Add(new Sedan(MaxDistance));
            (Cars.Last() as Sedan).HasFinished += AddFinishers;
            Cars.Last().Name = "Mazda";
        }
        public void AddFinishers(object sender, CarArgs args)
        {
            FinishedCars.Add(sender as Car);
        }

       
    }
}
