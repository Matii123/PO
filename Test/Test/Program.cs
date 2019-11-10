using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Test obiekt1 = new Test();
            Test obiekt2 = new Test();
            Test obiekt3 = new Test();


            obiekt1.liczba = 255;
            obiekt2 = obiekt1;
            obiekt3 = (Test)obiekt1.Clone();
            obiekt1.liczba = 347;

            Console.WriteLine("Wynik obiektu1: " + obiekt1.liczba);
            Console.WriteLine("Wynik obiektu2: " + obiekt2.liczba);
            Console.WriteLine("Wynik obiektu3: " + obiekt3.liczba);
            Console.ReadKey();


        }
    }
}
