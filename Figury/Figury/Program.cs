using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    class Program
    {
        static void Main(string[] args)
        {
            Kwadrat kwadrat = new Kwadrat();
            kwadrat.Pole(5,5);
            Trojkat trojkat = new Trojkat();
            trojkat.Pole(5, 4);

            Console.ReadKey();
        }
    }
}
