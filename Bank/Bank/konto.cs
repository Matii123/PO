using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class konto
    {
        public int saldoPoczatkowe;
        public int obecneSaldo;

        public konto(int saldoPoczatkowe)
        {
            this.obecneSaldo = saldoPoczatkowe;
        }

        public void wyplata(int kwota)
        {
            this.obecneSaldo = this.obecneSaldo - kwota;
        }
        public void wplata(int kwota)
        {
            this.obecneSaldo = this.obecneSaldo + kwota;
        }
        public void Info()
        {
            Console.WriteLine("Stan konta wynosi "+ this.obecneSaldo);
        }
    }
}
