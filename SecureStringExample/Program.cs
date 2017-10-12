using System;
using System.ServiceModel;

namespace SecureStringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting simple Service...");

            //var baseUri = new Uri("net.tcp://localhost:41523/stringinsert");
            var svcHost = new ServiceHost(typeof(StringInsertInstance));
            svcHost.Open();
            Console.WriteLine($"Service started and listens on {svcHost.BaseAddresses[0]}");

            Console.WriteLine("Press any key for exit");
            Console.ReadLine();

            svcHost.Close();
        }
    }
}
