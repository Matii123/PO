using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy3
{
    class Osoba
    {
        public string imie;
        public string nazwisko;
        public int rok_urodzenia;
        private string miejsceZamieszkania;

        public Osoba(string imie, string nazwisko, int rok_urodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rok_urodzenia = rok_urodzenia;
        }
        public void WypiszInfo()
        {
            Console.WriteLine("Osoba \n {0} {1}, urodzona w {2} roku.", this.imie, this.nazwisko, this.rok_urodzenia);
        }
        public int ObliczWiek()
        {
            int wiek;
            wiek = DateTime.Now.Year - this.rok_urodzenia;
            return wiek;
        }

    }
}
