

namespace ConsoleApp1.Domain.Entities
{
    public struct Fraction
    {
        public int Numerator {  get; set; }

        public int Denominator { get; set; }
        public Fraction (int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public void ShowFraction()
        {
            Console.WriteLine(Numerator + "\n",Denominator);
        }

        public static Fraction operator+(Fraction a, Fraction b)
        {
            if (a.Denominator== b.Denominator)
            {
                return new Fraction(a.Numerator + b.Numerator, a.Denominator);
            }
            else
            {
                int newNumerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
                int newDenominator = a.Denominator * b.Denominator;
                return new Fraction(newNumerator, newDenominator);
            }
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            if (a.Denominator == b.Denominator)
            {
                return new Fraction(a.Numerator - b.Numerator, a.Denominator);
            }else
            {
                int newNumerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
                int newDenominator = a.Denominator * b.Denominator;
                return new Fraction(newNumerator, newDenominator);
            }
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            int newNumerator = a.Numerator * b.Numerator;
            int newDenominator = a.Denominator * b.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            int newNumerator = a.Numerator * b.Denominator;
            int newDenominator = a.Denominator * b.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            if(a.Numerator == b.Numerator && a.Denominator == b.Denominator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            if (a.Numerator != b.Numerator || a.Denominator != b.Denominator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
