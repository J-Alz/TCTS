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
        double psubE;
        tools t = new tools();
        public PFCS(int lambda, int miu, int k, int n, int m)
        {
            Lambda = lambda;
            Miu = miu;
            M = m;
            K = k;
            PsubZero = calcPsubZero();
            PsubE = calcPsubE();
            PsubN = calcPsubN(n);
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
        public double PsubE
        {
            get { return psubE; }
            set { psubE = value; }
        }
        #endregion

        #region formulas
        private double formula(int n){
            return t.fact(M) / t.fact(M - n)! * Math.Pow(Lambda/Miu,n);
        }
        #endregion

        public double calcPsubZero()
        {
            double sumatoria = 0;
            for (int i = 0; i <= M; i++)
            {
                sumatoria += formula(i);
            }
            return 1 / sumatoria;
        }
        public double calcPsubE()
        {
            return 1 - PsubZero;
        }
        public List<double> calcPsubN(int n)
        {
            List<double> lista = new List<double>();
            for(int i = 1; i <= n; i++)
                lista.Add(formula(i) * PsubZero);
            return lista;
        }
        public double calcL()
        {
            return M - (Miu / Lambda) * PsubE;
        }
        public double calcLsubQ()
        {
            return M - ((Lambda + Miu) / Lambda) * PsubE;
        }
        public double calcLsubN()
        {
            return LsubQ / PsubE;
        }
        public double calcWsubQ()
        {
            return LsubQ / ((M - L) * Miu);
        }
        public double calcW()
        {
            return WsubQ + (1 / Miu);
        }
        public double calcWsubN()
        {
            return WsubQ / PsubE;
        }
    }
}
