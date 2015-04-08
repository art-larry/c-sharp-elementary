using System;

namespace Cont_howmanytime_userdigit_include_inarray
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            int[] arr = new int[20];

            // init array
            for(int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rnd.Next(-10, 10);
            }

            //Control out
            foreach(var el in arr)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();

            //user digit input
            int userDigit;
            do
            {
                Console.WriteLine("Enter digit between -10 and 10:");
                string tmp = Console.ReadLine();
                if(!Int32.TryParse(tmp, out userDigit))
                {
                    continue;
                }
                if(userDigit >= -10 && userDigit <= 10)
                { break; }
            }
            while (true);

            Console.WriteLine("Your choice:" + userDigit);

            //counting
            int count = 0;
            foreach(var el in arr)
            {
                if(el == userDigit)
                {
                    ++count;
                }
            }
            Console.WriteLine("Count:" + count);
        }
    }
}
