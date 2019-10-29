using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Klasy
{
    class Car
    {
        private double PojemnoscSilnika;
        private string Marka;
        public static int IloscKol = 4;

        public Car()
        {
            this.PojemnoscSilnika = 1.8;
            this.Marka = "Opel";
        }
        public Car(double PojemnoscSilnika, string Marka)
        {
            this.PojemnoscSilnika = PojemnoscSilnika;
            this.Marka = Marka;
        }
        public void CarCreate()
        {
            Console.WriteLine("Pojemnosc: {0} Marka: {1}", this.PojemnoscSilnika, this.Marka);
        }

        ~Car()
        {
            MessageBox.Show("Zwolnij pamiec");
        }
    }
}
