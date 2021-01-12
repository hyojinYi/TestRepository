using System;
using System.Diagnostics;
using System.Threading;

namespace TestPjt
{
    class StopwatchDemo
    {
        static void Main()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            LongTimeProcess();
            timer.Stop();

            //밀리초 단위로 표시
            Console.WriteLine($"경과시간: {timer.Elapsed.TotalMilliseconds}밀리초");

            //초 단위로 표시
            Console.WriteLine($"경과 시간 : {timer.Elapsed.Seconds}초");
        }

        static void LongTimeProcess()
        {
            //3초간 대기 : Thread.Sleep() 메서드로 현재 프로그램 3초간 대기
            Thread.Sleep(3000);
        }
    }
}
