using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec
{
    class Mleko: NapojDekorator
    {
        public Mleko(Napoj napoj):base(napoj)
        {

        }
        public override double Koszt()
        {
            return 0.50 + napoj.Koszt();
        }
        public override string GetOpis()
        {
            return napoj.GetOpis() + ", Mleko";
        }
    }
}
