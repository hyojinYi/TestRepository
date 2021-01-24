using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClassDemo
{
    class HttpClientDemo
    {
        static async Task Main()
        {
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("http://www.microsoft.com/");

            string responseBody = await httpResponseMessage.Content.ReadAsStringAsync();

            Console.WriteLine(responseBody);
        }
    }
}
