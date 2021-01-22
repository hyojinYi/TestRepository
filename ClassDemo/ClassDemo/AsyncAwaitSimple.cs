using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClassDemo
{
    class AsyncAwaitSimple
    {
        static async Task DoAsync()
        {
            using (var client = new HttpClient())
            {
                var r = await client.GetAsync("https://www.kosaf.go.kr/ko/main.do");
                var c = await r.Content.ReadAsStringAsync();

                Console.WriteLine(c); 
            }
        }

        static async Task Main()
        {
            await DoAsync();
        }
    }
}
