using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ElectricCar
    {
        public double BatteryLevel
        {
            get; set;
        }

        public string Model
        {
            get; set;
        }
        
        public int Year
        { 
            get; set; 
        }

        public double Charge()
        {
            while (BatteryLevel < 10) //100
            {
                Thread.Sleep(10000);
                BatteryLevel += 5;
            }
            return BatteryLevel;
        }

        public void PrintCarProperty()
        {
            Console.WriteLine($" model : {Model}, Year: {Year}, Battery Level: {BatteryLevel}");
        }
    }
}
