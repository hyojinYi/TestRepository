using System;
using static System.Console;

namespace TestPjt
{
    class PatternMatchingWithIf
    {
        static void Main()
        {
            PrintStars(null);
            PrintStars("하나");
            PrintStars(5);
        }
        static void PrintStars(object o)
        {
            if (o is null)
            {
                return;
            }

            if(o is string)
            {
                return;
            }

            //패턴 매칭: 넘어온 값이 정수 형식이면 int number =o;
            if (!(o is int number))
            {
                return;
            }
            WriteLine(new String('*', number));
        }
    }
}
