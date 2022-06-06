using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class LoanProcess
    {
       
        static void Main(string[] args)
        {
            float AccountBalance = 50000;
            float principal, rate, time, emi;
            
            Console.WriteLine("Enter your loan amount");
            principal = Convert.ToSingle(Console.ReadLine());
           
            rate = 13;
            time = 3;

            emi = emi_calculator(principal, rate, time);

            Console.WriteLine("Monthly EMI is = " + emi);
            
            if (AccountBalance < emi) 
            {
                Console.WriteLine("not sufficient balance to repay loan");
            }
            else
            {
                Console.WriteLine("paid successfully");
            }

        }
        static float emi_calculator(float p,float r, float t)
        {

            float emi;
            r = r / (12 * 100); // one month interest
            t = t * 12; // one month period
            emi = (p * r * (float)Math.Pow(1 + r, t))
            / (float)(Math.Pow(1 + r, t) - 1);

            return (emi);
        }
       
        }
    } 
            
