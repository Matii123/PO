using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class AudiA4 : Car
    {
        public AudiA4(string VIN):base(VIN)
        {
            Name = "Audi";
            Model = "A4";
        }
    }
}
