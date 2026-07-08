using System;

namespace ConsoleApp12
{    internal class Person
    {  
        public string Name;
        public int Age;

        public void Display()
        {
            Console.WriteLine($"Person Details --> Name : {Name}, Age : {Age}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        { 
            Person p1 = new Person();
            p1.Name = "Scott";
            p1.Age = 25;
            p1.Display();
          
            Console.ReadLine();
        }
    }
}
