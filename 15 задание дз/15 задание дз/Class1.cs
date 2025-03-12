using System;

namespace _15_задание_дз
{
    class Class1
    {
        public static int Chetn_sum(int[] numbers)
        {
            int s = 0;
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && numbers[i] > 0)
                {
                    s += numbers[i];
                    count++;
                }
            }
            if (count > 0)
                return s / count;
            else
                return 0;
        }
    }
}
