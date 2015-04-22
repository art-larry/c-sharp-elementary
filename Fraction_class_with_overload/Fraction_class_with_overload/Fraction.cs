using System;

namespace Fraction_class_with_overload
{
    public class Fraction
    {
        private int nominator;
        private int denominator;

        public Fraction(int nom, int denom)
        {
            nominator = nom;
            denominator = denom;
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}", nominator, denominator);
        }

        private static bool IsPrime(int a)
        {
            for (int i = 2; i < a / 2 + 1; ++i)
            {
                if (a % i == 0) return false;
            }
            return true;
        }

        private static int NOD(int d1, int d2)
        {
            return (d1 == 0 ? d2 : NOD(d2 % d1, d1));
        }

        private static int NOK(int d1, int d2)
        {
            return d1 / NOD(d1, d2) * d2;
        }

        private static Fraction Normalization(int nom, int denom)
        {
            int nod = NOD(nom, denom);
            return new Fraction(nom / nod, denom / nod);
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int nom, denom;
            denom = NOK(a.denominator, b.denominator);
            nom = denom / a.denominator * a.nominator + denom / b.denominator * b.nominator;
            return Normalization(nom, denom);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            int nom, denom;
            denom = NOK(a.denominator, b.denominator);
            nom = denom / a.denominator * a.nominator - denom / b.denominator * b.nominator;
            return Normalization(nom, denom);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            int nom = a.nominator * b.nominator;
            int denom = a.denominator * b.denominator;
            return Normalization(nom, denom);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            return a * new Fraction(b.denominator, b.nominator);
        }

        public static Fraction operator +(Fraction a, int b)
        {
            return (a + new Fraction(b, 1));
        }

        public static Fraction operator +(int a, Fraction b)
        {
            return b + a;
        }

        public static Fraction operator -(Fraction a, int b)
        {
            return a - new Fraction(b, 1);
        }

        public static Fraction operator -(int a, Fraction b)
        {
            return new Fraction(a, 1) - b;
        }

        public static Fraction operator *(Fraction a, int b)
        {
            return a * new Fraction(b, 1);
        }

        public static Fraction operator *(int a, Fraction b)
        {
            return b * a;
        }

        public static Fraction operator /(Fraction a, int b)
        {
            return a / new Fraction(b, 1);
        }

        public static Fraction operator /(int a, Fraction b)
        {
            return new Fraction(a, 1) / b;
        }

        private static Fraction GetFraction(double a)
        {
            int nom, denom = 1;
            var str = a.ToString();
            string[] tmp = str.Split('.', ',');
            char[] chtmp = tmp[1].ToCharArray();
            int t = Int32.Parse(tmp[1]);
            foreach (var el in chtmp)
            {
                denom *= 10;
            }
            nom = Int32.Parse(tmp[0]) * denom + t;
            return Normalization(nom, denom);
        }

        public static Fraction operator +(Fraction a, double b)
        {
            return a + GetFraction(b);
        }

        public static Fraction operator +(double a, Fraction b)
        {
            return b + a;
        }

        public static Fraction operator -(Fraction a, double b)
        {
            return a - GetFraction(b);
        }

        public static Fraction operator -(double a, Fraction b)
        {
            return GetFraction(a) - b;
        }

        public static Fraction operator *(Fraction a, double b)
        {
            return a * GetFraction(b);
        }

        public static Fraction operator *(double a, Fraction b)
        {
            return b * a;
        }

        public static Fraction operator /(Fraction a, double b)
        {
            return a / GetFraction(b);
        }

        public static Fraction operator /(double a, Fraction b)
        {
            return GetFraction(a) / b;
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.nominator == b.nominator & a.denominator == b.denominator;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }

        public static bool operator >(Fraction a, Fraction b)
        {
            int nok = NOK(a.denominator, b.denominator);
            return a.nominator * nok > b.nominator * nok;
        }

        public static bool operator <(Fraction a, Fraction b)
        {
            return b > a;
        }

        public static bool operator true(Fraction a)
        {
            return a.denominator > a.nominator;
        }

        public static bool operator false(Fraction a)
        {
            return a.denominator < a.nominator;
        }
    }
}
