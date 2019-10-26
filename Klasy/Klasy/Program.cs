using System;

namespace Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Console.WriteLine("car1: " + "marka: " + car1.marka + " " + "rok: " + car1.rok);
            Car car2 = new Car();
            car2.marka = "Ford";
            car2.rok = 1996;
            car2.srednieSpalanie = 2;
            /*
            Console.WriteLine("car2: " + "marka: " + car2.marka + " " + "rok: " + car2.rok);
            car1 = car2;
            Console.WriteLine();
            Console.WriteLine("car1: " + "marka: " + car1.marka + " " + "rok: " + car1.rok);
            Console.WriteLine("car2: " + "marka: " + car2.marka + " " + "rok: " + car2.rok);
            car1.marka = "Opel";
            Console.WriteLine();
            Console.WriteLine("car1: " + "marka: " + car1.marka + " " + "rok: " + car1.rok);
            Console.WriteLine("car2: " + "marka: " + car2.marka + " " + "rok: " + car2.rok);
            */
            Console.WriteLine("kosz przejazdu  {0} na trasie 100km wynosi: {1}", car2.marka, car2.ObliczKosztPrzejazdu(100, 1.98));

            Osoba dyrektor = new Osoba();
            dyrektor.imie = "Jasio";
            dyrektor.nazwisko = "Kowalski";
            dyrektor.rokUrodzenia = 1950;
            dyrektor.plec1 = Osoba.plec.M;
            dyrektor.przedrostek();

            Console.WriteLine("Imie: " + dyrektor.imie + " Nazwisko: " + dyrektor.nazwisko + " Wiek: " + dyrektor.obliczWiek(dyrektor.rokUrodzenia));

            Osoba Pacjent = new Osoba();
            Pacjent.imie = "Piotr";
            Pacjent.nazwisko = "Nowak";
            Pacjent.wzrost = 180;
            Pacjent.waga = 68;
            Pacjent.BMI();

            koszyk kosz = new koszyk();
            kosz.DodajProdukty(new Produkt("marchew", 3.50));
            kosz.DodajProdukty(new Produkt("chleb", 4));
            kosz.DodajProdukty(new Produkt("maslo", 2.50));
            kosz.DodajProdukty(new Produkt("mleko", 3.50));

            kosz.WyswietlProdukty();

            Console.ReadKey();

        }
    }
}