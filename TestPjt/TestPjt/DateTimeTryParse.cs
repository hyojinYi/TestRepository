using System;

namespace ClassDemo
{
    class DateTimeTryParse
    {
        static void Main()
        {
            DateTime dt;

            if (DateTime.TryParse("2020-01-01", out dt))
            {
                Console.WriteLine(dt);
            }
            else
            {
                Console.WriteLine("날짜형식으로 변환할 수 없습니다.");
            }
            if (DateTime.TryParse("2020-01-01", out var myDate))
            {
                Console.WriteLine(myDate);
            }
        }
    }
}
