using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    public class Cell
    {
        int cellContents;           // Cell contents
        bool readerFlag = false;    // State flag

        public int ReadFromCell()
        {
            lock (this)
            {
                if (!readerFlag)
                {
                    try
                    {
                        Monitor.Wait(this);
                    }
                    catch (SynchronizationLockException e)
                    {
                        Console.WriteLine(e);
                    }
                    catch (ThreadInterruptedException e)
                    {
                        Console.WriteLine(e);
                    }
                }

                Console.WriteLine("Consume: {0}", cellContents);
                readerFlag = false;
                Monitor.Pulse(this);
            }

            return cellContents;
        }

        public void WriteToCell(int n)
        {
            lock (this)
            {
                if (readerFlag)
                {
                    try
                    {
                        Monitor.Wait(this);
                    }
                    catch (SynchronizationLockException e)
                    {
                        Console.WriteLine(e);
                    }
                    catch (ThreadInterruptedException e)
                    {
                        Console.WriteLine(e);
                    }
                }
                cellContents = n;
                Console.WriteLine("Produce: {0}", cellContents);
                readerFlag = true;
                Monitor.Pulse(this);

            }
        }
    }

    public class CellProd
    {
        Cell cell;
        int quantity = 1;

        public CellProd(Cell box, int request)
        {
            cell = box;
            quantity = request;
        }
    }


    class MonitorSample
    {

    }
}
