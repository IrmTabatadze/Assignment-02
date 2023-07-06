using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11
{
    public interface ICar<T>
    {

        public int Name { get; set; }
        public string Color { get; set; }
        
        public void IsSUV(string Name)
        {
            if (Name == null)
            { 
                Console.WriteLine("Car name is empty"); 
            }
            else if(Name == "Jeep")
            {
                Console.WriteLine("This car is Jeep");
            }
            else
            {
                Console.WriteLine("This car is SUV");
            }
            
        }
    }
}
