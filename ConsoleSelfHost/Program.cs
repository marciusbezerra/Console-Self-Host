using System;
using Microsoft.Owin.Hosting;

namespace ConsoleSelfHost
{
    class Program
    {
        const string Url = "http://localhost:9001";

        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>(Url))
            {
                Console.WriteLine("Server started at:" + Url);
                Console.ReadLine();
            }
        }
    }
}
