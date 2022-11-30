using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS
{
    internal class PICM:modeloColas
    {
        double pk;
        double pNe;
        public PICM(double lambda, double miu, int k, int n)
        {
            Lambda = lambda;
            Miu = miu;
            K = k;
            P0 = calcularP0();
            Pn = calcularPn(n);
            Pk = calcularPk();
            PNe = calcularPNe();
            L = calcularL();
            Lq = calcularLq();
            Ln = calcularLn();
            W = calcularW();
            Wq = calcularWq();
            Wn = calcularWn();
            
        }

        #region get/set pK, PNe
        public double Pk
        {
            get { return pk; }
            set { pk = value; }
        }
        public double PNe
        {
            get { return pNe; }
            set { pNe = value; }
        }

        #endregion

        #region formulas
        private double formula1(int value)
        {
            return Math.Pow(Lambda / Miu, value) / factorial(value);
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
            return factorial(K - 1) * Math.Pow(K * Miu - Lambda, 2);
        }
        #endregion

        private double calcularP0()
        {
            double sumatoria = 0;
            for(int i = 0; i <= K - 1; i++)
            {
                sumatoria += formula1(i);
            }
            return 1 / (sumatoria + formula1(K) + formula2());
        }
        private double calcularPk()
        {
            return formula1(K) * formula2() * P0;
        }
        private double calcularPNe()
        {
            return 1 - Pk;
        }
        private List<double> calcularPn(int n)
        {
            List<double> result = new List<double>();
            for(int i = 1; i <= n; i++)
                if (i >= K)
                    result.Add(0 * formula1(i));
                else
                    result.Add(P0 * (Math.Pow(Lambda/Miu,i)/factorial(K)) * (1/Math.Pow(K,i - K)));
            return result;
        }
        private double calcularL()
        {
            return Lambda*formula3() / formular4() * P0 + (Lambda / Miu);
        }
        private double calcularLq()
        {
            return Lambda*formula3() / formular4() * P0;
        }
        private double calcularLn()
        {
            return Lq / Pk;
        }
        private double calcularW()
        {
            return formula3() / formular4() * P0 + (1 / Miu);
        }
        private double calcularWq()
        {
            return formula3() / formular4() * P0;
        }
        private double calcularWn()
        {
            return Wq / Pk;
        }
    }
}
