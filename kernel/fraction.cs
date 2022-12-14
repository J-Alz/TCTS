using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS.fractionKernel
{
    internal class fraction
    {
        private int numerator;
        private int denominator;
        fraction()
        {

        }
        fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        } 
    }
}
