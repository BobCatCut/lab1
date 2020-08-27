using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        class ThreadTest
        {
            static bool done; // Статичне поле, розділене потоками 
            static void Main()
            {
                new Thread(Go).Start(); // новий потік викликає Go
                Go(); // викликаємо Go в головному потоці
            }
            static void Go() // функція з умовою для виводу слова Done
            {
                if (!done) { done = true; Console.WriteLine("Done"); }
            }
        }
    }
}
