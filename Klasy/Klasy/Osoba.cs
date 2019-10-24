using System;
using System.Collections.Generic;
using System.Text;

namespace Klasy
{
    public class Osoba
    {
        public string imie;
        public string nazwisko;
        public int rokUrodzenia;
        public int waga;
        public int wzrost;
        protected bool okulary;
        public plec plec1;
        public enum plec { K, M };

        public int obliczWiek(int rokUrodzenia)
        {
            return DateTime.Now.Year - rokUrodzenia;
        }
        public void przedrostek()
        {
            if (plec1 == plec.M)
            {
                Console.WriteLine("Pan " + this.imie + " " + this.nazwisko);
            }
            else
            {
                Console.WriteLine("Pani " + this.imie + " " + this.nazwisko);
            }
        }
        public void BMI()
        {
            float bmi = (float)this. waga/((float)this.wzrost / 100 * (float)this.wzrost / 100);
            if(bmi < 16.0)
            {
                Console.WriteLine("Wygłodzenie");
            }
            else if (bmi > 16.0 && bmi < 16.99)
            {
                Console.WriteLine("Wychudzenie");
            }
            else if (bmi > 17.0 && bmi < 18.49)
            {
                Console.WriteLine("Niedowaga");
            }
            else if (bmi > 18.5 && bmi < 24.99)
            {
                Console.WriteLine("Pozadana masa ciala");
            }
            else if (bmi > 25.0 && bmi < 29.99)
            {
                Console.WriteLine("Nadwaga");
            }
            else
            {
                Console.WriteLine("Otylosc");
            }
        }
    }
}
