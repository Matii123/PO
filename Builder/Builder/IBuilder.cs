using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface IBuilder
    {
        void AddSeats();
        void AddWheels();
        void AddEquipment();
        void AddEngine();
        Car GetCar();
    }
}
