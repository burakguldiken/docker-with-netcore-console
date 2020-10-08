using System;
using System.Threading;

namespace dockerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;

            while(count < 100)
            {
                Console.WriteLine($"Hello Docker {count}");

                Thread.Sleep(TimeSpan.FromSeconds(1));

                count++;
            }
        }
    }
}
