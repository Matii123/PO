using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Bicycle bicycle1 = new Bicycle();

            car1.Ride();
            bicycle1.Ride();

            Osoba jasio = new Osoba();

            jasio.Graj();
            
            IGitarzysta krzys = new Osoba();

            krzys.Graj();

            ISkrzypek mati = new Osoba();

            mati.Graj();

            

            Console.ReadKey();
        }
    }
}
