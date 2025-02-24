using System;

namespace Семинар
{
    class Program
    {
        public static int Max_value(int[] ar)
        {
            int _max = ar[0];
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > _max)
                {
                    _max = ar[i];
                }
            }
            return _max;
        }

        public static int Min_value(int[] ar)
        {
            int _min = ar[0];
            for (int i = 1; i < ar.Length; i++)
            {
                if (_min > ar[i])
                {
                    _min = ar[i];
                }
            }
            return _min;
        }

        public static int[] Replace_value(int[] ar)
        {
            int _max = Max_value(ar);
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == _max)
                {
                    ar[i] = 100;
                }
            }
            return ar;
        }

        public static int[] Replace_value2(int[] ar)
        {
            int _min = Min_value(ar);
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == _min)
                {
                    ar[i] = 0;
                }
            }
            return ar;
        }

        static void Main(string[] args)
        {
            int[] ar = {3, 1, 2, 8};

            int _max = Max_value(ar);
            int _min = Min_value(ar);

            Console.WriteLine($"Максимальное значение: {_max}");
            Console.WriteLine($"Минимальное значение: {_min}");

            int[] new_ar = Replace_value(ar);

            int[] new_ar2 = Replace_value2(new_ar);
            Console.WriteLine("Конечный массив: " + String.Join(", ", new_ar2));
        }
    }
}
