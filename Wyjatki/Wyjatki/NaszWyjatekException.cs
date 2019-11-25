using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    class NaszWyjatekException: Wyjatek
    {
        public NaszWyjatekException(string message): base(message)
        {

        }
        public NaszWyjatekException(String message, Exception innerException): base(message, innerException)
        {

        }
        public NaszWyjatekException(SerializationInfo info, StreamingContext context): base(info, context)
        {

        }

    }
}
