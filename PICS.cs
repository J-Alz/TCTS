using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS
{
    internal class PICS
    {
        private bool poblacionFinita;
        private int lambda;
        private int miu;
        private int servidores;
        private int horasDiarias;

        #region Probabilidad
        PICS(bool poblacionFinita, int lambda, int miu, int servidores)
        {
            this.poblacionFinita = poblacionFinita;
            this.lambda = lambda;
            this.miu    = miu;
            this.servidores = servidores;
        }
        public double ro()
        {
            //Probabilidad de hallar el sistema ocupado
            //Utilizacion del sistema
            //Probabilidad que tiene los usuarios de esperar para ser
            //  atendidos
            return lambda / miu;
        }
        public double PsubZero()
        {
            //Probabilidad de hallar sistema vacio u ocioso
            //Probabilidad que tienen los usuarios de no esperar
            //Probabilidad que tiene ser atendidos sin esperar en cola
            return 1 - (lambda / miu);
        }
        public double PsubN(int nClientes)
        {
            if(poblacionFinita == true)
                return 1;
            else
                return PsubZero() * Math.Pow((lambda / miu),nClientes);
        }
        #endregion

        #region Esperado de clientes
        public double L()
        {
            return lambda / (miu - lambda);
        }
        public double LsubQ()
        {
            return Math.Pow(lambda, 2) / (miu *(miu - lambda));
        }
        public double LsubN()
        {
            return lambda / (miu - lambda);
        }

        #endregion

        #region Tiempo Esperado

        public double W()
        {
            return 1 / (miu - lambda);
        }
        public double WsubQ()
        {
            return lambda / (miu * (miu - lambda));
        }
        public double WsubN()
        {
            return 1 / (miu - lambda);
        }

        #endregion

        #region Costo Diario
        public double CTsubTE()
        {
            return lambda * horasDiarias * WsubQ();
            ///no vale
        }
        #endregion
    }
}
