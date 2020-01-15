using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec
{
    interface IObservable
    {
        void RegisterObserver(IObserver observer);
        void UnregisterObserver(IObserver observer);
        void NotifyObservers();
    }
}
