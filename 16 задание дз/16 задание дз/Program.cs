using System;

namespace _16_задание_дз
{
    class Program
    {
        public static int NOD(int a, int b)
        {
            while (b != 0)
            {
                int c = b;
                b = a % b;
                a = c;
            }
            return a;
        }
        public static void Main(string[] args)
        {
            if (NOD(12, 18) == 6)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");
            if (NOD(1, 2) == 1)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");
            if (NOD(3, 4) == 1)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");
            if (NOD(36, 36) == 36)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");
            if (NOD(225, 25) == 25)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");
            if (NOD(64, 18) == 2)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");
            if (NOD(20, 18) == 2)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");
        }
    }
}