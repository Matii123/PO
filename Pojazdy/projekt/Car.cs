using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Car : Vehicle, IRideable
    {
        public void Ride()
        {
            Console.WriteLine("Jade samochodem");
        }
    }
}
