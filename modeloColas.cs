using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS
{
    internal class modeloColas
    {
        private double lambda;
        private double miu;
        private double k;

        private double psubZero;
        private double psubN;
        private double l;
        private double lsubQ;
        private double lsubN;
        private double w;
        private double wsubQ;
        private double wsubN;

        public double Lambda
        {
            get { return lambda; }
            set { lambda = value; }
        }
        public double Miu
        {
            get { return miu; }
            set { miu = value; }
        }
        public double K
        {
            get { return k; }
            set { k = value; }
        }
        public double PsubZero
        {
            get { return psubZero; }
            set { psubZero = value; }
        }
        public double PsubN
        {
            get { return psubN; }
            set { psubN = value; }
        }
        public double L
        {
            get { return l; }
            set { l = value; }
        }
        public double LsubQ
        {
            get { return lsubQ; }
            set { lsubQ = value; }
        }
        public double LsubN
        {
            get { return lsubN; }
            set { lsubN = value; }
        }
        public double W
        {
            get { return w; }
            set { w = value; }
        }
        public double WsubQ
        {
            get { return wsubQ; }
            set { wsubQ = value; }
        }
        public double WsubN
        {
            get { return WsubN; }
            set { wsubN = value; }
        }
    }
}
