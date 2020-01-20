using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Car
    {
        protected string Name;
        protected string Model;
        public readonly string VIN;
        public string Wheels;
        public string Seats;
        public string Engine;
        public List<string> Equipment;

        public Car(string a)
        {
            this.VIN = a;
        }
    }
}
