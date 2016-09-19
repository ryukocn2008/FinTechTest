using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class StopJoin
    {
        public class Alpha
        {
            public void Beta()
            { 
                while(true)
                {
                    Console.WriteLine("Alpha.Beta is running in its own thread");
                }
            }
        }

        public static int Main(string[] args)
        {
            Console.WriteLine("Thread Start/Stop/Join Sample");

            Alpha oAlpha = new Alpha();

            Thread oThread = new Thread(new ThreadStart(oAlpha.Beta));

            oThread.Start();
            while (!oThread.IsAlive) ;
            Thread.Sleep(1);

            oThread.Abort();
            oThread.Join();

            Console.WriteLine();
            Console.WriteLine("Alpha.Beta has finished");

            try
            {
                Console.WriteLine("Try to restart the Alpha.Beta thread");
                oThread.Start();
            }
            catch (ThreadStateException)
            {
                Console.Write("ThreadStateException trying to restart Alpha.Beta. ");
                Console.WriteLine("Excepted since aborted thread cannot be restarted.");
            }

            return 0;
        }
    }
}
