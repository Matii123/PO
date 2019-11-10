using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Bicycle : Vehicle, IRideable
    {
        public void Ride()
        {
            Console.WriteLine("Jade rowerem");
        }
    }
}
