using System;
using System.Linq;

namespace TestPjt
{
    class MaxAlforithm
    {
        static void Main()
        {
            int max = int.MinValue;

            int[] numbers = { -2, -5, -3, -7, -1 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine($"최댓값(식) : {numbers.Max()}");
            Console.WriteLine($"최댓값(문) : {max}");
        }
    }
}
