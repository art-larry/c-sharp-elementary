using System;

namespace Decision_of_system_of_linear_equation
{
    struct Radical
    {
        private double radical1;
        private double radical2;

        public double Radical1
        {
            get { return radical1; }
            private set { radical1 = value; }
        }

        public double Radical2
        {
            get { return radical2; }
            private set { radical2 = value; }
        }

        public Radical(double r1, double r2)
        {
            radical1 = r1;
            radical2 = r2;
        }
    }
}
