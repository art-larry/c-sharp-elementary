using System;

namespace Complex_number_class_with_overload
{
    class ComplexNumber
    {
        private double x;
        private double y;

        public ComplexNumber(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.x + b.x, a.y + b.y);
        }

        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.x - b.x, a.y - b.y);
        }

        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber((a.x * b.x) - (a.y * b.y), (a.y * b.x) + (a.x * b.y));
        }

        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber((a.x * b.x + a.y * b.y) / (b.x * b.x + b.y * b.y), (a.y * b.x - a.x * b.y) / (b.x * b.x + b.y * b.y));
        }

        public static ComplexNumber operator +(ComplexNumber a, int b)
        {
            return new ComplexNumber(a.x + b, a.y);
        }

        public static ComplexNumber operator +(int a, ComplexNumber b)
        {
            return b + a;
        }

        public static ComplexNumber operator -(ComplexNumber a, int b)
        {
            return new ComplexNumber(a.x - b, a.y);
        }

        public static ComplexNumber operator -(int a, ComplexNumber b)
        {
            return new ComplexNumber(a - b.x, b.y);
        }

        public static ComplexNumber operator *(ComplexNumber a, int b)
        {
            return new ComplexNumber(a.x * b, a.y * b);
        }

        public static ComplexNumber operator *(int a, ComplexNumber b)
        {
            return b * a;
        }

        public static bool operator ==(ComplexNumber a, ComplexNumber b)
        {
            return (a.x == b.x) && (a.y == b.y);
        }

        public static bool operator !=(ComplexNumber a, ComplexNumber b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return String.Format("{0} + ({1})i", x, y);
        }
    }
}
