using System;
using System.Linq;

namespace TestPjt
{
    class CountAlgorithm
    {
        static void Main()
        {
            //1
            var numbers = Enumerable.Range(1, 1_000).ToArray();
            int count = default;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 13 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"1부터 1000까지 정수 중 13의 배수 개수 : {count}");

            //2
            Console.WriteLine(Enumerable.Range(1, 1000).Where(n=>n%13==0).Count());

            //3
            Console.WriteLine(Enumerable.Range(1,1000).Count(n=>n%13==0));
        }
    }
}
