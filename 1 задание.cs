﻿using System;

namespace _1_задание
{
    class Program
    {
        public static void Main(string[] args)
        {
            int mx = 0;
            int CN = 0;
            int A = -1;
            int N;
            do
            {
                if (int.TryParse(Console.ReadLine(), out N))
                {
                    if (A == N)
                    {
                        CN++;
                    }
                    else
                    {
                        if (CN > mx)
                        {
                            mx = CN;
                        }
                        CN = 1;
                        A = N;
                    }
                }
            } while (N != 0);
            Console.WriteLine(mx);
        }
    }
}