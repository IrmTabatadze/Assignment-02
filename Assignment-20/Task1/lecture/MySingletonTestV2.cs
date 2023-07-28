using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture
{
    public sealed class MySingletonTestV2
    {
        public static MySingletonTestV2 _instance = new MySingletonTestV2();

        public MySingletonTestV2()
        {

        }
    }
}
