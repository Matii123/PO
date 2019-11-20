using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    class Kwadrat : Figura
    {
        public override void Pole(int a, int b)
        {
            Console.WriteLine("Pole kwadratu: {0}", a * a);
        }
    }
}
