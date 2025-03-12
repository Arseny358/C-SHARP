using System;

namespace _15_задание_дз
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] Ar = { 1, 2, 3, 4, 5 };
            if (Class1.Chetn_sum(Ar) == 3)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Error");
            }
            int[] Ar1 = {-1, -2, -3, -4, -5};
            if (Class1.Chetn_sum(Ar1) == 0)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Error");
            }
            int[] Ar2 = {1, -2, 3, 4, 5, 6};
            if (Class1.Chetn_sum(Ar2) == 5)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Error");
            }
            int[] Ar3 = {-1, -2, -3, -4, -5, 6};
            if (Class1.Chetn_sum(Ar3) == 6)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Error");
            }
            int[] Ar4 = {-3};
            if (Class1.Chetn_sum(Ar4) == 0)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}