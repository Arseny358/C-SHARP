using System;

namespace _14_задание_дз
{
    class Program
    {
        public static void Main(string[] args)
        {
            if (Summ_nubers_number.Test_snumb(123) == 6)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");
            if (Summ_nubers_number.Test_snumb(12) == 3)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");
            if (Summ_nubers_number.Test_snumb(1) == 1)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");
            if (Summ_nubers_number.Test_snumb(10000000) == 1)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");
            if (Summ_nubers_number.Test_snumb(345) == 12)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");
            if (Summ_nubers_number.Test_snumb(0) == 0)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");
        }
    }
}
