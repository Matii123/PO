using System;
using System.Collections.Generic;
using System.Text;

namespace Klasy
{
    class Produkt
    {
        public string nazwa;
        public double cena;

        public Produkt(string nazwa, double cena)
        {
            this.nazwa = nazwa;
            this.cena = cena;
        }
        public string WyswietlOpis()
        {
            return String.Format("{0} : {1}", nazwa, cena);
        }

    }
}
