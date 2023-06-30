using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class TransportCategory
    {
        public TransportCategory()
        {
        
        }

        public enum SportCarCategory
        {
            Formula1,
            Rally,
            OffRoad
        }

        public enum PublicTransportCategory
        {
            Bus,
            Subway,
            Tram
        }

        public enum ConsumerCategory
        {
            Sedan,
            Jeep,
            Motorcycle,
            Bicycle
        }

        public enum CombatCategory
        {
            Tank,
            Beteer,
            CombatAircraft
        }
    }
}
