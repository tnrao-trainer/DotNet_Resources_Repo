using System;

namespace ConsoleApp12
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ar =  { 
                    { 1, 2, 3 }, 
                    { 4, 5, 6  }, 
                    { 7, 8, 9  } 
            };

           
            Console.WriteLine();
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    Console.Write($" {ar[i,j]}");
                }
                Console.WriteLine();
            }


          
            Console.ReadLine();
        }
    }
}
