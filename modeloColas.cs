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
        
        public double PsubZero
        {
            get { return psubZero; }
            set { psubZero = value; }
        }
        public List<double> PsubN
        {
            get { return pN; }
            set { pN = value; }
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
            get { return wsubN; }
            set { wsubN = value; }
        }
        #endregion
    }
}
