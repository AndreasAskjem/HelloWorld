using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for(int i=0; i<11; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Hello {0}", i);
                }
            }

            Console.Beep(699, 200);
            Console.Beep(523, 100);
            Console.Beep(523, 100);
            Console.Beep(587, 200);
            Console.Beep(523, 400);
            Console.Beep(659, 200);
            Console.Beep(699, 200);
            Console.WriteLine("Bye World!");
        }
    }
}
