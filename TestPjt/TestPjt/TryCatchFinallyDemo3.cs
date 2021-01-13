using static System.Console;

namespace TestPjt
{
    class TryCatchFinallyDemo3
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 0;
            int r;

            try
            {
                r = x / y;

                WriteLine($"{x}/{y}={r}");
            }
            catch
            {
                WriteLine("예외가 발생했습니다.");
            }
            finally
            {
                WriteLine("프로그램을 종료합니다.");
            }
        }
    }
}