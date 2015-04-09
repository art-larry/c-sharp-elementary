using System;

namespace Struct_for_save_koef_linear_equaision_ex2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var inst1 = new Coefficients(2.0, 9.4);
                var inst2 = new Coefficients();
                inst2.Parse("2.9, 4.3");
                Console.WriteLine("coefa: {0}, coefb: {1}", inst1.CoefA, inst1.CoefB);
                Console.WriteLine("CoefA: {0}, CoefB: {1}", inst2.CoefA, inst2.CoefB);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
