using System;

namespace ConsoleApp12
{    
    class Person
    {  
        private string _name;
        private int _age;

        public Person() {
            _name = "";
            _age = 0;
        }

        public Person(string name)
        {
            this._name = name;            
        }

        public Person(int age)
        {
            _age = age;
        }

        public Person(string name, int age)
        {
            this._name = name;
            this._age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Person Details --> Name : {_name}, Age : {_age}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        { 
            Person p1 = new Person();           
            Person p2 = new Person("Scott");           
            Person p3 = new Person(25);           
            Person p4 = new Person("Smith", 35);

            p1.Display();
            p2.Display();
            p3.Display();
            p4.Display();

            Console.ReadLine();
        }
    }
}
