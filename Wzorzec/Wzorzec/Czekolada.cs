using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec
{
    class Czekolada: NapojDekorator
    {
        public Czekolada(Napoj _napoj) : base(_napoj)
        {
        }
        public override double Koszt()
        {
            return 0.80 + napoj.Koszt();
        }
        public override string GetOpis()
        {
            return napoj.GetOpis() + ", Czekolada";
        }
    }
}
