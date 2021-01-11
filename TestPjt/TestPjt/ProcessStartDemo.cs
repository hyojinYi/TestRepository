using System.Diagnostics;

namespace TestPjt
{
    class ProcessStartDemo
    {
        static void Main()
        {
            Process.Start("Notepad.exe");
            Process.Start("Explorer.exe", "https://dotnetkorea.com");
        }
    }
}
