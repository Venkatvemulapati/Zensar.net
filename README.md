# Zensar.net
Daily programme
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Programmes
    {
        public static void Main()
        {

            /**************  GIVEN ARRAY PROGRAMME 1************/


            int[] marks= { 10, 20, 30, 40, 50 };
            int n = 0;
            foreach(int i in marks) 
            {
                n += i;
            }
            Console.WriteLine("Average of marks is {0}",n/marks.Length);
            Console.WriteLine(marks.Min());
            Console.WriteLine(marks.Max());
            Console.WriteLine("PROGRAMME 1 IS DONE");



            /***************ACCEPT ARRAY PROGRAMME 2************/



            int[] numbers = new int [5];
            int sum=0;
            Console.WriteLine("Enter a numbers of an array");
            for (int i = 0; i < numbers.Length; i++)
            { 
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int i in numbers)
            {
                sum += i;


            }
            Console.WriteLine("Total marks is {0}" , sum);
            Console.WriteLine( "Average of given numbers {0}",sum/5);
            Console.WriteLine("Maximum  NUmmber of marks is {0}",numbers.Max());
            Console.WriteLine("Minimum number of marks is {0}",numbers.Min());
            Array.Sort(numbers);
           
            Console.WriteLine("Ascending order of marks is ");
            foreach (int i in numbers)
            { 
                Console.Write(i+" ");
            }
            Array.Reverse(numbers);
            Console.WriteLine(" ");
            Console.WriteLine("Descending order of marks is ");
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");


            /*************** LENGTH OF STRING PROGRAMME 3********************/



            Console.WriteLine("Hello Welcome Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("The length opf your name is {0}", name.Length);


            /**************** REVERSE THE STRING PROGRAMME 4 *****************/




            Console.WriteLine("Enter your name");
            String s2 = Console.ReadLine();
            char[] chars = s2.ToCharArray();
            string s3 = "";
            for(int i=s2.Length-1;i>=0;i--)
            {
                s3 += chars[i];
            }
            Console.WriteLine(s3);


            /**************  CHECKING THE TWO STRINGS PROGRAMME 5 *******************/



            Console.WriteLine(" ENTER A WWORD 1");
            string word1= Console.ReadLine();
            Console.WriteLine(" ENTER A WWORD 2");
            string word2= Console.ReadLine();
            char[] ch1 = word1.ToCharArray();
            char[] ch2 = word2.ToCharArray();
            int temp = 0;
            for (int i = 0; i < ch1.Length; i++)
            {
                if (ch1[i] != ch2[i])
                {
                    temp =1;
                }
            }
            if (temp != 0)
            {
                Console.WriteLine("Two words are not same ");
            }
            else
            {
                Console.WriteLine("Two words are same ");
            }



            /*******************  PALINDROME PROGRAMME 6 *****************/




            Console.WriteLine("Enter A word");
            string s5 = Console.ReadLine();
            char[] cha3 = s5.ToCharArray();
            int temp1 = 0;
            int j = cha3.Length-1;
            for(int i = 0;i<cha3.Length-1/2;i++)
            {

                if (cha3[i] != cha3[j])
                {
                   temp1 = 1;
                    
                }
                j--;
            }
            if(temp1 != 0)
            {
                Console.WriteLine("its not a palindrome");
            }
            else
            {
                Console.WriteLine("its a palindrome ");
            }




        }
    }
}
