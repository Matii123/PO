using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwierzaki
{
    class Zwierze : IAkcja
    {
        public void CoJem()
        {
            throw new NotImplementedException();
        }

        public void JakSiePoruszam()
        {
            Console.WriteLine("Poruszam sie na 4 lapach");
        }
    }
}
