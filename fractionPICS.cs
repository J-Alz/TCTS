using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS
{
    internal class fractionPICS:modeloColas
    {
        private Fraction ro;

        /*
         * TODO:
         * 1. Reducir tamaño de funciones, tipo funciones lambda
         * 2. Convertir fractionPICS en static para hacer llamadas mas simples
         */


        #region get/set
        public Fraction Ro
        {
            get { return ro; }
            set { ro = value; }
        }
        #endregion

        private Fraction calcRo()
        {
            return new Fraction((int)Lambda,(int)Miu);
            //Cambiar modelo colas para evitar conversión
        }
        private Fraction calcP0()
        {

            return new Fraction(1) - calcRo();
        }
        private List<Fraction> calcPn(int n)
        {
            List<Fraction> result = new List<Fraction>();
            for(int i = 1; i <= n; i++)
            {
                result.Add(calcP0() * (calcRo()^i));
            }
            return result;
        }
        private Fraction calcL()
        {
            return new Fraction((int)Lambda,(int)(Miu - Lambda));
        }
        private Fraction calcLq()
        {
            return new Fraction((int)(Lambda * Lambda),(int)(Miu * (Miu - Lambda)));
        }
        private Fraction calcLn()
        {
            return new Fraction((int)Lambda, (int)(Miu - Lambda));
        }
        private Fraction calcW()
        {
            return new Fraction(1,(int)(Miu - Lambda));
        }
        private Fraction calcWq()
        {
            return new Fraction((int)Lambda,(int)(Miu * (Miu - Lambda)));
        }
        private Fraction calcWn()
        {
            return new Fraction(1, (int)(Miu - Lambda));
        }



    }
}
