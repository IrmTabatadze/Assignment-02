using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Models
{
    internal class Bus : PublicTransportVehicle
    {
        public Bus(int maxSpeed, int weightKg, int powerHp) : base(maxSpeed, weightKg, powerHp)
        {
        }

        public override void GiveSignal()
        {
            Console.WriteLine("BOOOP!");
        }

        public override void TransportCargo(int cargoAmountKg)
        {
            if (cargoAmountKg > 5000)
                Console.WriteLine("This cargo is too heavy");
            else
                Console.WriteLine("Transporting!");
        }



        public override void TransportPeople(int amountOfPeople)
        {
            if (amountOfPeople > 50)
                Console.WriteLine("There is no place for this many people on board");
            else
                Console.WriteLine("Transporting!");
        }

    }
}
