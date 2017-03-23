using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace OperatorLock
{
    class Work
    {
        int i, j;
        object LockObj = new object();
        public void ThreadStart()
        {
            lock (LockObj)
            {
                if (i != j)
                    Console.WriteLine("Ошибка");
                i++;
                Thread.Sleep(200);
                j++;
                Console.WriteLine("{0},{1}", i, j);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Work store = new Work();

            for (int i = 0; i < 10; ++i)
            {
                new Thread(new ThreadStart(store.ThreadStart)).Start();
                Thread.Sleep(100);
            }

            Console.ReadLine();
        }
    }
}
