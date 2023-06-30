using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Models
{
    internal abstract class PublicTransportVehicle : IVehicle
    {
        protected PublicTransportVehicle(int maxSpeed, int weightKg, int powerHp)
        {
            MaxSpeed = maxSpeed;
            WeightKg = weightKg;
            PowerHp = powerHp;
        }

        public int MaxSpeed { get; set; }
        public int WeightKg { get; set; }
        public int PowerHp { get; set; }

        public void Drive(Road road)
        {
            if (road.Obstacles.Count == 0)
                Console.WriteLine("Can't drive on this road, it has obstacles on it");
            else
                Console.WriteLine("Driving!");
        }

        public abstract void GiveSignal();
        public abstract void TransportCargo(int cargoAmountKg);
        public abstract void TransportPeople(int amountOfPeople);
    }
}