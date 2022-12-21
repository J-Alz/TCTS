using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS
{
    public readonly struct Fraction
    {
        
        private readonly int num;
        private readonly int den;

        public Fraction(int num, int den)
        {
            if (den == 0)
                throw 
                    new ArgumentException("El denominador no puede ser cero", 
                    nameof(den));
            this.num = num;
            this.den = den;
        }
        public Fraction(int num)
        {
            this.num = num;
            this.den = 1;
        }
        public static Fraction operator +(Fraction a) 
            => a;
        public static Fraction operator -(Fraction a) 
            => new Fraction(-a.num, a.den);
        public static Fraction operator +(Fraction a, Fraction b)
            => new Fraction(a.num * b.den + b.num * a.den,a.den * b.den);
        public static Fraction operator -(Fraction a, Fraction b)
            => a + (-b);
        public static Fraction operator *(Fraction a, Fraction b)
            => new Fraction(a.num * b.num, a.den * b.den);
        public static Fraction operator /(Fraction a, Fraction b)
        {
            if(b.num == 0)
                throw new DivideByZeroException();
            return new Fraction(a.num * b.den, a.den * b.num);
        }
        public override string ToString() => $"{num}/{den}";
        public static Fraction operator ^(Fraction a, double exp)
        {

            return new Fraction((int)Math.Pow(a.num,exp),(int)Math.Pow(a.den,exp));
        }
        public static double Decimal(Fraction a)
        {
            return a.num / a.den;
        }
    }
}
