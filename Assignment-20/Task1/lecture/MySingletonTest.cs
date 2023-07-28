using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture
{
    public sealed class MySingletonTest
    {
        private static MySingletonTest _instance;
        private static readonly object _instanceLock = new object();

        MySingletonTest()
        {

        }

        public MySingletonTest Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new MySingletonTest();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
