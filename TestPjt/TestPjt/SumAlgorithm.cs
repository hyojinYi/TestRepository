﻿using System;
using System.Linq;

namespace TestPjt
{
    class SumAlgorithm
    {
        static void Main()
        {
            //1
            int[] scores = { 100, 75, 50, 37, 90, 95 };
            int sum = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] >= 80)
                {
                    sum += scores[i];
                }
            }
            Console.WriteLine($"{scores.Length}명의 점수 중 80점 이상 총점 : {sum}");

            //2
            int sum2 = (new int[] { 100, 75, 50, 37, 90, 95 }).Where(s => s >= 80).Sum();
            Console.WriteLine(sum2);
        }
    }
}
