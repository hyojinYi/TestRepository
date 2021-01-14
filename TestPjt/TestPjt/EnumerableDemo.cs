using System;
using System.Linq;

namespace TestPjt
{
    class EnumerableDemo
    {
        static void Main()
        {
            var numbers = Enumerable.Range(1, 5);
            foreach (var n in numbers)
            {
                Console.Write($"{n}\t");
            }


            Console.WriteLine();

            var sameNumbers = Enumerable.Repeat(-1, 5);
            foreach (var n in sameNumbers)
            {
                Console.Write($"{n}\t");
            }
            Console.WriteLine();
        }
    }
}
