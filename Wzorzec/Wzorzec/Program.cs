using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec
{
    class Program
    {
        static void Main(string[] args)
        {
            Napoj nowaKawa = new Kawa();
            Console.WriteLine(nowaKawa.GetOpis() + " kosztuje: " + $"{nowaKawa.Koszt()}");

            // dodajemy mleko
            nowaKawa = new Mleko(nowaKawa);
            Console.WriteLine(nowaKawa.GetOpis() + " kosztuje: " + $"{nowaKawa.Koszt()}");

            // i czekoladę
            nowaKawa = new Czekolada(nowaKawa);
            Console.WriteLine(nowaKawa.GetOpis() + " kosztuje: " + $"{nowaKawa.Koszt()}");

            nowaKawa = new Sredni(nowaKawa);
            Console.WriteLine(nowaKawa.GetOpis() + " kosztuje: " + $"{nowaKawa.Koszt()}");

            Console.ReadKey();
        }
    }
}
