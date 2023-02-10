using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS.Modelo
{
    internal class PICS: Cola
    {
        public float Ro()
            => Lambda / Miu;

        #region Probabilidades
        public float P0()
            => 1 - Ro();

        public List<float> Pn(int n)
        {
            List<float> lista = new List<float>();
            for (int i = 1; i <= n; i++)
            {
                lista.Add(P0() * (float)Math.Pow(Ro(), i));
            }
            return lista;
        }
        #endregion


        #region Cantidad de clientes

        public float L()
            => Lambda / (Miu - Lambda);

        public float Lq()
            => (float)Math.Pow(Lambda, 2) / (Miu * (Miu - Lambda));

        public float Ln()
            => Lambda / (Miu - Lambda);
        #endregion

        #region Tiempo de espera
        public float W()
            => 1 / (Miu - Lambda);

        public float Wq()
            => Lambda / (Miu * (Miu - Lambda));

        public float Wn()
            => 1 / (Miu - Lambda);
        #endregion
    }
}
