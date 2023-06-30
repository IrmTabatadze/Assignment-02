using System.Threading.Tasks;
using Task1.Models;

var m1 = new Tank(
    5,
    new List<Gun>()
    {
        new Gun("FN Mag",Caliber.Cal762mm,GunType.AntiPersonnel),
        new Gun("M2",Caliber.Cal50BMG,GunType.AntiPersonnel),
        new Gun("MainGun",Caliber.Cal180mm,GunType.AntiTank)
    },
    120,
    55000,
    300);

var bradley = new APC(
    2,
    new List<Gun>()
    {
        new Gun("FN Mag",Caliber.Cal762mm,GunType.AntiPersonnel),
        new Gun("M2",Caliber.Cal50BMG,GunType.AntiPersonnel),
        new Gun("AntiAircraftCannon",Caliber.Cal75mm,GunType.AntiAircraft)
    },
    160,
    10000,
    300);


m1.Shoot(bradley);