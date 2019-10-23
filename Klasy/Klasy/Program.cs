using System;

namespace Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.marka = "Audi";
            car1.rok = 2005;
            Console.WriteLine("car1: " + "marka: " + car1.marka + " " + "rok: " + car1.rok);
            Console.ReadKey();

        }
    }
}
