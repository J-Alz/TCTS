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
        double pe;
        double pNe;
        public PFCM(double lambda, double miu, int k, int n, int m,
            double cte, double cts, double ctse, double cs, double tiempo)
        {
            Lambda = lambda;
            Miu = miu;
            M = m;
            K = k;
            Tiempo = tiempo;
            P0 = calcularP0();
            Pn = calcularPn(1,n);
            pe = calcularPe();
            pNe = calcularPNe();
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

        #region get/set M, Pe, PNe
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
        public double PNe
        {
            get { return pNe; }
            set { pNe = value; }
        }
        #endregion

        #region formulas
        private double formula1(int n)
        {
            return (factorial(M) / (factorial(M - n) * factorial(n))) * Math.Pow(Lambda/Miu,n);
        }
        private double formula2(int n)
        {
            return (factorial(M)/(factorial(M-n) * factorial(K) * Math.Pow(K, n - K))) * Math.Pow(Lambda/Miu,n);
        }
        
        
        #endregion

        private double calcularP0()
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
        private List<double> calcularPn(int ini, int fin)
        {
            List<double> lista = new List<double>();
            for(int i = ini; i <= fin; i++)
            {
                if (fin >= K && fin <= M)
                    lista.Add(P0 * formula2(i));
                else
                    lista.Add(P0 * formula1(i));
            }
            return lista;
        }
        private double calcularPe()
        {
            double sumatoria = 0;
            List<double> lista = new List<double>();
            lista = calcularPn(0,K -1);
            foreach(double elemento in lista)
            {
                sumatoria += elemento;
            }
            return 1 - sumatoria;
        }
        private double calcularPNe()
        {
            return 1 - Pe;
        }
        private double calcularL()
        {
            List<double> lista1 = calcularPn(0,K-1);
            List<double> lista2 = calcularPn(K,M);
            double sumatoria1 = 0;
            double sumatoria2 = 0;
            double sumatoria3 = 0;
            for(int i = 0; i <= K-1; i++)
            {
                sumatoria1 += (i * lista1[i]);
            }
            int j = 0;
            for(int i = K; i <= M; i++)
            {
                sumatoria2 += (i - K) * lista2[j];
                j++;
            }
            foreach(double elemento in lista1)
            {
                sumatoria3 += elemento;
            }
            return sumatoria1 + sumatoria2 + (K * (1 - sumatoria3));
        }
        private double calcularLq()
        {
            List<double> lista = calcularPn(K,M);
            double sumatoria = 0;
            int j = 0;
            for(int i = K; i<= M; i++)
            {
                sumatoria += (i - K) * lista[j];
                j++;
            }
            return sumatoria;
        }
        private double calcularLn()
        {
            return Lq / Pe;
        }
        private double calcularWq()
        {
            return Lq / Math.Pow(M - L,Lambda);
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
