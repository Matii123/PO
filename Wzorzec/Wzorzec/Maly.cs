using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec
{
    class Maly : NapojDekorator
    {
        public Maly(Napoj napoj) : base(napoj)
        {

        }
        public override string GetOpis()
        {
            return napoj.GetOpis() + " mala";
        }
        public override double Koszt()
        {
            return 1.00 + napoj.Koszt();
        }
    }
}
