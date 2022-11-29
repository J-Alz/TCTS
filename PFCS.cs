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
        double pe;
        public PFCS(double lambda, double miu, int k, int n, int m)
        {
            Lambda = lambda;
            Miu = miu;
            M = m;
            K = k;
            P0 = calcularP0();
            Pe = calcularPe();
            Pn = calcularPn(n);
            L = calcularL();
            Lq = calcularLq();
            Ln = calcularLn();
            W = calcularW();
            Wq = calcularWq();
            Wn = calcularWn();
        }

        #region get/set M, Pe
        public int M
        {
            get { return m; }
            set { m = value; }
        }
        public double Pe
        {
            get { return pe; }
            set { pe = value; }
        }
        #endregion

        #region formulas
        private double formula(int n){
            return factorial(M) / factorial(M - n)! * Math.Pow(Lambda/Miu,n);
        }
        #endregion

        public double calcularP0()
        {
            double sumatoria = 0;
            for (int i = 0; i <= M; i++)
            {
                sumatoria += formula(i);
            }
            return 1 / sumatoria;
        }
        public double calcularPe()
        {
            return 1 - P0;
        }
        public List<double> calcularPn(int n)
        {
            List<double> lista = new List<double>();
            for(int i = 1; i <= n; i++)
                lista.Add(formula(i) * P0);
            return lista;
        }
        public double calcularL()
        {
            return M - (Miu / Lambda) * Pe;
        }
        public double calcularLq()
        {
            return M - ((Lambda + Miu) / Lambda) * Pe;
        }
        public double calcularLn()
        {
            return Lq / Pe;
        }
        public double calcularWq()
        {
            return Lq / ((M - L) * Miu);
        }
        public double calcularW()
        {
            return Wq + (1 / Miu);
        }
        public double calcularWn()
        {
            return Wq / Pe;
        }
    }
}
