using System;
using System.Net.Http;
using Microsoft.Owin.Hosting;
using WebService;

namespace SelfHost
{
    public class Program
    {
        public static void Main()
        {
            const string serviceAddress = "http://localhost:19000/";

            using (WebApp.Start<Startup>(url: serviceAddress))
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = client.GetAsync(serviceAddress + "api/persons").Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            }

            Console.ReadLine(); 
        }
    }
}
