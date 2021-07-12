using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Assignment
{
    class UC2_PerfectNumber
    {
        public int Number;
        public int i;
        public int Result;

        public void CheckPerfectNumber()
        {
            Console.WriteLine("Input the  number : ");  //Input Number
            Number = int.Parse(Console.ReadLine());//Read Number
            Result = 0;//By Default Result is 0
            Console.WriteLine("The positive divisor  : ");
            for (i = 1; i < Number; i++) ////loop starts from 1 and Check if 1 < Given Number and den it will increment by1
            {
                if (Number % i == 0) //check Given ip Number % i == 0 (28 % 1 == 0 )
                {
                    Result = Result + i;  // Result = 0+1
                    Console.WriteLine("{0}  ", i); //{0} Format string  
                }
            }
            Console.WriteLine("\nThe sum of the divisor is : {0}", Result);  //print sum of divisor
            //Check Number is Perfect Or not
            if (Result == Number)
                Console.WriteLine("\nSo, the number is perfect.");
            else
                Console.WriteLine("\nSo, the number is not perfect.");
        }
    }
}
    
