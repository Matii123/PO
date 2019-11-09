using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraRPG
{
    class wojownik: bohater
    {
        public int sila;
        public int punktyTaktyki;
        public int mocAtaku;

        public wojownik(string imie, int zywotnosc, int sila, int punktyTaktyki)
        {
            this.imie = imie;
            this.zywotnosc = zywotnosc;
            this.sila = sila;
            this.punktyTaktyki = punktyTaktyki;
        }
        public void Atak()
        {
            this.mocAtaku = sila * punktyTaktyki * zywotnosc;
        }
        public void Info()
        {
            Console.WriteLine("Bohater 2: imie: {0} zywotnosc: {1} sila: {2} punkty taktyki: {3} punkty ataku: {4}", this.imie, this.zywotnosc, this.sila, this.punktyTaktyki, this.mocAtaku);
        }
    }
}
