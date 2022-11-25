using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS
{
    internal class PFCM : modeloColas
    {
        int m;
        double psubE;
        double psubNE;
        tools t = new tools();
        PFCM(double lambda, double miu, int k, int n, int m)
        {
            Lambda = lambda;
            Miu = miu;
            M = m;
            K = k;
            PsubZero = calcPsubZero();
            PsubN = calcPsubN(n);
            psubE = calcPsubE();
            psubNE = calcPsubNE();
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
        public double PsubNE
        {
            get { return psubNE; }
            set { psubNE = value; }
        }
        #endregion

        #region formulas
        private double formula1(int n)
        {
            return (t.fact(M) / (t.fact(M - n) * t.fact(n))) * Math.Pow(Lambda/Miu,n);
        }
        private double formula2(int n)
        {
            return (t.fact(M)/(t.fact(M-n) * t.fact(K) * Math.Pow(K, n - K))) * Math.Pow(Lambda/Miu,n);
        }
        
        #endregion

        public double calcPsubZero()
        {
            double sumatoria1 = 0;
            double sumatoria2 = 0;
            for(int i = 0; i <= K - 1; i++)
            {
                sumatoria1 += formula1(i);
            }
            for(int i = K; i <= M; i++)
            {
                sumatoria2 += formula2(i);
            }
            return 1 / (sumatoria1 + sumatoria2);
        }
        public List<double> calcPsubN(int n)
        {
            List<double> lista = new List<double>();
            for(int i = 1; i <= n; i++)
            {
                if (n >= K && n <= M)
                    lista.Add(PsubZero * formula2(n));
                else
                    lista.Add(PsubZero * formula1(n));
            }
            return lista;
        }
        public double calcPsubE()
        {
            return 1;
        }
        public double calcPsubNE()
        {
            return 1 - PsubE;
        }
        public double calcL()
        {
            double sumatoria1 = 0,
                sumatoria2 = 0,
                sumatoria3 = 0;

            for(int i = 0; i < K-1; i++)
            {
                //sumatoria1 += N * PsubN;//Not
            }
            for(int i = 0; i < M; i++)
            {
                //sumatoria2 += (N - K) * PsubN;
            }
            sumatoria3 = sumatoria1 ;
            return sumatoria1 + sumatoria2 + K * (1 - sumatoria3);
        }
        public double calcLsubQ()
        {
            double sumatoria = 0;
            for (int i = 0; i < M; i++)
            {
                //sumatoria += (N - K) * PsubN;
            }
            return sumatoria;
        }
        public double calcLsubN()
        {
            return LsubQ / PsubE;
        }
        public double calcWsubQ()
        {
            return LsubQ / Math.Pow(M - L,Lambda);
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
