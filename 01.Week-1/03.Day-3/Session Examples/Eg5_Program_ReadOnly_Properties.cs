using System;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace ConsoleApp12
{
    class Employee
    {
        public int EmployeeId { get; private set; }   // Read-Only Properties
        public string EmployeeName { get; set; }
        public string EmployeeJob { get; set; }

       
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
            Employee e1 = new Employee(154566);


            Console.WriteLine(e1.EmployeeId);


            Console.ReadLine();
        }
    }
}
