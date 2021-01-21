using System;

namespace ClassDemo
{
    class TupleDeconstructionDescription
    {
        static void Main()
        {
            var (sum, count) = Tally();
            Console.WriteLine($"Sum : {sum}, count ; {count}");
        }
        static (int Sum, int Count) Tally()
        {
            var r = (s: 12, c: 3);
            Console.WriteLine($"{r.s}, {r.c}");
            return r;
        }
    }
}
