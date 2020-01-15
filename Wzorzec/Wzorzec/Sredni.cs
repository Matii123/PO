using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec
{
    class Sredni : NapojDekorator
    {
        public Sredni(Napoj napoj) : base(napoj)
        {

        }
        public override string GetOpis()
        {
            return napoj.GetOpis() + " srednia";
        }
        public override double Koszt()
        {
            return 2.00 + napoj.Koszt();
        }
    }
}
