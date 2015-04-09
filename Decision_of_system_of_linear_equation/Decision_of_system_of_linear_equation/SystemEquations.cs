using System;

namespace Decision_of_system_of_linear_equation
{
    static class SystemEquations
    {
        static private double coefA1;
        static private double coefB1;
        static private double coefA2;
        static private double coefB2;

        public static Radical Decision(double a, double b, double c, double d, double e, double f)
        {
            try
            {
                double y = checked((a * f - c * d) / (a * e - b * d));
                double x = checked((c * e - b * f) / (a * e - b * d));
                return new Radical(x, y); 
            }

            catch(Exception ex)
            {
                throw new ArgumentOutOfRangeException("Not have radicals", ex);
            }
        }
    }
}
