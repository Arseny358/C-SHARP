using System;

namespace _6_задание
{
    class Program
    {
        public static void Main(string[] args)
        {
            int N;

            if (!int.TryParse(Console.ReadLine(), out N))
            {
                Console.WriteLine("Неверный ввод");
                return;
            }
            bool D = true;
            if (N >= 10)
            {
                int F = N % 10;
                N /= 10;
                while (N > 0)
                {
                    if (N % 10 != F)
                    {
                        D = false;
                        break;
                    }
                    N /= 10;
                }
            }
            if (D)
            {
                Console.WriteLine("Все цифры одинаковые");
            }
            else
            {
                Console.WriteLine("Не все цифры одинаковые");
            }
        }
    }
}
