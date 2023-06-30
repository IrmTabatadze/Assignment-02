using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Models
{
    internal class Tank : MilitaryVehicle
    {
        public Tank(int armorThicknessCm, List<Gun> guns, int maxSpeed, int weightKg, int powerHp) : base(armorThicknessCm, guns, maxSpeed, weightKg, powerHp)
        {
        }

        public override void Drive(Road road)
        {
            if (road.Obstacles.Any(a => a == ObstacleType.DeepWater))
                Console.WriteLine("I can not drive over water, the vehicle is not amphibious");
            else
                Console.WriteLine("Driving! Vroom! Vroom!");
        }



        public override void GiveSignal()
        {
            Console.WriteLine("BEEEEEEEP!");
        }



        public override void TransportCargo(int cargoAmountKg)
        {
            if (cargoAmountKg > 2000)
                Console.WriteLine("This cargo is too heavy");
            else
                Console.WriteLine("Transporting!");
        }

        public override void TransportPeople(int amountOfPeople)
        {
            if (amountOfPeople > 5)
                Console.WriteLine("There is no place for this many people on board");
            else
                Console.WriteLine("Transporting!");
        }
    }
}