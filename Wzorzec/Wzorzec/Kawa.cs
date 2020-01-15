using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec
{
    class Kawa : Napoj
    {
        public override string GetOpis()
        {
            return "Czarna kawa";
        }

        public override double Koszt()
        {
            return 2.00;
        }
    }
}
