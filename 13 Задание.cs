using System;

namespace _13_задание
{
    class Program
    {
        public static int Index(int[] ar, int t)
        {
            int l = 0;
            int h = ar.Length - 1;
            while (l <= h)
            {
                int m = (l + h) / 2;
                if (ar[m] == t)
                {
                    return m;
                }
                else if (ar[m] < t)
                {
                    l = m + 1;
                }
                else
                {
                    h = m - 1;
                }
            }
            return -1;
        }
        public static void Main(string[] args)
        {
            int[] ar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 16};
            int t = 16;
            int I = Index(ar, t);
            if (I != -1)
            {
                Console.WriteLine($"Индекс числа {t} == {I}");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}