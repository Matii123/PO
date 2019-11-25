using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            pracownik programista = new programista();
            pracownik projektant = new projektant();
            pracownik ksiegowy = new ksiegowy();


            List<pracownik> lista = new List<pracownik>();
            lista.Add(programista);
            lista.Add(projektant);
            lista.Add(ksiegowy);

            foreach (var x in lista)
            {
                x.Pracuj();
            }


            Console.ReadKey();
        }
    }
}
