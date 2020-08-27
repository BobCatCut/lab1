using System;
using System.Threading;
namespace ConsoleApp1
{
    class Program
    {
        class ThreadTest

        {

            bool done;
            static void Main()
            {
                ThreadTest tt = new ThreadTest();
                new Thread(tt.Go).Start();
                tt.Go();
            }
            void Go()
            {
                if (!done) { done = true; Console.WriteLine("Done"); }
            }
        }
    }
}
