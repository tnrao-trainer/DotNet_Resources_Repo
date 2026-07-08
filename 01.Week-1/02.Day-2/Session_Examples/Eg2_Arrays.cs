using System;

namespace ConsoleApp12
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar;


            Console.WriteLine("Enter size of the array :");
            int size = Convert.ToInt32(Console.ReadLine());

            ar = new int[size];     //  memory allocation at runtime


            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine("Enter a value : ");
                ar[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();         
            foreach(int n in ar)
            {
                Console.Write($" {n}");
            }

            Console.WriteLine();



            Console.ReadLine();
        }
    }
}
