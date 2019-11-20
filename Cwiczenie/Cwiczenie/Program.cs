using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            pracownik p = new programista();
            p.Pracuj();

            Console.ReadKey();
        }
    }
}
