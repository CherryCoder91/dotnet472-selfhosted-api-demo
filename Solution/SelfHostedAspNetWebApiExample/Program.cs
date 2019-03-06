using System;
using System.Net.Http;
using Microsoft.Owin.Hosting;

namespace SelfHostedAspNetWebApiExample
{
    public class Program
    {
        static void Main()
        {
            const string baseAddress = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                // Create HttpCient and make a request to api/values 
                var client = new HttpClient();

                var response = client.GetAsync(baseAddress + "api/examples").Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.ReadLine();
            }
        }
    }
}