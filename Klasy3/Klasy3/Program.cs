using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy3
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba jasio = new Osoba("Jan", "Kowalski", 1986);
            Student krzysiu = new Student("Krzysiek", "Nowak", 1986, 2, 124633, 3);

            Type type = jasio.GetType();
            foreach (var f in type.GetFields())
            {
                Console.WriteLine( String.Format("Nazwa: {0}, Typ: {2},  Wartość: {1}", f.Name, f.GetValue(jasio), f.FieldType));
                
            }

            jasio.WypiszInfo();
            krzysiu.WypiszInfo();

            Console.WriteLine("Wiek Jasia to: " + jasio.ObliczWiek());


            Console.ReadKey();
        }
    }
}
