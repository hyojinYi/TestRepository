using System;

namespace ObjectNote
{
    public class Counter
    {
        public void GetTodaayVisitCount()
        {
            Console.WriteLine("오늘 1234명이 접속했습니다.");
        }
    }
    class ObjectNote
    {
        static void Main()
        {
            Counter counter = new Counter();
            counter.GetTodaayVisitCount();
        }
    }
}
