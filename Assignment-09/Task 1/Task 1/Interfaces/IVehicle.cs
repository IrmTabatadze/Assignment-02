using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Interfaces
{
    internal interface IVehicle
    {
        public int MaxSpeed { get; set; }
        public int WeightKg { get; set; }
        public int PowerHp { get; set; }
        public void Drive(Road road);
        public void GiveSignal();
        public void TransportPeople(int amountOfPeople);
        public void TransportCargo(int cargoAmountKg);
    }
}
