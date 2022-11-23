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
        }
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
        public void calcPsubZero()
        {
            double sumatoria = 0;
            for(int i = 0; i < K - 1; i++)
            {
                sumatoria += (1/t.fact(i)) * 
                    Math.Pow(Lambda/Miu,i);
            }
            PsubZero = 1 / (sumatoria + 
                (1/t.fact(K)*
                Math.Pow(Lambda/Miu,K)*
                (K * Miu)/(K*Miu - Lambda)));
        }
        public void calcPsubK()
        {
            PsubK = (1 / t.fact(K)*
                Math.Pow(Lambda/Miu,N)*
                ((K*Miu)/(K*Miu - Lambda))* 
                PsubZero);
        }
        public void calcPsubNE()
        {
            PsubNE = 1 - PsubK;
        }
        public void calcPsubN()
        {
            if(N >= K)
            {
                PsubN = (1 / t.fact(K) * Math.Pow(K, N - K)) *
                    Math.Pow(Lambda / Miu, N) *
                    PsubZero;
            }
            else
            {
                PsubN = (PsubZero / t.fact(N)) *
                    Math.Pow(Lambda/Miu,N);
            } 
        }
        public void calcL()
        {
            L = (Lambda * Miu * Math.Pow(Lambda / Miu, K) /
                t.fact(K - 1) * Math.Pow(K * Miu - Lambda, 2) *
                PsubZero) + (Lambda / Miu);
        }
        public void calcLsubQ()
        {
            LsubQ = (Lambda * Miu * Math.Pow(Lambda / Miu, K) * PsubZero) /
                (t.fact(K - 1)* Math.Pow(K * Miu - Lambda,2));
        }
        public void calcLsubN()
        {
            LsubN = LsubQ / PsubK;
        }
        public void calcW()
        {
            W = ((Miu * Math.Pow(Lambda / Miu, 2) * PsubZero) /
                t.fact(K-1)*Math.Pow(K * Miu - Lambda,2))+(1 /Miu);
        }
        public void calcWsubQ()
        {
            WsubQ = (Miu * Math.Pow(Lambda / Miu, K) * PsubZero) /
                (t.fact(K -1)*Math.Pow(K * Miu - Lambda,2));
        }
        public void calcWsubN()
        {
            WsubN = WsubQ / PsubK;
        }
    }
}
