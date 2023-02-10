using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS.Modelo
{
    internal class PFCS:Cola
    {
        private float formula(int n)
            => factorial(M) / factorial(M - n) * (float)Math.Pow(Lambda / Miu, n);
        #region Probabilidades
        public float P0()
        {
            float sumatoria = 0;
            for (int i = 0; i <= M; i++)
            {
                sumatoria += formula(i);
            }
            return 1 / sumatoria;
        }

        public List<float> calcularPn(int n)
        {
            List<float> lista = new List<float>();

            for (int i = 1; i <= n; i++)
                lista.Add(formula(i) * P0());
            return lista;
        }
        public float Pe()
            => 1 - P0();
        
        #endregion

        #region Cantidad de clientes
        public float L()
            => M - (Miu / Lambda) * Pe();

        public float Lq()
            => M - ((Lambda + Miu) / Lambda) * Pe();

        public float Ln()
            => Lq() / Pe();
        #endregion

        #region Tiempo de espera
        public float W()
            => Wq() + (1 / Miu);

        public float Wq()
            => Lq() / ((M - L()) * Lambda);

        public float Wn()
            => Wq() / Pe();
        #endregion
    }
}
