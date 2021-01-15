using System;
using System.Linq;

namespace TestPjt
{
    class Map
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            var nums = numbers.Select(it => it * it);

            foreach(var num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
