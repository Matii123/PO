using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec
{
    class Duzy: NapojDekorator
    {
        public Duzy(Napoj napoj):base(napoj)
        {

        }
        public override string GetOpis()
        {
            return napoj.GetOpis() + " duza";
        }
        public override double Koszt()
        {
            return 3.00 + napoj.Koszt();
        }
    }
}
