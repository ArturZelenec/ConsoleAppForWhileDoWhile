using System;

namespace ConsoleAppForWhileDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Element: {0}", i);
            }
            Console.WriteLine("___________________");

            for (double i = 200; i > 10; i /= 2)
            {
                Console.WriteLine("Element: " + i);
            }
            Console.WriteLine("___________________");

            int x = 0;
            while (x < 10)
            {
                Console.WriteLine("Element: {0}", x);
                x++;
            }
            Console.WriteLine("___________________");

            double z = 200;
            while (z > 10)
            {
                Console.WriteLine("Element: {0}", z);
                z /= 2;
            }
            Console.WriteLine("__________________");

            Console.WriteLine("Enter text or whrite end to cancel");
            bool isHasCar = true;
            while (isHasCar)
            {
                string end = Console.ReadLine();
                if (end == "end")
                {
                    isHasCar = false;
                }
            }
            Console.WriteLine("__________________");


            // do always doing 1 time if while are false
            int j = 100;
            do
            {
                Console.WriteLine("Element: {0}", j);
            } while (j < 10);
            Console.WriteLine("__________________");

            for (int i = 0; i < 10; i++)
            {
                // until 5 after break
                if (i > 5)
                {
                    break;
                }
                Console.WriteLine("Element: {0}", i);
            }
            Console.WriteLine("_________________");

            for (int i = 0; i < 10; i++)
            {
                // till 10 but  misses true eteration
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine("Element: {0}", i);
            }
            Console.WriteLine("_________________");
        }
    }
}
