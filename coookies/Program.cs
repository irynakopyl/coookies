using System;
using System.IO;
using System.Net;

namespace coookies
{
    class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login("https://bpmtest.ukr-china.eu", "testuser", "testuser333");
            Console.WriteLine("First request`s response:");
            login.TryLogin();
            Console.WriteLine("Second request`s response:");
            login.AddRecord("Iryna");
            Console.ReadLine();
        }

    }
   
}
