using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec
{
    class Program
    {
        static void Main(string[] args)
        {
            YTChannel ytChannel = new YTChannel();

            YTUser ytUser = new YTUser("Matt");
            ytChannel.RegisterObserver(ytUser);

            /**
             * 
             * 
             * 
             * 
             */

            ytChannel.publishNewVideo();
            Console.WriteLine("------------------");

            YTUser ytUser2 = new YTUser("Patt");
            ytChannel.RegisterObserver(ytUser2);
            ytChannel.publishNewVideo();
            Console.WriteLine("------------------");

            ytChannel.RegisterObserver(ytUser);
            ytChannel.publishNewVideo();
            Console.WriteLine("------------------");

            Console.ReadKey();
        }
    }
}
