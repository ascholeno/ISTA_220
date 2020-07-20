﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            Console.Write("Please enter a positive integer: ");
            string inputValue = Console.ReadLine();
            long factorialValue = CalculateFactorial(inputValue);
            Console.WriteLine($"Factorial({inputValue}) is {factorialValue}");
        }

        long CalculateFactorial(string input)
        {
            int inputValue = int.Parse(input);
            long factorial(int dataValue)
            {
                if (dataValue == 1) 
                    return 1;
                else 
                    return dataValue * factorial(--dataValue);
            }
            long factorialValue = factorial(inputValue);
            return factorialValue;
        }
    }
}
