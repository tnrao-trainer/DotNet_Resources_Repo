using System;

namespace ConsoleApp12
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 10, 20, 30, 40, 50 };

            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write($" {ar[i]}");
            }

            Console.WriteLine();
                       
            foreach(int n in ar)
            {
                Console.Write($" {n}");
            }



            Console.ReadLine();
        }
    }
}
