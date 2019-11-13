using System;
using System.Threading;

namespace MonoDockerTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm alive...");

            while (true)
            {
                Console.WriteLine($"It's currently {DateTime.Now}, and I'm still alive...");
                Thread.Sleep(60000);
            }
        }
    }
}
