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
            

            Console.ReadKey();

        }
    }
}
