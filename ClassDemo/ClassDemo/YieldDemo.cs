using System;
using System.Collections;

namespace ClassDemo
{
    class YieldDemo
    {
        static IEnumerable GetNumbers()
        {
            yield return 1;
            yield return 2;
            for (int i = 3; i <= 5; i++)
            {
                yield return i;
            }
        }

        static void Main()
        {
            foreach (var num in GetNumbers())
            {
                Console.WriteLine($"{num}\t", num);
            }
            Console.WriteLine();
        }
    }
}
