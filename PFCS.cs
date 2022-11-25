using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS
{
    internal class PFCS:modeloColas
    {
        int m;
        int n;
        double psubE;
        tools t = new tools();
        public PFCS(int lambda, int miu, int k, int n, int m)
        {
            Lambda = lambda;
            Miu = miu;
            M = m;
            N = n;
            K = k;
            PsubZero = calcPsubZero();
            PsubE = calcPsubE();
            //PsubN = calcPsubN();
            L = calcL();
            LsubQ = calcLsubQ();
            LsubN = calcLsubN();
            W = calcW();
            WsubQ = calcWsubQ();
            WsubN = calcWsubN();
        }

        #region get/set
        public int M
        {
            get { return m; }
            set { m = value; }
        }
        public int N
        {
            get { return n; }
            set { n = value; }
        }
        public double PsubE
        {
            get { return psubE; }
            set { psubE = value; }
        }
        #endregion

        public double calcPsubZero()
        {
            double sumatoria = 0;
            for(int n = 0; n < M; n++)
            {
                sumatoria +=(t.fact(M)/t.fact(M - n))*Math.Pow(Lambda/Miu,n);
            }
            return 1 / sumatoria;
        }
        public double calcPsubE()
        {
            return 1 - PsubZero;
        }
        public double calcPsubN()
        {
            return (t.fact(M!)/t.fact(M - n)) * Math.Pow(Lambda/Miu,n) * PsubZero;
        }
        public double calcL()
        {
            return M - (Miu / Lambda) * (1 - PsubZero);
        }
        public double calcLsubQ()
        {
            return M - ((Lambda + Miu) / Lambda) * (1 - PsubZero);
        }
        public double calcLsubN()
        {
            return LsubQ / PsubE;
        }
        public double calcWsubQ()
        {
            return LsubQ / (M - L) * Miu;
        }
        public double calcW()
        {
            return WsubQ + 1 / Miu;
        }
        public double calcWsubN()
        {
            return WsubQ / PsubE;
        }
    }
}
