using System;

namespace _11_задание
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите a");
            string a = Console.ReadLine();
            int A = Int32.Parse(a);
            Console.WriteLine("Введите b:");
            string b = Console.ReadLine();
            int B = Int32.Parse(b);
            if (A == 0)
            {
                if (B == 0)
                {
                    Console.WriteLine($"Уравнение {A} * x = {B} имеет бесконечно много решений, т.к. a = 0 и b = 0");
                }
                else
                {
                    Console.WriteLine($"Уравнение {A} * x = {B} не имеет решений, т.к. a = 0");
                }
            }
            else
            {
                int x = B / A;
                Console.WriteLine($"Уравнение: {a} * x = {b}. x = {x}");
            }

        }
    }
}