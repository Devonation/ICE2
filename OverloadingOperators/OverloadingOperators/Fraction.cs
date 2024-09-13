using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    public readonly struct Fraction
    {
        private readonly int numerator;
        private readonly int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public static Fraction operator + (Fraction a)
        {
            return new Fraction(a.numerator, a.numerator + a.denominator);
        }
        public static Fraction operator - (Fraction a) 
        {
            return new Fraction(-a.numerator, -a.denominator);
        }
        public static Fraction operator ++ (Fraction a)
        {
            return new Fraction(a.numerator*2, a.denominator*2);
        }
        public static bool operator == (Fraction a, Fraction b)
        {
            bool status = true;
            if (a.numerator == b.numerator)
            {
                status = false;
            }
            return status;
        }
        public static bool operator != (Fraction a, Fraction b)
        {
            bool status = false;
            if (a.numerator == b.numerator)
            {
                status = true;
            }
            return status;
        }
        public override string ToString() => $"{numerator}/{denominator}";
    }
}
