using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Models
{
    internal abstract class MilitaryVehicle : IVehicle
    {
        protected MilitaryVehicle(int armorThicknessCm, List<Gun> guns, int maxSpeed, int weightKg, int powerHp)
        {
            ArmorThicknessCm = armorThicknessCm;
            Guns = guns;
            MaxSpeed = maxSpeed;
            WeightKg = weightKg;
            PowerHp = powerHp;
        }

        public int ArmorThicknessCm { get; set; }
        public List<Gun> Guns { get; set; }
        public int MaxSpeed { get; set; }
        public int WeightKg { get; set; }
        public int PowerHp { get; set; }

        public abstract void Drive(Road road);
        public abstract void GiveSignal();
        public abstract void TransportCargo(int cargoAmountKg);
        public abstract void TransportPeople(int amountOfPeople);

        public void Shoot(MilitaryVehicle vehicle)
        {
            Gun biggestGun = Guns.OrderBy(gun => gun.Caliber).Last();
            if (vehicle.ArmorThicknessCm > (int)biggestGun.Caliber)
                Console.WriteLine("Can not damage the enemy vehicle, it is too thickly armored");
            else
                Console.WriteLine("The enemy vehicle has been destroyed");
        }

    }


}

