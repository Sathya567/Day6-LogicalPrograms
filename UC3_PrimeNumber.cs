using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Assignment
{
    class UC3_PrimeNumber
    {
        public int n;
        public int i;
        public int Remainder;
        public void CheckPrimeNumber()
        {
            Console.WriteLine("Enter a Number"); //Input Number
            n = int.Parse(Console.ReadLine());//Read Numbeer
            int a = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadLine();
        }
    }
}
