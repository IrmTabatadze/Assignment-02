using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Road
    {

        public Road(string name, HashSet<ObstacleType>? obstacles)
        {
            Name = name;
            Obstacles = obstacles;
        }

        public string Name { get; set; }
        public HashSet<ObstacleType>? Obstacles { get; set; }
    }

    public enum ObstacleType
    {
        Dirt,
        Rocks,
        Bridge,
        Tunnel,
        Mud,
        Ice,
        ShallowWater,
        DeepWater,
        Sand
    }

}
