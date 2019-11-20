using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    class Trojkat : Figura
    {
        public override void Pole(int a, int b)
        {
            double wynik = (double)(1 / 2) * (double)a * (double)b;
            Console.WriteLine("Pole trojkata: {0}", wynik);
        }
    }
}
