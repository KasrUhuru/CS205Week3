using System;

namespace CS205Week3
{
    public class Rational
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Rational()
        {
            this.Numerator = 0;
            this.Denominator = 1;
        }

        public Rational(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public void WriteRational()
        {
            Console.WriteLine($"{Numerator}/{Denominator}");
        }

        public void Negate()
        {
            Numerator = -Numerator;
        }

        public void Invert()
        {
            int temp = Numerator;
            Numerator = Denominator;
            Denominator = temp;
        }

        public double ToDouble()
        {
            return (double)Numerator / Denominator;
        }

        public Rational Reduce()
        {
            long gcd = GCD(Numerator, Denominator);
            return new Rational(Numerator / (int)gcd, Denominator / (int)gcd);
        }

        private static long GCD(long n1, long n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                return GCD(n2, n1 % n2);
            }
        }

        public Rational Add(Rational other)
        {
            int numerator = this.Numerator * other.Denominator + other.Numerator * this.Denominator;
            int denominator = this.Denominator * other.Denominator;
            Rational result = new Rational(numerator, denominator);
            return result.Reduce();
        }
    }
}
