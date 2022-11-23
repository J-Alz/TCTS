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
        public void calcPsubZero()
        {
            double sumatoria = 0;
            for(int n = 0; n < M; n++)
            {
                sumatoria +=(t.fact(M)/t.fact(M - n))*Math.Pow(Lambda/Miu,n);
            }
            PsubZero = 1 / sumatoria;
        }
        public void calcPsubE()
        {
            PsubE = 1 - PsubZero;
        }
        public void calcPsubN()
        {
            PsubN = (t.fact(M!)/t.fact(M - n)) * Math.Pow(Lambda/Miu,n) * PsubZero;
        }
        public void calcL()
        {
            L = M - (Miu / Lambda) * (1 - PsubZero);
        }
        public void calcLsubQ()
        {
            LsubQ = M - ((Lambda + Miu) / Lambda) * (1 - PsubZero);
        }
        public void calcLsubN()
        {
            LsubN = LsubQ / PsubE;
        }
        public void calcWsubQ()
        {
            WsubQ = LsubQ / (M - L) * Miu;
        }
        public void calcW()
        {
            W = WsubQ + 1 / Miu;
        }
        public void calcWsubN()
        {
            WsubN = WsubQ / PsubE;
        }
    }
}
