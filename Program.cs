using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Net.Http.Headers;

namespace ConsoleAppHTTP
{

    class Program
    {
        //static void Main(string[] args)
        //{
        //    Task task = new Task(() => LoadPage("https://yandex.ru/"));
        //    task.Start();
        //    Console.ReadLine();
        //}
        //static async void LoadPage(string uri)
        //{
        //    string _page = uri;
        //    using (HttpClient client = new HttpClient())
        //    {
        //        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        //        using (HttpResponseMessage message = await client.GetAsync(_page)) 
        //        {
        //            string responseBody = await message.Content.ReadAsStringAsync();
        //            Console.WriteLine(responseBody);
        //            Console.ReadLine();
        //        }
        //    } 
        //}
        static readonly HttpClient client = new HttpClient();
        private IEnumerable<string> contents;
        private static readonly object SyncObj = new object();

        static void Main()
        {
            var client = new vHttpClient("5a2a5f0e538dd5.6691914852255446e23a9bcac46ee5255625f5d5");
            var report = new SimpleReports();

            Task task = new Task(() => client.GETAsync(report.Dashboard("msk", "wildberries.ru")));
            task.Start();
            Console.ReadLine();
        }
    }
}
