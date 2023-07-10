using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLibrary
{
    public class CarClass
    {
        public CarClass()
        {
        }

        public string ReturnCarType(string MyCarType)
        {
            var StringCarType = "";
            if (GetCarType(MyCarType) == CarType.Offroad)
            {
                StringCarType = "This car is Off road";
                return StringCarType;
            }
            else if (GetCarType(MyCarType) == CarType.Sedan)
            {
                StringCarType = "This car is sedan";
                return StringCarType;
            }
            else if (GetCarType(MyCarType) == CarType.PublicTransport)
            {
                StringCarType = "This car is public transport";
                return StringCarType;
            }
            else if (GetCarType(MyCarType) == CarType.Construction)
            {
                StringCarType = "This car is construction machine";
                return StringCarType;
            }
            else 
            {
                StringCarType = "Car type not found!";
                return StringCarType;
            }

        }

        public CarType GetCarType(string cartype)
        {
            if (cartype == "Off road")
                return CarType.Offroad;
            else if (cartype == "Sedan")
            {
                return CarType.Sedan;
            }
            else if (cartype == "Construction")
            {
                return CarType.Construction;
            }
            else if (cartype == "Public")
            {
                return CarType.PublicTransport;
            }
            else
                return CarType.None;
        }

        public string ReturnCarTire(string car)
        {
            if (string.IsNullOrEmpty(car))
            {
                return "Car is empty";
            }
            else if (GetCarType(car) == CarType.Offroad)
            {
                return "4";
            }
            else if (GetCarType(car) == CarType.PublicTransport)
            {
                return "8";
            }
            else
            {
                return "4";
            }
        }
        public enum CarType
        {
            Offroad,
            Sedan,
            PublicTransport,
            Construction,
            None

        }
    }
}

