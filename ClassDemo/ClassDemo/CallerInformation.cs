using System.Runtime.CompilerServices;
using static System.Console;

namespace ClassDemo
{
    class CallerInformation
    {
        static void Main()
        {
            TraceMessage("여기서 무엇인가 실행...");
        }
         
        public static void TraceMessage(string message,
            [CallerMemberName] string memberName= "",
            [CallerFilePath] string sourcefFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
        {
            WriteLine("실행 내용 : " + message);
            WriteLine("멤버 이름 : " + memberName);
            WriteLine("소스 경로 : " + sourcefFilePath);
            WriteLine("실행 라인 : " + sourceLineNumber);
        }
    }
}
