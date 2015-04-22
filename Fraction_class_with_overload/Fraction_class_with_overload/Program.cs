using System;

namespace Fraction_class_with_overload
{
    class Program
    {
        static void Main(string[] args)
        {
            var d1 = new Fraction(1, 2);
            var d2 = new Fraction(4, 5);
            if (d2)
            {
                Console.WriteLine((d1 + 1.5).ToString());
            }
            Console.WriteLine();

            var f = new Fraction(3, 4);
            int a = 10;
            Fraction f1 = f * a;
            Fraction f2 = a * f;
            double d = 1.5;
            Fraction f3 = f + d;
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(f3);
        }
    }
}
