using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS.Modelo
{
    internal class PFCM:Cola
    {
        private float formula1(int n)
            =>(factorial(M) / (factorial(M - n) * factorial(n))) * (float)Math.Pow(Lambda / Miu, n);
        
        private float formula2(int n)
            => (factorial(M) / (factorial(M - n) * factorial(K) * 
            (float)Math.Pow(K, n - K))) * (float)Math.Pow(Lambda / Miu, n);

        #region Probabilidades
        public float P0()
        {
            float sumatoria1 = 0;
            float sumatoria2 = 0;
            for (int i = 0; i <= K - 1; i++)
            {
                sumatoria1 += formula1(i);
            }
            for (int i = K; i <= M; i++)
            {
                sumatoria2 += formula2(i);
            }
            return 1 / (sumatoria1 + sumatoria2);
        }

        public List<float> Pn(int ini, int fin)
        {
            List<float> lista = new List<float>();
            for (int i = ini; i <= fin; i++)
            {
                if (fin >= K && fin <= M)
                    lista.Add(P0() * formula2(i));
                else
                    lista.Add(P0() * formula1(i));
            }
            return lista;
        }

        public float Pe()
        {
            float sumatoria = 0;
            List<float> lista = new List<float>();
            lista = Pn(0, K - 1);
            foreach (float elemento in lista)
            {
                sumatoria += elemento;
            }
            return 1 - sumatoria;
        }

        public float PNe()
            => 1 - Pe();
        #endregion

        #region Cantidad de clientes
        public float L()
        {
            List<float> lista1 = Pn(0, K - 1);
            List<float> lista2 = Pn(K, M);
            float sumatoria1 = 0;
            float sumatoria2 = 0;
            float sumatoria3 = 0;
            for (int i = 0; i <= K - 1; i++)
            {
                sumatoria1 += (i * lista1[i]);
            }
            int j = 0;
            for (int i = K; i <= M; i++)
            {
                sumatoria2 += (i - K) * lista2[j];
                j++;
            }
            foreach (float elemento in lista1)
            {
                sumatoria3 += elemento;
            }
            return sumatoria1 + sumatoria2 + (K * (1 - sumatoria3));
        }

        public float Lq()
        {
            List<float> lista = Pn(K, M);
            float sumatoria = 0;
            int j = 0;
            for (int i = K; i <= M; i++)
            {
                sumatoria += (i - K) * lista[j];
                j++;
            }
            return sumatoria;
        }

        public float Ln()
            => Lq() / Pe();
        #endregion

        #region Tiempo de espera
        public float W()
            => Wq() + (1 / Miu);
        public float Wq()
            => Lq() / (float)Math.Pow(M - L(), Lambda);
        public float Wn()
            => Wq() / Pe();
        #endregion
    }
}
