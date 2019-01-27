using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TwoThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(Count);
            myThread.Start();

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Главный поток:");
                Console.WriteLine(i);
                Thread.Sleep(300);
            }
            Console.ReadLine();
        }

        private static void Count()
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Второй поток:");
                Console.WriteLine(i);
                Thread.Sleep(400);
            }
        }
    }
}
