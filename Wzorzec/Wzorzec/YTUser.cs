using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec
{
    class YTUser : IObserver
    {
        private String name;
        private int videosToWatch;

        public YTUser(String name)
        {
            this.name = name;
            videosToWatch = 0;
        }
        public void Update()
        {
            videosToWatch++;
            Console.WriteLine("Hey " + name + "! There is a new video! You have " + videosToWatch + " videos to watch.");
        }
    }
}
