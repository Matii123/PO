using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class A4Builder : IBuilder
    {
        private Car car = new AudiA4("753");
        public void AddEngine()
        {
            car.Engine = "Klasyczny 136 konny Diesel";
        }

        public void AddEquipment()
        {
            car.Equipment = new List<string>();
            car.Equipment.Add("Standardowe radio CD");
            car.Equipment.Add("Lakier matowy, kolor biały");
        }

        public void AddSeats()
        {
            car.Seats = "Klasyczne fotele. Kolor szaro-czarny";
        }

        public void AddWheels()
        {
            car.Wheels = "16 calowe stalowe felgi. Opona 205/55 Continental.";
        }

        public Car GetCar()
        {
            return car;
        }
    }
}
