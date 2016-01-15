using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_5_1_if_statement
{
    class Program
    {
        static void Main()
        {
            /*  Exercise_5_1 
           Write an if-statement that takes two integer variables 
           and exchanges their values if the first one is greater 
           than the second one. (Chapter 5, Exercise 1)*/

            Console.WriteLine("Enter two numbers.");
            Console.Write("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int biggerNumber = firstNumber;
            if (firstNumber > secondNumber)
            {
                firstNumber = secondNumber;
                secondNumber = biggerNumber;
            }
            Console.WriteLine("The first number's value is now: {0}", firstNumber);
            Console.WriteLine("The second number's value is now: {0}", secondNumber);
            Console.ReadKey();
        }
    }
}
