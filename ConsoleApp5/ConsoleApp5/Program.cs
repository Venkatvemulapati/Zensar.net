﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

            //PROGRAMME 1

namespace Assignment_1
{
    class Programme
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the integer 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Two integer are equal");
            }
            else
            {
                Console.WriteLine("Two integer are not equal");
            }




            //PROGRAMME 2

            int number;
            Console.WriteLine("Enter the number to check weather it is positive or negative");
            number = Convert.ToInt32(Console.ReadLine());
            if (number >= 0)
            {
                Console.WriteLine("Given number is positive");
            }
            else
            {
                Console.WriteLine("Given number is negative");
            }




            //PROGRAMME 3

            int number1, number2, result;
            char operation;
            Console.WriteLine("Enter the first number:");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose the operation");
            Console.WriteLine("+ addition");
            Console.WriteLine("- subtraction");
            Console.WriteLine("* multiplication");
            Console.WriteLine("/ division");
            operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("The addition of two number is : {0}", result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("The subtraction of two is : {0}", result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("The multiplication of two number is : {0}", result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("The division of two number is : {0}", result);
                    break;
            }
        }
    }
}
