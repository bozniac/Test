using System;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 36;
            int y = 50;

            Console.WriteLine($"x is {x}");
            Console.WriteLine($"y is {y}");

            // swapping...
            Swap(ref x, ref y);

            Console.WriteLine($"x is now {x}");
            Console.WriteLine($"y is now {y}");
        }

        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}