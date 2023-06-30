using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Subway: PublicTransport
    {
        public Subway(int maxNumberOfPeople, int maxNumberOfWheels, int maxSpeed) : base(maxNumberOfPeople, maxNumberOfWheels, maxSpeed)
        {        
        }

        public override void PeopleOfTransport(int NumberOfPeople)
        {
            if (NumberOfPeople > 10)
            {
                Console.WriteLine("We can go");
            }
            else if (NumberOfPeople < 10)
                Console.WriteLine("We have to wait other people");
        }

        public override void MakeSound()
        {
            Console.WriteLine("some sound");
        }

        public override void SetMaxSpeed(int MaxSpeed)
        {
            if (MaxSpeed == 0)
            {
                Console.WriteLine("speed is 0");
            }
            else
            {
                Console.WriteLine("speed is :" + MaxSpeed);
            }
            
        }
    }
}
