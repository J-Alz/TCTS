using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS
{
    internal class fractionPICS:modelo
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

        private Fraction cRo()
            => new Fraction(Lambda,Miu);//int,int
        private Fraction cP0()
            => new Fraction(1) - cRo();

        private List<Fraction> calcPn(int n)
        {
            List<Fraction> result = new List<Fraction>();
            for(int i = 1; i <= n; i++)
            {
                result.Add(cP0() * (cRo()^i));
            }
            return result;
        }
        
        private Fraction cL()
            => new Fraction(Lambda,Miu - Lambda);
        private Fraction cLq()
            => new Fraction(Lambda * Lambda, Miu * (Miu - Lambda));
        private Fraction cLn()
            => new Fraction(Lambda,Miu - Lambda);
        private Fraction cW()
            => new Fraction(1,Miu - Lambda);
        private Fraction cWq()
            => new Fraction(Lambda,Miu * (Miu - Lambda));
        private Fraction cWn()
            => new Fraction(1, Miu - Lambda);



    }
}
