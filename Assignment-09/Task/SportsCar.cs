using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class SportsCar: Vehicle
    {
        public SportsCar(int MaxNumberOfPeople, int MaxNumberOfWheels, int MaxSpeed) //: base(MaxNumberOfPeople, MaxNumberOfWheels, MaxSpeed) 
        { 
        }

        //public override void PeopleOfTransport(int NumberOfPeople)
        //{
        //    if (NumberOfPeople > 2)
        //        Console.WriteLine("We can't go, number of people is too much!!!");
        //    else
        //        Console.WriteLine("We can go!");
        //}

        public override void MakeSound(TransportCategory transportCategory)
        {
            //road.Obstacles.Any(a => a == ObstacleType.DeepWater)
            if (transportCategory.SportCarCategory.Formula1)
            {
                Console.WriteLine("some Formula1 sound");
            }

           

        }


    }
}
