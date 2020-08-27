using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            new Thread(Go).Start();
            Go();
        }
        static void Go()
        {
            for (int cycles = 0; cycles < 5; cycles++)
                Console.Write('P');
        }
    }
}
