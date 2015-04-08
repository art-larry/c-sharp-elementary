using System;

namespace Statistic_of_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string workString = null;
            if(args.Length > 0)
            {
                foreach(var el in args)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine();
                workString = String.Join(" ", args);
            }

            Console.WriteLine("Quantity of symbol:" + workString.Length);
            Console.WriteLine("Quantity space symbol:" + (args.Length - 1));
            char[] tmp = workString.ToCharArray();
            int upperCase = 0, lowerCase = 0, digit = 0;
            foreach(var el in tmp)
            {
                if(el >= 'A' && el <= 'Z' || el >= 'А' && el <= 'Я')
                {
                    ++upperCase;
                }
                if(el >= 'a' && el <= 'z' || el >= 'а' && el <= 'я')
                {
                    ++lowerCase;
                }
                if(el >= '0' && el <= '9')
                {
                    ++digit;
                }
            }
            Console.WriteLine("Quantity upper case:" + upperCase);
            Console.WriteLine("Quantity lower case:" + lowerCase);
            Console.WriteLine("Total alphabet symbol:" + (upperCase + lowerCase));
            Console.WriteLine("Digits quantity:" + digit);
        }
    }
}
