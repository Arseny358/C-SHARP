using System;
using System.Collections.Generic;

namespace _2_задание
{
    class Program
    {
        public static void Main(string[] args)
        {
            int N;
            if (!int.TryParse(Console.ReadLine(), out N) || N < 2)
            {
                Console.WriteLine("Неверный ввод или число меньше 2");
                return;
            }
            List<int> делит = new List<int>();
            VseDeliteli(N, ref делит);
            if (делит.Count >= 2)
            {
                Console.WriteLine(делит[1]);
            }
            else
            {
                Console.WriteLine("Кроме 1 больше нет значений");
            }
        }
        public static void VseDeliteli(int N, ref List<int> делит)
        {
            делит.Clear();
            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    делит.Add(i);
                }
            }
        }
    }
}
