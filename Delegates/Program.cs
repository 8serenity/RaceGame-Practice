using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceGame
{
    /*Разработать игру "Автомобильные гонки" с использованием делегатов.
    
    В игре использовать несколько типов автомобилей: спортивные, легковые, грузовые и автобусы. 
    
    Реализовать игру «Гонки». Принцип игры: Автомобили двигаются от старта к финишу со скоростями,
    которые изменяются в установленных пределах случайным образом.
    Победителем считается автомобиль, пришедший к финишу первым.

    Рекомендации по выполнению работы
    Разработать абстрактный класс «автомобиль» (класс Car).

    Собрать в нем все общие поля, свойства (например, скорость) методы (например, ехать).  

    Разработать классы автомобилей с конкретной реализацией конструкторов и методов, свойств.

    В классы автомобилей добавить необходимые события (например, финиш).

    Класс игры должен производить запуск соревнований автомобилей, выводить сообщения о текущем положении автомобилей,
    выводить сообщение об автомобиле, победившем в гонках.
    
    Создать делегаты, обеспечивающие вызов методов из классов автомобилей (например, выйти на старт, начать гонку).
    
    Игра заканчивается, когда какой-то из автомобилей проехал определенное расстояние
    (старт в положении 0, финиш в положении 100). Уведомление об окончании гонки
    (прибытии какого-либо автомобиля на финиш) реализовать с помощью событий. 
*/

    class Program
    {
        static void Main(string[] args)
        {
            double distanceMax = 2500;
            Race newRace = new Race(distanceMax);
            bool gameOver = false;

            while (!gameOver)
            {
                Console.Clear();
                for (int i = 0; i < newRace.Cars.Count; i++)
                {
                    if (newRace.Cars[i].IsFinished != true)
                    {
                        newRace.Cars[i].Go();
                    }
                }
                if (newRace.FinishedCars.Count == newRace.Cars.Count)
                {
                    gameOver = true;
                    Console.WriteLine("Race finished. Results:");
                    for (int i = 0; i < newRace.FinishedCars.Count; i++)
                    {
                        Console.WriteLine("{0} place - {1}", i + 1, newRace.FinishedCars[i].Name);
                    }

                }
                for (int i = 0; i < newRace.Cars.Count; i++)
                {
                    Console.WriteLine("{0} - speed {1} km/h distance covered {2} m", newRace.Cars[i].Name, newRace.Cars[i].CurrentSpeed, newRace.Cars[i].DistanceCovered);
                }
                System.Threading.Thread.Sleep(100);
            }
            Console.Read();
        }
    }
}
