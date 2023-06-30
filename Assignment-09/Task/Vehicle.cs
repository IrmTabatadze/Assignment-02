using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal interface Vehicle
    {
        public int MaxNumberOfPeople { get; set; }
        public int MaxNumberOfWheels { get; set; }
        public int MaxSpeed { get; set; }
        public void PeopleOfTransport(int NumberOfPeople);
        public void MakeSound();
    }
}
