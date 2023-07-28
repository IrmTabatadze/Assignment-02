using System.Data.SqlTypes;
using System.Reflection;
using Task2;

var cars = new ElectricCar[2]
{
    new ElectricCar{BatteryLevel = 0, Model = "tesla", Year = 2023},
    new ElectricCar{BatteryLevel = 5, Model = "toyota", Year = 2020}
};

ChargeCars(cars);

static void ChargeCars(IEnumerable<ElectricCar> cars)
{
    
    foreach (var car in cars)
    {
        car.Charge();
        car.PrintCarProperty();
    }

}