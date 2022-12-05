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
        public PFCS(double lambda, double miu, int k, int n, int m,
            double cte, double cts, double ctse, double cs, double tiempo)
        {
            Lambda = lambda;
            Miu = miu;
            M = m;
            K = k;
            Tiempo = tiempo;
            P0 = calcularP0();
            Pe = calcularPe();
            Pn = calcularPn(n);
            L = calcularL();
            Lq = calcularLq();
            Ln = calcularLn();
            Wq = calcularWq();
            W = calcularW();
            Wn = calcularWn();
            Ctte = calcularCTTE(cte);
            Ctts = calcularCTTS(cts);
            Cttse = calcularCTTSE(ctse);
            Cts = calcularCTS(cs);
            Ct = calcularCT();
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
            return factorial(M) / factorial(M - n) * Math.Pow(Lambda/Miu,n);
        }
        #endregion

        private double calcularP0()
        {
            double sumatoria = 0;
            for (int i = 0; i <= M; i++)
            {
                sumatoria += formula(i);
            }
            return 1 / sumatoria;
        }
        private double calcularPe()
        {
            return 1 - P0;
        }
        private List<double> calcularPn(int n)
        {
            List<double> lista = new List<double>();

            for(int i = 1; i <= n; i++)
                lista.Add(formula(i) * P0);  
            return lista;
        }
        private double calcularL()
        {
            return M - (Miu / Lambda) * Pe;
        }
        private double calcularLq()
        {
            return M - ((Lambda + Miu) / Lambda) * Pe;
        }
        private double calcularLn()
        {
            return Lq / Pe;
        }
        private double calcularWq()
        {
            return Lq / ((M - L) * Lambda);
        }
        private double calcularW()
        {
            return Wq + (1 / Miu);
        }
        private double calcularWn()
        {
            return Wq / Pe;
        }
    }
}
