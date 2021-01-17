using System;

namespace ClassDemo
{
    class Student
    {
        public Student()
        {
            Console.WriteLine("Student 개체가 생성됩니다.");
        }
    }
    class ConstrucTorMethod
    {
        static void Main()
        {
            Student student = new Student();

        }
    }
}
