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
        PICS(double lambda, double miu)
        {
            Lambda = lambda;
            Miu = miu;
        }

        public double Ro
        {
            get { return ro; }
            set { ro = value; }
        }

        public void calcRo()
        {
            Ro = Lambda / Miu;
        }
        public void calcPsubZero()
        {
            PsubZero = 1 - (Lambda / Miu);
        }
        public void calcPsubN()
        {
            PsubN = PsubZero * Math.Pow(Ro, 2);
        }
        public void calcL()
        {
            L = Lambda / (Miu - Lambda);
        }
        public void calcLsubQ()
        {
            LsubQ = Math.Pow(Lambda, 2) / (Miu * (Miu - Lambda));
        }
        public void calcLsubN()
        {
            LsubN = Lambda / (Miu - Lambda);
        }
        public void calcW()
        {
            W = 1 / (Miu - Lambda);
        }
        public void calcWsubQ()
        {
            WsubQ = Lambda / (Miu * (Miu - Lambda));
        }
        public void calcWsubN()
        {
            WsubN = 1 / (Miu - Lambda);
        }

        

        
    }
}
