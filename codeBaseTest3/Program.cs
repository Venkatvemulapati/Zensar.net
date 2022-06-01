using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CodebaseTest3Csharp
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlConnection getconnection()
        {
            con = new SqlConnection(@"data source = RMGW58ZLPC0864\SQLEXPRESS; Initial Catalog = zensarDB; user id =sa; password =Temp1234");
            con.Open();
            return con;
        }
        public static void Addemploye()
        {
            try
            {
                con = getconnection();
                Console.WriteLine("Name of the employee: ");
                string empname = Console.ReadLine();
                Console.WriteLine(" Employee Salary : ");
                float empsal = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine(" Employee type (C:-contract or P:-permanent) : ");
                string emptype = Console.ReadLine();
                cmd = new SqlCommand("AddEmploye", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd = new SqlCommand("execute AddEmployeee @empname,@empsal,@emptype");
                cmd = new SqlCommand("execute AddEmployeee @empname,@empsal,@emptype", con);
                cmd.Parameters.Add(new SqlParameter("@empname", empname));
                cmd.Parameters.Add(new SqlParameter("@empsal", empsal));
                cmd.Parameters.Add(new SqlParameter("@emptype", emptype));

                cmd.Connection = con;

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("rows effected :{0}", res);
                }
                else
                {
                    Console.WriteLine("No Row Effected");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void AllEmployeeDetails()
        {
            con = getconnection();


            cmd = new SqlCommand("select * from Code_Employee", con);


            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Employee details");
                Console.WriteLine("Employee Id is : " + dr[0]);
                Console.WriteLine("Employee name is : " + dr[1]);
                Console.WriteLine("Employee Salary is : " + dr[2]);
                Console.WriteLine("Employee Type is : " + dr[3]);
            

            }
        }
        static void Main(string[] args)
        {
            Addemploye();
            AllEmployeeDetails();
            Console.Read();
        }
    }
}