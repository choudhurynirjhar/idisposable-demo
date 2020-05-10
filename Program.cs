using System;

namespace IDisposable.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using var serviceProxy = new ServiceProxy(null);

            serviceProxy.Get();
            // DO something 
            serviceProxy.Post("");
            // Other code
        }
    }
}
