using System;

namespace ClassDemo
{
    public class Original { }
    public static class OriginalExtension
    {
        public static void NewMethod(this Original original) => Console.WriteLine("새로운 메서드 추가");
    }
    class ExtesionMethodNote
    {
        static void Main()
        {
            (new Original()).NewMethod();
        }
    }
}
