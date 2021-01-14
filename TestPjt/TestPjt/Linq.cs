using System;
using System.Linq;
using System.Collections.Generic;

namespace TestPjt
{
    class Linq
    {
        static void Main()
        {
            int[] numbers = { 1, 3, 4 };

            int sum = numbers.Sum();
            Console.WriteLine($"numbers 배열 요소의 합 : {sum}");

            int count = numbers.Count();
            Console.WriteLine($"{nameof(numbers)} 배열개수: {count}");

            double average = numbers.Average();
            Console.WriteLine($"{nameof(numbers)} 배열 요소 평균 : {average:#,###.##}");

            var numbers2 = new List<int>() { 1, 2, 3 };
            int max = numbers2.Max();
            Console.WriteLine($"{nameof(numbers2)} 컬렉션의 최댓값 : {max}");

            var numbers3 = new List<double> { 3.3, 2.2, 1.1 };
            var min = numbers3.Min();
            Console.WriteLine($"{nameof(numbers)} 리스트 최솟값 : {min:.00}");

            int[] arr = { 1, 2, 3 };
            int min2 = arr.Min();
            int max2 = arr.Max();

            Console.WriteLine($"최솟값 : {min2}, 최댓값 : {max2}");
        }
    }
}
