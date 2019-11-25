using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie
{
    class programista: pracownik
    {
        public override void Pracuj()
        {
            base.Pracuj();
            Console.WriteLine("Obowiazki programisty");
        }
    }
}
