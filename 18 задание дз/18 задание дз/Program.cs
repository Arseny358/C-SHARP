using System;
using System.Collections.Generic;
using System.Linq;

namespace _18_задание_дз
{
    class Program
    {
        public static List<int> Prigr(int N)
        {
            List<int> e = new List<int>();
            while (N % 2 == 0)
            {
                e.Add(2);
                N /= 2;
            }
            for (int i = 3; i * i <= N; i += 2)
            {
                while (N % i == 0)
                {
                    e.Add(i);
                    N /= i;
                }
            }
            if (N > 1)
            {
                e.Add(N);
            }

            return e;
        }

        public static void Main(string[] args)
        {
            List<int> a = new List<int> { 3, 3, 3 };
            List<int> b = Prigr(27);
            if (a.SequenceEqual(b))
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");

            List<int> a1 = new List<int> { 2, 2, 2, 2, 3 };
            List<int> b1 = Prigr(48);
            if (a1.SequenceEqual(b1))
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");

            List<int> a2 = new List<int> { 2, 2, 2, 2, 2, 2, 3, 3, 7};
            List<int> b2 = Prigr(4032);
            if (a2.SequenceEqual(b2))
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");

            List<int> a3 = new List<int> { 3 };
            List<int> b3 = Prigr(3);
            if (a3.SequenceEqual(b3))
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");
        }
    }
}
