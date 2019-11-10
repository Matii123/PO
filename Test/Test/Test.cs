using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Test : IClonable
    {
        public int liczba;
        public Object Clone()
        {
            return MemberwiseClone();
        }
    }
}
