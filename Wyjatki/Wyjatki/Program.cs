using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba1 = 30;
            int liczba2 = 0;
            int liczba3;
            int[] tab = new int[2];
            try
            {
                liczba3 = liczba1 / liczba2;
            }
            catch(Exception e)
            {
                liczba3 = 0;
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("FINALLY");
            }

            try
            {
                tab[25] = 2;
                throw new IndexOutOfRangeException();
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("wyjatek1");
            }
            catch
            {
                Console.WriteLine("wyjatek2");
            }
            Console.ReadKey();
        }
    }
}
