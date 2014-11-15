using System;
using System.Net.Http;
using Microsoft.Owin.Hosting;

namespace SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            const string baseAddress = "http://localhost:19000/";

            using (WebApp.Start<Startup>(url: baseAddress))
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = client.GetAsync(baseAddress + "api/persons").Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            }

            Console.ReadLine(); 
        }
    }
}
