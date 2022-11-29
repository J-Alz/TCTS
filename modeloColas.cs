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
        private int k;
        private double p0;
        private List<double> pn = new List<double>();
        private double l;
        private double lq;
        private double ln;
        private double w;
        private double wq;
        private double wn;

        #region get/set
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
        public int K
        {
            get { return k; }
            set { k = value; }
        }
        
        public double P0
        {
            get { return p0; }
            set { p0 = value; }
        }
        public List<double> Pn
        {
            get { return pn; }
            set { pn = value; }
        }
        public double L
        {
            get { return l; }
            set { l = value; }
        }
        public double Lq
        {
            get { return lq; }
            set { lq = value; }
        }
        public double Ln
        {
            get { return ln; }
            set { ln = value; }
        }
        public double W
        {
            get { return w; }
            set { w = value; }
        }
        public double Wq
        {
            get { return wq; }
            set { wq = value; }
        }
        public double Wn
        {
            get { return wn; }
            set { wn = value; }
        }
        #endregion

        public double factorial(int value)
        {
            if (value == 0)
                return 1;

            int result = 1;
            for(int i = 1; i <= value; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
