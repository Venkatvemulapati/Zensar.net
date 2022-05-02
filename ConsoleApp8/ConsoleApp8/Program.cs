
   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        public abstract class Student
        {
            public String Name;
            public int StudentId;
            public abstract void BooleanIspassed(int Grade);
        }
        //==============================inherited class========================
        public class Engineering : Student
        {
            public override void BooleanIspassed(int Grade)
            {
                try
                {

                    Console.WriteLine("Enter the engineering student Grade ");
                    Grade = Convert.ToInt32(Console.ReadLine());
                    if (Grade > 70)
                    {
                        Console.WriteLine("Engineering student passed the course ");
                    }
                    else
                    {
                        Console.WriteLine("engineering student failed the course ");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Input mismatch exception " + e.StackTrace);
                }
            }
        }

        class Graduate : Student
        {
            public override void BooleanIspassed(int Grade)
            {
                try
                {
                    Console.WriteLine("\n Enter the graduate student Grade");
                    Grade = Convert.ToInt32(Console.ReadLine());
                    if (Grade > 80)
                    {
                        Console.WriteLine("Engineering student passed the course ");
                    }
                    else
                    {
                        Console.WriteLine("Engineering student failed the course ");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Input missmatch exception " + e.StackTrace);
                }
            }
        }

        public class Employee
        {
            public int empId;
            public string empName;
            public float salary;

            public Employee(int empId, string empName, float salary)
            {
                this.empId = empId;
                this.empName = empName;
                this.salary = salary;
            }
            public void showDetails()
            {
                Console.WriteLine($"\n Emp Name {empName} with empid {empId} gets salary of {salary}");
            }
        }
        public class PartTimeemployee
        {
            public int wages = 1200;

            public void showDetails()
            {
                Console.WriteLine($"The part time employee gets " + wages);
            }
        }

        public class Students
        {
            public int st_Id;
            public string st_Name;
            public double exam_fee;


            public void showDetails()
            {
                Console.WriteLine($"\n The student {st_Name} with id {st_Id} paid {exam_fee}");
            }
            public void payFee()
            {
                Console.WriteLine("\n Enter student id: ");
                st_Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the student name: ");
                st_Name = Console.ReadLine();
                Console.WriteLine("The exam fee: is" + 1000);
                Console.WriteLine("Enter the amount to pay examfee");
                exam_fee = int.Parse(Console.ReadLine());
                double rem_fee = 1000 - exam_fee;
                if (exam_fee == 1000)
                {
                    Console.WriteLine("Full fees paid no dues");
                }
                else
                {
                    Console.WriteLine("The remaining fee: " + rem_fee);
                }
            }
        }
        class DayScholar
        {
            public double transport_fees;

            public DayScholar(double transport_fees)
            {
                this.transport_fees = transport_fees;
                double rem1_fee = 40000 - transport_fees;

                Console.WriteLine("\nThe transport fee: " + 40000 + "per year ");


                Console.WriteLine($"The dayscholar  paid {transport_fees} & remaining fee is {rem1_fee}");
                Console.WriteLine();
            }

        }
        public class Hosteller
        {
            public double hostel_fee;

            public Hosteller(double hostel_fee)
            {

                this.hostel_fee = hostel_fee;

                double rem2_fee = 30000 - hostel_fee;
                Console.WriteLine("The hostel  fee: " + 50000 + "per year ");

                Console.WriteLine($"The dayscholar  paid {hostel_fee} & remaining fee is {rem2_fee} ");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Engineering Estudent = new Engineering();
            Estudent.BooleanIspassed(10);
            Estudent.Name = "SAI";
            Estudent.StudentId = 15018;
            Console.WriteLine($"Name is {Estudent.Name} & id is {Estudent.StudentId}");

            Graduate g = new Graduate();
            g.Name = "NAGARJUNA";
            g.StudentId = 17018;
            g.BooleanIspassed(20);
            Console.WriteLine($"Name is {g.Name} & id is {g.StudentId}");


            Employee employee = new Employee(143, "Akash", 1000.3f);
            employee.showDetails();
            PartTimeemployee ptemployee = new PartTimeemployee();
            ptemployee.showDetails();

            Students students = new Students();
            students.payFee();
            students.showDetails();
            Console.WriteLine("Enter the tranport fee you want to pay: ");
            DayScholar dayScholar = new DayScholar(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter the hostel fee you want to pay: ");
            Hosteller hosteller = new Hosteller(int.Parse(Console.ReadLine()));
            Console.ReadLine();
        }
    }

}