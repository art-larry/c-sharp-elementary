using System;

namespace Cange_column_in_twodementionoal_array_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            int[,] arr = new int [3, 2];

            // init array
            for(int i = 0; i < arr.GetLength(0); ++i)
            {
                for(int j = 0; j < arr.GetLength(1); ++j)
                {
                    arr[i, j] = rnd.Next(-10, 10);
                }
            }

            //control out
            for(int i = 0; i < arr.GetLength(0); ++i)
            {
                for(int j = 0; j< arr.GetLength(1); ++j)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //change column
            for(int i = 0; i < arr.GetLength(0); ++i)
            {
                arr[i, 0] += arr[i, 1];
                arr[i, 1] = arr[i, 0] - arr[i, 1];
                arr[i, 0] -= arr[i, 1];
            }

            //result out 
            for(int i = 0; i < arr.GetLength(0); ++i)
            {
                for(int j = 0; j < arr.GetLength(1); ++j)
                {
                    Console.Write(arr[i, j]+" ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
