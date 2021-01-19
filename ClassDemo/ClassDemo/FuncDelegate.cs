using System;

namespace ClassDemo
{
    class FuncDelegate
    {
        static void Main()
        {
            Console.WriteLine(Add(3, 5));

            Func<int, int, string> AddDelegate = Add;
            Console.WriteLine(AddDelegate(3, 5));

            Func<int, int, string> AddLamda = (a, b) => (a + b).ToString();
            Console.WriteLine(AddLamda(3,5));
        }

        static string Add(int a, int b) => (a + b).ToString();
    }
}
