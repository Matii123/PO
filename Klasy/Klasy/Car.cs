using System;
using System.Collections.Generic;
using System.Text;

namespace Klasy
{
    public class Car
    {
        public string marka = "Audi";
        private string model;
        public int rok = 2005;
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        public int srednieSpalanie;

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            double srednieSpalanie = 0.05;
            return srednieSpalanie * dlugoscTrasy;
        }
        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            return ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
        }


    }
}
