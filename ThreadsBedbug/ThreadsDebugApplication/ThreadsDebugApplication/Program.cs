using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace ThreadsDebugApplication
{
    class Program
    {

        static void Main(string[] args)
        {

            Thread t1 = new Thread(new ThreadStart(Hello));
            t1.Name = "Thread 1";
            Thread t2 = new Thread(new ThreadStart(World));
            t2.Name = "Thread 2";
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
        static void Hello()
        {
            Console.Write("Hello ");
            Thread.Sleep(10000);
        }
        static void World()
        {
            Console.WriteLine("world!");
            Thread.Sleep(10000);
        }

    }
}
