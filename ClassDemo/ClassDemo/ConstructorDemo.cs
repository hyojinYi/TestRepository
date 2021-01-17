using System;

namespace ClassDemo
{
    class ConstructorDemo
    {
        public ConstructorDemo() //생성자
        {
            Console.WriteLine("생성자가 호출되었습니다.");
        }

        static void Main()
        {
            ConstructorDemo c = new ConstructorDemo();
        }
    }
}
