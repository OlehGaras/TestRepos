using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace thread
{
    class Program
    {
        int time = 1000;
        static void Main(string[] args)
        {
            Thread t = new Thread(f);
            t.Start(1000);
            f(1000);
        }
        static void f(Object o)
        {
            lock (new object() )
            {
                Thread.Sleep((int)o);
                Console.WriteLine((int)o);
            }
        }
    }
}
