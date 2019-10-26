using System;
using System.Collections.Generic;
using System.Text;

namespace Klasy
{
    class koszyk
    {
        private List<Produkt> produkty = new List<Produkt>();

        public void DodajProdukty(Produkt p)
        {
            this.produkty.Add(p);
        }

        public void WyswietlProdukty()
        {
            foreach (Produkt prod in this.produkty)
            {
                Console.WriteLine(prod.WyswietlOpis());
            }
        }
    }
}
