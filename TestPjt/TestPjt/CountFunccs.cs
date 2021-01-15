using System;
using System.Linq;

namespace TestPjt
{
    class CountFunccs
    {
        static void Main()
        {
            bool[] blns = { true, false, true, false, true };

            Console.WriteLine(blns.Count());
            Console.WriteLine(blns.Count(bln =>bln == true));
            Console.WriteLine(blns.Count(bln => bln == false));
        }
    }
}
