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
        double psubK;
        double psubNE;
        public PICM(double lambda, double miu, int k, int n)
        {
            Lambda = lambda;
            Miu = miu;
            K = k;
            PsubZero = calcPsubZero();
            PsubN = calcPsubN(n);
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

        #region formulas
        private double formula1(int value)
        {
            return Math.Pow(Lambda / Miu, value) / t.fact(value);
        }
        private double formula2()
        {
            return (K * Miu) / (K * Miu - Lambda);
        }
        private double formula3()
        {
            return Miu * Math.Pow(Lambda / Miu, K);
        }
        private double formular4()
        {
            return t.fact(K - 1) * Math.Pow(K * Miu - Lambda, 2);
        }
        #endregion

        public double calcPsubZero()
        {
            double sumatoria = 0;
            for(int i = 0; i <= K - 1; i++)
            {
                sumatoria += formula1(i);
            }
            return 1 / (sumatoria + formula1(K) + formula2());
        }
        public double calcPsubK()
        {
            return formula1(K) * formula2() * PsubZero;
        }
        public double calcPsubNE()
        {
            return 1 - PsubK;
        }
        public List<double> calcPsubN(int n)
        {
            List<double> result = new List<double>();
            for(int i = 1; i <= n; i++)
                if (i >= K)
                    result.Add(PsubZero * formula1(i));
                else
                    result.Add(PsubZero * (Math.Pow(Lambda/Miu,i)/t.fact(K)) * 1/Math.Pow(K,i - K));
            return result;
        }
        public double calcL()
        {
            return Lambda*formula3() / formular4() * PsubZero + (Lambda / Miu);
        }
        public double calcLsubQ()
        {
            return Lambda*formula3() / formular4() * PsubZero;
        }
        public double calcLsubN()
        {
            return LsubQ / PsubK;
        }
        public double calcW()
        {
            return formula3() / formular4() * PsubZero + (1 / Miu);
        }
        public double calcWsubQ()
        {
            return formula3() / formular4() * PsubZero;
        }
        public double calcWsubN()
        {
            return WsubQ / PsubK;
        }
    }
}
