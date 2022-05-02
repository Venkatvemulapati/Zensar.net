using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        class Bank
        {
            int money = 22000;
            String accountName = "SAI";
            String accountNum;
            static String bankName = "ICICI";
            static public int updatedBal;
            public void depositMoney()
            {

                Console.WriteLine("Enter the Amount to add :");
                int depositMoney = int.Parse(Console.ReadLine());
                updatedBal = money + depositMoney;
                if (depositMoney == 0)
                {
                    Console.WriteLine(" Add minimum amount of Money 500 ");
                }
                else
                {
                    Console.WriteLine(" updated balance of " + accountName + " After deposit is " + updatedBal);
                }

            }
            public void withdrawMoney()
            {
                try
                {
                    Console.WriteLine("Enter the account name is " + accountName + " your accbal: " + updatedBal);
                    Console.WriteLine("Enter the amount how much you want to withdraw is:");
                    int withdraw = int.Parse(Console.ReadLine());
                    updatedBal = updatedBal - withdraw;
                    if (withdraw > updatedBal)
                    {
                        Console.WriteLine(" Balance does not Sufficient");
                    }
                    else
                    {
                        Console.WriteLine(" Remaining Updated balance is " + accountName + " after withdrawal is " + updatedBal);
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine(" The enter balance in number whose in words are not taken to the inputmissmatch exception ");
                }
            }
            public void Balance()
            {
                Console.WriteLine("Display to the " + bankName + "bank ");
                Console.WriteLine("Enter account number is ");
                accountNum= Console.ReadLine();
                Console.WriteLine("Display the account name is  " + accountName + " your account balance is : " + money);

            }
        }
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.Balance();
            b.depositMoney();
            b.withdrawMoney();
            Console.ReadLine();

        }
    }
}