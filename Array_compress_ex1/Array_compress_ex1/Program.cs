using System;

namespace Array_compress_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            int[] arr = new int[20];

            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rnd.Next(-10, 10);
            }

            foreach(var el in arr)  // контрольный вывод
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
            
            for (int i = 0; i < arr.Length; ++i)
            {
                if(arr[i] == 0)
                {
                    for(int j = i + 1; j < arr.Length; ++j)
                    {
                        arr[j - 1] = arr[j];
                    }
                    arr[arr.Length - 1] = -1;
                }
            }
 
            foreach(var el in arr)  // результирующий вывод
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }
    }
}
