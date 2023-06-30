using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Models
{
    internal class Gun
    {
        public Gun(string name, Caliber caliber, GunType type)
        {
            Name = name;
            Caliber = caliber;
            Type = type;
        }

        public string Name { get; set; }
        public Caliber Caliber { get; set; }
        public GunType Type { get; set; }
    }


    public enum Caliber
    {
        Cal556mm,
        Cal762mm,
        Cal50BMG,
        Cal75mm,
        Cal180mm
    }

    public enum GunType
    {
        AntiPersonnel,
        AntiTank,
        AntiAircraft
    }
}
