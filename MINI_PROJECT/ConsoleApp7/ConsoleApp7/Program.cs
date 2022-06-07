
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StudentDetails
{
    public class Student
    {
        public String name;
        public int id;
        public string DateOfBirth;
         public Student(String name, int id, String DateOfBirth)
        {
            this.name = name;
            this.id = id;
            this.DateOfBirth = DateOfBirth;
        }
        public Student()
        { }
        public String getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public void setid(int id)
        {
            this.id = id;
        }
        public int getid()
        {
            return id;
        }
        public void setDateOfBirth(String DateOfBirth)
        {
            this.DateOfBirth = DateOfBirth;
        }
        public String getDateOfBirth()
        {
            return DateOfBirth;
        }
        public String toString()
        {
            return "'\n'StudentId:" + " " + this.id + "\n " + "Student Name:" + " " + this.name + "\n " + "Student Dob:" + " " + this.DateOfBirth;
        }
    }
   
    class App
    {
        public void Scenario1()
        {
            Student s1 = new Student("SAI", 101, "11-05-1999");
            Student s2 = new Student("VINAY", 102, "11-06-1999");
            Student s3 = new Student("VIVEK", 103, "11-07-1999");
            Info info = new Info();
            info.display(s1);
            info.display(s2);
            info.display(s3);
        }
        public void Scenario2()
        {
            Student[] students = new Student[3];
            students[0] = new Student("ANIL", 104, "11-08-1999");
            students[1] = new Student("MAHESH", 105, "11-06-2000");
            students[2] = new Student("SURESH", 106, "11-07-2001"); for (int i = 0; i <= 2; i++)
            {
                Info info = new Info();
                info.display(students[i]);
            }
        }
        public void Scenario3()
        {
            Console.WriteLine("Number of Students");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] student = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Student s = new Student();
                Console.WriteLine("enter student name");
                String s1 = Console.ReadLine();
                s.setName(s1);
                Console.WriteLine("Enter student id");
                int ID = Convert.ToInt32(Console.ReadLine());
                s.setid(ID);
                Console.WriteLine("Enter Student DOB");
                String DOB = Console.ReadLine();
                s.setDateOfBirth(DOB);
                student[i] = s;
            }
            for (int i = 0; i < n; i++)
            {
                Info info = new Info();
                info.display(student[i]);
            }
        }
    }
    public class MainClass
    {
        public static void Main()
        {
            Course course1 = new Course(1, "JAVA", "4 months", 5000);
            Course course2 = new Course(2, "PYTHON", "3 months", 5000);
            Course course3 = new Course(3, "CSHARP", "4 months", 8000); Info info = new Info();
           
               
                AppEngine engine = new AppEngine();
            
                new UserInterFace().showFirstScreen();
            
                Console.Read();
            
        }
    }
    public class Course
    {
        public int id;
        public string nameOfCourse;
        public string duration;
        public double fees; public Course(int id, string name, string duration, double fees)
            
        {
            this.id = id;
            this.nameOfCourse = name;
            this.duration = duration;
            this.fees = fees;
        }
    }
}

