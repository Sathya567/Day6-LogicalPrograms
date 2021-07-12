using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Assignment
{
    class UC1_FibonacciSeries
    {
        public int Number1 = 0;
        public int Number2 = 1;
        public int Number3;
        public int Var_i;
        public int ReadNumber;
        public void CheckFibonacciSeries()
        {

            Console.Write("Enter the number of elements: "); //Input From User
            ReadNumber = int.Parse(Console.ReadLine()); //Read Number 
            Console.WriteLine(Number1 + " " + Number2 + " "); //printing 0 and 1    
            for (Var_i = 2; Var_i < ReadNumber; ++Var_i) //loop starts from 2 because 0 and 1 are already printed    
            {
                Number3 = Number1 + Number2; //adding Number1 + Number 2 and storee it in Number 3
                Console.WriteLine(Number3 + " ");  // print Number3
                Number1 = Number2; //assign value
                Number2 = Number3;//assign value
            }

        }
    }
}
    
