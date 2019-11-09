using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            int kwota = 0;
            konto konto = new konto(2000);

            Console.WriteLine("Witamy w banku");
            int n= 1;
            while(n!=4)
            {
                Console.WriteLine("Wybierz 1 jesli chcesz wplacic: ");
                Console.WriteLine("Wybierz 2 jesli chcesz wyplacic: ");
                Console.WriteLine("Wybierz 3 jesli chcesz zobaczyc stan konta: ");
                Console.WriteLine("Wybierz 4 jesli chcesz wyjsc: ");
                n = int.Parse(Console.ReadLine());

                if(n==1)
                {
                    Console.Write("Podaj kwote: ");
                    kwota = int.Parse(Console.ReadLine());
                    konto.wplata(kwota);
                    Console.WriteLine("Dokonales wplaty " + kwota);
                }
                else if(n==2)
                {
                    Console.Write("Podaj kwote: ");
                    kwota = int.Parse(Console.ReadLine());
                    konto.wyplata(kwota);
                    Console.WriteLine("Dokonales wyplaty " + kwota);
                }
                else if(n==3)
                {
                    konto.Info();
                }
                else if(n==4)
                {
                    Console.WriteLine("Do widzenia!");
                }
                else
                {
                    Console.WriteLine("Podales zla liczbe");
                }
            }
            Console.ReadKey();
        }
    }
}
