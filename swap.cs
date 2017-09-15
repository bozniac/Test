using System;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 28;
            int y = 50;

            Console.WriteLine($"x is {x}");
            Console.WriteLine($"y is {y}");

            // swapping...
            int temp = x;
            x = y;
            y = temp;

            Console.WriteLine($"x is now {x}");
            Console.WriteLine($"y is now {y}");
        }
    }
}