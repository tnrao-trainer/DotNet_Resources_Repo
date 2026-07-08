using System;

namespace ConsoleApp12
{  
    class  Employee
    {
        private int _id;
        private string _name;
        private string _job;

        public  Employee() { }
        public  Employee(int id) {
            _id = id;
        }
        public Employee(int id, string name)
        {
            _id = id;
            _name = name;
        }


        public int EmployeeId
        {
            get 
            { 
                return _id; 
            }

            set
            {
                _id = value;
            }
        }

        public string  EmployeeName
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string EmployeeJob
        {
            get
            {
                return _job;
            }

            set
            {
                _job = value;
            }
        }


        public void ShowDetails()
        {
            Console.WriteLine($"Id : {_id}, Name : {_name}, Job : {_job}");
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
