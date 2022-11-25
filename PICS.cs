using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS
{
    internal class PICS: modeloColas
    {
        
        private double ro;
        public PICS(double lambda, double miu, int k, int n)
        {
            Lambda = lambda;            //a
            Miu = miu;                  //b
            K = k;                      //c
            Ro = calcRo();              //1
            PsubZero = calcPsubZero();  //2
            PsubN = calcPsubN(n);       //3 *
            L = calcL();                //4
            LsubQ = calcLsubQ();        //5
            LsubN = calcLsubN();        //6
            W = calcW();                //7
            WsubQ = calcWsubQ();        //8
            WsubN = calcWsubN();        //9
        }

        #region get/Set Ro
        public double Ro
        {
            get { return ro; }
            set { ro = value; }
        }
        #endregion

        public double calcRo()
        {
            return Lambda / Miu;
        }
        public double calcPsubZero()
        {
            return 1 - Ro;
        }
        public List<double> calcPsubN(int n)
        {
            List<double> lista = new List<double>();
            if (n == 0)
            {
                lista.Add(PsubZero);
                return lista;
            }
            for(int i = 1; i <= n; i++)
            {
                lista.Add(PsubZero * Math.Pow(Ro, i));
            }
            return lista;
        }
        public double calcL()
        {
            return  Lambda / (Miu - Lambda);
        }
        public double calcLsubQ()
        {
            return Math.Pow(Lambda, 2) / (Miu * (Miu - Lambda));
        }
        public double calcLsubN()
        {
            return Lambda / (Miu - Lambda);
        }
        public double calcW()
        {
            return 1 / (Miu - Lambda);
        }
        public double calcWsubQ()
        {
            return Lambda / (Miu * (Miu - Lambda));
        }
        public double calcWsubN()
        {
            return 1 / (Miu - Lambda);
        }
    }
}
