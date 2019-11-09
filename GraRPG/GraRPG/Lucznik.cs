using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraRPG
{
    class lucznik: bohater
    {
        public int zrecznosc;
        public int punktyTaktyki;
        public int mocAtaku;

        public lucznik(string imie, int zywotnosc, int zrecznosc, int punktyTaktyki)
        {
            this.imie = imie;
            this.zywotnosc = zywotnosc;
            this.zrecznosc = zrecznosc;
            this.punktyTaktyki = punktyTaktyki;
        }
        public void Atak()
        {
            this.mocAtaku = zrecznosc * punktyTaktyki * zywotnosc;
        }
        public void Info()
        {
            Console.WriteLine("Bohater 1: imie: {0} zywotnosc: {1} zrecznosc: {2} punkty taktyki: {3} punkty ataku: {4}", this.imie, this.zywotnosc, this.zrecznosc, this.punktyTaktyki, this.mocAtaku);
        }
    }
}
