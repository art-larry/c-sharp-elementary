using System;
using System.Globalization;

namespace Struct_for_save_koef_linear_equaision_ex2_1
{
    struct Coefficients
    {
        private double coefA;
        private double coefB;

        public Coefficients(double a, double b)
        {
            coefA = a;
            coefB = b;
        }

        public double CoefA
        {
            get { return coefA; }
            private set { coefA = value; }
        }

        public double CoefB
        {
            get { return coefB; }
            private set { coefB = value; }
        }

        public void Parse(string param)
        {
            
            string[] inputParam = param.Split(new char[] {',', ' '}, 2, StringSplitOptions.RemoveEmptyEntries);
            if(!Double.TryParse(inputParam[0], NumberStyles.AllowDecimalPoint, CultureInfo.CreateSpecificCulture("en-en"), out coefA) 
                & !Double.TryParse(inputParam[1], NumberStyles.AllowDecimalPoint, CultureInfo.CreateSpecificCulture("en-en"), out coefB))
            {
                throw new FormatException();
            }
        }
    }
}
