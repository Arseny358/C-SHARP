using System;

namespace _14_задание_дз
{
    class Summ_nubers_number
    {
        public static int Test_snumb(int number)
        {
            int s = 0;
            while (number > 0)
            {
                s += number % 10;
                number /= 10;
            }
            return s;
        }
    }
}
