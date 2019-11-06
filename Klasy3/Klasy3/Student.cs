using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy3
{
    class Student : Osoba
    {
        int rok;
        int numerGrupy;
        int numerAlbumu;
        public Student(string imie, string nazwisko, int rok_urodzenia, int rok, int numerGrupy, int numerAlbumu) : base(imie, nazwisko, rok_urodzenia)
        {
            this.rok = rok;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
        }
        public void WypiszInfo()
        {
            Console.WriteLine("Osoba \n {0} {1}, urodzona w {2} roku. rok: {3} numer grupy: {4} numer albumu: {5}", this.imie, this.nazwisko, this.rok_urodzenia, this.rok, this.numerGrupy, this.numerAlbumu);
        }
    }
}
