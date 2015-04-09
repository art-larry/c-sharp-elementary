using System;


namespace Decision_of_system_of_linear_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = SystemEquations.Decision(-10, 2, -42, 9, -3, 27);
            Console.WriteLine("X: {0}; Y: {1}", r.Radical1, r.Radical2);
        }
    }
}
