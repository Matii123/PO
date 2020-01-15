using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec
{
    class YTChannel : IObservable
    {
        private List<IObserver> observerList;

        public YTChannel()
        {
            observerList = new List<IObserver>();
        }
        public void publishNewVideo()
        {
            Console.WriteLine("YTChannel: Publisching new video.");
            this.NotifyObservers();
        }
        public void NotifyObservers()
        {
            foreach (var o in observerList)
            {
                o.Update();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            observerList.Remove(observer);
        }
    }
}
