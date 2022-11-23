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
        public PICS(double lambda, double miu, double n, double k)
        {
            Lambda = lambda;            //a
            Miu = miu;                  //b
            K = k;                      //c
            N = n;                      //d
            Ro = calcRo();              //1
            PsubZero = calcPsubZero();  //2
            PsubN = calcPsubN();        //3 *
            L = calcL();                //4
            LsubQ = calcLsubQ();        //5
            LsubN = calcLsubN();        //6
            W = calcW();                //7
            WsubQ = calcWsubQ();        //8
            WsubN = calcWsubN();        //9
        }

        #region get/Set
        public double Ro
        {
            get { return ro; }
            set { ro = value; }
        }
        #endregion

        public double calcRo()
        {
            //P. hallar el sistema ocupado.
            //Uso del sistema
            //P. tienen los usuarios de esperar para ser atendidos
            return Lambda / Miu;
        }
        public double calcPsubZero()
        {
            //P. hallar el sistema vacío u ocioso
            //P. tienen los usuarios de no esperar o ser atendidos
            //  sin esperar en cola
            return 1 - Ro;
        }
        public double calcPsubN()
        {
            //P. hallar exactamente n clientes dentro del sistema
            return PsubZero * Math.Pow(Ro, N);
        }
        public double calcL()
        {
            //# esperado de clientes en el sistema
            return  Lambda / (Miu - Lambda);
        }
        public double calcLsubQ()
        {
            //# esperado de clientes en la cola
            return Math.Pow(Lambda, 2) / (Miu * (Miu - Lambda));
        }
        public double calcLsubN()
        {
            //# esperado de clientes en la cola no vacía
            return Lambda / (Miu - Lambda);
        }
        public double calcW()
        {
            //Tiempo esperado en el sistema
            return 1 / (Miu - Lambda);
        }
        public double calcWsubQ()
        {
            //Tiempo esperado en cola
            return Lambda / (Miu * (Miu - Lambda));
        }
        public double calcWsubN()
        {
            //Tiempo esperado en cola para colas no vacías
            return 1 / (Miu - Lambda);
        }
    }
}
