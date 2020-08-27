using System;
using System.Threading;
namespace ConsoleApp1
{
    class Program
    {

        class ThreadSafe
        {
            static bool done; // Статичне поле, розділене потоками 
            static object locker = new object();//статичний об’єкт locker для блокування потоку
            static void Main()
            {
                new Thread(Go).Start(); // новий потік викликає Go
                Go(); // викликаємо Go в головному потоці
            }
            static void Go()// функція з умовою для виводу слова Done
            {
                lock (locker)// оператор lock для блокування потоку
                {
                    if (!done)
                    {
                        Console.WriteLine("Done");
                        done = true;
                    }
                }
            }
        }
    }
}
