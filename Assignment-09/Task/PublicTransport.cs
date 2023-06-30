using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal abstract class PublicTransport: Vehicle
    {
        protected PublicTransport(int maxNumberOfPeople, int maxNumberOfWheels, int maxSpeed)
            {
                MaxNumberOfPeople = maxNumberOfPeople;
                MaxNumberOfWheels = maxNumberOfWheels;
                MaxSpeed = maxSpeed;

            }

        public int MaxNumberOfPeople { get; set; }
        public int MaxNumberOfWheels { get; set; }
        public int MaxSpeed { get; set; }
        public abstract void PeopleOfTransport(int NumberOfPeople);
        public abstract void MakeSound();
        public abstract void SetMaxSpeed(int MaxSpeed);


        abstract class Bus : PublicTransport
        {
            protected Bus(int maxNumberOfPeople, int maxNumberOfWheels, int maxSpeed) : base(maxNumberOfPeople, maxNumberOfWheels, maxSpeed)
            {
                MakeSound();
                {
                    Console.WriteLine("some bus sound");
                }

                PeopleOfTransport(MaxNumberOfPeople);
                {
                    if (MaxNumberOfPeople > 10)
                    {
                        Console.WriteLine("We can go");
                    }
                    else if (MaxNumberOfPeople < 10)
                    Console.WriteLine("We have to wait other people");

                }
            }
        }
       

        abstract class Subway : PublicTransport
        {
            protected Subway(int maxNumberOfPeople, int maxNumberOfWheels, int maxSpeed) : base(maxNumberOfPeople, maxNumberOfWheels, maxSpeed)
            {
                MakeSound();
                {
                    Console.WriteLine("some subway sound");
                }
            }
        }
    }
}
