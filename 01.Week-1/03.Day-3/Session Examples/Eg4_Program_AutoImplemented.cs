using System;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace ConsoleApp12
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeJob { get; set; }

        public Employee() { }
        public Employee(int id)
        {
            EmployeeId = id;
        }

        public Employee(int id, string name)
        {
            EmployeeId = id;
            EmployeeName = name;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Id : {EmployeeId}, Name : {EmployeeName}, Job : {EmployeeJob}");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {             
            Employee e1 = new Employee(10256, "Scott");

            Console.WriteLine(e1.EmployeeId);
            Console.WriteLine(e1.EmployeeName);


            e1.EmployeeName = "Smith";
            e1.EmployeeJob = "Manager";
            e1.EmployeeId = 256856;

            e1.ShowDetails();

            e1.EmployeeJob = "Sr.Manager";
            e1.ShowDetails();
           


            Console.ReadLine();
        }
    }
}
