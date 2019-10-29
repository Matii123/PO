using System;
using System.Windows.Forms;


namespace Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Car autko = new Car();
            Car autko2 = new Car(2.2, "Audi");
            Console.Write("Podaj pojemnosc silnika: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Podaj marke: ");
            string b = Console.ReadLine();
            Car autko3 = new Car(a, b);

            autko.CarCreate();
            autko2.CarCreate();
            autko3.CarCreate();

            Console.ReadKey();
        }
    }
}
