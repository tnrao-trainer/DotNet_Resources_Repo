using System;

namespace ConsoleApp12
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = {  2, 9, 4, 7, 1, 6, 8, 5, 3 };
              
                
            foreach(int n in ar)
            {
                Console.Write($" {n}");
            }
            Console.WriteLine();


            Array.Sort(ar);
            Array.Reverse(ar);
            foreach (int n in ar)
            {
                Console.Write($" {n}");
            }
            Console.WriteLine();

           
           Array.Clear(ar);
            //Array.Clear(ar, 0, 4);
            foreach (int n in ar)
            {
                Console.Write($" {n}");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
