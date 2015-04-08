using System;

namespace Array_sort_from_minus_to_plus_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            int[] arr = new int [20];

            //init
            for(int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rnd.Next(-10, 10);
            }

            //control out
            foreach(var el in arr)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();

            Array.Sort(arr);

            //result out
            foreach(var el in arr)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }
    }
}
