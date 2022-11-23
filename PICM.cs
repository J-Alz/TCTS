using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS
{
    internal class PICM:modeloColas
    {
        tools t = new tools();
        int n;
        double psubK;
        double psubNE;
        PICM(double lambda, double miu)
        {
            Lambda = lambda;
            Miu = miu;
            PsubZero = calcPsubZero();
            PsubN = calcPsubN();
            PsubK = calcPsubK();
            PsubNE = calcPsubNE();
            L = calcL();
            LsubQ = calcLsubQ();
            LsubN = calcLsubN();
            W = calcW();
            WsubQ = calcWsubQ();
            WsubN = calcWsubN();
            
        }

        #region get/set
        public int N
        {
            get { return n; }
            set { n = value; }
        }
        public double PsubK
        {
            get { return psubK; }
            set { psubK = value; }
        }
        public double PsubNE
        {
            get { return psubNE; }
            set { psubNE = value; }
        }

        #endregion

        public double calcPsubZero()
        {
            double sumatoria = 0;
            for(int i = 0; i < K - 1; i++)
            {
                sumatoria += (1/t.fact(i)) * 
                    Math.Pow(Lambda/Miu,i);
            }
            return 1 / (sumatoria + 
                (1/t.fact(K)*
                Math.Pow(Lambda/Miu,K)*
                (K * Miu)/(K*Miu - Lambda)));
        }
        public double calcPsubK()
        {
            return (1 / t.fact(K)*
                Math.Pow(Lambda/Miu,N)*
                ((K*Miu)/(K*Miu - Lambda))* 
                PsubZero);
        }
        public double calcPsubNE()
        {
            return 1 - PsubK;
        }
        public double calcPsubN()
        {
            if(N >= K)
            {
                return (1 / t.fact(K) * Math.Pow(K, N - K)) *
                    Math.Pow(Lambda / Miu, N) *
                    PsubZero;
            }
            else
            {
                return (PsubZero / t.fact(N)) *
                    Math.Pow(Lambda/Miu,N);
            } 
        }
        public double calcL()
        {
            return (Lambda * Miu * Math.Pow(Lambda / Miu, K) /
                t.fact(K - 1) * Math.Pow(K * Miu - Lambda, 2) *
                PsubZero) + (Lambda / Miu);
        }
        public double calcLsubQ()
        {
            return (Lambda * Miu * Math.Pow(Lambda / Miu, K) * PsubZero) /
                (t.fact(K - 1)* Math.Pow(K * Miu - Lambda,2));
        }
        public double calcLsubN()
        {
            return LsubQ / PsubK;
        }
        public double calcW()
        {
            return ((Miu * Math.Pow(Lambda / Miu, 2) * PsubZero) /
                t.fact(K-1)*Math.Pow(K * Miu - Lambda,2))+(1 /Miu);
        }
        public double calcWsubQ()
        {
            return (Miu * Math.Pow(Lambda / Miu, K) * PsubZero) /
                (t.fact(K -1)*Math.Pow(K * Miu - Lambda,2));
        }
        public double calcWsubN()
        {
            return WsubQ / PsubK;
        }
    }
}
