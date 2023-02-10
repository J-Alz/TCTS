using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS.Modelo
{
    internal class PICM:Cola
    {
        private float formula1(int value)
            => (float)Math.Pow(Lambda / Miu, value) / factorial(value);

        private float formula2()
            =>(K * Miu) / (K * Miu - Lambda);

        private float formula3()
            =>Miu * (float)Math.Pow(Lambda / Miu, K);

        private float formular4()
            =>factorial(K - 1) * (float)Math.Pow(K * Miu - Lambda, 2);


        #region Probabilidades
        public float P0()
        {
            float sumatoria = 0;
            for (int i = 0; i <= K - 1; i++)
            {
                sumatoria += formula1(i);
            }
            return 1 / (sumatoria + formula1(K) * formula2());
        }

        public List<float> Pn(int n)
        {
            List<float> result = new List<float>();
            for (int i = 1; i <= n; i++)
                if (i < K)
                    result.Add(P0() * formula1(i));
                else
                    result.Add(P0() * (float)(Math.Pow(Lambda / Miu, i) / 
                        factorial(K)) * (1 / (float)Math.Pow(K, i - K)));
            return result;
        }
        public float Pk()
            => formula1(K) * formula2() * P0();

        public float PNe()
            => 1 - Pk();

        #endregion


        #region Cantidad de clientes
        public float L()
            => Lambda * formula3() / formular4() * P0() + (Lambda / Miu);
        public float Lq()
            => Lambda * formula3() / formular4() * P0();
        
        public float Ln()
            => Lq() / Pk();

        #endregion


        #region Tiempo de espera
        public float W()
            => formula3() / formular4() * P0() + (1 / Miu);
        public float Wq()
            => formula3() / formular4() * P0();
        public float Wn()
            => Wq() / Pk();
        #endregion
    }
}
