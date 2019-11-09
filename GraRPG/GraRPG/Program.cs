using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            lucznik lucznik = new lucznik("GoblinA", 100, 15, 3);
            wojownik wojownik = new wojownik("OrkA", 100, 15, 1);

            lucznik.Atak();
            wojownik.Atak();

            lucznik.Info();
            wojownik.Info();



            Console.ReadKey();
        }
    }
}
